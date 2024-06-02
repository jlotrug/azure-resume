using Newtonsoft.Json;

namespace Company.Function 
{
    public class Counter
    {
        // Makes sure names match what's in our container in Cosmos DB
        [JsonProperty(PropertyName ="id")]
        public string Id {get; set;}

        [JsonProperty(PropertyName ="count")]
        public int Count {get; set;}
    }

}