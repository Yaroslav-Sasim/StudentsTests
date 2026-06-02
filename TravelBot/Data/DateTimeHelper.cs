namespace TravelBot.Data;

public static class DateTimeHelper
{
    /// <summary>Дата тура для PostgreSQL timestamptz (только UTC).</summary>
    public static DateTime ToUtcDate(DateTime value) =>
        DateTime.SpecifyKind(value.Date, DateTimeKind.Utc);
}
