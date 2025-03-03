# 🍝 Lasagna Cooking - C# Solution

This repository contains the solution for the **Lasagna Cooking** exercise in C#. The exercise focuses on calculating different time measurements required to cook a lasagna.

## 📜 Description
Lucian needs to prepare an exquisite lasagna for his anniversary. This class helps calculate the required times for cooking and preparation.

## 🛠️ Implementation
The `Lasagna` class includes the following methods:

### 1️⃣ `ExpectedMinutesInOven()`
Returns the expected time in minutes that the lasagna should be in the oven.

### 2️⃣ `RemainingMinutesInOven(int minutesInOven)`
Takes the number of minutes the lasagna has been in the oven and returns how many minutes it still needs to cook.

### 3️⃣ `PreparationTimeInMinutes(int layers)`
Takes the number of layers in the lasagna and returns the preparation time, assuming each layer takes 2 minutes to prepare.

### 4️⃣ `ElapsedTimeInMinutes(int layers, int minutesInOven)`
Takes two parameters:
- `layers`: The number of lasagna layers.
- `minutesInOven`: The time the lasagna has been in the oven.

Returns the total elapsed time, which is the sum of the preparation time and oven time.

## 📂 Project Structure
```
📁 LasagnaCooking
│── 📄 Lasagna.cs    // Class implementation
│── 📄 README.md     // This file
```

## 🚀 How to Run
1. Clone this repository:
   ```sh
   git clone https://github.com/gpalomino91/LasagnaCooking.git
   cd LasagnaCooking
   ```
2. Build the project (ensure you have .NET SDK installed):
   ```sh
   dotnet build
   ```
3. Run the program:
   ```sh
   dotnet run
   ```

## 🏆 Learning Outcomes
This exercise helps improve skills in:
- Using instance methods in C#.
- Performing basic arithmetic operations.
- Implementing clean and efficient code.

---
💡 Feel free to contribute or improve the solution!
📢 Got questions? Open an issue or submit a pull request! 🚀

