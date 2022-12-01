// See https://aka.ms/new-console-template for more information
Solution s = new Solution();
var lst = new List<string>() { "un", "iqs", "ue" };
var answer = s.MaxLength(lst);
Console.WriteLine(answer);  

public class Solution
{
  public int MaxLength(List<string> lst)
  {
    int max = 0;
    void Dfs(List<string> lst, int index , string str)
    {
      var isUnique = IsUnique(str);
      if(isUnique) max = Math.Max(max, str.Length);
      if (!isUnique || index >= lst.Count) return;

      for (int i = index; i < lst.Count; i++)
        Dfs(lst, i + 1, str + lst[i]);
    }

    bool IsUnique(string str)
    {
      HashSet<char> hash = new HashSet<char>();
      foreach(char c in str)
      {
        if (hash.Contains(c)) return false;
        hash.Add(c);  
      }
      return true;
    }


    Dfs(lst, 0, "");
    return max;
  }


}
