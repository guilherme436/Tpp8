﻿using Tpp8.Data.models;

namespace Tp11.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountryId { get; set; }

        public List<Property> Properties { get; set; }

        public Country Country { get; set; }
    }
}