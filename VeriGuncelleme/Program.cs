NorthwindContext.NorthwindDbContext northwindDbContext = new();
TestDB.TestDbContext testDbContext = new();
//Context üzerinden geldiği için update fonksiyonunu çağırmaya gerek yok. SaveChanges ile update sorgusu oluşturulur.
var entity = testDbContext.Products.FirstOrDefault(op=>op.ID==1);
if (entity != null)
{
    var entry = testDbContext.Products.Entry(entity);
    entity.Name = "Güncellenen veri 1";
    entry = testDbContext.Products.Entry(entity);
}
//Context üzerinden gelmeyen veriler için update
TestDB.Product product = new TestDB.Product
{
    ID = 2,
    Name = "Güncellenen veri 2"
};
var result = testDbContext.Products.Update(product);

testDbContext.SaveChanges();
