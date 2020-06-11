namespace InsecureBindingConfiguration_POC.Models
{
    public class UserDataModel
    {
        public UserDataModel()
        {
            IsAdmin = false;
        }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public bool IsAdmin { get; set; }
    }
}
