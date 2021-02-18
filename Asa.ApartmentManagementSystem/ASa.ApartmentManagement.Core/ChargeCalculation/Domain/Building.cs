using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ASa.ApartmentManagement.Core.ChargeCalculation.Domain
{
    public class Building
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int TotalArea => Units.Sum(x => x.Area);

        internal List<(int payerId, int days)> GetDayOfLivingForPayers(int unit, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public int UnitsCount => Units.Count;
        public virtual List<ApartmentUnit> Units { get; set; }
        public IEnumerable<Charge> CalulateCharge(IEnumerable<Expens> expenses)
        {
            List<Charge> charges = new List<Charge>();
            foreach (var unit in Units)
            {
                Charge charge = new Charge();
                //Fill other data in charge
                foreach (var expens in expenses)
                {
                    charge.CalculateFor(this, unit.UnitNumber, expens);

                }
            }
            return charges;
        }
    }
}
