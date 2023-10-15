using TodoAppCli.CreateTodo;

string commandLineArgs = Environment.CommandLine;
string input = commandLineArgs.Substring(commandLineArgs.IndexOf("\"", 1) + 2);

TodoHandler.Process(input);