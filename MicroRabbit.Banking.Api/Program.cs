using MediatR;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Interfaces.CuentasPorCobrar;
using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Services.CuentasPorCobrar;
using MicroRabbit.Banking.Application.Services.Inventario;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.CommandHandlers.CuentasPorCobrar;
using MicroRabbit.Banking.Domain.CommandHandlers.Inventario;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Commands.CuentasPorCobrar.Cliente;
using MicroRabbit.Banking.Domain.Commands.Inventario.TransferenciaBodega;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Infra.IoC;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<BankingDbContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("BankingDbConnection"));
//});


builder.Services.Configure<RabbitMQSettings>(builder.Configuration.GetSection("RabbitMQSettings"));
builder.Services.RegisterServices(builder.Configuration);


builder.Services.AddTransient<INivel1Services, Nivel1Services>();
builder.Services.AddTransient<IClienteServices, ClienteServices>();
builder.Services.AddTransient<ITransferenciaBodegaServices, TransferenciaBodegaServices>();

builder.Services.AddTransient<IRequestHandler<CreateNivel1Command, bool>, Nivel1CommandHandler>();
builder.Services.AddTransient<IRequestHandler<CreateClienteCommand, bool>, ClienteCommanHandler>();
builder.Services.AddTransient<IRequestHandler<CreateTransferenciaBodegaCabCommand, bool>, TransferenciaBodegaCabCommandHandler>();




builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
    );
    
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
