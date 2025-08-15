



using user_mcp.Services.Interfaces;

namespace user_mcp.MCP_Tools
{
    [McpServerToolType]
    public class UserTool : IUserTool
    {
        private readonly IUserService _userService;

        public UserTool(IUserService userService)
        {
            _userService = userService;
        }

        [McpServerTool(Name = "GetByUserId"), Description("Get user by ID.")]
        public async Task<List<User>> GetByUserIdAsync([Description("The user's unique Id or email.")] string Id)
        {
            return await _userService.GetByIdAsync(Id);
        }
    }
}
