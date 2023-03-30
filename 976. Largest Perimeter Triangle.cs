public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        int distance=-1;
        int index=-1;
        for(int i=0;i<points.Length;i++)
        {
            if(points[i][0]==x || points[i][1]==y)
            {
                int temp =Math.Abs(points[i][0]-x)+Math.Abs(points[i][1]-y);
                if( distance==-1)
                {
                   distance=temp;
                   index=i;
                }
                else if(distance>temp )
                {
                    distance=temp;
                    index=i;
                }
            }
        }
        return index;
    }
}