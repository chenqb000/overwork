using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1351300360陈前标.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BolgIndex()
        {
            var db = new DB();
            db.Database.CreateIfNotExists();
            var lst = db.BlogArticles.OrderByDescending(o => o.Id).ToList();
            ViewBag.BlogArticles = lst;

            return View();
        }
        public ActionResult AddArticle()
        {

            return View();
        }
        public ActionResult ArticleSave(string subject, string body)
        {
            var article = new BlogArticle();
            article.Subject = subject;
            article.Body = body;
            article.DateCreated = DateTime.Now;
            
            var db = new DB();
            db.BlogArticles.Add(article);
            db.SaveChanges();
            
                        return Redirect("BolgIndex");
        }
        public ActionResult Show(int id)
        {
            var db = new DB();
            var article = db.BlogArticles.First(o => o.Id == id);

            ViewData.Model = article;
            return View();
        }
        public ActionResult Edit(int id)
            {
                var db = new DB();
                var article = db.BlogArticles.First(o => o.Id == id);
                
                ViewData.Model = article;
                            return View();
              }
        public ActionResult EditSave(int id, string subject, string body)
        {
            var db = new DB();
             var article = db.BlogArticles.First(o => o.Id == id);
 
             article.Subject = subject;
             article.Body = body;
 
             db.SaveChanges();
 
             return RedirectToAction("BolgIndex");
         }
        public ActionResult Delete(int id)
         {
             var db = new DB();
             var article = db.BlogArticles.First(o => o.Id == id);
 
             db.BlogArticles.Remove(article);
             db.SaveChanges();
 
             return RedirectToAction("Index");
         }



}
}