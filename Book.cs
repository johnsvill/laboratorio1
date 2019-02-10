namespace Laboratorio1
{
    public class Book : Publication
    {

    private int id;
    private string isbn;
    private bool readed;
    private int timeReaded;
    

    public int Id
    {
        get{ return id; }
        set{ id = value;}
    }
    public string Isbn
    {
        get{ return isbn; }
        set{ isbn = value;}
    }
    public bool Readed
    {
        get{ return readed;}
        set{ readed = value;}
    }
    public int TimeReaded
    {
        get{ return timeReaded; }
        set{ timeReaded = value;}
    }

    }
}