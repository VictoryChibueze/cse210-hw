class Scripture
{
    private Reference _reference;
    List<Word> _words = new List<Word>();

    public Scripture(Reference Reference,String text)
    {
        Reference = _reference;
        text = _words.ToString(); 

    }
    
    public void HideRandomWords(int numberToHide)
    { 
        Random random = new Random();
        int index1 = random.Next(_words.Count);
        int index2 = random.Next(_words.Count);

        do
        {
            _words[index1].Hide();
            _words[index2].Hide();
        }while(index1 !=index2);


    }

    public void GetDisplayText()
    {
        Console.Clear();
        Console.WriteLine($"{_reference.GetDisplayText()}\n");

        foreach(Word w in _words)
        {
            Console.WriteLine(w.GetDisplayText()+ " ");
        }
        Console.WriteLine("\n");


    }

    public bool isCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.isHidden())
            {
                return false;
            }
            
        }
        return true;
    }

}
