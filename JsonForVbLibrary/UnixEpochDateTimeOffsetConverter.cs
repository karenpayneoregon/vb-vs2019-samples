using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JsonForVbLibrary
{
    /// <summary>
    /// Used for deserializing json with Microsoft date time format.
    /// </summary>
    /// <remarks>
    /// This class was code by Microsoft
    /// https://docs.microsoft.com/en-us/dotnet/standard/datetime/system-text-json-support
    ///
    /// Karen Payne took advantage of current C# features
    /// </remarks>
    public sealed class UnixEpochDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        static readonly DateTimeOffset epochDateTime = new(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);
        static readonly Regex regex = new("^/Date\\(([^+-]+)([+-])(\\d{2})(\\d{2})\\)/$", RegexOptions.CultureInvariant);

        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {

            string formatted = reader.GetString();
            Match match = regex.Match(formatted);

            if ( !match.Success
                || !long.TryParse(match.Groups[1].Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out long unixTime)
                || !int.TryParse(match.Groups[3].Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out int hours)
                || !int.TryParse(match.Groups[4].Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out int minutes))
            {
                throw new JsonException();
            }

            int sign = match.Groups[2].Value[0] == '+' ? 1 : -1;
            TimeSpan utcOffset = new TimeSpan(hours * sign, minutes * sign, 0);

            return epochDateTime.AddMilliseconds(unixTime).ToOffset(utcOffset);
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            long unixTime = Convert.ToInt64((value - epochDateTime).TotalMilliseconds);
            TimeSpan utcOffset = value.Offset;

            var formatted = FormattableString
                .Invariant($"/Date({unixTime}{(utcOffset >= TimeSpan.Zero ? "+" : "-")}{utcOffset:hhmm})/");
            
            writer.WriteStringValue(formatted);
        }
    }
}
