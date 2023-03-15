using Calibracion.DDD.Infrastructure;
using Calibracion.DDD.UseCase.Gateways;
using Calibracion.DDD.UseCase.UseCases;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(
					builder.Configuration.GetConnectionString("conexionCalibracion"),
					b => b.MigrationsAssembly(typeof(DataBaseContext).Assembly.FullName)
));

builder.Services.AddScoped(typeof(IStoredEventRepository<>), typeof(StoredEventRepository<>));
builder.Services.AddScoped<ICertificadoUseCase, CertificadoUseCase>();
builder.Services.AddScoped<IClienteUseCase, ClienteUseCase>();
builder.Services.AddScoped<IInstrumentoUseCase, InstrumentoUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
