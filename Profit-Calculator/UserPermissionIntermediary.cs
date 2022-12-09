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
        public UserPermissionIntermediary(string username, int permissionId, DateTime expireDate) {
            Username = username;
            PermissionId = permissionId;
            PermissionExpireDate = expireDate;
        }
        public string Username { get; set; }
        public int PermissionId { get; set; }
        public DateTime PermissionExpireDate { get; set; }
        
    }
}
