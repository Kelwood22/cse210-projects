
public class Scripture
{
    private string _reference;

    private List<Word> _words;

    private Random _random = new Random();

    public string Reference => _reference;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        var availableWords = _words.Where(word => !word.IsHidden()).ToList();

        if (availableWords.Count < numberToHide)
        {
            numberToHide = availableWords.Count;
        }

        foreach (var word in availableWords.OrderBy(x => _random.Next()).Take(numberToHide))
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference}: {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}