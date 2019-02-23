using System.Collections.Generic;
using System;
namespace Laboratorio1
{
    public class Book : Publication, IVisualizable
    {

        private int id;
        private string isbn;
        private bool readed;
        private int timeReaded;
    
        public int Id
        {
            get{ return id; }
            
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
        public Book() : base()
        {
            
        }
        public Book(string title, DateTime editionDate, string editorial, string[] authors) : base(title,editionDate,editorial)
        {
            this.Authors = authors;

        }
        public DateTime StarToSee(DateTime dateI)
        {
             return dateI;
        }

        public void StopToSee(DateTime dateTime, DateTime dateF)
        {
             this.timeReaded = dateF.Second - dateTime.Second;
        }
        public override string ToString()
        {
            return $"Book: {this.Isbn} {this.Title}"; //Interpolacón
        }
        public static List<Book> makeBookList()
        {
             return null;
        }
    }
}