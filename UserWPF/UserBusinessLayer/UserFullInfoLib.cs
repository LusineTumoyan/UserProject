using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBusinessLayer
{
    public class UserFullInfoLib 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }

        public AddressLib Address { get; set; }
        public CompanyLib Company { get; set; }

        public UserFullInfoLib()
        {

        }
        public UserFullInfoLib(int iD, string name, string userName, string email, string phone, string website, AddressLib address, CompanyLib company)
        {
            ID = iD;
            Name = name;
            UserName = userName;
            Email = email;
            Phone = phone;
            Website = website;
            Address = address;
            Company = company;
        }

        public override bool Equals(object obj)
        {
            UserFullInfoLib lib = obj as UserFullInfoLib;
            return lib != null &&
                   ID == lib.ID &&
                   Name == lib.Name &&
                   UserName == lib.UserName &&
                   Email == lib.Email &&
                   Phone == lib.Phone &&
                   Website == lib.Website &&
                   EqualityComparer<AddressLib>.Default.Equals(Address, lib.Address) &&
                   EqualityComparer<CompanyLib>.Default.Equals(Company, lib.Company);
        }

        public override int GetHashCode()
        {
            var hashCode = -670585162;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UserName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Phone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Website);
            hashCode = hashCode * -1521134295 + EqualityComparer<AddressLib>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + EqualityComparer<CompanyLib>.Default.GetHashCode(Company);
            return hashCode;
        }
    }
}
