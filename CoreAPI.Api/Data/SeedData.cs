using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CoreAPI.Api.Models;

namespace CoreAPI.Api.Data
{
    public class SeedData
    {
        public static void Initialize(CoreAPIContext context)
        {
            if(!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product{
                        Name = "Ginger Root",
                        Price = 800m 
                    },
                    new Product {
                        Name = "Potato",
                        Price = 1000m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}