using DesignPatterns.Facade;
using DesignPatterns.Adapter;
using DesignPatterns.Adapter.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

/* Facade */
app.MapPost("/facade/order", (string userId, string productId, int quantity, decimal amount) => 
{
    var orderFacade = new OrderFacade();
    var success = orderFacade.PlaceOrder(userId, productId, quantity, amount);
    return success ? Results.Ok("Order placed successfully.") : Results.BadRequest("Order failed.");
})
.WithName("PlaceOrder")
.WithOpenApi();

/* Adapter */
app.MapPost("/adapter/pay", (string orderId, string cardNumber, float amount) => 
{
    IExistingPaymentService paymentService; // This can't change. However, the new PaymentService is different. Hence the Adapter Pattern.
    paymentService = new PaymentServiceAdapter();
    paymentService.ProcessCreditCard(orderId, cardNumber, amount);
})
.WithName("PayOrder")
.WithOpenApi();

app.Run();
