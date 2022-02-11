using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {

            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
                
                    return false;
           
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            var sum = numbers.Sum();
            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            foreach (var ch in password)
            {
                if (char.IsLower(ch))
                {

                    isLower = true;
                }

                if (char.IsUpper(ch))
                {

                    isUpper = true;
                }

                if (char.IsNumber(ch))
                {
                    isNumber = true;
                }
                
            }

            if (isLower && isUpper && isNumber)
            {
                return true;
            }
            
            return false;
                        
        }


        public char GetFirstLetterOfString(string val)
        {
            return val[0]; 

            //LINQ way
            // return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];


            //LINQ way
            // return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
            
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
            
            // return nums[nums.Length - 1] - nums[0];    // Other way to do it. nums.Length was supplemented with ^.
        }

        public int[] GetOddsBelow100()
        {
            var oddslist = new List<int>();
            for (var i = 1; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    oddslist.Add(i);
                }
                
            }

            return oddslist.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
