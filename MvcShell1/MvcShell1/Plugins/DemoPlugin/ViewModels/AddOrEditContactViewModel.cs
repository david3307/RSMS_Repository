using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoPlugin.Models;

namespace DemoPlugin.ViewModels
{
    public class AddOrEditContactViewModel
    {
        public int CurrentPageNum { get; set; }
        public int PageSize { get; set; }
        public bool Added { get; set; }
        public Contact Contact { get; set; }
    }
}