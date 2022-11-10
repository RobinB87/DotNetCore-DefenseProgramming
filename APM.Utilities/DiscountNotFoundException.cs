using System;
using System.Runtime.Serialization;

namespace APM.Utilities
{
    [Serializable]
    public class DiscountNotFoundException : Exception
    {
        // use at least two constructors
        // in both cases, simply call the base constructor
        public DiscountNotFoundException() 
            : base() { }
        public DiscountNotFoundException(string message) 
            : base(message) { }

        // if you want the exception to be full featured, add another constructor
        // which takes the error message and the inner exception
        public DiscountNotFoundException(string message, Exception inner) 
            : base(message, inner) { }

        // make the exception serializable by adding another PROTECTED constructor
        // also add the Serializable attribute to the class 
        protected DiscountNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}