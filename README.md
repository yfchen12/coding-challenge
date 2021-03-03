# 9Spokes Coding Challenge Solution

## Overview
This repo contains my solution to the 9Spokes coding challenge, which is a .Net core console app to calculate the common metrics, including:
* Revenue
* Expenses
* Gross Profit Margin
* Net Profit Margin
* Working Capital Ratio

xUnit is used as the unit testing framework. 

## How to run?
To run the program, you will need to clone this feature branch to your local computer, by using the Git command below:
```bash
git clone -b feature/calculate_common_accounting_metrics https://github.com/yfchen12/coding-challenge.git
```

Once the branch is cloned successfully, you can navigate into the git folder to run the program:
```bash
cd coding-challenge
```

### Running the program
Before running the program, please ensure the update version of .Net core is installed on your computer. Otherwise, you can follow the [.NET website](https://dotnet.microsoft.com/download) to download a suitable version. 

To run the program, copy the following command:
```bash
dotnet run --project ./AccountingMetrics/AccountingMetrics/AccountingMetrics.csproj
```

### Running the test
To run the test, copy the following command:
```bash
dotnet test ./AccountingMetrics/AccountingMetrics.Tests/AccountingMetrics.Tests.csproj
```
