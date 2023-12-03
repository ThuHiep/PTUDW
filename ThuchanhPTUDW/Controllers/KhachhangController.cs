using MyClass.DAO;
using MyClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThuchanhPTUDW.Library;

namespace ThuchanhPTUDW.Controllers
{
    public class KhachhangController : Controller
    {
        //////////////////////////////////////////////////////////////////////////
        // GET: Khachhang DangNhap
        // GET: Customer
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection field)
        {
            UsersDAO usersDAO = new UsersDAO();

            String username = field["username"];
            String password = XString.ToMD5(field["password"]);
            //so sanh thong tin nguoi dung
            Users row_user = usersDAO.getRow(username, "customer");
            String strErr = "";
            if (row_user == null)
            {
                strErr = "Tên đăng nhập không tồn tại";
                ViewBag.Error = "<span class='text-danger'>" + strErr + "</div";
                return View("Login");
            }
            else
            {
                return RedirectToAction("Index", "Site");
            }

        }


        //////////////////////////////////////////////////////////////////////////
        // GET: Khachhang DangKy
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(FormCollection form)
        {
            if (!string.IsNullOrEmpty(form["register"]))//nut ThemCategory duoc nhan
            {
                UsersDAO usersDAO = new UsersDAO();
                String fullname = form["fullname"];
                String email = form["email"];
                String phone = form["phone"];
                String username = form["username"];
                String password = form["password"];
                Users row_user = usersDAO.getRow(username, "customer");
                //xu ly tu dong cho 1 so truong
                if (row_user != null)
                {
                    ViewBag.Err = "Tài khoản đã tồn tại";
                }
                else
                {
                    Users users = new Users();
                    users.Fullname = fullname;
                    users.Status = 1;
                    users.Role = "customer";
                    // xu ly cac truong nhap vao
                    users.Phone = phone;
                    users.Email = email;
                    users.Gender = "1";
                    users.Username = username;
                    users.Password = password;
                    usersDAO.Insert(users);
                    ViewBag.Err = "Tạo tài khoản thành công";
                }
            }
            return View();
        }
    }
}