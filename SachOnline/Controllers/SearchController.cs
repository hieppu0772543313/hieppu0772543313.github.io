using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SachOnline.Models;

namespace SachOnline.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        SACHDataContext db = new SACHDataContext();
        public ActionResult Search(string strSearch)
        {
            ViewBag.Search = strSearch;
            if (!string.IsNullOrEmpty(strSearch))
            {

                var kq = from s in db.SACHes where s.TenSach.Contains(strSearch) || s.MoTa.Contains(strSearch) select s;
                //var kq = db.SACHes… return View(kq);
                //var kq = db.SACHes.Where(s => s.TenSach.Contains(strSearch))
                //Cau 2
                //var kq = from s in db.SACHes where s.MaCD == Convert.ToInt32(strSearch);
                //var kq = db.SACHes.Where(S => s.MaCD == int.Parse(strSearch));
                //var kq= db.SACHes.Where(s => s.SoLuongBan >= 5 && s.SoLuongBan <= 10 orderby Ascending) select s;
                return View(kq);
}
            return View();
        }

    }
}