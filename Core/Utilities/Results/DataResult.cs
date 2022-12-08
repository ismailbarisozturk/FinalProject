using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>  //implemente et //ctor oluştur
    {
        public DataResult(T data,bool success,string message):base(success,message)  //constructor
        {
                Data = data;  //T data system for see
        }
        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
