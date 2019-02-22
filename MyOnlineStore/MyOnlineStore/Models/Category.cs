using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyOnlineStore.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="The category name cannot be blank")]
        [StringLength(50,MinimumLength =3,ErrorMessage="Please enter a category name between 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-z''-'\s]*$",ErrorMessage ="Please enter a category name begining with a capital letter and made up of letters and spaces only")]
        [Display(Name= "Category Name")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}