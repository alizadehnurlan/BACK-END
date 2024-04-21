namespace Library.Classes
{
    public class Books : AllMaterial
    {
        public override void BookList()
        {
            base.BookList();
        }
        public override void AddBookList(string newBook)
        {
            base.AddBookList(newBook);
        }
        public override void DeleteBookList(string removeBook)
        {
            base.DeleteBookList(removeBook);
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }



    }
}
