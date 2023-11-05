using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserController
{
    public class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private readonly DateTime registrationDate;

        public User(string login, string firstName, string lastName, int age)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            registrationDate = DateTime.Now;
        }

        public string Login
        {
            get { return login; }
        }
        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public DateTime RegistrationDate
        {
            get { return registrationDate; }
        }

        public string GetUserInfo()
        {
            string userInfo = $"Логін: {Login}\nІм'я: {FirstName}\nПрізвище: {LastName}\nВік: {Age} років\nДата заповнення анкети: {RegistrationDate}";
            return userInfo;
        }
    }
}
