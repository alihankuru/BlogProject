﻿using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication12.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddContact()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddContact(Contact p )
        {
            cm.BLContactAdd(p);
            return View();
        }

    }
}