

// Simple Login App

var users = new Dictionary<string, string>()
{
	["sheler"] = "123",
	["samira"] = "456p",
	["bahar"] = "a789"
};

int invalidAttempts = 0;

while (true)
{
	Console.Clear();

    Console.WriteLine($"Remain Login Attempts: {invalidAttempts}");

    Console.Write("Username: ");
	var username = Console.ReadLine();
    Console.Write("Password");
	var password = Console.ReadLine();


	if (users.ContainsKey(username) && users[username] == password)
	{
        Console.WriteLine("Welcome to simple login app.");
		Console.ReadKey();
		break;
	}
	else
	{
        Console.WriteLine("Invalid username or password!");
		invalidAttempts--;
		if (invalidAttempts == 0)
		{
            Console.WriteLine("There's no login attempts!");
			break;
		}
		Console.ReadKey();
		continue;
	}












}


