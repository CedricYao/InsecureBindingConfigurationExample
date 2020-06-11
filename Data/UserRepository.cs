using InsecureBindingConfiguration_POC.Models;

namespace InsecureBindingConfiguration_POC.Data
{
    public class UserRepository
    {
        private static UserDataModel _theUser;

        static UserRepository()
        {

            _theUser = new UserDataModel { Name = "Cedric", EmailAddress = "cedric.yao@fiserv.net", IsAdmin = false };
        }

        public UserDataModel GetTheUser()
        {
            return _theUser;
        }

        public void Save(UserDataModel user)
        {
            _theUser = user;
        }
    }
}
