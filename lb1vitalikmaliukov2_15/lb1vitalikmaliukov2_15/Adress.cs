namespace lb1vitalikmaliukov2_15
{
    public class Address
    {

        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public Address(int index, string country, string city,
                            string street, int house, int apartment)
        {
            this.SetIndex(index);
            this.SetCountry(country);
            this.SetCity(city);
            this.SetStreet(street);
            this.SetHouse(house);
            this.SetApartment(apartment);
        }

        public int GetIndex()
        {
            return index;
        }

        public void SetIndex(int value)
        {
            index = value;
        }

        public string GetCountry()
        {
            return country;
        }

        public void SetCountry(string value)
        {
            country = value;
        }

        public string GetCity()
        {
            return city;
        }

        public void SetCity(string value)
        {
            city = value;
        }

        public string GetStreet()
        {
            return street;
        }

        public void SetStreet(string value)
        {
            street = value;
        }

        public int GetHouse()
        {
            return house;
        }

        public void SetHouse(int value)
        {
            house = value;
        }

        public int GetApartment()
        {
            return apartment;
        }

        public void SetApartment(int value)
        {
            apartment = value;
        }

        public void print()
        {

            Console.WriteLine("Your address - " + "\n" +
                "index : " + index + "\n" +
                "country : " + country + "\n" +
                "city : " + city + "\n" +
                "street : " + street + "\n" +
                "house : " + house + "\n" +
                "appartment : " + apartment);

        }
    }
}
