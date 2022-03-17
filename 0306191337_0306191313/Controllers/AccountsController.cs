using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DOAN.Models;
using _0306191337_0306191313.Data;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace _0306191337_0306191313.Controllers
{
    public class AccountsController : Controller
    {
        private readonly _0306191337_0306191313Context _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AccountsController(_0306191337_0306191313Context context, IWebHostEnvironment WebHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = WebHostEnvironment;
        }

        //đăng ký 
        public ActionResult Register()
        {
            return RedirectToAction("Login", "Accounts");
        }

        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(string Username, string Password, string Email, string Phone, string Address, string Fullname,  IFormFile ImageAvata)
        {
            Account acc = _context.Accounts.FirstOrDefault(c => c.Username == Username && c.Password == Password);
            if (acc == null)
            {
                acc = new Account();
                acc.Username = Username;
                acc.Password = Password;
                acc.Email = Email;
                acc.Phone = Phone;
                acc.Address = Address;
                acc.FullName = Fullname;
                if (ImageAvata != null)
                {
                    var filename = Guid.NewGuid() + Path.GetExtension(ImageAvata.FileName);
                    var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "user_images");
                    var filePath = Path.Combine(uploadPath, filename);

                    using (FileStream fs = System.IO.File.Create(filePath))
                    {
                        ImageAvata.CopyTo(fs);
                        fs.Flush();
                    }
                    acc.Avatar = filename;
                }
                acc.Status = true;
                acc.IsAdmin = false;
                _context.Add(acc);
                _context.SaveChanges();
            }
            else
            {
                return RedirectToAction("Login", "Accounts");
            }

            return RedirectToAction("Index", "Home");
        }
        // GET: Accounts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Accounts.ToListAsync());
        }

        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Accounts/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Password,Email,Phone,Address,FullName,IsAdmin,Avatar,ImageAvata,Status")] Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                if (account.ImageAvata != null)
                {
                    var filename = account.Id.ToString() + Path.GetExtension(account.ImageAvata.FileName);
                    var uploadfile = Path.Combine(_webHostEnvironment.WebRootPath, "img", "product");
                    var filePath = Path.Combine(uploadfile, filename);
                    using (FileStream fs = System.IO.File.Create(filePath))
                    {
                        account.ImageAvata.CopyTo(fs);
                        fs.Flush();

                    }
                    account.Avatar = filename;
                    _context.Accounts.Update(account);
                    await _context.SaveChangesAsync();

                }
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }
        //public IActionResult Login()
        //{
        //    return View();
        //}
       // [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Login(string Username, string Password)
        {
            Account account = _context.Accounts.Where(a => a.Username == Username && a.Password == Password).FirstOrDefault();

            if (account != null)
            {
                //CookieOptions cookieOptions = new CookieOptions()
                //{
                //    Expires = DateTime.Now.AddDays(2)
                //};

                // Tạo Cookies
                //HttpContext.Response.Cookies.Append("AccountID", account.Id.ToString(), cookieOptions);
                //HttpContext.Response.Cookies.Append("AccountUsername", account.Username.ToString());

                //Tạo section
                HttpContext.Session.SetInt32("id", account.Id);
                HttpContext.Session.SetString("Username", account.Username);

                return RedirectToAction("Index", "Accounts");

                if(account.IsAdmin ==true )
                {
                    return RedirectToAction("Index", "Accounts");
                }
                else
                {
                    return RedirectToAction("Index", "Home");

                }
            }
            return View(); 
        }
        //logout 
        [HttpPost]
        public IActionResult logout()
        {
            HttpContext.Response.Cookies.Append("AccountID", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            HttpContext.Response.Cookies.Append("AccountUsername","", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            return RedirectToAction("Index","Home");
        }
        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                if (account.ImageAvata != null)
                {
                    var filename = account.Id.ToString() + Path.GetExtension(account.ImageAvata.FileName);
                    var uploadfile = Path.Combine(_webHostEnvironment.WebRootPath, "img", "product");
                    var filePath = Path.Combine(uploadfile, filename);
                    using (FileStream fs = System.IO.File.Create(filePath))
                    {
                        account.ImageAvata.CopyTo(fs);
                        fs.Flush();

                    }
                    account.Avatar = filename;
                    _context.Accounts.Update(account);
                    await _context.SaveChangesAsync();

                }
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Password,Email,Phone,Address,FullName,IsAdmin,Avatar,Status")] Account account)
        {
            if (id != account.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Accounts.FindAsync(id);
            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //Tài khoản có địa chỉ ở Tp.Hồ Chí Minh
        public async Task<IActionResult> ByAddress()
        {
            var accounts = _context.Accounts.Where(acc => acc.Address.Contains("Tp.Hồ Chí Minh")).ToList();
            return View(accounts);
        }
        //Tài khoản có email thuộc Gmail
        public async Task<IActionResult> ByEmail()
        {
            var accounts = _context.Accounts.Where(acc => acc.Email.Contains("@gmail.com")).ToList();
            return View(accounts);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Search()
        {
            return View();
        }
        //public IActionResult Search(String username, string email, string phone, string address, String fullname)
        //{
        //    List<Account> accounts = _context.Accounts.ToList();
        //    if (username != null)
        //    {
        //        accounts = accounts.Where(acc => acc.Username == username).ToList();
        //    }
        //    if (email != null)
        //    {
        //        accounts = accounts.Where(acc => acc.Email == email).ToList();
        //    }
        //    if (phone != null)
        //    {
        //        accounts = accounts.Where(acc => acc.Phone == phone).ToList();
        //    }
        //    if (address != null)
        //    {
        //        accounts = accounts.Where(acc => acc.Address.Contains(address)).ToList();
        //    }
        //    if (fullname != null)
        //    {
        //        accounts = accounts.Where(acc => acc.FullName.Contains(fullname)).ToList();
        //    }

        //    return View(accounts);
        //}

        public async Task<IActionResult> Search(string search)
        {
            ViewData["Get"] = search;
            var accounts = from x in _context.Accounts select x;
            if (!String.IsNullOrEmpty(search))
            {
                accounts = accounts.Where(x => x.Username.Contains(search) || x.Email.Contains(search) || x.Phone.Contains(search) || x.Address.Contains(search) || x.FullName.Contains(search));
            }
            return View(await accounts.AsNoTracking().ToListAsync());
        }

        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.Id == id);
        }
    }
}
