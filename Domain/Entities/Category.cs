using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class Category : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public List<Transaction> Transactions { get; set; }
            = new List<Transaction>();
    }
}
