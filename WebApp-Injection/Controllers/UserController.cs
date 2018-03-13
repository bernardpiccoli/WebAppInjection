using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Application;
using WebApp.Domain;

namespace WebApp_Injection.Controllers
{
    [Route("api/User")]
    public class UserController : Controller
    {
        private IUserService _userService;
        private INotification _notification; 

        public UserController(IUserService userService, INotification notification)
        {
            _userService = userService;
            _notification = notification;
        }


        [HttpPost]
        [Route("create")]
        public void Create(User u)
        {
            _userService.Create(u);
            _notification.Send(u);
        }

    }

}