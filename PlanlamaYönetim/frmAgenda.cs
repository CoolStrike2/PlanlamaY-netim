using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanlamaYönetim
{
    public partial class frmAgenda : Form
    {
        public frmAgenda(string NickName)
        {
            InitializeComponent();
            txtNickName.Text = NickName;
        }

        private void frmAgenda_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
