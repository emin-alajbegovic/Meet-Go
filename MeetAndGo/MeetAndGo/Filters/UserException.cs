using System;

namespace MeetAndGo.Filters
{
    public class UserException : Exception
    {
        public UserException(string message) : base(message) { }
    }
}
