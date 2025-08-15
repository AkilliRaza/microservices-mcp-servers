

namespace user_mcp.MCP_Tools.ITools
{
    public interface IUserTool
    {
        /// <summary>
        /// Retrieves all users associated with a given Id.
        /// </summary>
        /// <param name="Id">The user’s unique id or email.</param>
        Task<List<User>> GetByUserIdAsync(string Id);
    }
}
