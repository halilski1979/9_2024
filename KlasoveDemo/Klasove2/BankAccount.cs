using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasove2
{
    public class BankAccount
    {
		private int id;
		private double balsnce;
		//Метод за зареждане на банкова сметка
		public void Deposit(double amount)
		{
			balsnce += amount;
		}
		public void Withdraw(double amount)
		{
			balsnce -= amount;
		}

        public double Balance
		{
			get { return balsnce; }
			set { balsnce = value; }
		}
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
        public override string ToString()
        {
            return $"Account ID {this.Id}, balance {this.balsnce:f2}";
        }

    }
}
