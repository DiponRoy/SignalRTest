using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Ccs.Web
{
    public class ResponseSerializerConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            JsonResponse(configuration);
            XmlResponse(configuration);
        }

        private static void XmlResponse(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }

        private static void JsonResponse(HttpConfiguration config)
        {
            config.Formatters.JsonFormatter.SerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore, //ReferenceLoopHandling.Serialize,
                NullValueHandling = NullValueHandling.Include,
                Formatting = Formatting.Indented,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                DateFormatHandling = DateFormatHandling.IsoDateFormat
            };

        }
    }
}