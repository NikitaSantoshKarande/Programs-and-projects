// 4. Write a typescript program which contains one arrow function named as ChkArmstrong. That 
// function accepts one numbers and check whether number is Armstrong number or not. 
// Input : 153 
// Output : It is Armstrong number

function ChkArmstrong(No: number): boolean {
    var Sum: number = 0;
    var rem: number = 0;
    var temp:number=0;

    temp = No;

    while (temp > 0) {
        rem = temp % 10;
        Sum = Sum + (rem * rem * rem);
        temp = parseInt(temp / 10);
        rem = 0;
    }

    if (No == Sum) {
        return true;
    }
    else {
        return false;
    }
}

var ret: boolean = false;
ret = ChkArmstrong(153);
if (ret == true) {
    console.log("It is Armstrong number");
}
else {
    console.log("It is not Armstrong number");
}