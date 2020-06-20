namespace AirMonitor.Model.Domain.Installation
{
    public struct Address
    {
        public string Country { get; }
        public string City { get; }
        public string Street { get; }
        public string Number { get; }
        public string DisplayAddress1 { get; }
        public string DisplayAddress2 { get; }

        public Address(string country,
                       string city,
                       string street,
                       string number,
                       string displayAddress1,
                       string displayAddress2)
        {
            Country = country;
            City = city;
            Street = street;
            Number = number;
            DisplayAddress1 = displayAddress1;
            DisplayAddress2 = displayAddress2;
        }
    }
}