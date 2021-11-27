using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.API.Data.Responses
{
    public class ServiceResponse<T> where T : new()
    {
        public ServiceResponse(string message)
        {
            this.isSuccess = false;
            this.message = message;
            this.data = new T();
        }
        //IsSuccess is false.
        public ServiceResponse()
        {
            this.isSuccess = false;
            this.message = "No Data Response For this Request!";
            this.data = new T();
        }
        public ServiceResponse(T data, string message)
        {
            this.isSuccess = true;
            this.message = message;
            this.data = data;
        }

        //IsSuccess is true.
        public ServiceResponse(T data)
        {
            this.isSuccess = true;
            this.message = "Data Fetched Successfully!";
            this.data = data;

        }
        public ServiceResponse(bool isSuccess, string message, T data)
        {
            this.isSuccess = isSuccess;
            this.message = message;
            this.data = data;

        }
        public ServiceResponse(bool isSuccess, string message)
        {
            this.isSuccess = isSuccess;
            this.message = message;
            this.data = new T();
        }
        public bool isSuccess { get; }
        public string message { get; }
        public DateTime time { get; } = DateTime.Now.Date;
        public T data { get; set; }
    }
}
