using Moq;
using ShoppingCart.BusinessRules;
using ShoppingCart.Entity;
using ShoppingCart.Interface;

namespace ShoppingCart.Tests
{
    public class DiscountTests
    {

        Discount _discount;
        Mock<IUsersRepository> _usersRepositoryMock;

        public DiscountTests()
        {
            //objeto fake usado no mock
            var fakeData = new List<User>() {
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

            //cria��o do mock
            _usersRepositoryMock = new Mock<IUsersRepository>();
            _usersRepositoryMock.Setup(x => x.BuscarUsuarios())
                .Returns(fakeData);

            //passa o objeto fake para a classe Discount usar como fonte
            _discount = new Discount(_usersRepositoryMock.Object);
        }

        //cria��o dos testes
        [Theory(DisplayName = "Check Discount Percentage Based On User Role")]
        [InlineData(20, "rodferr")]
        [InlineData(5, "jonsan")]
        public void CheckDiscountPercentageBasedOnUserRole(decimal discountExpected, string userID)
        {
            //verifica se a quantidade de desconto aplicada est� correta com base na role do perfil do usu�rio (vip ou n�o)
            Assert.Equal(discountExpected, _discount.DiscountPercentage(userID));
        }
    }
}