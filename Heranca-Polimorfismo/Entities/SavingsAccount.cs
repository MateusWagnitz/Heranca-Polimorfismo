namespace Heranca_Polimorfismo.Entities
{
    //sealed class SavingsAccount : Account   //sealed para selar a classe, não permitindo ser herdada
     class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //public override void Withdraw(double amount)       //Sobrescrevendo o Withdraw para ficar disponivel, herdado de Account porém com outra regra (sem a taxa de 5.0)
        //{
        //    Balance -= amount;
        //}

        //public override void Withdraw(double amount)       //Sobrescrevendo o Withdraw para ficar disponivel, herdado de Account porém
                                                             //descontando além dos 5.0 da taxa padrão .base mais 2.0
         public sealed override void Withdraw(double amount)  //criando uma classe selada, pode ser usada em outros métodos, 
                                                              //porém não pode ser reescrita
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }

    }
}