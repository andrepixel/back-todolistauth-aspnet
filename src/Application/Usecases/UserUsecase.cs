class CreateUserUsecase
{
    private required IUserRepository repository;

    public void UserUsecase(IUserRepository repository)
    {
        this.repository = repository;
    }

    public UserEntity Execute(UserEntity entity)
    {
        UserEntity userEntity = repository.CreateUser(entity);

        return userEntity;
    }
}