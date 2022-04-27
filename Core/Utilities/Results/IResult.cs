using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel void başlangıcı
    public interface IResult
    {
        //basarili ve ya basarisiz 
        bool Success { get; }
        //urun eklendi veya eklenemedi
        string Message { get; }
    }
}
