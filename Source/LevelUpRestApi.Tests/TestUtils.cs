namespace LevelUpRestApi.Tests
{
    /// <summary>
    /// Utilities used by various test cases
    /// </summary>
    public static class TestUtils
    {
        public static LevelUpAuthorizationToken CreateValidAuthorizationToken()
        {
            return new LevelUpAuthorizationToken(null, null);
        }
    }
}
