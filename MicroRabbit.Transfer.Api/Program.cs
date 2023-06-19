
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
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Infra.IoC;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Data.Repository;
using MicroRabbit.Transfer.Data.Repository.Contabilidad;
using MicroRabbit.Transfer.Data.Repository.CuentasPorCobrar;
using MicroRabbit.Transfer.Data.Repository.CuentasPorPagar;
using MicroRabbit.Transfer.Data.Repository.Inventario;
using MicroRabbit.Transfer.Data.Repository.Parametros;
using MicroRabbit.Transfer.Domain.EventHandlers.Contabilidad;
using MicroRabbit.Transfer.Domain.EventHandlers.CuentasPorCobrar;
using MicroRabbit.Transfer.Domain.EventHandlers.CuentasPorPagar;
using MicroRabbit.Transfer.Domain.EventHandlers.Inventario;
using MicroRabbit.Transfer.Domain.EventHandlers.Parametros;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Events.Contabilidad;
using MicroRabbit.Transfer.Domain.Events.CuentasPorCobrar;
using MicroRabbit.Transfer.Domain.Events.CuentasPorPagar;
using MicroRabbit.Transfer.Domain.Events.Inventario;
using MicroRabbit.Transfer.Domain.Events.Parametros;
using MicroRabbit.Transfer.Domain.Interfaces.Contabilidad;
using MicroRabbit.Transfer.Domain.Interfaces.CuentasPorCobrar;
using MicroRabbit.Transfer.Domain.Interfaces.CuentasPorPagar;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Interfaces.Parametros;
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
builder.Services.AddTransient<IPersonaServices, PersonaServices>();
builder.Services.AddTransient<IBancoCiaServices, BancoCiaServices>();
builder.Services.AddTransient<IMotivosInventarioServices, MotivosInventarioServices>();
builder.Services.AddTransient<INivel2Services, Nivel2Services>();
builder.Services.AddTransient<INivel3Services, NIvel3Services>();
builder.Services.AddTransient<ITransferenciaBodegaServices, TransferenciaBodegaServices>();
builder.Services.AddTransient<IAjusteIngresoServices, AjusteIngresoServices>();


builder.Services.AddTransient<ICuentaContableServices, CuentaContableServices>();
builder.Services.AddTransient<IPrecioServices, PrecioServices>();
builder.Services.AddTransient<IEventHandler<Nivel1CreateEvent>, Nivel1EventHandler>();
builder.Services.AddTransient<IEventHandler<ProductoCreateEvent>, ProductoEventHandler>();
builder.Services.AddTransient<IEventHandler<PersonaCreateEvent>, PersonaEventHandler>();
builder.Services.AddTransient<IEventHandler<ChoferCreateEvent>, ChoferEventHandler>();
builder.Services.AddTransient<IEventHandler<CamionCreateEvent>, CamionEventHandler>();
builder.Services.AddTransient<IEventHandler<ProveedorCreateEvent>, ProveedorEventHandler>();
builder.Services.AddTransient<IEventHandler<BancoCiaCreateEvent>, BancoCiaEventHandler>();
builder.Services.AddTransient<IEventHandler<MotivosInventarioCreateEvent>, MotivosInventarioEventHandler>();
builder.Services.AddTransient<IEventHandler<TransferenciaBodegaCabCreateEvent>, TranferenciaBodegaEventHandler>();
builder.Services.AddTransient<IEventHandler<AjusteIngresoCreateEvent>, AjusteIngresoEventHandler>();


builder.Services.AddTransient<Nivel1DbContext>();
builder.Services.AddTransient<IEventHandler<Nivel2CreateEvent>, Nivel2EventHandler>();
builder.Services.AddTransient<IEventHandler<Nivel3CreateEvent>, Nivel3EventHandler>();
builder.Services.AddTransient<IEventHandler<CuentaContableCreateEvent>, CuentaContableEventHandler>();
builder.Services.AddTransient<IEventHandler<PrecioCreateEvent>, PrecioEventHandler>();
builder.Services.AddTransient<IEventHandler<BodegaCreateEvent>, BodegaEventHandler>();
builder.Services.AddTransient<IEventHandler<ProductoBodegaCreateEvent>, ProductoBodegaEventHandler>();

builder.Services.AddTransient<INivelRepository, Nivel1Repository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IProductoRepository, ProductoRepository>();
builder.Services.AddTransient<IChoferRepository, ChoferRepository>();
builder.Services.AddTransient<ICamionRepository, CamionRepository>();
builder.Services.AddTransient<IProveedorRepository, ProveedorRepository>();
builder.Services.AddTransient<IPersonaRepository, PersonaRepository>();
builder.Services.AddTransient<IBancoCiaRepository, BancoCiaRepository>();
builder.Services.AddTransient<INivel2Repository, Nivel2Repository>();
builder.Services.AddTransient<INivel3Repository, Nivel3Repository>();
builder.Services.AddTransient<ITranfrenciaBodegaRepository, TranferenciaBodegaRepository>();
builder.Services.AddTransient<IAjusteIngresoRepository, AjusteIngresoRepository>();


builder.Services.AddTransient<ICuentaContableRepository, CuentaContableRepository>();
builder.Services.AddTransient<IMotivosInventarioRepository, MotivosInventarioRepository>();
builder.Services.AddTransient<IPrecioRepository, PrecioRepository>();
builder.Services.AddTransient<TablasContext>();
builder.Services.AddTransient<TablasSinKeyDbContext>();


builder.Services.AddTransient<IBodegaRepository, BodegaRepository>();
builder.Services.AddTransient<IProductoBodegaRepository, ProductoBodegaRepository>();
builder.Services.AddTransient<TablasContext>(); 





//Subscriptions

builder.Services.AddTransient<Nivel1EventHandler>();
builder.Services.AddTransient<ClienteEventHandller>();
builder.Services.AddTransient<ProductoEventHandler>();
builder.Services.AddTransient<CamionEventHandler>();
builder.Services.AddTransient<ChoferEventHandler>();
builder.Services.AddTransient<ProveedorEventHandler>();
builder.Services.AddTransient<PersonaEventHandler>();
builder.Services.AddTransient<BancoCiaEventHandler>();
builder.Services.AddTransient<Nivel2EventHandler>();
builder.Services.AddTransient<Nivel3EventHandler>();
builder.Services.AddTransient<MotivosInventarioEventHandler>();
builder.Services.AddTransient<CuentaContableEventHandler>();
builder.Services.AddTransient<PrecioEventHandler>();
builder.Services.AddTransient<TranferenciaBodegaEventHandler>();
builder.Services.AddTransient<AjusteIngresoEventHandler>();



builder.Services.AddTransient<BodegaEventHandler>();
builder.Services.AddTransient<ProductoBodegaEventHandler>();



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
eventBus.Subscribe<PersonaCreateEvent, PersonaEventHandler>();
eventBus.Subscribe<ProveedorCreateEvent, ProveedorEventHandler>();
eventBus.Subscribe<BancoCiaCreateEvent, BancoCiaEventHandler>();
eventBus.Subscribe<MotivosInventarioCreateEvent, MotivosInventarioEventHandler>();
eventBus.Subscribe<CuentaContableCreateEvent, CuentaContableEventHandler>();
eventBus.Subscribe<PrecioCreateEvent, PrecioEventHandler>();
eventBus.Subscribe<TransferenciaBodegaCabCreateEvent, TranferenciaBodegaEventHandler>();
eventBus.Subscribe<AjusteIngresoCreateEvent, AjusteIngresoEventHandler>();



eventBus.Subscribe<BodegaCreateEvent, BodegaEventHandler>();
eventBus.Subscribe<ProductoBodegaCreateEvent, ProductoBodegaEventHandler>();


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
