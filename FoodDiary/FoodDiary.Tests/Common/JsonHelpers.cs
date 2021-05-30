using System;
using System.Text.Json;

namespace FoodDiary.Tests.Common
{
    public static class JsonHelpers
    {
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        public static string ToJson(this object obj)
        {
            return JsonSerializer.Serialize(obj, Options);
        }

        public static T FromJson<T>(this string str)
        {
            return JsonSerializer.Deserialize<T>(str, Options);
        }

        public static object FromJson(this string str, Type type)
        {
            return JsonSerializer.Deserialize(str, type, Options);
        }

        public static T FromJson<T>(this JsonElement jsonElement)
        {
            return jsonElement.ToJson().FromJson<T>();
        }

        public static JsonElement ToJsonElement(this object obj)
        {
            if (obj == null)
                return ((object) null).ToJson().FromJson<JsonElement>();

            var str = obj.ToJson();
            return str.FromJson<JsonElement>();
        }
    }
}