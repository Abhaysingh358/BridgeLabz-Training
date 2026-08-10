using ContactApp.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var contacts = new List<Contact>
{
    new(){Id = 1 , Name = "California" ,Email = "California@gmail.com" ,Phone = "7418529630"} ,
    new() {Id = 2 ,Name = " Paris" , Email = "Paris@gmail.com", Phone = "7896541230" }
};




app.MapGet("/", () => "Hello World!");

app.MapGet("/api/contacts" , () =>
{
    return Results.Ok(contacts);
});


app.MapPost("/api/contacts" , (Contact newContact) =>
{
    if (string.IsNullOrEmpty(newContact.Name))
    {
        return Results.BadRequest(new{error = "Contact Name is required"});
    }
        newContact.Id = contacts.Count+1;

    // Add to our in-memory list
    contacts.Add(newContact);

    // Return 201 Created status with a path to the new item
    return Results.Created($"/api/contacts/{newContact.Id}", newContact);

});

app.MapGet("/api/contacts/{id:int}" ,(int id) =>
{
    var contact = contacts.FirstOrDefault(c => c.Id==id);

    return contact is not null ? Results.Ok(contact) : Results.NotFound();
});

// 2. PUT (Full Update)
app.MapPut("/api/contacts/{id:int}", (int id, Contact updatedContact) =>
{
    var contact = contacts.FirstOrDefault(c => c.Id == id);
    if (contact is null) return Results.NotFound();

    if (string.IsNullOrWhiteSpace(updatedContact.Name))
    {
        return Results.BadRequest(new { error = "Name field cannot be left blank." });
    }

    // Overwrite all fields completely
    contact.Name = updatedContact.Name;
    contact.Email = updatedContact.Email;
    contact.Phone = updatedContact.Phone;

    return Results.Ok(contact);
});



// 4. DELETE
app.MapDelete("/api/contacts/{id:int}", (int id) =>
{
    var contact = contacts.FirstOrDefault(c => c.Id == id);
    if (contact is null) return Results.NotFound();

    contacts.Remove(contact);
    return Results.NoContent();
});

app.Run();
