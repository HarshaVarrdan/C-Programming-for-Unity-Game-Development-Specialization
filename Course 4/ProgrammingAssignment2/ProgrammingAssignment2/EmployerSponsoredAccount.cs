using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// An employer-sponsored account
    /// </summary>
    class EmployerSponsoredAccount : MutualFund
    {
        #region Contructor
        public EmployerSponsoredAccount(float initialDeposit) : base(initialDeposit) 
        { 
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Provides balance with account type caption
        /// </summary>
        /// <returns>balance with caption</returns>

        public override void AddMoney(float amount)
        {
            if (amount > 0)
            {
                balance += (amount * 2) - ((amount*2) * 0.01f);
            }
        }
        
        public override void UpdateBalance()
        {
            balance += balance * 0.06f; // Assuming 6% growth similar to MutualFund
        }

        public override string ToString()
        {
            return "Employer-Sponsored Account Balance: " + balance;
        }


        #endregion
    }
}
