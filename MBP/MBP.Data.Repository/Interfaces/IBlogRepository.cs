using System;
using System.Collections.Generic;
using System.Text;
using MBP.Entity;

namespace MBP.Data.Repository.Interfaces
{
    public interface IBlogRepository : IRepository<Blog>
    {
        Blog GetBuyUrl(string url);
    }
}
