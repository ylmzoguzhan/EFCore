NorthwindContext.NorthwindDbContext northwindDbContext = new();
TestDB.TestDbContext testDbContext = new();

// tolist üretilen sorguyu execute etmek için kullanıla fonkisyon
var result = northwindDbContext.Products.ToList();

var result2 = (from p in northwindDbContext.Products
               select p).ToList();

// where oluşturulan sorguya where şartı sağlamamızı sağlar.
var result3 = northwindDbContext.Products.Where(op => op.ProductId > 10).ToList();

var result4 = (from p in northwindDbContext.Products
               where p.ProductId > 10 && p.ProductId < 20
               select p).ToList();

// orderby sorgu üzerinde sıralama yapmamızı sağlar
var result5 = northwindDbContext.Products.Where(p => p.ProductId > 10).ToList().OrderBy(p=>p.ProductName);

var result6 = (from p in northwindDbContext.Products
               where p.ProductId > 10
               orderby p.ProductName
               select p).ToList();

// thenby orderby üzerinden yapılan sıralama işlemini farklı kolonlarda uygulamamızı sağlar
var result7 = northwindDbContext.Products.Where(p => p.ProductId > 10).ToList().OrderBy(p => p.ProductName).ThenBy(p => p.UnitPrice);
