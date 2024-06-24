using DevFreela.Payments.API.Models;

namespace DevFreela.Payments.API.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public PaymentService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel)
        {
            return Task.FromResult(true);
        }
    }
}
