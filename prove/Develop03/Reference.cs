using Newtonsoft.Json;

public class Reference
{
    [JsonProperty("scripture")]
    public string Scripture { get; set; }

    [JsonProperty("book")]
    public string Book { get; set; }

    [JsonProperty("chapter")]
    public string Chapter { get; set; }

    [JsonProperty("verse")]
    public string Verse { get; set; }
}