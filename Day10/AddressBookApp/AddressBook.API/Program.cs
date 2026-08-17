using AddressBook.Repository;
using Microsoft.EntityFrameworkCore;
using AddressBook.Business;
using Microsoft.EntityFrameworkCore.Design;
using AddressBook.Models;
using Microsoft.AspNetCore.Mvc;



var builder = WebApplication.CreateBuilder(args);

var conn = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AddressBookContext>(options => options.UseSqlServer(conn));

builder.Services.AddScoped<IRepository , Repository>();
builder.Services.AddScoped<IService , Service>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}

app.UseHttpsRedirection();

app.MapGet("api/contacts" , (IService s) => { 
    return Results.Ok(s.GetAll());
    
});

app.MapPost("api/contacts" , ([FromBody] ContactCreateDTO dto , IService s) =>
{
     var contact = new Contact 
    { 
        Name = dto.Name, 
        City = dto.City, 
        Country = dto.Country, 
        PinCode = dto.PinCode 
    };
    s.Add(contact); 
    return Results.Created($"/contacts/{contact.id}", contact);
});

app.MapPut("api/contacts", (Contact c, IService s) => 
{ 
    s.Update(c); 
    return Results.NoContent(); 
});

app.MapDelete("api/contacts/{id}", (int id, IService s) => 
{ 
    s.Delete(id); 
    return Results.NoContent(); 
});


app.Run();

