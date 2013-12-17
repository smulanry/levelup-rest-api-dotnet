using System;

namespace LevelUpRestApi
{
    [Serializable()]
    public class LevelUpApiException : Exception
    {
        public LevelUpApiException() : base() { }
        public LevelUpApiException(string message) : base(message) { }
        public LevelUpApiException(string message, Exception inner) : base(message, inner) { }
    }
}
