using System;
using System.Collections.Generic;
using System.Text;
using MBP.Entity;

namespace MBP.Data.Repository.Interfaces
{
    public interface IBlogTypeRepository : IRepository<BlogType>
    {
        BlogType GetByUrl(string url);
    }
}
