System.Console.WriteLine("");
var album1 = new PhotoBook();
var album2 = new PhotoBook(24);
var album3 = new BigPhotoBook();

System.Console.WriteLine($"First Album have {album1.GetNumberPages()} pages.");
System.Console.WriteLine($"Second Album have {album2.GetNumberPages()} pages.");
System.Console.WriteLine($"Third Album have {album3.GetNumberPages()} pages.");

