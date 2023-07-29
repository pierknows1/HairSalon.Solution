using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;
    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }
    public ActionResult Index ()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Client client)
    {
        if (client.StylistId == 0)
        {
            return RedirectToAction("Create");
        }
            _db.Clients.Add(client);
            _db.SaveChanges();
            return RedirectToAction("Index");
    }
    public ActionResult Details (int id)
    {
        Client currentClient = _db.Clients.Include
        (client => client.Stylist).FirstOrDefault(client => client.ClientId == id);

        return View(currentClient);
    }
  }
}
