using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tiziano.MyBlog.Web.Models.Account
{
    public class HomeUserViewModel
    {
        public string ProfilePhoto { get; set; }

        public string TenancyName { get; set; }

        public string Surname { get; set; }
        public string RoleName { get; set; }
    }
}