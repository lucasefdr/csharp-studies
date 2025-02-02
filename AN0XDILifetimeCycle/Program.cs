var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Injection
builder.Services.AddSingleton<PrimaryService>(); // Singleton: sempre terá o mesmo ID
builder.Services.AddScoped<SecondaryService>(); // Scoped: mesmo ID dentro da requisição
builder.Services.AddTransient<TertiaryService>(); // Transient: ID por instância

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet(pattern: "/", handler: (PrimaryService primaryService, SecondaryService secondaryService, TertiaryService tertiaryService,
    TertiaryService tertiaryServiceOtherInstance) =>
new
{
    Id = Guid.NewGuid(),
    PrimaryServiceId = primaryService.Id,
    SecondaryService = new
    {
        Id = secondaryService.Id,
        PrimaryServiceId = secondaryService.PrimaryServiceId
    },
    TertiaryService = new
    {
        Id = tertiaryService.Id,
        PrimaryServiceId = tertiaryService.PrimaryServiceId,
        SecondaryServiceId = tertiaryService.SecondServiceId,
        SecondaryServiceNewInstanceId = tertiaryService.SecondServiceNewInstanceId,
        TertiaryServiceOtherInsanceId = tertiaryServiceOtherInstance.Id
    }
});

app.Run();


// Classes
internal class PrimaryService
{
    // Properties
    public Guid Id { get; set; } = Guid.NewGuid();
}

internal class SecondaryService
{
    // Fields
    private readonly PrimaryService _primaryService;

    // Constructor - DI
    public SecondaryService(PrimaryService primaryService) => _primaryService = primaryService;

    // Properties 
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PrimaryServiceId => _primaryService.Id;
}
internal class TertiaryService
{
    // Fields
    private readonly PrimaryService _primaryService;
    private readonly SecondaryService _secondaryService;
    private readonly SecondaryService _secondaryServiceNewInstance;

    // Constructor DI
    public TertiaryService(PrimaryService primaryService, SecondaryService secondaryService, SecondaryService secondaryServiceNewInstance)
    {
        _primaryService = primaryService;
        _secondaryService = secondaryService;
        _secondaryServiceNewInstance = secondaryServiceNewInstance;
    }

    // Properties
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PrimaryServiceId => _primaryService.Id;
    public Guid SecondServiceId => _secondaryService.Id;
    public Guid SecondServiceNewInstanceId => _secondaryServiceNewInstance.Id;
}