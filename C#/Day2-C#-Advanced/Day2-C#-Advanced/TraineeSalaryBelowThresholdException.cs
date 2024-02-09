using System;
using System.Runtime.Serialization;

namespace Day2_C__Advanced
{
    [Serializable]
    internal class TraineeSalaryBelowThresholdException : Exception
    {
        public TraineeSalaryBelowThresholdException()
        {
        }

        public TraineeSalaryBelowThresholdException(string message) : base(message)
        {
        }

        public TraineeSalaryBelowThresholdException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TraineeSalaryBelowThresholdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}