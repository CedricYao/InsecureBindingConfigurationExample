namespace InsecureBindingConfiguration_POC.Models
{
    public static class UserExtensions
    {
        public static UserDataModel MapFrom(this UserDataModel user, UserViewModel viewModel)
        {
            user.EmailAddress = viewModel.EmailAddress;
            user.Name = viewModel.Name;

            return user;
        }
    }
}
