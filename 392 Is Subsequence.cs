public class Solution {
    public bool IsSubsequence(string s, string t) 
    {
        for(int i=0;i<s.Length;i++)
        {
           
          
              
                int index=t.IndexOf(s[i]);
                if(index>=0)
                    t=t.Substring(index+1);
            else 
                return false;
          
        }
        return true;
    }
}