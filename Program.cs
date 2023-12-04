// See https://aka.ms/new-console-template for more information
using ifeanyi_algorithm_solutions.algorithms.arrays;
using ifeanyi_algorithm_solutions.algorithms.stack;

Console.WriteLine("");

//Implementation of Two Sum and Two Sum Boolean
//int[] nums = new int[] { 2, 3, 4, 5 };
//var result = two_sum.two_sum_solution(nums, 6);
//foreach(int res in result)
//{
//    Console.Write(res);
//}
//Console.WriteLine(two_sum.two_sum_solution_bool(nums, 6).ToString());

////Implementation of Max Profit
//int[] nums = new int[] { 2, 6, 3, 11 };
//Console.WriteLine($"The maximum profit is {max_profit.MaxProfit(nums)}");

//Implementation of Valid Parentheses
//Console.WriteLine(valid_parentheses.IsValid("(]"));

//Implementation of Product Array Except Self
int[] nums = new int[] { 2, 3, 4, 5 };
var result = product_array_except_self.ProductArrayExceptSelf(nums);
foreach (int res in result)
{
    Console.WriteLine(res);
}

Console.WriteLine("");


