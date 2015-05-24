using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication4.Models;

namespace MvcApplication4.Controllers
{
    public class PlayersController : Controller
    {
        private PlayerDBContext db = new PlayerDBContext();

        //
        // GET: /Players/

        public ActionResult Index()
        {
            return View(db.Players.ToList());
        }

        //
        // GET: /Players/Details/5

        public ActionResult Details(int id = 0)
        {
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        //
        // GET: /Players/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Players/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Player player)
        {
            if (ModelState.IsValid)
            {
                db.Players.Add(player);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(player);
        }

        //
        // GET: /Players/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        //
        // POST: /Players/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Player player)
        {
            if (ModelState.IsValid)
            {
                db.Entry(player).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(player);
        }

        //
        // GET: /Players/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        //
        // POST: /Players/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult SearchIndex(string searchString)
        {
            var players = from p in db.Players
                          select p;
            if (!string.IsNullOrEmpty(searchString))
            {
                players = players.Where(s => s.CName.Contains(searchString));
            }

            return View(players);
        }

        public ActionResult SearchIndex2(string id)
        {
            string searchString = id;
            return this.SearchIndex(searchString);
        }

        public ActionResult SearchIndex3(string searchString)
        {
            return this.SearchIndex(searchString);
        }

        public ActionResult SearchIndex4(string searchString)
        {
            var players = from p in db.Players
                          select p;
            if (!string.IsNullOrEmpty(searchString))
            {
                players = players.Where(s => s.CName.Contains(searchString));
            }

            return View(players);
        }
        [HttpPost]
        public string SearchIndex4(FormCollection fc, string searchString)
        {
            return "<h3> From [HttpPost]SearchIndex4:" + searchString + "</h3>";
        }

        public ActionResult SearchIndex5(string playerMobile, string searchString)
        {
            var mobileList = new List<string>();
            var mobileQuery = from p in db.Players
                              orderby p.Mobile
                              select p.Mobile;
            mobileList.AddRange(mobileQuery.Distinct());
            ViewBag.playerMobileList = new SelectList(mobileList);

            var players = from p in db.Players
                          select p;

            if (!string.IsNullOrEmpty(searchString))
            {
                players = players.Where(s => s.CName.Contains(searchString));
            }

            if (string.IsNullOrEmpty(playerMobile))
            {
                return View(players);
            }
            else
            {
                return View(players.Where(s => s.Mobile == playerMobile));
            }
        }
    }
}