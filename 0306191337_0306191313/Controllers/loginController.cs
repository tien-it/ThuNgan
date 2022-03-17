using DOAN.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191337_0306191313.Controllers
{
    public class loginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public async Task<IActionResult> Login(string Username, string Password)
        //{
        //    Account account = _Context.Accounts.Where(a => a.Username == Username && a.Password == Password && a.IsAdmin == true).FirstOrDefault();
        //    if (account != null)
        //    {
        //        HttpContext.Response.Cookies.Append("AccountID", account.Id.ToString());
        //        HttpContext.Response.Cookies.Append("AccountUsername", account.Username.ToString());
        //        return RedirectToAction("Index", "Home");

        //    }
        //    else
        //    {
        //        ViewBag.ErrorMessage = " đăng nhập thất bại";
        //        return View();
        //    }


       // }
    }
}
