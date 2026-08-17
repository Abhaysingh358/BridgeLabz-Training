using AddressBook.Repository;
using Microsoft.EntityFrameworkCore;
using AddressBook.Business;
using Microsoft.EntityFrameworkCore.Design;
using AddressBook.Models.DTO;
using AddressBook.Models.Model;
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

app.MapGet("api/contacts/{id:int}" , (int id , IService s) =>
{
    return Results.Ok(s.GetById(id));
});

app.MapPost("api/contacts" , ([FromBody] ContactCreateDTO dto , IService s) =>
{
     var contact = new ContactModel 
    { 
        Name = dto.Name, 
        City = dto.City, 
        Country = dto.Country, 
        PinCode = dto.PinCode 
    };
    s.Add(contact); 
    return Results.Created($"/contacts/{contact.Id}", contact);
});

app.MapPut("api/contacts", (ContactModel c, IService s) => 
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

