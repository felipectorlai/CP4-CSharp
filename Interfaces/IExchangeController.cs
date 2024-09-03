namespace cp.Interfaces
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public interface IExchangeController
    {
        Task<IActionResult> GetUsdToBrl();
    }
}
