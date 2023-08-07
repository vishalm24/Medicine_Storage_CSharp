using System.Runtime.Serialization;

namespace Medicine_Storage
{
    [Serializable]
    internal class NoMedicineFoundException : Exception
    {
        public NoMedicineFoundException()
        {
        }

        public NoMedicineFoundException(string? message) : base(message)
        {
        }

        public NoMedicineFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoMedicineFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}