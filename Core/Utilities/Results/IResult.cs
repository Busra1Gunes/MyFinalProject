using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç örn Add metodu cevap döndürmek için
    public interface IResult //Sonuç
    {
        bool Success { get; }   //Get okumak için  //Set yazmak için
        string Message { get; } 
    }
}
