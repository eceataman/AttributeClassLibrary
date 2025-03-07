using AttributeExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeClassLibrary
{
    public class Person
    {
        [ZorunluAlan]  // Ad alanı zorunlu
        public string FirstName;

        [ZorunluAlan]  // Soyad alanı zorunlu
        public string LastName;
    }
}
