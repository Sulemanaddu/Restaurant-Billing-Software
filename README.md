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

## screenshot 

1.AdminRegistration:- ![Screenshot_20241207_111337](https://github.com/user-attachments/assets/dd67657f-e288-42d4-8438-16919b7df020)
 
2.LoginPage:- ![Screenshot_20241207_111222](https://github.com/user-attachments/assets/7c663067-822b-4edc-aad2-98aab9cdf4fe)

3. Home:- ![Screenshot_20241207_111204](https://github.com/user-attachments/assets/7bd316db-3acb-4d57-a74e-fe969a03a663)
   
4.AddUpdateDelete:- ![Screenshot_20241207_111359](https://github.com/user-attachments/assets/6c3320b9-901f-461a-a61a-f7ab00c31e8c)

5.BillingPage:- ![Screenshot_20241105_032144](https://github.com/user-attachments/assets/4c64a218-0ce8-40f0-8315-64dafc3ed2dc)

6. TotalOrders:-![Screenshot_20241207_111638](https://github.com/user-attachments/assets/17592ead-589c-4553-b25c-bf9139fd8362)
   
7. Bill:- ![Screenshot_20241213_123916](https://github.com/user-attachments/assets/ec742234-86c1-4fe1-b30e-5ac7f2aa4e93)




## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-name`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature-name`).
5. Create a new pull request.


## Acknowledgements

- Special thanks to the open-source community for their contributions to Windows Forms, C#, and SQL Server resources.
for more help contact :- sulemanaddu07@gmail.com
instagram:- @sulemanaddu
