namespace LeetCodeSolutions.Solutions
{
    class Problem151
    {
        public string ReverseWords(string s)
        {
            string result = "";
            string[] array = s.Trim().Split(' ');

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(array[i]))
                {
                    result += array[i] + " ";
                }
            }

            return result.TrimEnd();
        }
    }
}
