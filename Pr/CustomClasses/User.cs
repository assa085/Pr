using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Perforator.CustomClasses
{
    public class User
    {
        [Required]
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [Required]
        [JsonPropertyName("Password")]
        public string Password { get; set; }
    }
}
