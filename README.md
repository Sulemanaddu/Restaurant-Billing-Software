# Restaurant Billing Software

This project is a Windows Forms-based Restaurant Billing Software designed to streamline the billing and management processes for restaurants. The software allows users (admins) to create and manage food items, generate bills, and track orders with ease. It also provides features like billing history, payment methods, and adding/removing food items dynamically.

## Features

- **User Login/Registration**: Secure login system for admins to manage the restaurant's operations.
- **Food Management**: Admins can add, update, and delete food items with types and prices linked to a database.
- **Bill Generation**: Admins can generate bills by selecting food items, quantities, and payment methods (UPI, cash, or card).
- **Payment Options**: Provides various payment methods, including UPI, cash, and card for seamless transactions.
- **Bill History**: Access historical bills, searchable by date and time, for easy tracking.
- **User Interface**: Simple and intuitive UI built with Windows Forms for a smooth user experience.

## Technologies Used

- **C#**: The main programming language used for developing the software.
- **Windows Forms**: For creating the graphical user interface (GUI).
- **SQL Server**: For database management to store and retrieve food items, bills, and user data.
- **Visual Studio 2020**: The integrated development environment (IDE) used to develop and manage the project.

## Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/sulemanaddu/restaurant-billing-software.git
    ```

2. Open the solution file (`.sln`) in Visual Studio 2020.

3. Ensure you have **SQL Server** installed and configured.

4. Set up the database by importing the provided `RestaurantBillingDN2` database or creating your own schema based on the structure in the `Database` folder.

5. Build the project and run the application.

## Usage

1. **Admin Login**: Use the login page to access the admin dashboard.
2. **Add Food Items**: Navigate to the "Add/Update Food" section to add new food items, edit existing ones, or delete them.
3. **Generate Bills**: On the "Billing" page, select food items to generate a bill. Choose the payment method and print the bill.
4. **View Bill History**: Go to the "History" section to search and view previous bills by date and time.


## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-name`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature-name`).
5. Create a new pull request.


## Acknowledgements

- Special thanks to the open-source community for their contributions to Windows Forms, C#, and SQL Server resources.
