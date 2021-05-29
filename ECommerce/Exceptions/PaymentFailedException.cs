using System;


namespace Ecommerce.Exceptions {
   
public class PaymentFailedException : Exception {
        public PaymentFailedException() {
        }

        public PaymentFailedException(string message)
            : base(message) {
        }

        public PaymentFailedException(string message, Exception inner)
            : base(message, inner) {
        }
    }
}

