using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Day12_13Assignment 
{
    class Toy_Customer_Context : DbContext
    {
        public Toy_Customer_Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server=LAPTOP-3P2R1D3J\SQLEXPRESS;Database=Toy_Customer_DB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Toy> Toys { set; get; }
        public DbSet<Customer> Customers { set; get; }
        public DbSet<CustomerAddress> CustomerAddresses { set; get; }
        public DbSet<Cart> Carts { set; get; }
        public DbSet<Order> Orders { set; get; }

    }

    class Toy
    {
        public int ToyId { set; get; }
        public string ToyType { set; get; }
        public int ToyPayPrice { set; get; }
        public Cart cart { set; get; }
    }
    class Customer
    {
        public int CustomerId { set; get; }
        public string CustomerName { set; get; }
        public ICollection<CustomerAddress> customeraddress { set; get; }
        public ICollection<Order> orders { set; get; }
        public Cart cart { set; get; }
    }

    class CustomerAddress
    {
        public int CustomerAddressId { set; get; }
        public int CustomerId { set; get; }
        public Customer customer { set; get; }
        public string AddressLine { set; get; }
        public string City { set; get; }
        public string District { set; get; }
        public string State { set; get; }

        public ICollection<Order> orders { set; get; }
    }

    class Cart
    {
        public int CartId { set; get; }
        public int CustomerId { set; get; }
        public Customer customer { set; get; }
        public int ToyId { set; get; }
        public Toy toy { set; get; }
        public int ToyCount { set; get; }
        public int ToyCartPrice { set; get; }
    }

    class Order
    {
        public int OrderId { set; get; }
        public int CustomerId { set; get; }
        public Customer customer { set; get; }
        public int CustomerAddressId { set; get; }
        public CustomerAddress customerAddress { set; get; }
        public int FinalDiscount { set; get; }
        public int ToyFinalPrice { set; get; }

    }


}
