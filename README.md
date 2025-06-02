# ASPNet-HardwareShop
"A basic hardware store product website built with ASP.NET MVC and role-based access."

# Hardware Store Product Website

This project is a simple hardware store-themed website developed using the ASP.NET MVC framework. It includes user and admin roles with role-based authorization. The system supports basic CRUD operations such as listing, adding, editing, and deleting products.

## 🔧 Technologies Used

- ASP.NET MVC (.NET Framework)
- Entity Framework (Database First)
- ADO.NET Entity Data Model
- Microsoft SQL Server LocalDB
- HTML / CSS / Bootstrap
- C#

## 🚀 Features

- Individual user accounts (Identity)
- Login, registration, and role-based authorization
- Admin panel with:
  - Add product
  - Edit product
  - Delete product
- Regular users can view products only
- Image slider on the homepage
- Database operations with LocalDB

## 🧩 Roles

- **Admin**: Can add, edit, and delete products.
- **User**: Can only view products.

## 🔮 Future Improvements

- Adding proper model validation in form actions (using ModelState.IsValid where missing)
- User comments and product reviews
- Product categories and filtering options
- Admin dashboard with statistics and charts
- Responsive design improvements for mobile devices
- Image upload functionality for products
- Search bar to find products quickly
- Pagination for large product lists
- Email notifications for user actions (e.g., registration confirmation)
