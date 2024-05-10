using AtmiraPayNet.Client.Interfaces;
using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;
using System.Net.Http.Json;

namespace AtmiraPayNet.Client.Services
{
    public class PaymentLetterService : IPaymentLetterService
    {
        private readonly HttpClient _httpClient;

        public PaymentLetterService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseAPI<List<PaymentLetterDTO>>> GetPaymentLetters()
        {
            var response = await _httpClient.GetAsync("api/PaymentLetter");
            if (response.IsSuccessStatusCode)
            {
                return null;
            }
            else
            {
                return null;
            }
        }

        public async Task<ResponseAPI<PaymentLetterDTO>> PostPaymentLetter(CreateRequestPaymentLetter model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/PaymentLetter",model);
            if (response.IsSuccessStatusCode)
            {
                return new ResponseAPI<PaymentLetterDTO>
                {
                    Successful = true,
                    Menssage = "Payment Letter created successfully",
                };
            }
            else
            {
                return new ResponseAPI<PaymentLetterDTO>
                {
                    Successful = false,
                    Menssage = "Error, no se ha podido crear la carta de pago",
                };
            }
        }

    }
}
