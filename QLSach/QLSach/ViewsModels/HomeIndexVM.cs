using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QLSach.Models;

namespace QLSach.ViewsModels
{
    public class HomeIndexVM
    {

        public List<Books> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
