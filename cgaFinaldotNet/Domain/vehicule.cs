using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class vehicule
    {
        public string chasisNumber { get; set; }
        public string Marque { get; set; }
        public string model { get; set; }
        public int power { get; set; }
        public string registrationNumber { get; set; }
        public Nullable<int> contractVehicule_ContractId { get; set; }
    }
}
