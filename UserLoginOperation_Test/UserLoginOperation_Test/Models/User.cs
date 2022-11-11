namespace UserLoginOperation_Test.Models
{
    public  class User
    {
        public Guid UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public Role UserRole { get; set; }


    }
}
