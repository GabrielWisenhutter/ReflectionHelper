namespace ReflectionHelper
{
    // This is an example of how to instantiate properties of a class that are read-only,
    // meaning they do not have a setter method.
    // In this way, we can define their values, which is particularly useful in scenarios such as unit testing,
    // when there isn't a method available to set the values of these properties.
    public class Example
    {
        public User InitializeUserProperties()
        {
            var user = ReflectionHelper.CreateWithPrivateProperties<User>(
                (nameof(User.Name), "Gabriel Wisenhutter"),
                (nameof(User.Email), "gabrielwisenhutter2015@gmail.com")
            );
            return user;
        }
    }

    public class User
    {
        public string Name { get; }
        public string Email { get; }
    }
}
