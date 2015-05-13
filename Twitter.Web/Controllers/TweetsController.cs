using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Twitter.Data.UnitOfWork;
using Twitter.Models;
using Twitter.Web.Models.Binding;

namespace Twitter.Web.Controllers
{
    [Authorize]
    public class TweetsController : BaseController
    {
        // GET: Tweets
        public TweetsController(ITwitterData data) : base(data)
        {
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post(TweetBindingModel model)
        {
            if (!ModelState.IsValid)
            {

            }

            var tweet = new Tweet
            {
                Content = model.Content,
                PostDate = DateTime.Now,
                Reports = 0,
                UserId = this.User.Identity.GetUserId()
            };

            this.Data.Tweets.Add(tweet);
            this.Data.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}