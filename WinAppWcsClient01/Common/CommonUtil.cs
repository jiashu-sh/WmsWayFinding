﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWcsClient01.Common
{
    class CommonUtil
    {

        internal static int GenProductNo(string sIdType)
        {
            int iProductNo = GenSystemNo(sIdType);
            if (iProductNo == -1)
                return -1;

            iProductNo = FormMain.WAREHOUSE_ID * 100000 + iProductNo; //必须为偶数

            return iProductNo;
        }

        internal static int GenSerailNo(string sIdType)
        {
            int iSerialNo = GenSystemNo(sIdType);
            if (iSerialNo == -1)
                return -1;

            iSerialNo = FormMain.WAREHOUSE_ID * 10000000 + iSerialNo; //必须为偶数

            return iSerialNo;
        }

        internal static int GenSystemNo(string sIdType)
        {
            int iProductNo = -1;

            DataSet ds = Common.CommonDa.ExecuteQuery("select system_no from bc_system_no where id_type='"+ sIdType + "' and void=0 order by system_no desc ");
            if (ds == null)
                iProductNo = 1;
            else if (ds.Tables[0].Rows.Count == 0)
                iProductNo = 1;
            else
            {
                try
                {
                    iProductNo = int.Parse(ds.Tables[0].Rows[0]["system_no"].ToString()) + 1;
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }

            bool bInsert = false;
            string connectionString = Common.CommonDa.GetDbConnection();

            SQLiteTransaction transaction = null;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    
                    string strSql2 = "update bc_system_no set system_no=@system_no where id_type=@id_type and void=0";
                    SQLiteCommand cmd = new SQLiteCommand(strSql2, conn, transaction);
                    //cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@system_no", iProductNo);
                    cmd.Parameters.AddWithValue("@id_type", sIdType);
                    int iInsert = cmd.ExecuteNonQuery();

                    if (iInsert == 0)
                    {
                        string strSql = "insert into bc_system_no (system_no,id_type,void,update_uid,update_time) values (@system_no,@id_type,0,@update_uid,@update_time)";
                        cmd = new SQLiteCommand(strSql, conn, transaction);
                        //cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@system_no", iProductNo);
                        cmd.Parameters.AddWithValue("@id_type", sIdType);
                        cmd.Parameters.AddWithValue("@update_uid", FormMain.USER_ID);//remark_desc
                        cmd.Parameters.AddWithValue("@update_time", DateTime.Now);
                        iInsert += cmd.ExecuteNonQuery();
                    }

                    if (iInsert > 0)
                    {
                        bInsert = true;

                        transaction.Commit();
                    }
                }
                catch (System.Data.SQLite.SQLiteException ex)
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message);
                }
                finally
                {
                    //cmd.Dispose();
                    conn.Close();
                }

            }

            if ( !bInsert)
                return -1;

            return iProductNo;
        }

        
    }
}
