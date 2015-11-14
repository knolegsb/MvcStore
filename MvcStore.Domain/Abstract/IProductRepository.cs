using MvcStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Products> Products { get; set; }
    }
}
