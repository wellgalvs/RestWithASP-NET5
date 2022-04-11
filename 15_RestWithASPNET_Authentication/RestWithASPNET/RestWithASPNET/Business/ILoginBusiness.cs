using RestWithASPNET.Data.VO;

namespace RestWithASPNET.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidadeCredentials(UserVO user);
        TokenVO ValidateCredentials(TokenVO token);
    }
}
