using System.Text.Json.Serialization;

namespace WEB_API.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))] //Change number values to string in swagger
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3
    }
}