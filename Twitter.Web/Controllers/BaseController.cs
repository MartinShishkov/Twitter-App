using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twitter.Data.UnitOfWork;

namespace Twitter.Web.Controllers
{
    public class BaseController : Controller
    {
        protected ITwitterData _data;

        public BaseController(ITwitterData data)
        {
            this.Data = data;
        }

        public ITwitterData Data
        {
            get { return this._data; }
            private set { this._data = value; }
        }

    }
}