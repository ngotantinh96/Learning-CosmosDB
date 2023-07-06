using Newtonsoft.Json;

public class Person 
{
    [JsonProperty("id")]
    public string Id { get; set; }         
    public string LastName { get; set; }         
}