

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JazaniActividad.Infrastructure.Cores.Converters
{
    public class DateTimeToDateTimeOffset : ValueConverter<DateTime, DateTimeOffset>
    {

        public DateTimeToDateTimeOffset() : base
        (
            dateTime => DateTimeOffset.UtcNow,
            dateTimeOffset => dateTimeOffset.DateTime
        )
        { }
    }
}
