using ExerciseBPO.Services;
using ExerciseBPO.Interfaces;
using Microsoft.OpenApi.Models;

namespace ExerciseBPO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<ISimpleMathematicalExpressionsServices, SimpleMathematicalExpressionsServices>();
            builder.Services.AddSingleton<IComplexMathematicalExpressionServices, ComplexMathematicalExpressionServices>();

            builder.Services.AddControllers()
                .AddJsonOptions(jsonOptions =>
                jsonOptions.JsonSerializerOptions.NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowNamedFloatingPointLiterals);
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("v1/swagger.json", "My API V1");
                });
            }

            app.MapControllers();

            app.Run();
        }
    }
}