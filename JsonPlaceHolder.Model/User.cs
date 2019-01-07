using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPlaceHolder.Model
{
    public class User
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public string UserName { set; get; }
        public string Email { set; get; }
        public Address Address { set; get; }
        public string Phone { set; get; }
        public string Website { set; get; }
        public Company Company { set; get; }
    }

    public class Address
    {
        public string Street { set; get; }
        public string Suite { set; get; }
        public string City { set; get; }
        public string Zipcode { set; get; }
        public Geo Geo { set; get; }
    }
    public class Geo
    {
        public string Lat { set; get; }
        public string Lng { set; get; }
    }
    public class Company
    {
        public string Name { set; get; }
        public string CatchPhrase { set; get; }
        public string BS { set; get; }
    }
}
