public class Solution {
    public int LongestPalindrome(string s)
    {
      
        Dictionary<char,int> map = new Dictionary<char,int>();
        
        foreach(var ch in s){
           if(map.ContainsKey(ch)) map[ch] +=1;
            else
                map.Add(ch,1);
        }
        int ans = 0;
        bool isOdd=false;
        foreach(var v in map)
        {
            if(v.Value %2==0){
                 ans +=v.Value;
            }                
            else
            {
                isOdd=true;
                ans =ans+(v.Value-1);;
            }
           
        }
         if(isOdd)
                ans++;
        return ans;
    }
}