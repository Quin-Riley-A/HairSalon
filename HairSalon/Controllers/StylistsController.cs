using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      //model definition
      //return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(StylistObj stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      //should end with: 
      //return View(particularStylist)
    }

    public ActionResult Edi(int id)
    {
      //should end with: 
      //return View(particularStylist)
    }

    [HttpPost]
    public ActionResult Edit()
    {
      //_db.SaveChanges();
      //return Redirect
    }
  }
}