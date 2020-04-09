using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace emarket.Models
{
       [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {

    }

    public class ProductMetadata
    {

        // [Display(Name = "ID")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Please enter ID")]
        //public int Id { get; set; }


        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Name")]
        public string Name { get; set; }

        [Display(Name = "Price")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Price")]
        public double Price { get; set; }


        [Display(Name = "Image")]
        public byte[] Image { get; set; }

        [Display(Name = "Description")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Descripyion")]
        public string Description { get; set; }


        [Display(Name = "Category_Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Category_Id")]
        public int Category_Id { get; set; }


    }

}
}