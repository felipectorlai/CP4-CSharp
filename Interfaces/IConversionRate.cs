using cp.HttpObjetcs;

namespace cp4.Interfaces
{
    public interface IConversionRate
    {
        Task<ExchangeRateResponse> GetUsdRateAsync();
    }
}
