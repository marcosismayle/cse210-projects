
public class Reference
{
    private string _book= "Matthew";
    private int _chapter= 5;
    private string _verse= "14-16";
    private string _reference;
    
    public string GetReference()
    {
        return _reference = $"{_book} {_chapter}:{_verse} ";
    }
}
