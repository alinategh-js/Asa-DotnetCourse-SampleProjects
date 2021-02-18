using System;
using System.Collections.Generic;
using System.Text;

namespace ASa.ApartmentManagement.Core.ChargeCalculation.Domain
{
    public class Charge
    {
        public int Id { get; set; }
        List<ChargeItem> _items;
        public IEnumerable<ChargeItem> Items => _items.AsReadOnly();
        public int UnitId { get; set; }
        public int UnitNumber { get; set; }
        public DateTime IssueDate { get; set; }

        internal void CalculateFor(Building building, int unitNumber, Expens expens)
        {
            var shares = expens.CalculateShare(building, unitNumber);
            foreach (var share in shares)
            {
                ChargeItem item = new ChargeItem { Amount = share.amount, ExpensId = expens.Id, PayerId = share.payerId };
                this._items.Add(item);
            }
        }
    }
}
