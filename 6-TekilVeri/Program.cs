NorthwindContext.NorthwindDbContext northwindDbContext = new();
TestDB.TestDbContext testDbContext = new();

// single-> Sorgu sonucunda birden fazla veri geliyorsa veya hiç veri gelmiyorsa exception fırlatır
// singleordefault-> Sorgu sonucunda birden fazla veri geliyorsa exception fırlatır hiç veri gelmiyorsa null döner

//single hata fırlatır
//var result = northwindDbContext.Products.Single(op => op.ProductId > 50);
//var result = northwindDbContext.Products.Single(op => op.ProductId == 10000);

//single çalışır
var result = northwindDbContext.Products.Single(op=>op.ProductId == 1);

//singleordefault hata fırlatır
//var result2 = northwindDbContext.Products.SingleOrDefault(op => op.ProductId > 50);

//singleordefault çalışır
var result2 = northwindDbContext.Products.SingleOrDefault(op => op.ProductId == 10000);
var result3 = northwindDbContext.Products.SingleOrDefault(op => op.ProductId == 1);

// first-> Gelen verilerin ilkini getirir. Veri gelmiyorsa exception fırlatır
// firstordefault-> Gelen verilerin ilkini getirir. Veri gelmiyorsa null döner.

// first hata fırlatır
// var result4 = northwindDbContext.Products.First(op => op.ProductId > 10000);

// first çalışır
var result4 = northwindDbContext.Products.First(op => op.ProductId > 40);

// firstordefault çalışır
var result5 = northwindDbContext.Products.FirstOrDefault(op => op.ProductId > 10000);

// find->primary key kolonuna özel sorgulama yapmamızı sağlar
var result6 = northwindDbContext.Products.Find(40);

// last-> gelen verilerden sonuncusunu alır. Orderby kullanılması gerekir. Veri gelmiyorsa exception fırlatır.
// lastordefault-> gelen verilerden sonuncusunu alır. Orderby kullanılması gerekir. Veri gelmiyorsa null döner.

// last hata fırlatır
//var result7 = northwindDbContext.Products.OrderBy(op => op.ProductId).Last(p => p.ProductId > 10000);
var result7 = northwindDbContext.Products.OrderBy(op => op.ProductId).Last(p => p.ProductId > 100);

// lastordefault çalışır
var result8 = northwindDbContext.Products.OrderBy(op => op.ProductId).LastOrDefault(p=>p.ProductId>10000);