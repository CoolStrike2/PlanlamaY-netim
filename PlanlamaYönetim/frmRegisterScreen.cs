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
    public partial class frmRegisterScreen : Form
    {
        public frmRegisterScreen()
        {
            InitializeComponent();
        }

        private void btnRegisterSave_Click(object sender, EventArgs e)
        {
            try
            {
                PContext pContext = new PContext();
                User user = new User
                {
                    Name = txtName.Text,
                    SureName = txtSurName.Text,
                    NickName = txtNickName.Text,
                    Password = txtPassword.Text,
                    TCNo = txtTCNo.Text,
                    UserTel = txtTelNo.Text,
                    UserEmail = txtEmail.Text,
                    UserAddress = txtAddress.Text,
                    UserType = "User"
                };
                pContext.Users.Add(user);
                pContext.SaveChanges();
                MessageBox.Show("Kayıt Başarılı!","BAŞARILI",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch 
            {

                MessageBox.Show("Bir sorun oluştu");
            }
           
        }
    }
}
