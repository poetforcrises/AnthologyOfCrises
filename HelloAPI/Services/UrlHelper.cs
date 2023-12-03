using Shortener.Service.Services.Interface;
using HashidsNet;
using System;

namespace Shortener.Service.Services
{
    public class UrlHelper : IUrlHelper
    {
        private Hashids _hashIds;
        //string salt = GenerateRandomSalt();
        public UrlHelper()
        {
            _hashIds = new Hashids("0ahUKEwismN2yp9SCAxVZd2wGHf3iDDUQ4dUDCBA&uact", 6);
        }

        public string GetShortUrl(int id)
        {
            return _hashIds.Encode(id);
        }
        public int GetId(string shortUrl)
        {
            var decodedId = _hashIds.Decode(shortUrl);
            return decodedId[0];
        }
        //static string GenerateRandomSalt()
        //{
        //    byte[] saltBytes = new byte[16];
        //    new Random().NextBytes(saltBytes);
        //    return Convert.ToBase64String(saltBytes);
        //}
    }
}