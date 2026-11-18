# EASY-Q Week 2 OOP Prototype

This console prototype models a queue ticket in **EASY-Q: A Web-Based Digital Queue Management System for Improving Cashier Queue Management at National Teachers College**.

## Files
- `QueueTicket.cs` contains the class, properties, constructor, and methods.
- `Program.cs` creates two ticket objects and tests valid and rejected actions.

## Business rule
A queue ticket must follow the correct service order: **Waiting → Called → In Service → Completed**. A completed ticket cannot be called again. The `Status` property has a private setter, so outside code cannot directly change the status.

## Run
```bash
dotnet run
```

## Expected test results
- First ticket can be called: `True`
- First ticket can start service after being called: `True`
- First ticket can be completed while in service: `True`
- Calling the completed first ticket is rejected: `False`
- Second ticket can be called while waiting: `True`
