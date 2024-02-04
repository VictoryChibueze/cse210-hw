using System.Text;


class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }






public void HideRandomWords(int numberToHide)
{
    HashSet<int> selectedIndices = new HashSet<int>();

    for (int i = 0; i < numberToHide; i++)
    {
        int index;
        do
        {
            index = _random.Next(_words.Count);
        } while (selectedIndices.Contains(index));

        selectedIndices.Add(index);
        _words[index].Hide();
    }
}

    
    public string GetDisplayText()
{
    // Create a StringBuilder to efficiently build the display text
    StringBuilder displayText = new StringBuilder();

    displayText.AppendLine($"{_reference.GetDisplayText()}");

    foreach (Word w in _words)
    {
        displayText.Append(w.GetDisplayText() + " ");
    }

    displayText.AppendLine("\n");

    // Return the final display text as a string
    return displayText.ToString();
}



    public bool isCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }

    
}

