using Api.Application.Bases;
using Api.Application.Features.Products.Exceptions;
using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Products.Rules
{
    public class AuthRules :BaseRules
    {
        public Task UserShouldNotBeExixt(User? user)
        {
           if(user is not null)
            {
                throw new UserAlreadyExistException();
            }
            return Task.CompletedTask;
        }
    }
}
