namespace FR.Common.Ultilities
{
    public static partial class Ultilities
    {
        public static readonly TimeZoneInfo LOCAL_TIME_ZONE = TimeZoneInfo.Local;
        public static readonly TimeSpan BASE_UTC_OFFSET = LOCAL_TIME_ZONE.BaseUtcOffset;
        /// <summary>
        /// Gets the 12:00:00 instance of a DateTime
        /// </summary>
        public static DateTime AbsoluteStart(this DateTime dateTime)
        {
            dateTime = dateTime.Add(BASE_UTC_OFFSET).Date.Subtract(BASE_UTC_OFFSET);
            return dateTime;
        }

        /// <summary>
        /// Gets the 11:59:59 instance of a DateTime
        /// </summary>
        public static DateTime AbsoluteEnd(this DateTime dateTime)
        {
            dateTime = dateTime.Add(BASE_UTC_OFFSET).Date.AddDays(1).AddTicks(-1).Subtract(BASE_UTC_OFFSET);
            return dateTime;
        }
    }
}
