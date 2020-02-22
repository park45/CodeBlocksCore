using System;
using Microsoft.EntityFrameworkCore;

namespace CodeBlocksCore.Data
{
    public class Entities : DbContext
    {
        public Entities(DbContextOptions<Entities> options) : base(options)
        {
        }
    }
}
