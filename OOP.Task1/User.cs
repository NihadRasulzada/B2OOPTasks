using OOP.Task1.Extensions;

namespace OOP.Task1
{
    internal class User
    {
        private string _password;
        public string Name { get; set; }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (IsPasswordValid(value))
                {
                    _password = value;
                }
            }
        }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
            if (Password == null)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }

        }

        public bool IsPasswordValid(string password)
        {
            if (password.Length < 6)
            {
                return false;
            }
            bool hasNumber = false;
            foreach (char item in password)
            {
                if (item.IsNumber())
                {
                    hasNumber = true;
                    break;
                }
            }
            if (!hasNumber)
            {
                return false;
            }

            password = password.ToUpper();
            string name = Name.ToUpper();

            if (password.Contains(name))
            {
                return false;
            }

            return true;

        }
    }
}
