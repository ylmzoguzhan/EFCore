NorthwindContext.NorthwindDbContext northwindDbContext = new();
TestDB.TestDbContext testDbContext = new();

//Takip edilen nesneler için
var entity = testDbContext.Products.FirstOrDefault(op => op.ID == 2);
var result = testDbContext.Products.Remove(entity);

//Takip edilmeyen nesneler için 
TestDB.Customer customer = new()
{
     ID = 1
};
//var entry = testDbContext.Customers.Entry(customer);
//entry.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
testDbContext.Customers.Remove(customer);
testDbContext.SaveChanges();