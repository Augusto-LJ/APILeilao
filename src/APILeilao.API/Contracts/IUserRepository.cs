using APILeilao.API.Entities;

namespace APILeilao.API.Contracts
{
    public interface IUserRepository
    {
        public bool ExistUserWithEmail(string email);
        User GetUserByEmail(string email);
    }
}
