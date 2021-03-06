﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using digiozPortal.BO;
using digiozPortal.BLL;
using Microsoft.AspNetCore.Mvc;
using digiozPortal.BLL.Interfaces;
using Microsoft.Extensions.Logging;

namespace digiozPortal.Web.Controllers
{
    public class LinksController : BaseController
    {
        private readonly ILogic<Link> _linkLogic;
        private readonly ILogic<LinkCategory> _linkCategoryLogic;

        public LinksController(
            ILogic<Link> linkLogic,
            ILogic<LinkCategory> linkCategoryLogic
        ) {
            _linkLogic = linkLogic;
            _linkCategoryLogic = linkCategoryLogic;
        }

        //
        // GET: /Links/
        public ActionResult Index()
        {
            var linkcategories = _linkCategoryLogic.GetAll(); 

            return View(linkcategories);
        }

        public ActionResult LinkBox(int id)
        {
            var links = _linkLogic.GetAll().Where(x => x.LinkCategoryId == id).ToList();

            return PartialView("LinkBox", links);
        }
	}
}