class Reference
{
    private string Book;
    private int Chapter;
    private int Verse ;
    private int EndVerse;


    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verse = startVerse;
        EndVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (EndVerse == 0)
        {
            return $"{Book} {Chapter}:{Verse}";
        }
        else
        {
            return $"{Book} {Chapter}:{Verse} - {EndVerse}";
        }
    }
}
