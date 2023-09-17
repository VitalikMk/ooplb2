namespace lb1vitalikmaliukov2_15
{
    public class Employee
    {

        private String firstName;
        private String lastName;
        private int salary;
        private int standartWorkingHours;
        private int actualWorkingHours;
        private int payment;
        private double tax;

        public Employee(string firstName, string lastName, int salary,
            int standartWorkingHours, int actualWorkingHours)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
            this.standartWorkingHours = standartWorkingHours;
            this.actualWorkingHours = actualWorkingHours;
        }

        public void calculatePayment()
        {
            this.payment = salary * actualWorkingHours / standartWorkingHours;
        }

        public void calculateTax()
        {
            this.tax = salary * 0.2;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string value)
        {
            firstName = value;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string value)
        {
            lastName = value;
        }

        public int GetSalary()
        {
            return salary;
        }

        public void SetSalary(int value)
        {
            salary = value;
        }

        public int GetStandartWorkingHours()
        {
            return standartWorkingHours;
        }

        public void SetStandartWorkingHours(int value)
        {
            standartWorkingHours = value;
        }

        public int GetActualWorkingHours()
        {
            return actualWorkingHours;
        }

        public void SetActualWorkingHours(int value)
        {
            actualWorkingHours = value;
        }

        public int GetPayment()
        {
            return payment;
        }

        public void SetPayment(int value)
        {
            payment = value;
        }

        public double GetTax()
        {
            return tax;
        }

        public void SetTax(double value)
        {
            tax = value;
        }

        public void print()
        {

            Console.WriteLine("You are - " + "\n" +
                "name : " + firstName + "\n" +
                "surname : " + lastName + "\n" +
                "salary : " + salary + "\n" +
                "standart working hours : " + standartWorkingHours + "\n" +
                "actual working hours : " + actualWorkingHours + "\n" +
                "salary : " + salary + "\n" +
                "payment : " + payment + "\n" +
                "tax : " + tax);

        }
    }
}
