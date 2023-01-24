using IsBasvuruFormu.DLL.Repositories;
using IsBasvuruFormuMVC.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IsBasvuruFormuMVC.UI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registry()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(ViewModel modelView)
        {
            try
            {
                //if (ModelState.IsValid)
                //{
                    UnitOfWork uow = new UnitOfWork();
                    uow.personRep.Insert(modelView.person);
                    if (await uow.SaveChanges())
                    {
                        modelView.contact.PersonID = modelView.person.ID;
                        modelView.education.PersonID = modelView.person.ID;
                        modelView.otherEducation.PersonID = modelView.person.ID;
                        modelView.language.PersonID = modelView.person.ID;
                        modelView.workExperience.PersonID = modelView.person.ID;
                        modelView.reference.PersonID = modelView.person.ID;

                        uow.contactRep.Insert(modelView.contact);
                        uow.educationRep.Insert(modelView.education);
                        uow.otherEducationRep.Insert(modelView.otherEducation);
                        uow.languageRep.Insert(modelView.language);
                        uow.referenceRep.Insert(modelView.reference);
                        uow.workExperienceRep.Insert(modelView.workExperience);
                        ViewBag.ViewModel = modelView;
                        await uow.SaveChanges();
                    }

                //}

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

    }
}
