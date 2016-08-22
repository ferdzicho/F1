using F1.Services;
using F1Repository.Models;
using F1Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace F1.Controllers
{
    [Authorize]
    public class CustomersController : BaseController, IF1Controller
    {
        private readonly ICustomerRepository _repo;

        public CustomersController(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            try
            {
                var customers = _repo.GetCustomers();
                return View(customers);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            try
            {
                var customer = _repo.GetCustomerById(id);
                if (customer == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                return View(customer);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult Details(int id)
        {
            try
            {
                var customer = _repo.GetCustomerById(id);
                if (customer == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                return View(customer);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _repo.DeleteCustomer(id);
            _repo.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SaveChanges(Customer customer)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    if (customer.Id == 0)
                    {
                        _repo.AddCustomer(customer);
                    }
                    else
                    {
                        _repo.EditCustomer(customer);
                    }
                    _repo.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return View(customer);
        }
    }


}