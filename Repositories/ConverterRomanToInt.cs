using System;

namespace TPZ.Repositories
{
    public class ConverterRomanToInt
    {
        public ConverterRomanToInt()
        {
            // Empty constructor
        }
        
        public int Convert(string roman)
        {
            if (!IsValid(roman))
            {
                throw new System.ArgumentException("Invalid Roman numeral");
            }
            
            int result = 0;
            int i = 0;
            
            while (i < roman.Length)
            {
                int s1 = Value(roman[i]);
                
                if (i + 1 < roman.Length)
                {
                    int s2 = Value(roman[i + 1]);
                    
                    if (s1 >= s2)
                    {
                        result = result + s1;
                        i++;
                    }
                    else
                    {
                        result = result + s2 - s1;
                        i = i + 2;
                    }
                }
                else
                {
                    result = result + s1;
                    i++;
                }
            }
            
            return result;
        }
        
        private int Value(char r)
        {
            switch (r)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return -1;
            }
        }
        
        public bool IsValid(string roman)
        {
            if (roman == null)
            {
                throw new ArgumentNullException(nameof(roman), "Roman numeral cannot be null");
            }

            if (roman == null || roman.Trim().Length == 0)
            {
                throw new ArgumentException("Roman numeral cannot be null, empty, or whitespace", nameof(roman));
            }

            foreach (var c in roman)
            {
                if (c != 'I' && c != 'V' && c != 'X' && c != 'L' && c != 'C' && c != 'D' && c != 'M')
                {
                    throw new ArgumentException($"Invalid character '{c}' in Roman numeral", nameof(roman));
                }
            }
            
            if (roman.Contains("IIII") || roman.Contains("VV") || roman.Contains("XXXX") || 
                roman.Contains("LL") || roman.Contains("CCCC") || roman.Contains("DD") || 
                roman.Contains("MMMM"))
            {
                throw new ArgumentException("Invalid sequence in Roman numeral", nameof(roman));
            }

            return true;
        }
    }
}