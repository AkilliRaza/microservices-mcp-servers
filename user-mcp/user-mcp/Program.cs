using user_mcp.MCP_Tools;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices(builder.Configuration);

// MCP Server registration
builder.Services
    .AddMcpServer(options =>
    {
        options.ServerInfo = new()
        {
            Name = "User Tool Server",
            Version = "1.0.0",
        };
    })
    .WithHttpTransport()
    .WithTools<UserTool>();

var app = builder.Build();

app.MapGet("/", () => "Healthy!");

app.MapMcp("/mcp");

app.Run();
