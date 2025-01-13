using Newtonsoft.Json;
using System.Globalization;

namespace SalesRepo.utils
{
    public class CustomDateTimeConverter : JsonConverter<DateTime?>
    {
        private const string DateTimeFormat = "dd/MM/yyyy HH:mm:ss";

        public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
        {
            writer.WriteValue(value?.ToString(DateTimeFormat));
        }

        public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            if (reader.TokenType == JsonToken.String)
            {
                string dateStr = (string)reader.Value;
                if (DateTime.TryParseExact(dateStr, DateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                {
                    return date;
                }
            }

            throw new JsonSerializationException($"Invalid date format: {reader.Value}");
        }
    }
}
