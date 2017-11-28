using System;
using System.Collections.Generic;
using System.Text;
using MBP.Entity;

namespace MBP.Data.Repository.Interfaces
{
    public interface IBlogCatagoryRepository : IRepository<BlogCatagory>
    {
        BlogCatagory GetBuyUrl(string url);
    }
}
