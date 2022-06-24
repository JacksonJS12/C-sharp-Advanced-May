using System;
using System.Collections.Generic;
using System.Linq;

public class MealPlan
{
    static void Main(string[] args)
    {
        var meals = new Queue<string>();
        var mealsInput = Console.ReadLine()
            .Split()
            .ToArray();
        foreach (var meal in mealsInput)
        {
            meals.Enqueue(meal);
        }

        var caloriesPerDay = new Stack<int>();
        var caloriesPerDayInput = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        foreach (var dayCalories in caloriesPerDayInput)
        {
            caloriesPerDay.Push(dayCalories);
        }

        int leftCaloriesToday = caloriesPerDay.Peek();
        var caloriesPerDayOutput = new int[] {};
        while (true)
        {
            int diffrance = 0;
            if (meals.Peek() == "salad")
            {
                diffrance = leftCaloriesToday - 350;

                if (diffrance <= 0)
                {
                    leftCaloriesToday -= 350;
                   
                    caloriesPerDay.Pop();
                    if (caloriesPerDay.Count == 0)
                    {
                        meals.Dequeue();
                        break;
                    }
                    leftCaloriesToday = caloriesPerDay.Peek() - Math.Abs(leftCaloriesToday);
                }
                else
                {
                    leftCaloriesToday -= 350;
                }

                meals.Dequeue();
            }
            else if (meals.Peek() == "soup")
            {
                diffrance = leftCaloriesToday - 490;
                if (diffrance <= 0)
                {
                    leftCaloriesToday -= 490;
                    
                    caloriesPerDay.Pop();
                    if (caloriesPerDay.Count == 0)
                    {
                        meals.Dequeue();
                        break;
                    }
                    leftCaloriesToday = caloriesPerDay.Peek() - Math.Abs(leftCaloriesToday);
                }
                else
                {
                    leftCaloriesToday -= 490;
                }

                meals.Dequeue();
            }
            else if (meals.Peek() == "pasta")
            {
                diffrance = leftCaloriesToday - 680;
                if (diffrance <= 0)
                {
                    leftCaloriesToday -= 680;
                   
                    caloriesPerDay.Pop();
                    if (caloriesPerDay.Count == 0)
                    {
                        meals.Dequeue();
                        break;
                    }
                    leftCaloriesToday = caloriesPerDay.Peek() - Math.Abs(leftCaloriesToday);
                }
                else
                {
                    leftCaloriesToday -= 680;
                }

                meals.Dequeue();
            }
            else if (meals.Peek() == "steak")
            {
                diffrance = leftCaloriesToday - 790;
                if (diffrance <= 0)
                {
                    leftCaloriesToday -= 790;
                    
                    caloriesPerDay.Pop();
                    if (caloriesPerDay.Count == 0)
                    {
                        meals.Dequeue();
                        break;
                    }
                    leftCaloriesToday = caloriesPerDay.Peek() - Math.Abs(leftCaloriesToday);
                }
                else
                {
                    leftCaloriesToday -= 790;
                }

                meals.Dequeue();
            }
            if (meals.Count == 0 || caloriesPerDay.Count == 0)
            {
                break;
            }

        }
        if (caloriesPerDay.Count != 0)
        {
            caloriesPerDayOutput = caloriesPerDay.ToArray();
            caloriesPerDayOutput[0] = leftCaloriesToday;
        }
        
        if (meals.Count == 0)
        {
            Console.WriteLine($"John had {mealsInput.Length} meals.");
            Console.WriteLine($"For the next few days, he can eat {string.Join(", ", caloriesPerDayOutput)} calories.");
        }
        else
        {
            Console.WriteLine($"John ate enough, he had {mealsInput.Length-meals.Count} meals.");
            Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
        }
    }
}

