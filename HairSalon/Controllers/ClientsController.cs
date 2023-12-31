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
    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();
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
    public ActionResult Edit(int id)
    {
        Client currentClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
        ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
        return View(currentClient);
    }
    [HttpPost]
        public ActionResult Edit (Client client)
    {
        _db.Clients.Update(client);_db.SaveChanges();
        return RedirectToAction("Index");
    }
    public ActionResult Delete (int id)
    {
        Client currentClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
        return View(currentClient);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        Client currentClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
        _db.Clients.Remove(currentClient);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}