NorthwindContext.NorthwindDbContext northwindDbContext = new();
TestDB.TestDbContext testDbContext = new();

//Method Syntax
var result = northwindDbContext.Products.ToList();

//Query Syntax
var result2 = (from product in northwindDbContext.Products
               select product).ToList();

// foreach ile IQueryable çalıştırılabilir.
var result3 = (from product in northwindDbContext.Products
               select product);
foreach (var item in result3)
{
    Console.WriteLine(item);
}

//Ertelenmiş çalışma deferred execution
// Sorgu çalışana kadar parametreler değiştirilebilir
int id = 10;
var products = (from product in northwindDbContext.Products
                where product.ProductId > id
                select product);
id = 30;
Console.WriteLine(products);
foreach (var item in products)
{
    Console.WriteLine(item.ProductId);
}

#region IQueryable ve IEnumerable
//IQueryable ef core üzerinden yapılmış sorgunun execute edilmemiş hali
//IEnumerable Sorgunun execute edilip verilerin in memorye yüklenmiş hali
#endregion