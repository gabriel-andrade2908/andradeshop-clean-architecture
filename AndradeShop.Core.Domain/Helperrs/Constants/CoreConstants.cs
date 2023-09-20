namespace AndradeShop.Core.Domain.Helperrs.Constants
{
    public static class CoreConstants
    {
        public const int MIN_LEN = 2;
        public const int MAX_LEN = 150;
        public readonly static DateTime CURRENT_DATE = DateTime.UtcNow;
        public readonly static DateTime MIN_BIRTH_DATE = new(1900, 01, 01, 0, 0, 0, DateTimeKind.Utc);
    }
}
