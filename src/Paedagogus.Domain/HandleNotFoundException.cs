namespace Paedagogus.Domain
{
    using System;

    public class HandleNotFoundException : Exception
    {
        public HandleNotFoundException(string message) : base(message)
        {

        }
    }
}