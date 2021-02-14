using System;
using System.Collections.Generic;
using System.Text;

namespace ASa.ApartmentManagement.Core.ChargeCalculation.Domain
{
    public class ChargeItem
    {
        public decimal Amount { get; set; }
        public int ExpensId { get; set; }
        public int PayerId { get; set; }

    }
}
