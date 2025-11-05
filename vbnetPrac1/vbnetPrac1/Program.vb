Imports System

Module Program
    Sub Main()
        Dim test_name As String
        Dim num1, num2, gsispremium, philhealth, Housingloan, taxrate, grosssalary, totaldeduction, netsalary As Double

        Console.WriteLine("Enter Employee Name: ")
        test_name = Console.ReadLine()
        Console.WriteLine("Enter number of hours rendered: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Enter rate per hour: ")
        num2 = Console.ReadLine()
        Console.WriteLine("GSIS Premium: ")
        gsispremium = Console.ReadLine()
        Console.WriteLine("PhilHealth: ")
        philhealth = Console.ReadLine()
        Console.WriteLine("Housing Loan: ")
        Housingloan = Console.ReadLine()
        Console.WriteLine("Tax rate: " & taxrate.ToString)
        taxrate = Console.ReadLine()

        taxrate = taxrate / 100
        grosssalary = num1 * num2
        totaldeduction = grosssalary * taxrate + gsispremium + philhealth + Housingloan
        netsalary = grosssalary - totaldeduction

        Console.WriteLine(test_name)
        Console.WriteLine("Gross Salary: " & grosssalary.ToString())
        Console.WriteLine("Total deduction: " & totaldeduction.ToString("0.0"))
        Console.WriteLine("Net Salary: " & netsalary.ToString("0.0"))
        Console.ReadLine()
    End Sub

End Module
