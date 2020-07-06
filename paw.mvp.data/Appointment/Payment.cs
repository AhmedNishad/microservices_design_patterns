using paw.mvp.data.Base;
using paw.mvp.data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paw.mvp.data.Appointment
{
    public class Payment
    {
        public bool IsComplete { get; private set; }
        public Price SubTotal{ get; set; }
        public Price SalesTax { get; set; }
        public Price InvoiceAmount { get; set; }
        public Price PriorPayments { get; set; }
        public Price Balance { get; set; }
        public PaymentMethod Method { get; set; }
        public Payment(Price subTotal, Price salesTax, Price priorPayments, PaymentMethod method )
        {
            // Ensure all same currency
            if(subTotal.Currency != salesTax.Currency || subTotal.Currency != priorPayments.Currency)
            {
                throw new InvalidOperationException("Payment Amounts need to be of the same currency");
            }

            SubTotal = subTotal;
            SalesTax = salesTax;
            InvoiceAmount = new Price { Currency = SubTotal.Currency, Value = SubTotal.Value + SalesTax.Value };
            PriorPayments = priorPayments;

            Balance = new Price { Currency = SubTotal.Currency, Value = InvoiceAmount.Value - PriorPayments.Value };

            Method = method;
            IsComplete = false;
        }

        public Payment Complete()
        {
            IsComplete = true;
            return this;
        }
    }

    public class PaymentMethod: Enumeration
    {
        public static PaymentMethod Cash = new PaymentMethod(1, "Cash");
        public static PaymentMethod BankTransfer = new PaymentMethod(2, "BankTransfer");
        public PaymentMethod(int id, string name) : base(id, name)
        {

        }
    }
}
