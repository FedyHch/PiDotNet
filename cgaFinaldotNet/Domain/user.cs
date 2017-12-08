using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class user
    {
        public string DTYPE { get; set; }
        public string Cin { get; set; }
        public Nullable<System.DateTime> Birth_date { get; set; }
        public string E_mail { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Phone_number { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string driving_licence_id { get; set; }
        public string role { get; set; }
        public Nullable<float> salary { get; set; }
        public string status { get; set; }
        public string Diplome { get; set; }
    }
}
