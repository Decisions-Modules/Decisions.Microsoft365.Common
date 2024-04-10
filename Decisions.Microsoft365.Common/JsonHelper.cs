using DecisionsFramework;
using Newtonsoft.Json;

namespace Decisions.Microsoft365.Common
{
    public static class JsonHelper<T>
    {
        public static T? JsonDeserialize(string content)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(content);
            }
            catch (Exception ex)
            {
                throw new LoggedException($"Could not deserialize result: {content}", ex);
            }
        }
    }
}