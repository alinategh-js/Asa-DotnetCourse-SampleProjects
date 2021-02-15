using ASa.ApartmentManagement.Core.BaseInfo.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASa.ApartmentManagement.Core.BaseInfo.DataGateways
{
    public interface IExpenseCategoryTableGateway
    {
        Task<IEnumerable<ExpenseCategoryDTO>> GetAllExpenseCategories();
        Task<int> InsertExpenseCategory(ExpenseCategoryDTO expenseCategoryDTO);
        Task DeleteExpenseCategory(int categoryId);
    }
}
