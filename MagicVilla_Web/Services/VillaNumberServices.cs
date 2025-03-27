using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;
using Newtonsoft.Json;
using System.Net.Http;

namespace MagicVilla_Web.Services
{
    public class VillaNumberServices : BaseServices, IVillaNumberServices
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;
        private readonly ILogger<VillaServices> _logger;
        public VillaNumberServices(IHttpClientFactory clientFactory, IConfiguration configuration, ILogger<VillaServices>logger) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            villaUrl = configuration.GetValue<string>("ServicesUrls:VillaAPI");
            _logger = logger;
            _logger.LogInformation("Villa API URL: {villaUrl}", villaUrl); // Log the URL
        }
        public Task<T> CreateAsync<T>(VillaNumberCreateDTO dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = dto,
                Url = villaUrl + "api/villaNumberAPI"
            });
        }
        
        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = villaUrl + "api/villaNumberAPI/" + id
            });
        }
        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = villaUrl + "api/villaNumberAPI"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = villaUrl + "api/villaNumberAPI/" + id
            });
        }
        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                Url = villaUrl + "api/villaNumberAPI/" + dto.VillaNo
            });
        }
    
    }
}
