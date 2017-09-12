using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[] A) {
        
        int result = 0;
        int len = A.Length;        
        
        char[] sol = new char[len];        
        
        for(int i = 0; i<len; i++){         
            if(A[i]-1<len){            
                sol[A[i]-1] = 'x';  
                //Console.WriteLine("sol[" + (A[i]-1) + "]");
            }
        }
        
        string joined = new string(sol);                
        result = (joined.IndexOf("\0") == -1) ? 1 : 0;
        
        return result;
    }
}
