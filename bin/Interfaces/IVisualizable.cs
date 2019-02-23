using System;

    namespace Laboratorio1
    {
        public interface IVisualizable
        {
            DateTime StarToSee(DateTime dateI);
            void StopToSee(DateTime dateI, DateTime dateF);           
        }
    }
