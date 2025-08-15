namespace user_mcp.Services.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Retrieves all user profiles associated with this id.
        /// </summary>
        /// <param name="Id">The user’s unique id or email.</param>
        /// <returns>A list of matching users.</returns>
        Task<List<User>> GetByIdAsync(string Id);
    }
}
