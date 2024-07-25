// See https://aka.ms/new-console-template for more information
namespace keyword{
    public class Book{
        public string title { get; set; }
        public string author { get; set; }
        public Book(string title, string author){
            Title = title;
            Author = author;
        }

        public class library{
            private List<Book> books = new List<Book>();

            public Book this[int index]{
                get{
                    if(index >=0 &&indexn< books count);
                    {
                        return books[index];
                    }
                }

            }
            class AdvanceIndexers{

            }
        }
    }
}