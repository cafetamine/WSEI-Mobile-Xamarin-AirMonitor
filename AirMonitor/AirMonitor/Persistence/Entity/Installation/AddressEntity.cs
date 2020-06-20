using AirMonitor.Core.Domain.Installation;
using SQLite;

namespace AirMonitor.Persistence.Entity.Installation
{
    public class AddressEntity
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string DisplayAddress1 { get; set; }
        public string DisplayAddress2 { get; set; }

        public AddressEntity()
        {
            // for serialization
        }
        
        private AddressEntity(long? id,
                              string country,
                              string city,
                              string street,
                              string number,
                              string displayAddress1,
                              string displayAddress2)
        {
            Id = id;
            Country = country;
            City = city;
            Street = street;
            Number = number;
            DisplayAddress1 = displayAddress1;
            DisplayAddress2 = displayAddress2;
        }
        
        public Address ToDomain()
            => new Address(Id,
                           Country,
                           City,
                           Street,
                           Number,
                           DisplayAddress1,
                           DisplayAddress2);
        
        public static AddressEntity FromDomain(Address address)
            => new AddressEntity(address.Id,
                                 address.Country,
                                 address.City,
                                 address.Street,
                                 address.Number,
                                 address.DisplayAddress1,
                                 address.DisplayAddress2);
    }
}
