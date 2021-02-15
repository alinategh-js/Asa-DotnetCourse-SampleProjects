using ASa.ApartmentManagement.Core.BaseInfo.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASa.ApartmentManagement.Core.BaseInfo.DataGateways
{
    public interface IExpenseTableGateway
    {
        Task<IEnumerable<ExpenseDTO>> GetAllExpensesAsync();
        Task<int> InsertExpense(ExpenseDTO expenseDto);
        Task DeleteExpenseForUnit(int unitId);
    }
}