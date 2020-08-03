using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppWcsClient01.LocationMgt;

namespace WinAppWcsClient01
{
    public partial class FormMain : Form
    {
        public static int WAREHOUSE_ID = 1;
        public static int USER_ID = 1;

        public FormMain()
        {
            InitializeComponent();
        }

        private void tsmiSubExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiHelpAbout_Click(object sender, EventArgs e)
        {
            HelpAbout.FormAbout formAbout = new HelpAbout.FormAbout();
            DialogResult dlgResult = formAbout.ShowDialog(this);
        }

        private void tsmiLocationMapSet_Click(object sender, EventArgs e)
        {
            FormLocationMapSet formLocationMapSet = null;
            foreach (Form ftemp in this.MdiChildren) //查找当前父表单所有子表单
            {
                if (ftemp is FormLocationMapSet)
                {
                    formLocationMapSet = (FormLocationMapSet)ftemp;
                    break;
                }
            }
            if (formLocationMapSet == null || formLocationMapSet.IsDisposed)
            {
                formLocationMapSet = new FormLocationMapSet();
                formLocationMapSet.MdiParent = this;
            }
            formLocationMapSet.Show();
            formLocationMapSet.WindowState = FormWindowState.Maximized;
            formLocationMapSet.Activate();
        }
    }
}
