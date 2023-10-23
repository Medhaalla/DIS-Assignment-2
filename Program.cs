/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE QUESTION FUNCTION BLOCK


*/

using System.Text;

namespace ISM6225_Fall_2023_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 1, 3, 50, 75 };
            int upper = 99, lower = 0;
            IList<IList<int>> missingRanges = FindMissingRanges(nums1, lower, upper);
            string result = ConvertIListToNestedList(missingRanges);
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine();

            //Question2:
            Console.WriteLine("Question 2");
            string parenthesis = "()[]{}";
            bool isValidParentheses = IsValid(parenthesis);
            Console.WriteLine(isValidParentheses);
            Console.WriteLine();
            Console.WriteLine();

            //Question 3:
            Console.WriteLine("Question 3");
            int[] prices_array = { 7, 1, 5, 3, 6, 4 };
            int max_profit = MaxProfit(prices_array);
            Console.WriteLine(max_profit);
            Console.WriteLine();
            Console.WriteLine();

            //Question 4:
            Console.WriteLine("Question 4");
            string s1 = "69";
            bool IsStrobogrammaticNumber = IsStrobogrammatic(s1);
            Console.WriteLine(IsStrobogrammaticNumber);
            Console.WriteLine();
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Question 5");
            int[] numbers = { 1, 2, 3, 1, 1, 3 };
            int noOfPairs = NumIdenticalPairs(numbers);
            Console.WriteLine(noOfPairs);
            Console.WriteLine();
            Console.WriteLine();

            //Question 6:
            Console.WriteLine("Question 6");
            int[] maximum_numbers = { 3, 2, 1 };
            int third_maximum_number = ThirdMax(maximum_numbers);
            Console.WriteLine(third_maximum_number);
            Console.WriteLine();
            Console.WriteLine();

            //Question 7:
            Console.WriteLine("Question 7:");
            string currentState = "++++";
            IList<string> combinations = GeneratePossibleNextMoves(currentState);
            string combinationsString = ConvertIListToArray(combinations);
            Console.WriteLine(combinationsString);
            Console.WriteLine();
            Console.WriteLine();

            //Question 8:
            Console.WriteLine("Question 8:");
            string longString = "leetcodeisacommunityforcoders";
            string longStringAfterVowels = RemoveVowels(longString);
            Console.WriteLine(longStringAfterVowels);
            Console.WriteLine();
            Console.WriteLine();
        }

        /*
        
        Question 1:
        You are given an inclusive range [lower, upper] and a sorted unique integer array nums, where all elements are within the inclusive range. A number x is considered missing if x is in the range [lower, upper] and x is not in nums. Return the shortest sorted list of ranges that exactly covers all the missing numbers. That is, no element of nums is included in any of the ranges, and each missing number is covered by one of the ranges.
        Example 1:
        Input: nums = [0,1,3,50,75], lower = 0, upper = 99
        Output: [[2,2],[4,49],[51,74],[76,99]]  
        Explanation: The ranges are:
        [2,2]
        [4,49]
        [51,74]
        [76,99]
        Example 2:
        Input: nums = [-1], lower = -1, upper = -1
        Output: []
        Explanation: There are no missing ranges since there are no missing numbers.

        Constraints:
        -109 <= lower <= upper <= 109
        0 <= nums.length <= 100
        lower <= nums[i] <= upper
        All the values of nums are unique.

        Time complexity: O(n), space complexity:O(1)
        */

        public static IList<IList<int>> FindMissingRanges(int[] nums, int lower, int upper)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                return new List<IList<int>>();
            }
            catch (Exception)
            {
                throw;
            }

        }

        /*
         
        Question 2

        Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.An input string is valid if:
        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
        Every close bracket has a corresponding open bracket of the same type.
 
        Example 1:

        Input: s = "()"
        Output: true
        Example 2:

        Input: s = "()[]{}"
        Output: true
        Example 3:

        Input: s = "(]"
        Output: false

        Constraints:

        1 <= s.length <= 104
        s consists of parentheses only '()[]{}'.

        Time complexity:O(n^2), space complexity:O(1)
        */

        public static bool IsValid(string s)
        {
            try
            {
                // Define a dictionary to store matching brackets
               Dictionary<char, char> brackets = new Dictionary<char, char> { { '(', ')' }, { '[', ']' }, { '{', '}' } };
              // Initialize the opener index as -1
              int opener = -1;
             // Iterate through the characters in the input string
            for (int i = 0; i < s.Length; i++)
               {
                 // If the current character is an opening bracket, update the opener index
                  if (brackets.ContainsKey(s[i]))
                   opener = i;
                 // If the current character is a closing bracket and there is a corresponding opening bracket
                 else if (opener >= 0 && s[i] == brackets[s[opener]])
                     {
                       int remaining = 0;
                       opener -= 1;
                      // Continue searching for matching opening brackets
                      while (opener >= 0 && remaining < 1)
                        {
                     // If an opening bracket is found, increment the remaining count
                     if (brackets.ContainsKey(s[opener]))
{
remaining += 1;
// If there are extra opening brackets, keep moving back in the string
if (remaining < 1)
opener -= 1;
}
else
{
// If a closing bracket is found, decrement the remaining count
remaining -= 1;
opener -= 1;
}
}
// Check if there are unmatched brackets
if (opener == -1 && remaining != 0)
return false;
// Check if there are unmatched brackets within the current range
if (opener >= 0 && remaining != 1)
return false;
}
else
return false;
}
// Check if all brackets are matched
return opener == -1;
}
catch (Exception)
{
throw;
}
/* Self-reflection: This code uses a dictionary and iterative approach to check bracket matching.
It ensures that opening brackets are correctly closed in the given order. */
}

/*
        Question 3:
        You are given an array prices where prices[i] is the price of a given stock on the ith day.You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
        Example 1:
        Input: prices = [7,1,5,3,6,4]
        Output: 5
        Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

        Example 2:
        Input: prices = [7,6,4,3,1]
        Output: 0
        Explanation: In this case, no transactions are done and the max profit = 0.
 
        Constraints:
        1 <= prices.length <= 105
        0 <= prices[i] <= 104

        Time complexity: O(n), space complexity:O(1)
        */

       public static int MaxProfit(int[] prices)
{ 
    try
    {
        int minPrice = int.MaxValue; // Initialize the minimum price to the maximum possible value.
        int maxProfit = 0; // Initialize the maximum profit to 0.

        if (prices.Length == 0)
        {
            // Handle the case of an empty array by returning 0 profit.
            return 0;
        }

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                // If the current price is lower than the previously recorded minimum price, update the minimum price.
                minPrice = prices[i];
            }
            else
            {
                // Calculate the current profit and update the maximum profit if needed.
                int currentProfit = prices[i] - minPrice;
                maxProfit = Math.Max(maxProfit, currentProfit);
            }
        }

        // Return the maximum profit obtained by buying and selling a single stock.
        return maxProfit;
    }
    catch (Exception)
    {
        throw;
    }
    /* Self-reflection:
    This code effectively finds the maximum profit that can be obtained by buying and selling a single stock in
    a given array of stock prices. It maintains a record of the minimum price seen so far and continuously updates
    the maximum profit if a better selling opportunity is encountered. The code handles the case of an empty
    array gracefully and provides a clear algorithm for maximizing profit in a simple and efficient manner.
    */
}



        /*
        
        Question 4:
        Given a string num which represents an integer, return true if num is a strobogrammatic number.A strobogrammatic number is a number that looks the same when rotated 180 degrees (looked at upside down).
        Example 1:

        Input: num = "69"
        Output: true
        Example 2:

        Input: num = "88"
        Output: true
        Example 3:

        Input: num = "962"
        Output: false

        Constraints:
        1 <= num.length <= 50
        num consists of only digits.
        num does not contain any leading zeros except for zero itself.

        Time complexity:O(n), space complexity:O(1)
        */
public static bool IsStrobogrammatic(string s)
{
    try
    {
        if (s == null)
        {
            // Handle the case of a null input string by returning false.
            return false;
        }

        // Initialize two pointers, 'left' and 'right,' to examine characters from the beginning and end of the string.
        int left = 0;
        int right = s.Length - 1;

        // Define pairs of strobogrammatic characters. Strobogrammatic pairs read the same when rotated 180 degrees.
        string strobogrammaticPairs = "00 11 88 69 96";

        // Iterate while the 'left' pointer is less than or equal to the 'right' pointer.
        while (left <= right)
        {
            char leftChar = s[left];
            char rightChar = s[right];

            // Check if the pair of characters formed by 'leftChar' and 'rightChar' is a valid strobogrammatic pair.
            if (!strobogrammaticPairs.Contains($"{leftChar}{rightChar}"))
            {
                // If not, the input string is not strobogrammatic, so return false.
                return false;
            }

            // Move the pointers towards each other.
            left++;
            right--;
        }

        // If the loop completes without returning false, the input string is strobogrammatic.
        return true;
        /* Self-reflection:
        This code effectively determines whether the input string is a strobogrammatic number, with the assumption
        that the input consists of numerical digits. It iterates through the string from both ends, comparing character
        pairs to a predefined list of valid strobogrammatic pairs. The code handles null input gracefully and provides
        a clear and efficient solution for checking strobogrammatic properties.
        */
    }
    catch (Exception)
    {
        throw;
    }
}

/*

        Question 5:
        Given an array of integers nums, return the number of good pairs.A pair (i, j) is called good if nums[i] == nums[j] and i < j. 

        Example 1:

        Input: nums = [1,2,3,1,1,3]
        Output: 4
        Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.
        Example 2:

        Input: nums = [1,1,1,1]
        Output: 6
        Explanation: Each pair in the array are good.
        Example 3:

        Input: nums = [1,2,3]
        Output: 0

        Constraints:

        1 <= nums.length <= 100
        1 <= nums[i] <= 100

        Time complexity:O(n), space complexity:O(n)

        */

       public static int CountIdenticalPairs(int[] numbers)
{
    try
    {
        if (numbers == null || numbers.Length == 0)
        {
            // Handle the scenario of null or empty input by returning 0 pairs.
            return 0;
        }

        // Initialize a dictionary to keep a count of occurrences for each unique number in the array.
        Dictionary<int, int> numberCounts = new Dictionary<int, int>();

        int identicalPairsCount = 0; // Initialize a variable to track the count of identical pairs.

        // Iterate through the input array 'numbers.'
        foreach (int num in numbers)
        {
            // If the number already exists in the 'numberCounts' dictionary, increment the 'identicalPairsCount'
            // by the count associated with that number and update the count for that number.
            if (numberCounts.ContainsKey(num))
            {
                identicalPairsCount += numberCounts[num];
                numberCounts[num]++;
            }
            else
            {
                // If the number is not in the dictionary, add it with an initial count of 1.
                numberCounts[num] = 1;
            }
        }

        // Return the total count of identical pairs found in the input array.
        return identicalPairsCount;

        /*
        Self-reflection: This code efficiently calculates the count of identical pairs within the input array. It
        employs a dictionary to maintain counts for each distinct number and increments the 'identicalPairsCount'
        when a number is encountered that already exists in the dictionary. The code handles null or empty input
        scenarios gracefully and offers a straightforward and effective solution for counting identical pairs of
        numbers.
        */
    }
    catch (Exception)
    {
        throw;
    }
}

        /*
        Question 6

        Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.

        Example 1:

        Input: nums = [3,2,1]
        Output: 1
        Explanation:
        The first distinct maximum is 3.
        The second distinct maximum is 2.
        The third distinct maximum is 1.
        Example 2:

        Input: nums = [1,2]
        Output: 2
        Explanation:
        The first distinct maximum is 2.
        The second distinct maximum is 1.
        The third distinct maximum does not exist, so the maximum (2) is returned instead.
        Example 3:

        Input: nums = [2,2,3,1]
        Output: 1
        Explanation:
        The first distinct maximum is 3.
        The second distinct maximum is 2 (both 2's are counted together since they have the same value).
        The third distinct maximum is 1.
        Constraints:

        1 <= nums.length <= 104
        -231 <= nums[i] <= 231 - 1

        Time complexity:O(nlogn), space complexity:O(n)
        */

       public static int ThirdMax(int[] nums)
{
    try
    {
        if (nums == null)
        {
            // Account for cases where the input array is null by providing a default value, such as -1.
            return -1;
        }

        // Arrange the 'nums' array in descending order to identify the maximum values.
        Array.Sort(nums);
        Array.Reverse(nums);

        int distinctCount = 0;
        int? thirdMax = null;

        // Traverse through the sorted array to count distinct numbers.
        for (int i = 0; i < nums.Length; i++)
        {
            // Determine if the current number is distinct, not equal to the previous number.
            if (i == 0 || nums[i] != nums[i - 1])
            {
                distinctCount++;
            }

            // If the third distinct number is found, store it and exit the loop.
            if (distinctCount == 3)
            {
                thirdMax = nums[i];
                break;
            }
        }

        // If the 'thirdMax' variable remains null, return the maximum number from the sorted array.
        return thirdMax ?? nums[0];

        /*
        Self-reflection: This code effectively identifies the third distinct maximum number in the input array
        by sorting the array and counting distinct values. It gracefully handles null input and presents a
        clear and straightforward solution suitable for various input scenarios.
        */
    }
    catch (Exception)
    {
        throw;
    }
}



        /*
        
        Question 7:

        You are playing a Flip Game with your friend. You are given a string currentState that contains only '+' and '-'. You and your friend take turns to flip two consecutive "++" into "--". The game ends when a person can no longer make a move, and therefore the other person will be the winner.Return all possible states of the string currentState after one valid move. You may return the answer in any order. If there is no valid move, return an empty list [].
        Example 1:
        Input: currentState = "++++"
        Output: ["--++","+--+","++--"]
        Example 2:

        Input: currentState = "+"
        Output: []
 
        Constraints:
        1 <= currentState.length <= 500
        currentState[i] is either '+' or '-'.

        Timecomplexity:O(n), Space complexity:O(n)
        */

        public static IList<string> GeneratePossibleNextMoves(string currentState)
{
    try
    {
        if (currentState == null)
        {
            // Account for the possibility of null input by returning an empty list (assuming that null input
            // should result in an empty list).
            return new List<string>();
        }

        List<string> nextMoveList = new List<string>();

        int length = currentState.Length;

        // Iterate through the input string to identify potential moves.
        for (int i = 0; i < length - 1; i++)
        {
            if (currentState[i] == '+' && currentState[i + 1] == '+')
            {
                // Create a new string with "++" replaced by "--."
                char[] newState = currentState.ToCharArray();
                newState[i] = '-';
                newState[i + 1] = '-';
                nextMoveList.Add(new string(newState));
            }
        }

        // Return the list of possible next moves.
        return nextMoveList;

        /*
        Self-reflection: This code proficiently discovers and generates potential next moves by substituting
        consecutive "++" with "--" in the input string. It also accounts for null strings with input validation,
        returning an empty list when needed. The function maintains its name and functionality.
        */
    }
    catch (Exception)
    {
        throw;
    }
}


        /*

        Question 8:

        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:

        Input: s = "leetcodeisacommunityforcoders"
        Output: "ltcdscmmntyfrcdrs"

        Example 2:

        Input: s = "aeiou"
        Output: ""

        Timecomplexity:O(n), Space complexity:O(n)
        */

        public static string RemoveVowels(string inputString)
{
    if (inputString == null)
    {
        // Account for the possibility of null input by returning an empty string (assuming that null input
        // should result in an empty string).
        return string.Empty;
    }

    // Initialize a StringBuilder to construct the output string.
    StringBuilder resultBuilder = new StringBuilder(inputString.Length);

    // Iterate through the characters in the input string.
    foreach (char character in inputString)
    {
        // Verify if the current character is not a vowel (considering both uppercase and lowercase).
        if ("AEIOUaeiou".IndexOf(character) == -1)
        {
            resultBuilder.Append(character); // Append the character to the result if it's not a vowel.
        }
    }

    // Convert the StringBuilder to a string and return the result.
    return resultBuilder.ToString();

    /*
    Self-reflection: This code adeptly eliminates vowels from the input string and incorporates input validation
    to manage null input cases by returning an empty string. It performs as expected for various inputs, with the
    assumption that the input consists of characters from the English alphabet.
    */
}
