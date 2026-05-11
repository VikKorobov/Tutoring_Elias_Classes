public interface ISavingAccount: IAccount
{
    
    double InterestRate{get; set;}

    void ApplyInterest();

    void ApplyInterest(int months);
}