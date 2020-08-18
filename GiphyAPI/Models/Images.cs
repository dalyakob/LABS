using System.Text.Json.Serialization;

namespace GiphyAPI.Models
{
    public class Images
    {
        public Looping looping { get; set; }
        [JsonPropertyName("original_mp4")]
        public OriginalMp4 OriginalMp4 { get; set; }
    }

    public class OriginalMp4
    {
        public string mp4 { get; set; }
    }

    public class Looping
    {
        public string mp4 { get; set; }
    }
}