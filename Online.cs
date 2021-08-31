using System;

namespace pt78
{
    class Online : Transaction
    {
        //*Fields
        /// <summary>
        /// payment type a private field
        /// </summary>
        private  PaymentType _paymentType;

        public enum PaymentType
        {
            CreditCard,
            Paypal
        }

        //*Property

        //*Method
        /// <summary>
        /// This should print
        /// </summary>
        public void print(){

        }
    }
}