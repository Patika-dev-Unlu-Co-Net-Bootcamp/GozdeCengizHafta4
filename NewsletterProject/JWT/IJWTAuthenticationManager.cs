using NewsletterProject.Models.ViewModels;

namespace NewsletterProject.JWT
{
    public interface IJWTAuthenticationManager
    {
        string Authenticate(LoginUserViewModel userViewModel);
    }
}
