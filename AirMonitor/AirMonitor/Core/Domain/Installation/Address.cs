namespace AirMonitor.Core.Domain.Installation
{
    public struct Address
    {
        public long? Id { get; }
        public string Country { get; }
        public string City { get; }
        public string Street { get; }
        public string Number { get; }
        public string DisplayAddress1 { get; }
        public string DisplayAddress2 { get; }

        public Address(long? id,
                       string country,
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
        
        public string Description => $"{Street} {Number}, {City}";

        public static Address Create(string country,
                                     string city,
                                     string street,
                                     string number,
                                     string displayAddress1,
                                     string displayAddress2)
            => new Address(null, country, city, street, number, displayAddress1, displayAddress2);
    }
}
