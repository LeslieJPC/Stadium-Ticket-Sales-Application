# Ticket Sales Application

## Overview
The **Stadium Ticket Sales Application** is a Windows Forms application designed to calculate the total sales for different types of tickets. The application processes the number of tickets sold for three categories, computes the total revenue, and displays the results in a user-friendly interface.

## Features
- Input fields for the number of tickets sold in three categories: A, B, and C.
- Calculation of total revenue based on ticket prices.
- Display of individual category totals and the overall total in currency format.
- Buttons to process data, clear inputs, and exit the application.

## Code Structure
The application is developed in C# using Windows Forms. Below is a brief description of the main components and their functionality.

### Variables
- `ATix`: Price for category A tickets ($15).
- `BTix`: Price for category B tickets ($12).
- `CTix`: Price for category C tickets ($9).
- `TotA`, `TotB`, `TotC`, `TotR`: Variables to store the total revenue for each category and the overall total.
- `IntegerNum`: Boolean to validate input as an integer.

### Methods
- `Form1()`: Constructor to initialize components.
- `button1_Click()`: Event handler for the "Process Data" button.
  - Calls `GetInput()`, `ProcessData()`, and `OutputData()` methods.
- `GetInput()`: Validates and retrieves the number of tickets sold from text boxes.
- `ProcessData()`: Computes the total revenue for each category and the overall total.
- `OutputData()`: Displays the computed totals in the respective labels.
- `button2_Click()`: Event handler for the "Clear All" button.
  - Calls the `Reset()` method.
- `Reset()`: Clears all input fields and result labels.
- `button3_Click()`: Event handler for the "Exit" button.
  - Displays a message and closes the application.

## Getting Started

### Prerequisites
- .NET Framework (version 4.7.2 or higher)
- Visual Studio (or any C# compatible IDE)

### Installation
1. Clone the repository:
    ```sh
    git clone https://github.com/LeslieJPC/TicketSalesApp.git
    ```
2. Open the project in Visual Studio.
3. Build the solution to restore dependencies and compile the application.
4. Run the application.

### Usage
1. Enter the number of tickets sold for categories A, B, and C in the respective text boxes.
2. Click the "Process Data" button to calculate the total revenue. The results will be displayed in the labels.
3. To clear all inputs and results, click the "Clear All" button.
4. To exit the application, click the "Exit" button.

## License
This project is licensed under the MIT License. See the `LICENSE` file for more details.

## Author
- Leslie

Feel free to reach out for any questions or contributions. Happy coding!

---

### Note
This application is a sample project intended for learning and demonstration purposes. It may require further enhancements and testing for production use.
