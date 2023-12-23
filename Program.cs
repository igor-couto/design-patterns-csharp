using DesignPatterns.Facade;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

/* Facade */
var orderFacade = new OrderFacade();
app.MapPost("/order", (string userId, string productId, int quantity, decimal amount) => 
{
    bool success = orderFacade.PlaceOrder(userId, productId, quantity, amount);
    return success ? Results.Ok("Order placed successfully.") : Results.BadRequest("Order failed.");
})
.WithName("PlaceOrder")
.WithOpenApi();

app.Run();
