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

    }

    public string GetDisplayText()
    {
        return "";

    }

    public bool isCompletelyHidden()
    {
        return true;
    }

}
