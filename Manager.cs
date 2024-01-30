using System;

class Manager
{
    static void Main()
    {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("\nKütüphane");
            Console.WriteLine("1. Yeni Kitap Ekle");
            Console.WriteLine("2. Tüm Kitapları Görüntüle");
            Console.WriteLine("3. Kitap Ara");
            Console.WriteLine("4. Kitap Ödünç Al");
            Console.WriteLine("5. Kitap İade Et");
            Console.WriteLine("6. Süresi Geçmiş Kitapları Görüntüle");
            Console.WriteLine("0. Çıkış");

            Console.Write("Seçiminizi yapınız: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Kitap Başlığı: ");
                    string title = Console.ReadLine();
                    Console.Write("Yazar: ");
                    string writer = Console.ReadLine();
                    Console.Write("Toplam Kopya Sayısı: ");
                    int totalCopies = int.Parse(Console.ReadLine());
                    library.AddBook(title,writer,totalCopies);
                    break;

                case "2":
                    library.DisplayAllBooks();
                    break;

                case "3":
                    Console.Write("Arama Kelimesi: ");
                    string keyword = Console.ReadLine();
                    library.SearchBook(keyword);
                    break;

                case "4":
                    Console.Write("Ödünç Alınacak Kitap Başlığı: ");
                    string borrowTitle = Console.ReadLine();
                    library.BorrowBook(borrowTitle);
                    break;

                case "5":
                    Console.Write("İade Edilecek Kitap Başlığı: ");
                    string returnTitle = Console.ReadLine();
                    library.ReturnBook(returnTitle);
                    break;

                case "6":
                    Console.Write("Süresi Geçmiş Kitaplar Hakkında Bilgiler: ");
                    library.DisplayOverdueBooks();
                    break;

                case "0":
                    Console.WriteLine("Programdan çıkılıyor");
                    return;

                default:
                    Console.WriteLine("Geçersiz seçim. Tekrar deneyin.");
                    break;
            }
        }
    }
}