using ASa.ApartmentManagement.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASa.ApartmentManagement.Core.BaseInfo.DTOs
{
    public class ExpenseCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FormulaEnum Formula { get; set; }
    }
}
