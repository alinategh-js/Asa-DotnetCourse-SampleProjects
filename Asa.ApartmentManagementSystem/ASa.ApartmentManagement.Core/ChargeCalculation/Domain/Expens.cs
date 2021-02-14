using System;
using System.Collections.Generic;
using System.Text;

namespace ASa.ApartmentManagement.Core.ChargeCalculation.Domain
{

    public class Expens
    {
        public int Id { get; private set; }
        public decimal Amount { get; private  set; }
        public string Title { get; private  set; }
        public IFormula Formula { get; private  set; }
        public DateTime From { get; private  set; }
        public DateTime To { get; private  set; }

        //Tuple
        public List<(int payerId, decimal amount)> CalculateShare(Building building, int unitNumber)
        {
            // TODO : Do calculation by formula
            var shares = new List<(int payerId, decimal amount)>();
            var share = (payerId: 1, amount: 1000);
            shares.Add(share);
            return shares;

        }
    }
}
