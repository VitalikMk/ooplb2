namespace lb1vitalikmaliukov2_15
{

    public class Program
    {

        public static void Main(string[] args)
        {
            //First task

            Console.WriteLine("First Task \n");
            Address address = new Address(125, "Ukraine", "Virginia", "Namibia", 1, 1);
            address.print();
            Console.WriteLine("\n");

            //Second task

            Console.WriteLine("Second Task \n");
            Converter converter = new Converter(37.17, 35.9, 0.64);
            Console.WriteLine(converter.convertUAHToUSD(1000));
            Console.WriteLine(converter.convertUSDToUAH(1000));
            Console.WriteLine(converter.convertEURToUAH(1000));
            Console.WriteLine(converter.convertPLNToUAH(1000));
            Console.WriteLine("\n");

            //Third task

            Console.WriteLine("Third Task \n");
            Employee employee = new Employee("Arnold", "Shwarzenegger", 100000, 40, 31);
            employee.calculatePayment();
            employee.calculateTax();
            employee.print();
            Console.WriteLine("\n");

            //Fourth task

            Console.WriteLine("Fourth Task \n");
            User user = new User("Petro", "Petrovich", "Petrovichevich", 53);
            user.print();
        }
    }
}
