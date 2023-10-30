using System.ComponentModel.DataAnnotations;

namespace Dedea_Alexandra_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string AuthorFirstName { get; set; }

        public string AuthorLastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return AuthorFirstName + " " + AuthorLastName;
            }
        }
        public ICollection<Book>? Books { get; set; }
    }
}
