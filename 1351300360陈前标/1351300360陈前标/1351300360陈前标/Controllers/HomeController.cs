﻿using System;
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
       

}
}