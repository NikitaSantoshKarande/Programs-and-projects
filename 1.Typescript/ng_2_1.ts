// 1. Write a typescript program which contains one function named as Maximum. That function accepts array of numbers and returns the largest number from array.
//  Input :  23 89 6 29 56 45 77 32 Output :  Maximum number is 89
function Maximum(...arr:number[]):number
{  
    var i:number;
    var temp:number;
    temp=arr[0];
    console.log("Number of arguments are : "+arr.length);
     
    for(i = 0; i<arr.length; i++) 
    { 
       if(temp<arr[i])
       {
           temp=arr[i];
       }
    } 
    return temp; 
} 
var arr:number;
arr = Maximum(23,89,6,29,56,45,77,32);
console.log("Maximum Number is :"+arr);