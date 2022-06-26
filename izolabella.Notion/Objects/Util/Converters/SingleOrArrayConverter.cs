using Newtonsoft.Json.Linq;

namespace izolabella.Notion.Objects.Util.Converters
{
    public class SingleOrArrayConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<T>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);

            return token.Type == JTokenType.Array ? token.ToObject<T[]>() : (object)(new T[] { token.ToObject<T>() });
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            List<T> list = (List<T>)value;

            if (list.Count == 1)
            {
                value = list[0];
            }

            serializer.Serialize(writer, value);
        }

        public override bool CanWrite => true;
    }
}
