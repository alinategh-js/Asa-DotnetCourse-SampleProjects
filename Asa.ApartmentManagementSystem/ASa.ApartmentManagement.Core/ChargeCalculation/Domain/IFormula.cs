using System;
using System.Collections.Generic;
using System.Text;

namespace ASa.ApartmentManagement.Core.ChargeCalculation.Domain
{
    public interface IFormula
    {
        List<(int payerId, decimal amount)> Calculate(Expens expens, Building building, int unit);
    }
}
