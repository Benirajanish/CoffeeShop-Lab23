using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace CoffeeShop.Controllers
{
    public class CoffeeShopController : Controller
    {
        CoffeeShopDBEntities db = new CoffeeShopDBEntities();
        // GET: CoffeeShop
        public ActionResult Index()
        {
            var Items = db.Items;
            return View(Items.ToList());
        }

        public ActionResult AddItems()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddItems(Item item)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    db.Items.Add(item);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");

            }

            catch
            {
                return View();
            }
        }


        public ActionResult UpdateItems(int id)
        {
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }
        
        [HttpPost]
        public ActionResult UpdateItems(Item item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(item).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");

                }
                return View(item);
            }
            catch
            {
                return View(item);
            }
        }

        //***************************************************************
        public ActionResult DeleteItems(int id)
        {
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        [HttpPost , ActionName("DeleteItems")]

        public ActionResult DeleteItemsConfirm(int id)
        {
            try
            {
                Item item = db.Items.Find(id);
                db.Items.Remove(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }

        //******************************************************************************
        public ActionResult UserIndex()
        {
            var Users = db.Users;
          
            return View(Users.ToList());
        }

        public ActionResult AddUsers()
        {
            return View();
        }
        [HttpPost]

        public ActionResult AddUsers(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                //return View();
                return RedirectToAction("UserIndex");
            }

            catch
            {
                return View();
            }
        }

        // *****************************************************************************

        public ActionResult UpdateUsers(int id)
        {
            User user = db.Users.Find(id);
            
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpPost]
        public ActionResult UpdateUsers(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("UserIndex");

                }
                return View(user);
            }
            catch
            {
                return View(user);
            }
        }
        //******************************************************************************

        //***************************************************************
        public ActionResult DeleteUsers(int id)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("DeleteUsers")]

        public ActionResult DeleteUsersConfirm(int id)
        {
            try
            {
                User user = db.Users.Find(id);
                db.Users.Remove(user);
                 db.SaveChanges();
                return RedirectToAction("UserIndex");
            }
            catch
            {

                return View();
            }
        }

        //******************************************************************************




    }
}