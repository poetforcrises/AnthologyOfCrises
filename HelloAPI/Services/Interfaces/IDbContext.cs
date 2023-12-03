using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1;

namespace Shortener.Service.Services.Interface
{
    public interface IDbContext
    {
        int AddUrl(UrlData urlData);

        UrlData GetUrl(int id);

        bool CheckIfUrlExists(string longUrl);
    }
}