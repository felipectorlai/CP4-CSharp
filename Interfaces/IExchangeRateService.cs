namespace cp.Interfaces
{
    public interface IExchangeRateService
    {
        Task<decimal> GetUsdToBrlRateAsync();
    }
}
