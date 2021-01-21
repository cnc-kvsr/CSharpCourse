using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //prop yazıp Tab tuşuna iki kere tıkla : public int MyProperty { get; set; } kalıbı çıkar.

        //public string FirstName;  ikinci bir kodlama şekli..
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
