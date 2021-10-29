using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Controllers;

namespace WebApplication1.DBOperations
{
    public class UserRepo
    {
        public RegisterModel GetUser(string uid)
        {
            using (var context = new GKHUBEntities())
            {
                var result = context.Registers.
                    Where(x => x.Email == uid)
                    .Select(x => new RegisterModel()
                    {
                        id = x.Id,
                        name = x.Name,
                        gender = x.Gender,
                        mobile = x.Mobile,
                        email = x.Email,
                        address = x.Address,
                        password = x.Password,

                    }).FirstOrDefault();
                return result;
            }
        }
        public bool UpdateUser(string uid, RegisterModel model)
        {
            using (var context = new GKHUBEntities())
            {

                var result = context.Registers.FirstOrDefault(x => x.Email == uid);
                var logindetails = context.Logins.FirstOrDefault(x=>x.Email==uid);


                if (result != null)
                {
                    result.Id = model.id;
                    result.Name = model.name;
                    result.Gender = model.gender;
                    result.Mobile = model.mobile;
                    result.Email = model.email;
                    result.Address = model.address;

                    logindetails.Email = model.email;
                }
                context.SaveChanges();
                return true;
            }
        }
        public bool UpdatePasswrod(ChangePasswordModel model)
        {
            using (var context = new GKHUBEntities())
            {
                var logindetails = context.Logins.FirstOrDefault(x => x.Email == model.id);
                var result = context.Registers.FirstOrDefault(x => x.Email == model.id);

                if (logindetails != null)
                {                    
                    logindetails.Password = model.newpass;
                    result.Password = model.newpass;
                }
                context.SaveChanges();
                return true;
            }
        }
    }
}