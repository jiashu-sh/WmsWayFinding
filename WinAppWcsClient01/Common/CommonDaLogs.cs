using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppWcsClient01.Entities;

namespace WinAppWcsClient01.Common
{
    class CommonDaLogs
    {
        internal static bool InsertLogs(EntityRbtReportStatus rbtStatus)
        {
            bool bInsert = false;

            string connectionString = Common.CommonDa.GetDbConnection("sqlite_logs_conn");

            SQLiteTransaction transaction = null;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {

                    //string strSql2 = "update bc_system_no set system_no=@system_no where id_type=@id_type and void=0";
                    //SQLiteCommand cmd = new SQLiteCommand(strSql2, conn, transaction);
                    ////cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@system_no", iProductNo);
                    //cmd.Parameters.AddWithValue("@id_type", sIdType);
                    //int iInsert = cmd.ExecuteNonQuery();
                    int iInsert = 0;
                    if (iInsert == 0)
                    {
                        string strSql = "insert into log_rbt_status_logs " +
                            "(current_time_stamp,delta_time_ms,rbt_status_get,orient,rbt_location_no,rbt_angle,left_wheel_speed,left_wheel_direction,right_wheel_speed,right_wheel_direction,angular_velocity,sum_angular_velocity,sum_distance,remark_desc, void,update_uid,update_time) values " +
                            "(@current_time_stamp,@delta_time_ms,1,@orient,@rbt_location_no,@rbt_angle,@left_wheel_speed,@left_wheel_direction,@right_wheel_speed,@right_wheel_direction,@angular_velocity,@sum_angular_velocity,@sum_distance,@remark_desc, 0,@update_uid,@update_time)";
                        SQLiteCommand cmd = new SQLiteCommand(strSql, conn, transaction);
                        //cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@current_time_stamp", rbtStatus.CurrentTimeStamp);
                        cmd.Parameters.AddWithValue("@delta_time_ms", rbtStatus.DeltaTimeMs);
                        cmd.Parameters.AddWithValue("@orient", rbtStatus.Orient);
                        cmd.Parameters.AddWithValue("@rbt_location_no", rbtStatus.RbtLocationNo);
                        cmd.Parameters.AddWithValue("@rbt_angle", rbtStatus.RbtAngle);
                        cmd.Parameters.AddWithValue("@left_wheel_speed", rbtStatus.LeftWheelSpeed);
                        cmd.Parameters.AddWithValue("@left_wheel_direction", rbtStatus.LeftWheelDirection);
                        cmd.Parameters.AddWithValue("@right_wheel_speed", rbtStatus.RightWheelSpeed);
                        cmd.Parameters.AddWithValue("@right_wheel_direction", rbtStatus.RightWheelDirection);
                        cmd.Parameters.AddWithValue("@angular_velocity", rbtStatus.AngularVelocity);
                        cmd.Parameters.AddWithValue("@sum_angular_velocity", rbtStatus.SumAngularVelocity);
                        cmd.Parameters.AddWithValue("@sum_distance", rbtStatus.SumDistance);
                        cmd.Parameters.AddWithValue("@remark_desc", rbtStatus.StatusDesc);

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

            return bInsert;
        }
    }
}
