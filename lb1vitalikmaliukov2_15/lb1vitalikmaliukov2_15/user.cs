namespace lb1vitalikmaliukov2_15
{
    public class User
    {

        private String login;
        private String name;
        private String surname;
        private int age;
        private readonly DateTime formSubmittingDate;

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.formSubmittingDate = DateTime.Today;
        }

        public string GetLogin()
        {
            return login;
        }

        public void SetLogin(string value)
        {
            login = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public string GetSurname()
        {
            return surname;
        }

        public void SetSurname(string value)
        {
            surname = value;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            age = value;
        }

        public DateTime GetFormSubmittingDate()
        {
            return formSubmittingDate;
        }

        public void print()
        {
            Console.WriteLine(
                "You are - " + "\n" +
                "login : " + login + "\n" +
                "name : " + name + "\n" +
                "age : " + age + "\n" +
                "date of submitting form : " + formSubmittingDate);
        }
    }
}
