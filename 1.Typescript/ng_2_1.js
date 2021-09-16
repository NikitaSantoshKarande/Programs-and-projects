<<<<<<< HEAD
// 1. Write a typescript program which contains one function named as Maximum. That function accepts array of numbers and returns the largest number from array.
//  Input :  23 89 6 29 56 45 77 32 Output :  Maximum number is 89
function Max() {
    var arr = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        arr[_i] = arguments[_i];
    }
    var i;
    var temp;
    temp = arr[0];
    console.log("Number of arguments are : " + arr.length);
    for (i = 0; i < arr.length; i++) {
        if (temp < arr[i]) {
            temp = arr[i];
        }
    }
    return temp;
}
var arr;
arr = Max(23, 89, 6, 29, 56, 45, 77, 32);
console.log("Maximum Number is :" + arr);
=======
// 1. Write a typescript program which contains one function named as Maximum. That function accepts array of numbers and returns the largest number from array.
//  Input :  23 89 6 29 56 45 77 32 Output :  Maximum number is 89
function Max() {
    var arr = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        arr[_i] = arguments[_i];
    }
    var i;
    var temp;
    temp = arr[0];
    console.log("Number of arguments are : " + arr.length);
    for (i = 0; i < arr.length; i++) {
        if (temp < arr[i]) {
            temp = arr[i];
        }
    }
    return temp;
}
var arr;
arr = Max(23, 89, 6, 29, 56, 45, 77, 32);
console.log("Maximum Number is :" + arr);
>>>>>>> 2d7a72f569719ead3e59056060109095bfe76e8d
