using Insurance.DAL.DataAccess;
using Insurance.DAL.Interfaces;
using Insurance.DAL.Models.Database;
using Insurance.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Insurance.Controllers
{
    public class InsuranceTypeController : Controller
    {
        private UnitOfWork<DatabaseContext> unitOfWork = new UnitOfWork<DatabaseContext>();
        private GenericRepository<InsuranceType> repository;
        private IInsuranceTypeRepository InsuranceTypeRepository;
        private IInsuranceCalculator _iIInsuranceCalculator;
        public InsuranceTypeController(IInsuranceCalculator iIInsuranceCalculator)
        {            
            repository = new GenericRepository<InsuranceType>(unitOfWork);            
            InsuranceTypeRepository = new InsuranceTypeRepository(unitOfWork);
            _iIInsuranceCalculator = iIInsuranceCalculator;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = repository.GetAll();

            //var model = InsuranceTypeRepository.GetInsuranceTypesByDepartment(1);
            return View(model);
        }


        [HttpGet]
        public ActionResult _Create()
        {
            return PartialView("Partials/_Create");
        }
        [HttpPost]
        public ActionResult Create(InsuranceType model)
        {
            try
            {
                unitOfWork.CreateTransaction();
                if (ModelState.IsValid)
                {
                    repository.Insert(model);
                    unitOfWork.Save();

                    unitOfWork.Commit();
                    return RedirectToAction("Index", "InsuranceType");
                }
            }
            catch (Exception ex)
            {
                unitOfWork.Rollback();
            }
            return View();
        }


        [HttpGet]
        public ActionResult Update(int InsuranceTypeId)
        {
            InsuranceType model = repository.GetById(InsuranceTypeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(InsuranceType model)
        {
            if (ModelState.IsValid)
            {
                repository.Update(model);
                unitOfWork.Save();
                return RedirectToAction("Index", "InsuranceType");
            }
            else
            {
                return View(model);
            }
        }


        [HttpGet]
        public ActionResult Delete(int InsuranceTypeId)
        {
            InsuranceType model = repository.GetById(InsuranceTypeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult DeletePost(int Id)
        {
            InsuranceType model = repository.GetById(Id);
            repository.Delete(model);
            unitOfWork.Save();
            return RedirectToAction("Index", "InsuranceType");
        }
    }
}