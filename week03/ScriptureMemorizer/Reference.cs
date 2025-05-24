

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseStart;
    private int _verseEnd;

    public string Book => _book;
    public int Chapter => _chapter;
    public int Verse => _verse;
    public int VerseStart => _verseStart;
    public int VerseEnd => _verseEnd;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }   

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verseStart}" + (_verseEnd != _verseStart ? $"-{_verseEnd}" : "");
    }
}

