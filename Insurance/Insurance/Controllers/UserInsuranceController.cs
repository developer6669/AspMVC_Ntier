using Insurance.DAL.DataAccess;
using Insurance.DAL.Models.Database;
using Insurance.DAL.Models.ViewModels.UserInsurance;
using Insurance.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Insurance.Controllers
{
    public class UserInsuranceController : Controller
    {
        private UnitOfWork<DatabaseContext> unitOfWork = new UnitOfWork<DatabaseContext>();
        private GenericRepository<UserInsurance> _repository;
        private IUserInsuranceRepository _userInsuranceRepository;
        private IInsuranceTypeRepository _insuranceTypeRepository;

        public UserInsuranceController(IInsuranceTypeRepository insuranceTypeRepository)
        {
            _repository = new GenericRepository<UserInsurance>(unitOfWork);
            _userInsuranceRepository = new UserInsuranceRepository(unitOfWork);
            _insuranceTypeRepository = insuranceTypeRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = _repository.GetAll();           

            return View(model);
        }


        [HttpGet]
        public ActionResult _Create()
        {
            var ViewModel = new UserInsuranceVm()
            {
                ListInsuranceType= _insuranceTypeRepository.GetAll().ToList()
            };

            return PartialView("Partials/_Create",ViewModel);
        }
        [HttpPost]
        public ActionResult Create(UserInsuranceVm viewModel)
        {
            try
            {
                unitOfWork.CreateTransaction();
                if (ModelState.IsValid)
                {
                    _userInsuranceRepository.CreateBulk(viewModel);
                    unitOfWork.Save();

                    unitOfWork.Commit();
                    return RedirectToAction("Index", "UserInsurance");
                }
            }
            catch (Exception ex)
            {
                unitOfWork.Rollback();
            }
            return View();
        }

        public ActionResult _Read()
        {
            var ViewModel = new UserInsuranceReadVm()
            {
                ListInsurance=_userInsuranceRepository.GetAll().ToList()
            };

            return PartialView("Partials/_Read",ViewModel);
        }

        [HttpGet]
        public ActionResult Update(int UserInsuranceId)
        {
            UserInsurance model = _repository.GetById(UserInsuranceId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(UserInsurance model)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(model);
                unitOfWork.Save();
                return RedirectToAction("Index", "UserInsurance");
            }
            else
            {
                return View(model);
            }
        }


        [HttpGet]
        public ActionResult Delete(int UserInsuranceId)
        {
            UserInsurance model = _repository.GetById(UserInsuranceId);
            return View(model);
        }
        [HttpPost]
        public ActionResult DeletePost(int Id)
        {
            UserInsurance model = _repository.GetById(Id);
            _repository.Delete(model);
            unitOfWork.Save();
            return RedirectToAction("Index", "UserInsurance");
        }
    }
}