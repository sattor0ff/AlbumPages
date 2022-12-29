public class PhotoBook
{
    protected int _numPages;

    public virtual int GetNumberPages()
    {
        return _numPages;
    } 
    public PhotoBook()
    {
        _numPages = 16;
    }
    public PhotoBook(int number)
    {
        _numPages = number;
    }
}

public class BigPhotoBook : PhotoBook
{
    public BigPhotoBook() : base(64)
    {}
    
}

