using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace xapp.Controllers
{
    //[AllowAnonymous]
    [Authorize]
    public abstract class BaseSecuredController : Controller
    {
        //Various methods can go here
    }
}
