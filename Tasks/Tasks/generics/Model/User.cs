namespace Tasks.generics.Model
{
    public class User : BaseItem
    {
        public string Name { get; init; }

        public string Email { get; init; }

        public Role Role { get; init; }
    }
}
