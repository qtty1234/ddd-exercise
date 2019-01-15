﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoneyTracker.Domain.AggregatesModel.AccountAggregate;
using MoneyTracker.Domain.Core;
using MoneyTracker.Domain.QueriesModel;

namespace MoneyTracker.Application
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;
        private readonly IAccountProvider accountProvider;

        public AccountService(IAccountRepository accountRepository, IAccountProvider accountProvider)
        {
            this.accountRepository = accountRepository;
            this.accountProvider = accountProvider;
        }

        public async Task AddExpenseAsync(Guid accountId,
            string id,
            Money value,
            DateTime spentAt,
            ExpenseType expenseType)
        {
            var account = accountRepository.GetById(accountId);
            account.AddExpense(new Expense(id, value, spentAt, expenseType));
            await accountRepository.UnitOfWork.CommitAsync();
        }

        public async Task AddIncomeAsync(
            Guid accountId,
            Money value,
            DateTime receivedAt)
        {
            var account = accountRepository.GetById(accountId);
            account.AddIncome(new Income(value, receivedAt));
            await accountRepository.UnitOfWork.CommitAsync();
        }

        public async Task<Guid> CreateAccountAsync()
        {
            var accountNumber = Guid.NewGuid();
            var account = new Account(accountNumber, Enumerable.Empty<Expense>(), Enumerable.Empty<Income>());

            accountRepository.Add(account);
            await accountRepository.UnitOfWork.CommitAsync();

            return accountNumber;
        }

        public async Task<IEnumerable<AccountDto>> GetAllAccountsAsync()
        {
            return await accountProvider.GetAllAsync();
        }
    }
}