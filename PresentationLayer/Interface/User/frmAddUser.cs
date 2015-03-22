using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;

namespace Markspen_SMBS_V1.Interface.User
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            var _user = new clsUser();

            _user.UserName = txtUserName.Text;
            _user.Password = txtPwd.Text;
                    }
    }
}
