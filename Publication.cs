using System.Collections.Generic;
using System;
namespace Laboratorio1
{
    public abstract class Publication
    {
        private string title;
        private DateTime editionDate;
        private string editorial;
        /* private List<Book> authors = new List<Book>();*/
        public string[] authors;
        
        public string Title
        {
            get{ return title; }
            set{ title = value; }
        }

        public DateTime EditionDate
        {
            get{ return editionDate; }
            set{ editionDate = value; }

        }

        public string Editorial
        {
            get{ return editorial; }
            set{ editorial = value; }
        }

        public string[] Authors
        {
            get{ return authors; }
            set{ authors = value; }
        }
        public Publication()
        {

        }       
        public Publication(string title, DateTime editionDate, string editorial)
        {
           /* Title = title;
            EditionDate = editionDate;
            Editorial = editorial; */
            this.Title = title;
            this.EditionDate = editionDate;
            this.Editorial = editorial;
        }
    }
}