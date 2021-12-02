using IntroWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroWebAPI.Controllers
{
    public class UserController : ApiController
    {
        List<string> userData = new List<string> { "Keyur Adhyaru", "neha Mehta", "Parth Jethni" };

        [ActionName("names")]
        public IEnumerable<string> GetNames()
        {
            
            return userData;
        }

        [HttpDelete]
        public List<String> removeUser(int id)
        {
            userData.Remove(userData.Find((i => i.ToString().Contains(id.ToString()))));
            return userData;
        }

        [HttpGet]
        public string nameById(int id)
        {
            try
            {
                return userData[id];
            }
            catch(Exception e)
            {
                return "User Not Found !!";
            }
            
        }

        [HttpPost]
        public List<string> addUser([FromUri] string name)
        {
            userData.Add(name);
            return userData;
        }

        [HttpPost]
        public Users displayDetails([FromBody] Users objUsers)
        {
            Users objlocalusers = new Users();
            objlocalusers.city = objUsers.city;
            objlocalusers.name = objUsers.name;
            return objlocalusers;
           // return "Hi I am ,  " + objUsers.name + " From " + objUsers.city;
        }

       // [AcceptVerbs(HttpVerbs.Get | System.Web.Mvc.HttpVerbs.Post)]
       [HttpPost]
        public string welcomeToSystem([FromUri] string FullName)
        {
            return "Welcome " + FullName;
        }

    }
}
