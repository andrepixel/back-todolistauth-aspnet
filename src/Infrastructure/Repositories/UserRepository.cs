// using Microsoft.EntityFrameworkCore;

// class UserRepository : IUserRepository
// {
//     private readonly AppDbContext context;

//     public UserRepository(AppDbContext context)
//     {
//         this.context = context;
//     }

//     public async Task<UserEntity?> CreateUser(UserEntity userEntity)
//     {
//         var respondeDatabase = await context.Users.AddAsync(userEntity);

//         await context.SaveChangesAsync();

//         return respondeDatabase.Entity;
//     }

//     public async Task<List<UserEntity>?> GetAllUsers()
//     {
//         return await context.Users.ToListAsync();
//     }

//     public async Task<UserEntity?> GetUserById(Guid id)
//     {
//         return await context.Users.FindAsync(id);
//     }

//     public async Task<UserEntity?> UpdateUser(UserEntity userEntity)
//     {
//         var responseDatabase = context.Users.Update(userEntity);

//         await context.SaveChangesAsync();

//         return responseDatabase.Entity;
//     }

//     public async Task<UserEntity?> DeleteUserById(UserEntity userEntity)
//     {
//         var respondeDatabase = context.Users.Remove(userEntity);

//         await context.SaveChangesAsync();

//         return respondeDatabase.Entity;
//     }
// }