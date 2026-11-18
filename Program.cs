using Week2_Prototype;

// Demonstration of two separate queue ticket objects.
QueueTicket firstTicket = new QueueTicket("Q001", "20260001", "Alex Reyes");
QueueTicket secondTicket = new QueueTicket("Q002", "20260002", "Jamie Cruz");

Console.WriteLine("=== EASY-Q QUEUE TICKET DEMO ===");
Console.WriteLine(firstTicket.GetTicketInfo());
Console.WriteLine(secondTicket.GetTicketInfo());

Console.WriteLine();
Console.WriteLine("1. Calling the first ticket:");
Console.WriteLine($"Call result: {firstTicket.Call()}");
Console.WriteLine(firstTicket.GetTicketInfo());

Console.WriteLine();
Console.WriteLine("2. Starting service for the first ticket:");
Console.WriteLine($"Start service result: {firstTicket.StartService()}");
Console.WriteLine(firstTicket.GetTicketInfo());

Console.WriteLine();
Console.WriteLine("3. Completing the first ticket:");
Console.WriteLine($"Complete result: {firstTicket.Complete()}");
Console.WriteLine(firstTicket.GetTicketInfo());

Console.WriteLine();
Console.WriteLine("4. Testing a rejected action:");
Console.WriteLine("Trying to call the first ticket again after it is completed.");
Console.WriteLine($"Call result: {firstTicket.Call()}");
Console.WriteLine("The action is rejected because a completed ticket cannot be called again.");

Console.WriteLine();
Console.WriteLine("5. Testing the second object:");
Console.WriteLine($"Call result: {secondTicket.Call()}");
Console.WriteLine(secondTicket.GetTicketInfo());
