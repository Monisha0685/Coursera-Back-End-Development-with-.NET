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

## Debugging with Copilot

Copilot helped identify and fix several issues:
- Suggested adding `[Required]` and `[EmailAddress]` validation attributes to the User model.
- Recommended wrapping controller logic in try-catch blocks to prevent crashes.
- Proposed using `Dictionary<int, User>` instead of `List<User>` for faster lookups.
- Helped generate meaningful error messages for invalid requests.

## Middleware Implementation

### Logging
- Logs HTTP method, request path, and response status code.

### Error Handling
- Catches unhandled exceptions.
- Returns JSON error responses consistently.

### Authentication
- Validates tokens from request headers.
- Blocks unauthorized requests with 401 responses.

### Pipeline Order
1. Error handling middleware
2. Authentication middleware
3. Logging middleware

## Copilot Contribution
- Generated boilerplate middleware classes.
- Suggested extension methods for clean pipeline configuration.
- Helped enforce correct middleware order.
- Provided fixes for exception handling and token validation logic.

## How to Run
This project is structured for .NET 8.0. Clone the repo and run:
```bash
dotnet run

