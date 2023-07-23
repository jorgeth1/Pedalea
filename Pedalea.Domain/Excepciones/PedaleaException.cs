namespace FantasyEventRoom.Dominio
{
    public class PedaleaException : System.Exception
    {
        public PedaleaException() { }
        public PedaleaException(string message) : base(message) { }
        public PedaleaException(string message, System.Exception inner) : base(message, inner) { }
        protected PedaleaException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
