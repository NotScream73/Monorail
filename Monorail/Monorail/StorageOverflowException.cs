using System.Runtime.Serialization;

namespace Monorail
{
    [Serializable]
    internal class StorageOverflowException : ApplicationException
    {
        public StorageOverflowException(int count) : base($"В наборе превышено допустимое количество: {count}") { }
        public StorageOverflowException() : base() { }
        public StorageOverflowException(string message) : base(message) { }
        public StorageOverflowException(string message, Exception exception) : base(message, exception) { }
        protected StorageOverflowException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }
    }
}