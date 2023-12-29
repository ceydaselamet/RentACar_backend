using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.ApiResponse
{
    public interface IApiResponse<T>
    {
        List<T> Data { get; set; }
        bool Success { get; set; }
        string Message { get; set; }
    }
}
