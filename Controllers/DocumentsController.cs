using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace xapp.Controllers
{
    public class DocumentsController : BaseSecuredController
    {
        public IActionResult Test()
        {
            return View();
        }
    }
}
