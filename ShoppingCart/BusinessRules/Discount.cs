using ShoppingCart.Interface;
using ShoppingCart.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.BusinessRules
{
    public class Discount
    {
        private IUsersRepository _usersRepository;

        public Discount(IUsersRepository usersRepository) 
        { 
            _usersRepository = usersRepository;
        }

        public decimal DiscountPercentage(string userID)
        {
            //trazemos todos os usuários
            var users = _usersRepository.BuscarUsuarios();

            //filtramos apenas por aquele que está vindo como parametro
            var user = users.Where(user => user.userID == userID).First();

            //OBS: Claro que em um cenário real, o filtro deveria ser feito na fonte e não trazer todos os usuários sem necessidade. Isso é apenas um teste de testes de unidade e mock

            if (user.isVip)
            {
                return 20.0m;
            }
            else
            {
                return 5.0m;
            }
        }
    }
}
