using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class clsUserRoles
    {
        public clsUserRoles()
        {

        }

        private int _roleId;

        public int RoleID
        {
            get { return _roleId; }
            set { _roleId = value; }
        }

        private string _roleName;

        public string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }

        private List<clsPermission> _permission;

        public List<clsPermission> Permission
        {
            get { return _permission; }
            set { _permission = value; }
        }
        
    }
}
