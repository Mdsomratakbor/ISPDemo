using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface ILibraryItem
    {
       string LibraryID { get; set; } 
        string Title { get; set; }
       // string Author { get; set; }
       // DateTime BorrowDate { get; set; }
       // string Borrower { get; set; }
       // int CheckOutDurationInDays { get; set; }
        //int Pages { get; set; }
       
       // void CheckIn();
       // void CheckOut(string borrower);
       // DateTime GetDueDate();
    }
}
