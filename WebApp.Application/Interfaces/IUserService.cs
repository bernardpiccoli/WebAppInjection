using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Domain;

namespace WebApp.Application
{
    public interface IUserService
    {
        void Create(User u);
    }
}
