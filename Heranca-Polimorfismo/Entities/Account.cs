namespace Heranca_Polimorfismo.Entities
{
    //class Account
        abstract class Account  //criando uma classe abstrata, para não poder ser estanciada para reuso ou polimorfismo
    {


        public int Number { get; private set; } //private deixando os arquivos como privado
        public string Holder { get; private set; }
        public double Balance { get; protected set; } //protected pode ser alterado pela classe ou pela subclasse

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) //pode ser subscrito virtual -> tornando ele disponível para as classes que herdam 
        {
            Balance -= amount + 5.0; //adicionando a taxa
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}