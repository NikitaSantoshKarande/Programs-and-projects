// 4. Write a typescript program which contains one function named as ChkPrime. That function should 
// accept one number and it should return true if the given number is prime and otherwise return false. 
// Input : 11 
// Output : It is prime number
function ChkPrime(No1:number):boolean
{  
    var i:number=0;
    if(No1<2)
    {
        return false;
    }
    for(i=2;i<No1;i++)
    {
        if(No1%i==0)
        {
            return false;
        }
    }
    return true;   
} 
var ret:boolean=false;
ret=ChkPrime(11);
if(ret==true)
{
    console.log("prime number");
}
else{
    console.log("Not prime number");
}