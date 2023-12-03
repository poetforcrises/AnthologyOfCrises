using WebApplication1;

namespace Shortener.Service.Services.Interface
{
    public interface IControllerService
    {
        UrlDataDto AddUrlData(UrlDataDto urlDataDto, string requestScheme, string requestHost);
        UrlDataDto GetUrlData(string shortUrl); 
        bool CheckUserAgent(string headersUserAgent);
        bool CheckIfUrlExists(UrlDataDto urlDataDto);
    }
}