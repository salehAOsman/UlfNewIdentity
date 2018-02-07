using System;

namespace UlfNewIdentity.Models
{
    internal class Car
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; } //1 --> * brand
    }
}