using Microsoft.AspNetCore.Mvc;
using MVCProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Controllers
{
    public class TrainingController : Controller
    {
        private readonly ApplicationDBContext dBContext;
        public TrainingController(ApplicationDBContext context)
        {
            this.dBContext = context;
        }
        public async Task<IActionResult> Index()
        {
            List<TrainingTable> result = dBContext.TRAININGS.OrderBy(x => x.TRAINING_NAME).ToList();

            return View(result);
        }
    }
}
