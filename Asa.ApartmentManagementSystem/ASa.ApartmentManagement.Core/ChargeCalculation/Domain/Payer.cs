using System;
using System.Collections.Generic;
using System.Text;

namespace ASa.ApartmentManagement.Core.ChargeCalculation.Domain
{
    public class Payer
    {
        public Payer(int id, DateTime from, DateTime to, string fullName, int numberOfPeople)
        {
            Id = id;
            From = from;
            To = to;
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
            NumberOfPeople = numberOfPeople;
        }

        public int Id { get; }
        public DateTime From { get; }
        public DateTime To { get; }
        public string FullName { get; }
        public int NumberOfPeople { get; }
    }
}
