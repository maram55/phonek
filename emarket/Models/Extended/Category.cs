using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace emarket.Models
{
    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    {
    }

    public class CategoryMetadata
    {
         [Display(Name = "id")]
         [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Id")]
        public int Id { get; set; }


        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Name")]
        public string Name { get; set; }



        [Display(Name = "Number of product")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Number of prod")]
        public int No_Of_Product { get; set; }


    }
}