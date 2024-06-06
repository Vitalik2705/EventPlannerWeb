﻿using System.Text.Json.Serialization;

namespace EventPlannerWeb.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
        
        [JsonIgnore]
        public ICollection<Recipe>? Recipes { get; set; }

    }
}
