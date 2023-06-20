using PlanlamaYönetim.Contexts;
using PlanlamaYönetim.Entities;
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
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            frmRegisterScreen frmRS = new frmRegisterScreen();
            frmRS.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                PContext pCtx = new PContext();
                User user = pCtx.Users.FirstOrDefault(u => u.NickName == txtNickname.Text && u.Password == txtPassword.Text);
                if (user != null)
                {
                    frmAgenda frmagenda = new frmAgenda(txtNickname.Text);
                    frmagenda.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }



            }
            catch 
            {
                MessageBox.Show("Bilinmeyen bir hata meydana geldi. Lütfen admininize başvurunuz.","HATA",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
