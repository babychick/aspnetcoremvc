using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class Transaction : IEntity
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Type { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
