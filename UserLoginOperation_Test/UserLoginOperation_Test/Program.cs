using UserLoginOperation_Test.View;

Console.WriteLine("Getting Connection ...");

try
{
    UserConsoleView.Input();
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}

Console.Read();