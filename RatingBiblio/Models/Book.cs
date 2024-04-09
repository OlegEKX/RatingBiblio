using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RatingBiblio.Models
{
    public class Book
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }


        [Display(Name = "Last Issue Date")]
        [DataType(DataType.Date)] // атрибут предствляет  дату
        public DateTime LastIssueDate { get; set; }


        [Display(Name = "Issued To")]
        public string IssuedTo { get; set; }

        [Display(Name = "Is In Library")]
        public bool IsInLibrary { get; set; }

        /*public Book(int id, string title, string author, DateTime lastIssueDate, string issuedTo, bool IsInLibrary)
        {
            Id = id;
            Title = title;
            Author = author; 
            LastIssueDate = lastIssueDate;
            IssuedTo = issuedTo;

        }*/
    }
}
