using System.Data.Entity;

namespace productoBack.Models
{
    public class DataContext1:DbContext
    {
        public DataContext1():base("DefaultConnection")
        {

        }    
    }
}