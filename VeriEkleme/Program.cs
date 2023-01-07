NorthwindContext.NorthwindDbContext northwindDbContext = new();
TestDB.TestDbContext testDbContext = new();

TestDB.Product testProduct = new()
{
    Name = "ürün",
    Quantity = 5,
    Price = 100
};
TestDB.Product kalem = new()
{
    Name = "kalem1",
    Quantity = 5,
    Price = 100
};
TestDB.Product kalem2 = new()
{
    Name = "kalem2",
    Quantity = 5,
    Price = 100
};
var entry = testDbContext.Entry(testProduct);

var result = testDbContext.Products.Add(testProduct); //Tip Güvenli
//var result2 = testDbContext.Add(testProduct); parametre obje

testDbContext.Products.AddRange(kalem, kalem2);

var result2 = testDbContext.SaveChanges(); //sorguları oluştuurp transaction ile veritabanına gönderip execute eder.
