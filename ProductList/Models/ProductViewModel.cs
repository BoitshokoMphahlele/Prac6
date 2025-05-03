using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductList.Models
    {
    public class ProductViewModel
        {
        [Display(Name = "Fisrt Name")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        public int SelectedCategoryId { get; set; }
        public int SelectedProductId { get; set; }
        public int SelectedSupplierId {  get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        }
    }