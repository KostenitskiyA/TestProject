using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestProject.Interfaces;
using TestProject.Models;

namespace TestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        
        private IUserProvider _userProvider;

        public UsersController(IUserProvider userProvider)
        {
            _userProvider = userProvider;
        }

        [HttpPost]
        public IActionResult Post(IEnumerable<User> users)
        {
            try 
            {
                if (ModelState.IsValid)
                {
                    _userProvider.AddUsers(users);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex) 
            {
                BadRequest();
            }
            
            return Ok();
        }

        [HttpGet]
        public Dictionary<int, double> Get()
        {
            var result = new Dictionary<int, double>();

            try 
            {
                result = _userProvider.CalculateUsers();

                return result;
            }
            catch (Exception ex) 
            {
                BadRequest();
            }

            return result;
        }
    }
}
