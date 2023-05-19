
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Interfaces.CuentasPorCobrar;
using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Services.CuentasPorCobrar;
using MicroRabbit.Banking.Application.Services.Inventario;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Infra.IoC;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Data.Repository;
using MicroRabbit.Transfer.Data.Repository.CuentasPorCobrar;
using MicroRabbit.Transfer.Data.Repository.Inventario;
using MicroRabbit.Transfer.Domain.EventHandlers.CuentasPorCobrar;
using MicroRabbit.Transfer.Domain.EventHandlers.Inventario;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Events.CuentasPorCobrar;
using MicroRabbit.Transfer.Domain.Events.Inventario;
using MicroRabbit.Transfer.Domain.Interfaces.CuentasPorCobrar;
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
builder.Services.AddDbContext<TablasSinKeyDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TransferDbConnection"));
});

builder.Services.Configure<RabbitMQSettings>(builder.Configuration.GetSection("RabbitMQSettings"));
builder.Services.RegisterServices(builder.Configuration);


builder.Services.AddTransient<INivel1Services, Nivel1Services>();
builder.Services.AddTransient<IClienteServices, ClienteServices>();
builder.Services.AddTransient<IProductoServices, ProductoServices>();
builder.Services.AddTransient<INivel2Services, Nivel2Services>();
builder.Services.AddTransient<INivel3Services, NIvel3Services>();


builder.Services.AddTransient<IEventHandler<Nivel1CreateEvent>, Nivel1EventHandler>();
builder.Services.AddTransient<IEventHandler<ProductoCreateEvent>, ProductoEventHandler>();
builder.Services.AddTransient<IEventHandler<Nivel2CreateEvent>, Nivel2EventHandler>();
builder.Services.AddTransient<IEventHandler<Nivel3CreateEvent>, Nivel3EventHandler>();

builder.Services.AddTransient<INivelRepository, Nivel1Repository>();
builder.Services.AddTransient<Nivel1DbContext>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IProductoRepository, ProductoRepository>();
builder.Services.AddTransient<INivel2Repository, Nivel2Repository>();
builder.Services.AddTransient<INivel3Repository, Nivel3Repository>();


builder.Services.AddTransient<TablasContext>();





//Subscriptions

builder.Services.AddTransient<Nivel1EventHandler>();
builder.Services.AddTransient<ClienteEventHandller>();
builder.Services.AddTransient<ProductoEventHandler>();
builder.Services.AddTransient<Nivel2EventHandler>();
builder.Services.AddTransient<Nivel3EventHandler>();





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
eventBus.Subscribe<Nivel2CreateEvent, Nivel2EventHandler>();
eventBus.Subscribe<Nivel3CreateEvent, Nivel3EventHandler>();






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
