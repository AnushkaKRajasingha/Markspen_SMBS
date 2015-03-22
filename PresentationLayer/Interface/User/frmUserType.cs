using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;

namespace Markspen_SMBS_V1.Interface.User
{
    public partial class frmUserType : SecureBaseForm
    {
        public frmUserType()
        {
            InitializeComponent();
        }
        public frmUserType(IPrincipal userPrincipal)
            : base(new string[] { "Admin" }, userPrincipal)
        {            
            InitializeComponent();
        }

        private void frmUserType_UserIsAllowed(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                c.Enabled = false;
                if (c.Name == "txtUserType") 
                    c.Enabled  = this.ValidatedUserRoles.Contains("Admin");
            }
           
         //   txtUserType.Enabled = this.ValidatedUserRoles.Contains("Admin");
         //   txtWholeSalePrice.Enabled = this.ValidatedUserRoles.Contains("Admin");
        }
    }

  
}
