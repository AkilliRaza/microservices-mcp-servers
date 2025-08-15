# microservices-mcp-servers
MCP server in .NET C#

# Local Testing
Run your MCP server
dotnet run

in program file 
app.MapMcp("/mcp"); // check launch setting : http://localhost:5278

 http://localhost:5278/mcp

# In Postman
Open Postman (latest version — MCP support is only in recent builds).

Click New → MCP Request.
In the Connection settings:
Protocol: HTTP
Server URL: http://localhost:5278/mcp
Click Connect.

After connecting, Postman will auto-load your MCP tools — in your case, it should show UserTool under Tools.

Pick a method inside UserTool, fill in the parameters, and click Run.
See results in the Response tab.
