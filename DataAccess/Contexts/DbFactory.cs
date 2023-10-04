using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataAccess.Contexts{
    public class DbFactory : IDesignTimeDbContextFactory<Db>
    {
         public Db CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Db>();
            optionsBuilder.UseMySQL("server=127.0.0.1;database=test;user id=root;password=;");
            // First, create an object containing the connection string of your database
            // (it's more suitable to use the development database).

            return new Db(optionsBuilder.Options);
            // Then, return an object of type Db using the optionsBuilder object we created above.
        }
    }

}

