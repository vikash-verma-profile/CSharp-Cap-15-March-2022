using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   
    class PhotoBook
    {
        protected int numpages;

        public PhotoBook()
        {
            numpages = 16;
        }
        public PhotoBook(int _numpages)
        {
            numpages = _numpages;
        }
        public int GetNumPages()
        {
            return numpages;
        }
    }
    class BigPhotoBook:PhotoBook
    {
        public BigPhotoBook()
        {
            numpages = 64;
        }
    }
    internal class Class6
    {
        public static void Main7()
        {
            PhotoBook book = new PhotoBook();
            Console.WriteLine(book.GetNumPages());

            PhotoBook book2 = new PhotoBook(24);
            Console.WriteLine(book2.GetNumPages());

            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            Console.WriteLine(bigPhotoBook.GetNumPages());

        }
    }
}
