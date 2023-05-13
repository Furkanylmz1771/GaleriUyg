using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriUyg
{
    public interface IArac
    {
        int GetId();
        void SetId(int value);

        string GetMarka();
        void SetMarka(string value);

        string GetModel();
        void SetModel(string value);

        int GetYas();
        void SetYas(int value);

         string OzellıkleriGoster();


    }
}
