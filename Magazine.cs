using System.Collections.Generic;
using System;
namespace Laboratorio1
{
    public class Magazine : Publication
    {
        private int id;

        public int Id
        {
            get{ return id; }
        }
        public Magazine() : base()
        {

        }
        public Magazine(string title, DateTime editionDate, string editorial) : 
           base(title,editionDate,editorial)
        {

        }
        public static List<Magazine> makeMagazineList()
        {
            return null;
        }
    }    
}