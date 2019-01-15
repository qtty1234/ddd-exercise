﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MoneyTracker.Domain.AggregatesModel.AccountAggregate;
using MoneyTracker.Domain.Core;
using MoneyTracker.Domain.QueriesModel;

namespace MoneyTracker.Application
{
    public interface IAccountService
    {
        Task AddExpenseAsync(Guid accountId, string id, Money value, DateTime spentAt, ExpenseType expenseType);
        Task AddIncomeAsync(Guid accountId, Money value, DateTime receivedAt);
        Task<Guid> CreateAccountAsync();
        Task<IEnumerable<AccountDto>> GetAllAccountsAsync();
    }
}