using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace _0306191337_0306191313.Models
{
    public class login
    {
        [DisplayName(" tên đăng nhập ")]
        public string usename { get; set; }
        [DisplayName(" mật khẩu  ")]
        public string password { get; set; }


    }
}
