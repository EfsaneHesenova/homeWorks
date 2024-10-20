using ValidatorLibrary;

namespace Accessmodifierstask.Models
{
    public class Person : Validator
    {
        private string _userName;
        public string UserName
        {
            get => _userName;

            set
            {
                if (UserNameValidator(value))
                {
                    _userName = value;
                }

                else
                {
                    Console.WriteLine("USername minimum 2 simvol olmalidir");
                }
            }
        }
        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                if (PasswordValidator(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("password uygun deyil");
                }
            }
        }
        private string _name;
        public string Name
        {
            get => _name;

            set
            {
                if (NameValidator(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("name minimum 2 simvol olmalidir");
                }
            }
        }
        private string _surName;
        public string SurName
        {
            get => _surName;
            set
            {
                if (SurNameValidator(value))
                {
                    _surName = value;
                }
                else
                {
                    Console.WriteLine("surname minimum 2 simvol olmalidir");
                }
            }
        }
        private byte _age;
        public byte Age
        {
            get => _age;
            set
            {
                if (AgeValidator(value))
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("age 0-dan boyuk olmalidir ");
                }
            }
        }
        private string _birthDay;
        public string Birthday
        {
            get => _birthDay;
            set
            {
                if (BirthdayValidator(value))
                {
                    _birthDay = value;
                }
                else
                {
                    Console.WriteLine("tevellud 1970-den kicik ola bilmez");
                }
            }
        }
        public Person(string userNAme, string password, string name, string surName, byte age, string birthday)
        {
            UserName = userNAme;
            Password = password;
            Name = name;
            SurName = surName;
            Age = age;
            Birthday = birthday;

        }
        public void GetInfo()
        {
            Console.WriteLine($"username: {UserName} \npassword: {Password}  \nname: {Name} \nsurname: {SurName} \nage: {Age} \nbirthday {Birthday}");
        }
    }
}
