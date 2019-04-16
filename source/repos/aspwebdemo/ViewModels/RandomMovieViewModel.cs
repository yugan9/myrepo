using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using aspwebdemo.Models;

namespace aspwebdemo.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movies movies { get; set; }
        public List<Customer> Customers { get; set; }
    }
}