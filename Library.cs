using System;
using System.Collections.Generic;

class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(string title, string writer, int totalCopies)
    {
        Book newBook = new Book(title, writer, totalCopies);
        books.Add(newBook);
        Console.WriteLine("Kitap başarıyla eklendi.");
    }

    public void DisplayAllBooks()
    {
        Console.WriteLine("Kütüphanedeki Tüm Kitaplar:");
        foreach (var book in books)
        {
            Console.WriteLine($"Başlık: {book.Title}, Yazar: {book.Writer}, Toplam Kopya: {book.TotalCopies}, Kullanılabilir Kopya: {book.AvailableCopies}");
        }
    }

    public void SearchBook(string keyword)
    {
        Console.WriteLine($"Arama sonuçları ({keyword}):");
        foreach (var book in books)
        {
            if (book.Title.Contains(keyword) || book.Writer.Contains(keyword))
            {
                Console.WriteLine($"Başlık: {book.Title}, Yazar: {book.Writer}, Toplam Kopya: {book.TotalCopies}, Kullanılabilir Kopya: {book.AvailableCopies}");
            }
        }
    }

    public void BorrowBook(string title)
    {
        Book bookToBorrow = books.Find(b => b.Title == title);

        if (bookToBorrow != null && bookToBorrow.AvailableCopies > 0)
        {
            bookToBorrow.AvailableCopies--;
            bookToBorrow.DueDate = DateTime.Now.AddDays(2);
            Console.WriteLine($"{bookToBorrow.Title} başarıyla ödünç alındı. Lütfen {bookToBorrow.DueDate} tarihine kadar iade edin.");
        }
        else
        {
            Console.WriteLine("Kitap ödünç alınamıyor. Ya kitap bulunamadı ya da tüm kopyalar ödünç alınmış durumda.");
        }
    }

    public void ReturnBook(string title)
    {
        Book bookToReturn = books.Find(b => b.Title == title);

        if (bookToReturn != null)
        {
            bookToReturn.AvailableCopies++;
            Console.WriteLine($"{bookToReturn.Title} başarıyla iade edildi.");
        }
        else
        {
            Console.WriteLine("Kitap iade edilemedi. Belirtilen başlıkta bir kitap bulunamadı.");
        }
    }

    public void DisplayOverdueBooks()
    {
        Console.WriteLine("Süresi geçmiş kitaplar:");
        foreach (var book in books)
        {
            if (book.DueDate != DateTime.MinValue && book.DueDate < DateTime.Now)
            {
                Console.WriteLine($"Başlık: {book.Title}, Yazar: {book.Writer}, Ödünç Alma Tarihi: {book.DueDate}");
            }
        }
    }

}

