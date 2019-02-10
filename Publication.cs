using System.Collections.Generic;
using System;
namespace Laboratorio1
{
    public abstract class Publication
    {
        private string title;
        private DateTime editionDate;
        private string editorial;
        private List<Book> autors = new List<Book>();
        

        public string Title
        {
            get{ return title; }
            set{ title = value; }
        }

        public string EditionDate
        {
            get{ return editionDate; }
            set{ editionDate = value; }

        }

        public string Editorial
        {
            get{ return editorial; }
            set{ editorial = value; }
        }

        public string Autors
        {
            get{ return autors; }
            set{ autors = value; }
        }
    }
}