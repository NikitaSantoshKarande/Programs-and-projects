// 1. Write a typescript program which contains one function named as Maximum. That function accepts 
// three parameters and it should returns largest value from three input parameters. 
// Input : 23 89 6 
// Output : Maximum number is 89
function Max(No1:number,No2:number,No3:number):number
{  
    
     if(No1>No2&&No1>No3)
     {
         return No1;
     }
     else if(No2>No1&&No2>No3)
     {
        return No2;
     }
     else{
        return No3;
     }
     
} 
var arr:number;
arr = Max(23,89,6);
console.log("Maximum Number is :"+arr);