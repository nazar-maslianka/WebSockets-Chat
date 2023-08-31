using WebSocketServer.Middlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddWebSocketServerConnectionManager();

var app = builder.Build();

app.UseWebSockets();

app.UseWebSocketServer();

app.Run();
