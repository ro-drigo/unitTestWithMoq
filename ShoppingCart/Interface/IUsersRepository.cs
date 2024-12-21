using ShoppingCart.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Interface
{
    public interface IUsersRepository
    {
        List<User> BuscarUsuarios();
    }
}