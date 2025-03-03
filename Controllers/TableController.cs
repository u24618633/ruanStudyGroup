using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ruanStudyGroup.Controllers
{
    public class TableController : Controller
    {
        // GET: Table
        public ActionResult Index()
        {
            List<Models.TableClass> people = new List<Models.TableClass>();
            
            people.Add(new Models.TableClass { StudentID = "u24618633", FirstName = "Ruan", LastName = "Snyman", EmailAdress = "u24618633@tuks.co.za" });
            people.Add(new Models.TableClass { StudentID = "u24618633", FirstName = "Ruan", LastName = "Snyman", EmailAdress = "u24618633@tuks.co.za" });
            people.Add(new Models.TableClass { StudentID = "u24618633", FirstName = "Ruan", LastName = "Snyman", EmailAdress = "u24618633@tuks.co.za" });
            people.Add(new Models.TableClass { StudentID = "u24618633", FirstName = "Ruan", LastName = "Snyman", EmailAdress = "u24618633@tuks.co.za" });
            people.Add(new Models.TableClass { StudentID = "u24618633", FirstName = "Ruan", LastName = "Snyman", EmailAdress = "u24618633@tuks.co.za" });


            return View(people);
        }
    }
}