static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return balance switch {
            < 0 => 3.213F,
            >= 0 and < 1000 => 0.5F,
            >= 1000 and < 5000 => 1.621F,
            >= 5000 => 2.475F
        };
    }

    public static decimal Interest(decimal balance) => balance * ((decimal)InterestRate(balance) / 100m);

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        bool targetIsUnreachable = 
            balance <= 0 && 
            targetBalance > balance;
        
        if(targetIsUnreachable)
        {
            throw new InvalidOperationException(
                $"Target balance cannot be reached because the current balance does not progress toward the target. " +
                $"Current balance: {balance}, " +
                $"Target balance: {targetBalance}.");
        }
        
        int years = 0;
        decimal currentBalance = balance;
        
        while(currentBalance < targetBalance) 
        {
            currentBalance = AnnualBalanceUpdate(currentBalance);
            years++;
        }
        
        return years;
    }
}
