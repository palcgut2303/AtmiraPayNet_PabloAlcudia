using AtmiraPayNet.Client.Interfaces;
using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

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


        public async Task<ResponseAPI<CreateRequestPaymentLetter>> GetPaymentLetterById(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<ResponseAPI<CreateRequestPaymentLetter>>($"api/PaymentLetter/{id}");
            if (response == null)
            {
                return new ResponseAPI<CreateRequestPaymentLetter>
                {
                    Successful = false,
                    Message = "Error, no se ha podido obtener la carta de pago",
                };
            }
            return new ResponseAPI<CreateRequestPaymentLetter>
            {
                Successful = true,
                Value = response.Value,
            };
        }

        public async Task<ResponseAPI<List<PaymentListAttribute>>> GetAttributePayment()
        {
            var response = await _httpClient.GetFromJsonAsync<List<PaymentListAttribute>>("api/PaymentLetter/GetAttributePaymentLetter");

            if (response.Count() == 0 || response == null)
            {
                return new ResponseAPI<List<PaymentListAttribute>>
                {
                    Successful = false,
                    Message = "Error, no se han podido obtener los atributos de la carta de pago",
                };
            }


            return new ResponseAPI<List<PaymentListAttribute>>
            {
                Successful = true,
                Value = response,
            };

        }

        public async Task<ResponseAPI<PaymentLetterDTO>> PostPaymentLetter(CreateRequestPaymentLetter model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/PaymentLetter", model);
            if (response.IsSuccessStatusCode)
            {
                return new ResponseAPI<PaymentLetterDTO>
                {
                    Successful = true,
                    Message = "Payment Letter created successfully",
                };
            }
            else
            {
                return new ResponseAPI<PaymentLetterDTO>
                {
                    Successful = false,
                    Message = "Error, no se ha podido crear la carta de pago",
                };
            }
        }

        public async Task<ResponseAPI<PaymentLetterDTO>> PutPaymentLetter(CreateRequestPaymentLetter model, int id)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/PaymentLetter/{id}", model);
            if (response.IsSuccessStatusCode)
            {
                return new ResponseAPI<PaymentLetterDTO>
                {
                    Successful = true,
                    Message = "Payment Letter created successfully",
                };
            }
            else
            {
                return new ResponseAPI<PaymentLetterDTO>
                {
                    Successful = false,
                    Message = "Error, no se ha podido crear la carta de pago",
                };
            }
        }

    }
}
