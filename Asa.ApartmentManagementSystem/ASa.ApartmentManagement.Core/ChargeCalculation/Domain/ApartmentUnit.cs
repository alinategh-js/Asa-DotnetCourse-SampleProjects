using System;
using System.Collections.Generic;
using System.Text;

namespace ASa.ApartmentManagement.Core.ChargeCalculation.Domain
{
   public  class ApartmentUnit
    {
        public int Area { get; }
        public int UnitNumber { get; }
        private List<Payer> _payers;
        public IEnumerable<Payer> Payers => _payers.AsReadOnly();
        public void Add(Payer payer)
        {
            //Business rule
        }
    }
}
