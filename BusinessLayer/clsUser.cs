using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class clsUser
    {
        public clsUser(){
            
        }

        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }


        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }


        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private clsUserRoles _userRole;

        public clsUserRoles UserRole
        {
            get { return _userRole; }
            set { _userRole = value; }
        }
        
        
        
    }
}
