public class Solution {
    public int NumberOfSteps(int num) 
    {
        int resCount=0;
        while(num>0){
          /*  if(num %2==0)
            {
                num /=2;
            }
            else{
                num -=1;
            }*/
            if((num & 1) ==0){
                num >>=1;
            }
            else{
                num --;
            }
            resCount++;
        }
        return resCount;
    }
}