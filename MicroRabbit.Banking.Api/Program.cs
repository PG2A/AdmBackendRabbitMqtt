using MediatR;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Interfaces.Contabilidad;
using MicroRabbit.Banking.Application.Interfaces.CuentasPorCobrar;
using MicroRabbit.Banking.Application.Interfaces.CuentasPorPagar;
using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Interfaces.Parametros;
using MicroRabbit.Banking.Application.Services.Contabilidad;
using MicroRabbit.Banking.Application.Services.CuentasPorCobrar;
using MicroRabbit.Banking.Application.Services.CuentasPorPagar;
using MicroRabbit.Banking.Application.Services.Inventario;
using MicroRabbit.Banking.Application.Services.Parametros;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.CommandHandlers.Contabilidad;
using MicroRabbit.Banking.Domain.CommandHandlers.CuentasPorCobrar;
using MicroRabbit.Banking.Domain.CommandHandlers.CuentasPorPagar;
using MicroRabbit.Banking.Domain.CommandHandlers.Inventario;
using MicroRabbit.Banking.Domain.CommandHandlers.Parametros;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Commands.Contabilidad.BancoCia;
using MicroRabbit.Banking.Domain.Commands.CuentasPorCobrar.Cliente;
using MicroRabbit.Banking.Domain.Commands.CuentasPorPagar.Proveedor;
using MicroRabbit.Banking.Domain.Commands.Inventario.Camion;
using MicroRabbit.Banking.Domain.Commands.Inventario.Chofer;
using MicroRabbit.Banking.Domain.Commands.Inventario.MotivosInventario;
using MicroRabbit.Banking.Domain.Commands.Inventario.Nivel2;
using MicroRabbit.Banking.Domain.Commands.Inventario.Nivel3;
using MicroRabbit.Banking.Domain.Commands.Inventario.Producto;
using MicroRabbit.Banking.Domain.Commands.Inventario.TransferenciaBodega;
using MicroRabbit.Banking.Domain.Commands.Parametros.Persona;
using MicroRabbit.Banking.Domain.Commands.Contabilidad.CuentaContable;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Infra.IoC;
using MicroRabbit.Banking.Domain.Commands.Parametros.Precio;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TablasContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BankingDbConnection"));
});


builder.Services.Configure<RabbitMQSettings>(builder.Configuration.GetSection("RabbitMQSettings"));
builder.Services.RegisterServices(builder.Configuration);

//builder.Services.AddTransient<TablasContext>();

builder.Services.AddTransient<ISucursalRepository, SucursalRepository>();


builder.Services.AddTransient<INivel1Services, Nivel1Services>();
builder.Services.AddTransient<IClienteServices, ClienteServices>();
builder.Services.AddTransient<ITransferenciaBodegaServices, TransferenciaBodegaServices>();
builder.Services.AddTransient<IProductoServices, ProductoServices>();
builder.Services.AddTransient<INivel2Services, Nivel2Services>();
builder.Services.AddTransient<INivel3Services, NIvel3Services>();
builder.Services.AddTransient<ICamionServices, CamionServices>();
builder.Services.AddTransient<IChoferServices, ChoferServices>();
builder.Services.AddTransient<IProveedorServices, ProveedorServices>();
builder.Services.AddTransient<IPersonaServices, PersonaServices>();
builder.Services.AddTransient<IBancoCiaServices, BancoCiaServices>();
builder.Services.AddTransient<IMotivosInventarioServices, MotivosInventarioServices>();
builder.Services.AddTransient<ICuentaContableServices, CuentaContableServices>();
builder.Services.AddTransient<IPrecioServices, PrecioServices>();
builder.Services.AddTransient<ISucursalServices, SucursalServices>();



builder.Services.AddTransient<IRequestHandler<CreateNivel1Command, bool>, Nivel1CommandHandler>();
builder.Services.AddTransient<IRequestHandler<CreateClienteCommand, bool>, ClienteCommanHandler>();
builder.Services.AddTransient<IRequestHandler<CreateTransferenciaBodegaCabCommand, bool>, TransferenciaBodegaCabCommandHandler>();
builder.Services.AddTransient<IRequestHandler<CreateProductoCommand, bool>, ProductoCommandHandler>();
builder.Services.AddTransient<IRequestHandler<CreateNivel2Command, bool>, Nivel2CommandHandler>();
builder.Services.AddTransient<IRequestHandler<CreateNivel3Command, bool>, Nivel3CommandHandler>();
builder.Services.AddTransient<IRequestHandler<CreateCamionCommand, bool>, CamionCommandHandler>();
builder.Services.AddTransient<IRequestHandler<CreateChoferCommand, bool>, ChoferCommandHandler>();
builder.Services.AddTransient<IRequestHandler<CreateProveedorCommand, bool>, ProveedorCommandHandler>();
builder.Services.AddTransient<IRequestHandler<CreatePersonaCommand, bool>, PersonaCommandHandler>();
builder.Services.AddTransient<IRequestHandler<CreateBancoCiaCommand, bool>, BancoCiaCommandHandler>();
builder.Services.AddTransient<IRequestHandler<CreateMotivosInventarioCommand, bool>, MotivosInventarioCommandHandler>();
builder.Services.AddTransient<IRequestHandler<CreateCuentaContableCommand, bool>, CuentaContableCommandHandler>();
builder.Services.AddTransient<IRequestHandler<CreatePrecioCommand, bool>, PrecioCommandHandler>();




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
