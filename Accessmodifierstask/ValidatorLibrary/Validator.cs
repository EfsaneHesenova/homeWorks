using System.Text.RegularExpressions;

namespace ValidatorLibrary
{
    public class Validator
    {
        public bool UserNameValidator(string userName)
        {
            if (userName.Length >= 2)
            {
                return true;
            }

            return false;
        }
        public bool NameValidator(string name)
        {
            if (name.Length >= 2)
            {
                return true;
            }

            return false;
        }
        public bool SurNameValidator(string surName)
        {
            if (surName.Length >= 2)
            {
                return true;
            }

            return false;
        }
        public bool PasswordValidator(string password)
        {
            string pattern = @"^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[@$!%?&])[A-Za-z\d@$!%?&]{8,}$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(password))
            {
                return true;
            }

            return false;
        }
        public bool AgeValidator(byte age)
        {
            if (age > 0)
            {
                return true;
            }

            return false;
        }
        public bool BirthdayValidator(string birthDay)
        {
            DateTime birthDate;

            if (DateTime.TryParse(birthDay, out birthDate))
            {
                DateTime dateTime1970 = new DateTime(1970, 1, 1);

                if (birthDate >= dateTime1970)
                {
                    return true;
                }
            }

            return false;
        }

        
    }
}
