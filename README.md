# Vulnerable .NET Core Web Application

This is a minimal **ASP.NET Core MVC** application containing intentional security vulnerabilities. The goal is for students to analyze and secure the application by fixing **SQL Injection, XSS, and CSRF vulnerabilities**.

## **Project Structure**
```
VulnerableWebApp/
│── Controllers/
│   ├── HomeController.cs
│   ├── AccountController.cs
│   ├── CommentController.cs
│── Models/
│   ├── User.cs
│── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   ├── Account/
│   │   ├── Login.cshtml
│   ├── Comment/
│   │   ├── Post.cshtml
│── wwwroot/
│── appsettings.json
│── Program.cs
│── VulnerableWebApp.csproj
│── README.md
```

## **Vulnerabilities to Identify & Fix**

### 1️⃣ SQL Injection (Login Page)
- **Issue:** The app constructs raw SQL queries using user input.
- **Fix:** Use **parameterized queries** or **Entity Framework ORM**.

### 2️⃣ Cross-Site Scripting (XSS) (Comment Section)
- **Issue:** User input is directly rendered in HTML.
- **Fix:** Apply **HTML encoding** before rendering input.

### 3️⃣ Cross-Site Request Forgery (CSRF) (Form Submission)
- **Issue:** The form lacks **anti-forgery tokens**.
- **Fix:** Use **ASP.NET Core's built-in anti-forgery tokens**.

## **How to Run the App**
1. Clone the repository:
   ```sh
   git clone https://github.com/your-repo/vulnerable-dotnet-app.git
   cd vulnerable-dotnet-app
   ```
2. Configure the database in `appsettings.json`.
3. Run migrations and seed the database (if applicable).
4. Start the application:
   ```sh
   dotnet run
   ```

## **Security Fixes**
After identifying vulnerabilities, students should apply fixes such as:
- Using **ORM (Entity Framework)** to prevent SQL Injection.
- Encoding **output data** to mitigate XSS.
- Implementing **anti-forgery tokens** for CSRF protection.
