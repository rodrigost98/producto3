using System.Data.Entity;

namespace productoAPI.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }
    }
}