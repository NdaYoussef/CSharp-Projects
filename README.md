# 🧩 CSharp Projects

This repository contains multiple C# console-based projects demonstrating key programming concepts and real-world mini applications.  
Each project is self-contained and focuses on a specific idea or functionality.

---
## 📚 Table of Contents
- [Inventory Management System](#inventory-management-system)
- [Quiz Game](#quiz-game)
- [Task Tracker](#task-tracker)
- [Shopping Project](#shopping-project)
- [How to Run Any Project](#how-to-run-any-project)

---

##  Inventory Management System

A simple C# console application that helps manage products by adding, updating, and viewing inventory details.

###  Features
- Add new products (name, quantity, price)
- Update existing product quantity
- View all products with ID, name, quantity, and price
- Exit the system safely

###  Implementation Details
- Uses a **2D string array** `inventory[numberOfProducts, 3]` to store product data  
- Controlled with a menu-driven loop and switch statements  
- Demonstrates basic **CRUD** logic

---

##  Quiz Game

A fun C# console game that asks the user a few questions and checks if the answers are correct.

###  Features
- Three quiz questions
- Input validation (empty answers not allowed)
- Displays current score after each question
- Shows correct answers when user gets it wrong

### Implementation Details
- Stores data in two arrays: `questions[]` and `answers[]`
- Uses method `IsCorrect()` for answer validation
- Demonstrates loops, conditionals, and exception handling

---

##  Task Tracker

A simple To-Do List application built using C#.  
Allows users to manage tasks directly from the console.

###  Features
- Add new tasks  
- View all tasks  
- Mark tasks as completed  
- Remove tasks  
- Exit application  

###  Implementation Details
- Stores up to 100 tasks in a string array  
- Appends `"----COMPLETED"` to completed tasks  
- Menu-driven logic using switch statements

---

##  Shopping Project

A small console-based shopping management system where users can browse and buy products.

###  Features
- Display available products  
- Add products to cart  
- Calculate total price and checkout  
- Simulate simple e-commerce behavior

###  Implementation Details
- Uses arrays or lists to store product and cart data  
- Demonstrates loops, conditionals, and basic OOP  
- Simulates shopping flow: Browse → Add → Checkout  

---

## ⚙️ How to Run Any Project

1. **Clone the repository**
   ```bash
   git clone https://github.com/NdaYoussef/CSharp-Projects.git
   cd CSharp-Projects

