using Microsoft.EntityFrameworkCore;
using PolicyCustomerService.Commands;
using PolicyCustomerService.Data;
using PolicyCustomerService.Interface;
using PolicyCustomerService.Results;

var builder = WebApplication.CreateBuilder(args);

// Register database context with MSSQL
builder.Services.AddDbContext<PolicyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register services and their interfaces
builder.Services.AddScoped<IPolicyCommand, PolicyCommand>(); // Register IPolicyCommand
builder.Services.AddScoped<IResultBuilder, ResultBuilder>(); // Register IResultBuilder
builder.Services.AddControllers();

// Build and run the application
var app = builder.Build();
app.MapControllers();
app.Run();
