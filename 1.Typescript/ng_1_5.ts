// 5. Write a typescript program which contains one function named as Fibonacci. That function accept 
// one number from user and print Fibonacci series till that number. 
// Input : 21 
// Output : 1 1 2 3 5 8 13 21
function Fibonacci(No1:number)
{  
    var i:number=0;
    var n1:number=0;
    var n2:number=1;
    var temp:number=0;

    for(i=1;i<=No1;i++)
    {
        console.log(" ",+n1);
        if(n1==No1)
        {
            break;
        }
        temp=n1+n2;
        n1=n2;
        n2=temp;
        
    }   
} 
Fibonacci(21);