# UserManagementAPI

A simple ASP.NET Core Web API for managing users (CRUD).

## Endpoints
- GET /api/users → Get all users
- GET /api/users/{id} → Get user by ID
- POST /api/users → Create new user
- PUT /api/users/{id} → Update user
- DELETE /api/users/{id} → Delete user

## Copilot Contribution
- Generated boilerplate code (`Program.cs`)
- Suggested repository pattern
- Helped fix logic errors (like assigning IDs)
- Provided testing strategy with Postman

## How to Run
This project is structured for .NET 8.0. Clone the repo and run:
```bash
dotnet run


## Debugging with Copilot

Copilot helped identify and fix several issues:
- Suggested adding `[Required]` and `[EmailAddress]` validation attributes to the User model.
- Recommended wrapping controller logic in try-catch blocks to prevent crashes.
- Proposed using `Dictionary<int, User>` instead of `List<User>` for faster lookups.
- Helped generate meaningful error messages for invalid requests.
