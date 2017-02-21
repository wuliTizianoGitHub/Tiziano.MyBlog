using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiziano.MyBlog.Authorization.Permissions
{
    public class Permission : Abp.Authorization.PermissionSetting
    {
        public virtual long ParentPermissionId { get; set; }

        public virtual string DisplayName { get; set; }

        public virtual bool IsFunction { get; set; }

        public virtual PermissionType PermissionType { get; set; }

        public virtual long UserId{get;set;}

        public virtual int RoleId { get; set;}
    }

    public enum PermissionType
    {
        Menu = 1,
        Button = 2
    }
}
