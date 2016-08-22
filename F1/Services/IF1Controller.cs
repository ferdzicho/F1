using F1Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F1.Services
{
    public interface IF1Controller
    {
        ActionResult Index();
        ActionResult Create();
        ActionResult Edit(int id);
        ActionResult Details(int id);
        ActionResult Delete(int id);
        ActionResult SaveChanges(Customer customer);
    }
}