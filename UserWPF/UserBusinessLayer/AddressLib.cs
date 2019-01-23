using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBusinessLayer
{
    public class Geo
    {
        public string Lat { get; set; }
        public string Lng { get; set; }

        public Geo()
        {

        }
        public Geo(string lat, string lng)
        {
            Lat = lat;
            Lng = lng;
        }

        public override bool Equals(object obj)
        {
            var geo = obj as Geo;
            return geo != null &&
                   Lat == geo.Lat &&
                   Lng == geo.Lng;
        }
        public override int GetHashCode()
        {
            var hashCode = 634768086;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Lat);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Lng);
            return hashCode;
        }
    }
    public class AddressLib
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public Geo Geo { get; set; }

        public AddressLib()
        {

        }
        public AddressLib(string street, string suite, string city, string zipcode, Geo geo)
        {
            Street = street;
            Suite = suite;
            City = city;
            Zipcode = zipcode;
            Geo = geo;
        }

        public override bool Equals(object obj)
        {
            var lib = obj as AddressLib;
            return lib != null &&
                   Street == lib.Street &&
                   Suite == lib.Suite &&
                   City == lib.City &&
                   Zipcode == lib.Zipcode &&
                   EqualityComparer<Geo>.Default.Equals(Geo, lib.Geo);
        }
        public override int GetHashCode()
        {
            var hashCode = -666292302;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Street);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Suite);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(City);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Zipcode);
            hashCode = hashCode * -1521134295 + EqualityComparer<Geo>.Default.GetHashCode(Geo);
            return hashCode;
        }
    }
}
