using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBusinessLayer
{
    public class CompanyLib
    {
        public string Name { get; set; }
        public string CatchPhrase { get; set; }
        public string Bs { get; set; }

        public CompanyLib()
        {
            
        }
        public CompanyLib(string name, string catchPhrase, string bs)
        {
            Name = name;
            CatchPhrase = catchPhrase;
            Bs = bs;
        }

        public override bool Equals(object obj)
        {
            var lib = obj as CompanyLib;
            return lib != null &&
                   Name == lib.Name &&
                   CatchPhrase == lib.CatchPhrase &&
                   Bs == lib.Bs;
        }
        public override int GetHashCode()
        {
            var hashCode = -6069311;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CatchPhrase);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Bs);
            return hashCode;
        }
    }
}
