using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WpfMultipleViews
{

    public class TestTemp
    {
        [JsonPropertyName("temp")] 
        public double Temperature { get; set; }

        [JsonPropertyName("dwell")]
        public int Dwell { get; set; }
    }

    public class Profile
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("voltage")]
        public double Voltage { get; set; }

        [JsonPropertyName("channel")]
        public int Channel { get; set; }

        [JsonPropertyName("temperatures")]
        public List<TestTemp> Temperatures { get; set; }

    }

    public class ProfileReader
    {
        public IEnumerable<Profile> GetProfiles()
        {
            using (var jsonFileReader = File.OpenText(@"d:\\profiles.json"))
            {

                var data = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<Profile[]>(data,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

    }
}
