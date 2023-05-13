using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GaleriUyg
{
    public class Otomobil : IArac
    {
        private int ıd;

        public int GetId()
        {
            return ıd;
        }

        public void SetId(int value)
        {
            ıd = value;
        }

        private string marka;

        public string GetMarka()
        {
            return marka;
        }

        public void SetMarka(string value)
        {
            marka = value;
        }

        private string model;

        public string GetModel()
        {
            return model;
        }

        public void SetModel(string value)
        {
            model = value;
        }

        private int yas;

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int value)
        {
            yas = value;
        }

        public bool UstuAcıkMı { get; set; }
        public object Id { get;  set; }
        public object Marka { get; set; }
        public object Model { get; set; }
        public object Yas { get;  set; }

        public string OzellıkleriGoster()
        {
            return $"Id:{Id} Marka Model:{Marka} {Model} Yas : {Yas} Üstü Açık mı: {(UstuAcıkMı ? "Evet" : "Hayır")}";
        }
    }
}
