using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SOLID_Demo
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AffiliateLevel
    {
        Basic = 0,
        Silver = 1,
        Gold = 2
    }
}
