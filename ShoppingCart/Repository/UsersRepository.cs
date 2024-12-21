using ShoppingCart.Entity;
using ShoppingCart.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingCart.Repository
{
    public class UsersRepository : IUsersRepository
    {
        public List<User> BuscarUsuarios()
        {
            //classe para simular o retorno de um BD ou API
            return new List<User>() {
                new User()
                {
                    name = "Rodrigo",
                    userID = "rodferr",
                    isVip = true
                },
                new User()
                {
                    name = "Fernando",
                    userID = "fernor",
                    isVip = false
                },
                new User()
                {
                    name = "Jonas",
                    userID = "jonsan",
                    isVip = false
                },
            };
        }
    }
}
