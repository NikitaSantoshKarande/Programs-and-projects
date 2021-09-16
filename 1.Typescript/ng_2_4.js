// 4. Write a typescript program which contains one arrow function named as ChkArmstrong. That 
// function accepts one numbers and check whether number is Armstrong number or not. 
// Input : 153 
// Output : It is Armstrong number
function ChkArmstrong(No) {
    var Sum = 0;
    var rem = 0;
    var temp;
    temp = No;
    rem = temp % 10;
    console.log(" ", rem);
    temp = temp / 10;
    console.log(" ", temp);
    // while (temp > 0) {
    //     Sum = Sum + (rem * rem * rem);
    //     temp = parseInt(temp / 10);
    //     rem = 0;
    // }
    if (No == Sum) {
        return true;
    }
    else {
        return false;
    }
}
var ret = false;
ret = ChkArmstrong(153);
if (ret == true) {
    console.log("It is Armstrong number");
}
else {
    console.log("It is not Armstrong number");
}
