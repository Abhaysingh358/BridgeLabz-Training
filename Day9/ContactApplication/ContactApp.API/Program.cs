using Microsoft.EntityFrameworkCore;
using ContactApp.Repository;
using ContactApp.Business;
using ContactApp.Repository.Data;
var builder = WebApplication.CreateBuilder(args);
//register Database context
builder.Services.AddDbContext<ContactDbContext> (options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Registered Repository and Business Service for Dependency Injection
builder.Services.AddScoped<ContactRepository>();
builder.Services.AddScoped<IContactService, ContactService>(); 

// tell the asp.net core to look for controller folder , enable controller support
builder.Services.AddControllers();

//  Register the Swagger Generator
builder.Services.AddEndpointsApiExplorer(); // Helps Swagger find controller metadata
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   app.UseSwagger();
    app.UseSwaggerUI(); // This generates the interactive dashboard
}


app.UseHttpsRedirection();

app.MapControllers();



app.Run();

