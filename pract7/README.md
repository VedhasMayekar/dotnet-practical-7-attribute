# Practical 7 — Controllers and Routing

**Aim:** Handle user requests using controllers and routing.

This ASP.NET Core MVC project demonstrates:
- Attribute routes such as `/student/create` and `/student/details`.
- Conventional routes configured in `Program.cs`.
- A strongly typed Student form.
- Passing a greeting with ViewBag and passing submitted values through TempData.
- A custom conventional route pattern for student details.

## Run
Open `pract7.csproj` in Visual Studio 2026 with the .NET 8 SDK and run the project. The default route opens the student creation form.

Submit the form to store the values temporarily and redirect to the details action. TempData is short-lived and is not a database.
