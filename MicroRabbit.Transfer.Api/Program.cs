
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Interfaces.CuentasPorCobrar;
using MicroRabbit.Banking.Application.Interfaces.CuentasPorPagar;
using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Services.CuentasPorCobrar;
using MicroRabbit.Banking.Application.Services.CuentasPorPagar;
using MicroRabbit.Banking.Application.Services.Inventario;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Infra.IoC;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Data.Repository;
using MicroRabbit.Transfer.Data.Repository.CuentasPorCobrar;
using MicroRabbit.Transfer.Data.Repository.CuentasPorPagar;
using MicroRabbit.Transfer.Data.Repository.Inventario;
using MicroRabbit.Transfer.Domain.EventHandlers.CuentasPorCobrar;
using MicroRabbit.Transfer.Domain.EventHandlers.CuentasPorPagar;
using MicroRabbit.Transfer.Domain.EventHandlers.Inventario;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Events.CuentasPorCobrar;
using MicroRabbit.Transfer.Domain.Events.CuentasPorPagar;
using MicroRabbit.Transfer.Domain.Events.Inventario;
using MicroRabbit.Transfer.Domain.Interfaces.CuentasPorCobrar;
using MicroRabbit.Transfer.Domain.Interfaces.CuentasPorPagar;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Cambiar al TablaDbCotext

builder.Services.AddDbContext<TablasContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TransferDbConnection"));
});


builder.Services.Configure<RabbitMQSettings>(builder.Configuration.GetSection("RabbitMQSettings"));
builder.Services.RegisterServices(builder.Configuration);


builder.Services.AddTransient<INivel1Services, Nivel1Services>();
builder.Services.AddTransient<IClienteServices, ClienteServices>();
builder.Services.AddTransient<IProductoServices, ProductoServices>();
builder.Services.AddTransient<ICamionServices, CamionServices>();
builder.Services.AddTransient<IChoferServices, ChoferServices>();
builder.Services.AddTransient<IProveedorServices, ProveedorServices>();
builder.Services.AddTransient<IEventHandler<Nivel1CreateEvent>, Nivel1EventHandler>();
builder.Services.AddTransient<IEventHandler<ProductoCreateEvent>, ProductoEventHandler>();
builder.Services.AddTransient<INivelRepository, Nivel1Repository>();
builder.Services.AddTransient<IEventHandler<ChoferCreateEvent>, ChoferEventHandler>();
builder.Services.AddTransient<IEventHandler<CamionCreateEvent>, CamionEventHandler>();
builder.Services.AddTransient<IEventHandler<ProveedorCreateEvent>, ProveedorEventHandler>();
builder.Services.AddTransient<Nivel1DbContext>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IProductoRepository, ProductoRepository>();
builder.Services.AddTransient<IChoferRepository, ChoferRepository>();
builder.Services.AddTransient<ICamionRepository, CamionRepository>();
builder.Services.AddTransient<IProveedorRepository, ProveedorRepository>();
builder.Services.AddTransient<TablasContext>();





//Subscriptions

builder.Services.AddTransient<Nivel1EventHandler>();
builder.Services.AddTransient<ClienteEventHandller>();
builder.Services.AddTransient<ProductoEventHandler>();
builder.Services.AddTransient<CamionEventHandler>();
builder.Services.AddTransient<ChoferEventHandler>();
builder.Services.AddTransient<ProveedorEventHandler>();



builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
    );

});

var app = builder.Build();
var eventBus = app.Services.GetRequiredService<IEventBus>();
eventBus.Subscribe<Nivel1CreateEvent, Nivel1EventHandler>();
eventBus.Subscribe<ClienteCreateEvent, ClienteEventHandller>();
eventBus.Subscribe<ProductoCreateEvent, ProductoEventHandler>();
eventBus.Subscribe<CamionCreateEvent, CamionEventHandler>();
eventBus.Subscribe<ChoferCreateEvent, ChoferEventHandler>();
eventBus.Subscribe<ProveedorCreateEvent, ProveedorEventHandler>();




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
