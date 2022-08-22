public class Solution 
{
    public bool IsIsomorphic(string s, string t) 
    {
     
        Dictionary<char,char> map1 = new Dictionary<char,char>();
        Dictionary<char,char> map2 = new Dictionary<char,char>();
        for(int i=0;i<s.Length;i++)
        {
           if( !map1.ContainsKey (s[i]) && !map2.ContainsKey (t[i]))
           {
                map2.Add(t[i],s[i]);
                map1.Add(s[i],t[i]);
           }
            else if(map1.ContainsKey (s[i])  !=map2.ContainsKey (t[i]))
            {
                return false;
            }
            else if(map2[t[i]] !=s[i] || map1[s[i]] !=t[i] ){
                return false;
            }
           
           
        }
        
       return  true;
        
    }
}