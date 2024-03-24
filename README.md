# Student Information System



This is my project for the Software University. The Student Information System is a web application designed to manage student and course information within a university setting. It provides features for administrators to add and manage universities, faculties, courses, teachers, and students. The system is built using ASP.NET Core and utilizes a relational database for data storage.

To login use the following username and password:
Username: admin@mail.com
Password: admin

## Features

- User Authentication and Authorization:
  - Admin users can register other users (students and teachers).
  - Initial password setup and forced password change on first login.
- University and Faculty Management:
  - Admins can add and manage universities and faculties.
- Course Management:
  - Admins can add, edit, and delete courses.
  - Assign teachers to courses and manage student enrollment.
- Student and Teacher Management:
  - Admins can manage student and teacher details.
  - Students can upload profile pictures.
- Email Notifications:
  - Automatic email to users when they are added to the system.
- Responsive Web Design:
  - Bootstrap framework used for a clean and mobile-friendly user interface.

## Getting Started

Follow these instructions to get the project up and running on your local machine.

## Installation

1. Clone the repository:

```
git clone https://github.com/your-username/student-information-system.git
```

2. In the appsettings.json set your connection string
3. Update the database to the latest migration using the following command in the package manager
```
Update-Database
```
4. Start Application with ctr+f5
5. The app has a seeded admin user you can use him
   Credentials:
    email: admin@mail.com
    pass:  admin  
6. Enjoy


##Technologies used
-ASP.NET Core
-Entity Framework Core
-Bootstrap
-SQL Server (or your preferred relational database)

##How to use the app

In order to login and start using the functionalities login with the following credentials
Username: admin@mail.com
password: admin

## Contributing

Contributions are welcome! If you encounter issues or have suggestions for improvements, please open an issue on this repository. If you'd like to contribute code, follow these steps:

1. Fork the repository by clicking the "Fork" button on the top right corner of this page.
2. Clone your forked repository to your local machine:

```bash
git clone https://github.com/your-username/student-information-system.git
