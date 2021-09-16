// 3. Write a typescript program which contains one function named as Maximum. That function accepts 
// array of numbers and returns the second largest number from array. 
// Input : 23 89 6 29 56 45 77 32 
// Output : Second Maximum number is 77
function Maximum(...arr:number[]):number
{  
    var i:number;
    var Max1:number;
    var Max2:number;
    
    Max1=arr[0];

    for(i = 0; i<arr.length; i++) 
    { 
       if(Max1<arr[i])
       {
           Max2=Max1;
           Max1=arr[i];
       }
       else if(arr[i]>Max2 && arr[i]<Max1)
       {
            Max2=arr[i];
       }
    } 
    return Max2; 
} 
var arr:number;
arr = Maximum(23,89,6,29,56,45,77,32);
console.log("Secound Maximum Number is :"+arr);