using cp.Interfaces;
using cp.Services;
using cp4.Interfaces;
using cp4.Services;

namespace cp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();


            builder.Services.AddHttpClient<IConversionRate, ConversionRate>(); // Adiciona o servi�o com HttpClient
            builder.Services.AddScoped<IExchangeRateService, ExchangeRateService>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new() { Title = "Currency Conversion API", Version = "v1" });
                c.DescribeAllParametersInCamelCase();
            });

            builder.Services.Configure<ExchangeRateApiSettings>(builder.Configuration.GetSection("ExchangeRateApi"));

            var app = builder.Build();

            //var exchangeRateUrl = app.Configuration["ExchangeRateApi:BaseUrl"];

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Currency Conversion API v1"));
            }

            app.UseHttpsRedirection();
            app.MapControllers();
            app.Run();
        }
    }
}
