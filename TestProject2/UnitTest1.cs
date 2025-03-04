using Klasy_i_metody_w_klasie;

namespace TestProject2
{

    public class Tests
    {
        [Test]

        public void Test1()
        {
            //arange

            string number1 = "Piotr";
            string number2 = "Piotr";
           
            //act

            //var result = user1.Result;

            //assert

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TEST()
        {
            //arange
            var user1 = GetUser("Piotr","12345");
            var user2 = GetUser("Piotr", "12345");


            //act

            //var result = user1.Result;

            //assert

            Assert.AreEqual(user1.Password, user2.Password);
        }

        private User GetUser(string name, string password)
        {
            return new User(name, password);
        }

    }
}
