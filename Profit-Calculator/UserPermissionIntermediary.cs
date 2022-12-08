using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit_Calculator
{
    public class UserPermissionIntermediary
    {
        public UserPermissionIntermediary() { }
        public UserPermissionIntermediary(string username, int permissionId) {
            Username = username;
            PermissionId = permissionId;
        }
        public string Username { get; set; }
        public int PermissionId { get; set; }
        
    }
}
