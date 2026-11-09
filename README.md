# Shopping Basket Price Calculator

A simple C# console application that calculates the total cost of a shopping basket based on item quantities and special promotional offers.

## Problem Statement

The application accepts a list of shopping items, where each item is identified by its name. Items can appear multiple times in the basket.

The program calculates the total price while applying the applicable promotional offers.

## Pricing Rules

| Item | Unit Price | Special Offer |
|---|---:|---|
| Apple | 35p | No offer |
| Banana | 20p | No offer |
| Melon | 50p | Buy One Get One Free |
| Lime | 15p | Three for the Price of Two |

### Offer Calculations

- **Apple:** Quantity × 35p
- **Banana:** Quantity × 20p
- **Melon:** Every two melons cost 50p.
- **Lime:** Every three limes cost 30p.

## Features

- Calculates the total shopping basket cost.
- Handles multiple occurrences of the same item.
- Automatically applies promotional offers.
- Uses dictionaries to efficiently count item quantities.
- Handles empty shopping baskets.
- Rejects unknown item names.
- Includes automated unit tests using xUnit.

## Tech Stack

- **Language:** C#
- **Framework:** .NET
- **Testing Framework:** xUnit
- **Application Type:** Console Application

## Project Structure

```text
ShoppingBasket/
│
├── ShoppingBasket/
│   ├── Program.cs
│   └── ShoppingBasket.csproj
│
├── ShoppingBasket.Tests/
│   ├── ShoppingBasketTests.cs
│   └── ShoppingBasket.Tests.csproj
│
└── ShoppingBasket.sln
```

## Implementation Approach

The application is divided into three main methods:

### 1. CountItems()

Counts the occurrences of each item in the shopping basket using a `Dictionary<string, int>`.

### 2. CalculateItemPrice()

Calculates the price of an individual item type based on its quantity and applicable promotional offer.

### 3. CalculateTotal()

Combines the above methods to calculate and return the final shopping basket cost.

## Getting Started

### Prerequisites

- .NET SDK installed.
- Visual Studio Code, Visual Studio, or any C# compatible IDE.

Download the .NET SDK: https://dotnet.microsoft.com/en-us/download

### Installation

**1. Clone the repository**

```bash
git clone <YOUR_GITHUB_REPOSITORY_URL>
```

**2. Navigate to the project directory**

```bash
cd ShoppingBasket
```

**3. Run the application**

```bash
dotnet run --project ShoppingBasket
```

## Running Unit Tests

The project uses xUnit to verify the correctness of the pricing calculations.

Run the tests using:

```bash
dotnet test ShoppingBasket.Tests
```

### Test Coverage

The test suite covers the following scenarios:

| Test Scenario | Expected Result |
|---|---:|
| One Apple | 35p |
| One Banana | 20p |
| Two Apples | 70p |
| Two Melons | 50p |
| Three Melons | 100p |
| Five Melons | 150p |
| Three Limes | 30p |
| Four Limes | 45p |
| Empty Basket | 0p |
| Mixed Basket | 235p |
| Unknown Item | Exception |
| Null Basket | Exception |

## Sample Input

```csharp
List<string> basket = new List<string>
{
    "Apple",
    "Apple",
    "Banana",
    "Melon",
    "Melon",
    "Melon",
    "Lime",
    "Lime",
    "Lime",
    "Lime"
};
```

## Sample Output

```text
Total shopping cost: 235p
```

## Error Handling

- An empty basket returns `0`.
- An unknown item throws an `ArgumentException`.
- A null basket throws an `ArgumentNullException`.

## Author

**Bhavya Natani**

Full Stack Developer
