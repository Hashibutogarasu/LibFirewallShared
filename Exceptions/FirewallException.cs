using System;

namespace LibFirewall.Shared.Exceptions
{
    public class FirewallException : Exception
    {
        public FirewallException(string message) : base(message) { }
        public FirewallException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class FirewallOperationException : FirewallException
    {
        public string Operation { get; }

        public FirewallOperationException(string operation, string message)
            : base($"Failed to perform {operation}: {message}")
        {
            Operation = operation;
        }

        public FirewallOperationException(string operation, string message, Exception innerException)
            : base($"Failed to perform {operation}: {message}", innerException)
        {
            Operation = operation;
        }
    }
}
