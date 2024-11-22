interface IUserRepository
{
    public Task<List<UserEntity>?> GetAllUsers();
    public Task<UserEntity?> GetUserById(Guid id);
    public Task<UserEntity?> CreateUser(UserEntity userEntity);
    public Task<UserEntity?> UpdateUser(UserEntity userEntity);
    public Task<UserEntity?> DeleteUserById(UserEntity userEntity);
}