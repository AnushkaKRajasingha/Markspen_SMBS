using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Security.Principal;

using Markspen_SMBS_V1.Interface.User;

namespace Markspen_SMBS_V1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< .mine
            IPrincipal userPrincipal = new GenericPrincipal(WindowsIdentity.GetCurrent(),
                new string[] { "UserRole2", "Admin" });
            var _frmUserType = new frmUserType(userPrincipal);
            //_frmUserType.IsMainWindow = true;
            _frmUserType.Show();
            if(_frmUserType.Created)
                Application.Run();
=======
            Application.Run(new Markspen_SMBS_V1.Interface.MDIParent1());
>>>>>>> .r11
        }
    }
}
