using System.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore;
using Microsoft.SqlServer;
using System.Data.SqlClient;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MVC_Working_With_Model_Product_Opereations.Models;


namespace MVC_Working_With_Model_Product_Opereations.Models
{
    public class Product
    {
        [Key]
        [DisplayName("Product Id")]
        public int ProductId { get; set; }



        [DisplayName("Product name")]
        //[Required]
        [DataType(DataType.Text)]
        [MaxLength(10)]
        [MinLength(1)]
        [Required(ErrorMessage = "Name is Required")]
        public string ProductName { get; set; }



        [Required]
        [DisplayName("Product Catagory")]
        public string ProductCatagory { get; set; }
    }
}
