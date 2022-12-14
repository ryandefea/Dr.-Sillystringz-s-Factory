using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class EngineerMachineController : Controller
  {
    private readonly FactoryContext _db;

    public EngineerMachineController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<EngineerMachine> model = _db.EngineerMachine.ToList();
      return View(model);
    }
  }
}