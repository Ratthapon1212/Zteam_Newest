using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Zteam.Data;

namespace Zteam.Controllers
{
    public class CartController : Controller
    {

        public readonly ApplicationDbContext _db;

        public CartController(ApplicationDbContext db) { _db = db; }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Show(string cartid)
        //{
        //    //Master
        //    //ตรวจสอบว่าเป็นตะกร้าของลูกค้าที่ใช้งานอยู่หรือไม่
        //    //ได้ข้อมูล Cart เป็นส่วน Master
        //    string cusid = HttpContext.Session.GetString("CusId");
        //    var cart = from ct in _db.Cart
        //               where ct.CartId == cartid &&
        //                   ct.CusId == cusid
        //               select ct;
        //    if (cart == null)
        //    {
        //        TempData["ErrorMessage"] = "ไม่พบตะกร้าที่ระบุ";
        //        return RedirectToAction("Index", "Home");
        //    }

        //    //Detail
        //    //เลือกข้อมูลของตะกร้า+สร้าง ViewModel CtdVM แสดงชื่อสินค้า
        //    var cartdtl = from ctd in _db.CartDtls
        //                  join p in _db.Game on ctd.GameId equals p.GameId
        //                      into join_ctd_p
        //                  from ctd_p in join_ctd_p.DefaultIfEmpty()
        //                  where ctd.CartId == cartid
        //                  select new CartVM
        //                  {
        //                      CartId = ctd.CartId,
        //                      PdId = ctd.PdId,
        //                      PdName = ctd_p.PdName,
        //                      CdtlMoney = ctd.CdtlMoney,
        //                      CdtlPrice = ctd.CdtlPrice,
        //                      CdtlQty = ctd.CdtlQty
        //                  };

        //    //สร้าง Dynamic model เพื่อส่งข้อมูลให้ View เป็นสองตารางพร้อมกัน
        //    dynamic DyModel = new ExpandoObject();
        //    //ระบุส่วน Master รับข้อมูลจาก Obj cart
        //    DyModel.Master = cart;
        //    //ระบุส่วน Detail รับข้อมูลจาก Obj cartdtl
        //    DyModel.Detail = cartdtl;
        //    //ส่ง Dynamic Model ไปที่ View
        //    return View(DyModel);
        //}

    }
}
