using System.Runtime.Serialization;

namespace Monorail
{
    [Serializable]
    internal class LocomotiveNotFoundException : ApplicationException
    {
        public LocomotiveNotFoundException(int i) : base($"Не найден объект по позиции {i}") { }
        public LocomotiveNotFoundException() : base() { }
        public LocomotiveNotFoundException(string message) : base(message) { }
        public LocomotiveNotFoundException(string message, Exception exception) : base(message, exception) { }
        protected LocomotiveNotFoundException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }
    }
}
