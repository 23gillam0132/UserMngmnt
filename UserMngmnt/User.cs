using UserMngmnt;

List<User> users = new();
Home();
void Home()
{
    Console.Clear();
    Console.WriteLine("Welcome.");
    Console.WriteLine("1. Create user.");
    Console.WriteLine("2. Login.");
    Console.WriteLine("3. View Users.");
    string input = Console.ReadLine();
    switch(input)
    {
        case "1":
            CreateUser();
            break;
        case "2":
            Login();
            break;
        case "3":
            ViewUsers();
            break;
    }
}
void CreateUser()
{
    Console.WriteLine("Create a username");
    string inputUser = Console.ReadLine();
    Console.WriteLine("Create a password");
    string inputPw = Console.ReadLine();
    Console.WriteLine("Choose 'Admin' 'User' 'Guest'");
    string input = Console.ReadLine();
    if (String.Equals(input, "Admin", StringComparison.CurrentCultureIgnoreCase))
    {
        users.Add(new Administrator(inputUser, inputPw));
    } else if (String.Equals(input, "User", StringComparison.CurrentCultureIgnoreCase))
    {
        users.Add(new User(inputUser, inputPw));
    } else
    {
        users.Add(new Guest(inputUser, inputPw));
    }
    
    Console.WriteLine("Created user");
    Console.ReadKey();
    Home();
}
void Login()
{
    Console.WriteLine("Type a username to log in.");
    foreach(User user in users)
    {
        Console.WriteLine(user.user);
    }
    string input = Console.ReadLine();
    foreach(User user in users)
    {
        if (input == user.user)
        {

        }
    }
}

void ViewUsers()
{
    Console.WriteLine("Admins:");
    foreach (User user in users)
    {
        
        if (user is Administrator)
        {
            Console.WriteLine(user.user);
        }
        
    }
    Console.WriteLine("Users:");
    foreach (User user in users)
    {
        if (user is User)
        {
            Console.WriteLine(user.user);
        }
    }
    Console.WriteLine("Guests:");
    foreach (User user in users)
    {
        if (user is Guest)
        {
            Console.WriteLine(user.user);
        }
    }
    Console.ReadKey();
    Home();
}