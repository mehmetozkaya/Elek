using System.ComponentModel.DataAnnotations;

namespace Elek.Data
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
    }
}