//  Ways to print in JavaScript
// console.log("Hello World");
// alert("aleart");
// document.write("this is document write in a browser")

// Javascript console API
// console.log("Hello World", 4 + 6, "Another log");
// console.warn("this is warning");
// console.error("This is an error");

/*
multi 
line 
commment
*/

var number1 = 34;
var number2 = 56;
// console.log(number1 + number2);

// Data types in JavaScript
let number=0;  //local scope

// Numbers
var num1 = 455;  //global scope
var num2 = 56.76;

// String
var str1 = "This is a string";
var str2 = 'This is also a string';


// Objects
var marks = {
    om:95,
    nikita: 86,
    tanmay:98.8
}
// console.log(marks);  o/p=>{om: 95, nikita:86, tanmay:98.8}




// Booleans
var a = true;
var b = false;
// console.log(a, b);  //o/p=true false



// var und = undefined;
var und;
// console.log(und);//   o/p=undefined



var n = null;
// console.log(n);  //o/p=null

/*
At a very high level, there are two types of data types in JavaScript
1. Primitive data types: undefined, null, number, string, boolean, symbol
2. Reference data types: Arrays and Objects
*/


// var arr = [1, 2, "bablu", 4, 5]
// console.log(arr)    //o/p=>(5) [1, 2, "bablu", 4, 5]


// **********************************************************************

// Operators in JavaScript
// Arithmetic Operators
var a = 100;
var b = 10;
// console.log("The value of a + b is ", a+b); //The value of a + b is  110
// console.log("The value of a - b is ", a-b);
// console.log("The value of a * b is ", a*b);
// console.log("The value of a / b is ", a/b);

// Assignment Operators
var c = b;
// c += 2;
// c -= 2; // c = c - 2;
// c *= 2;
// c /= 2;
// console.log(c);

// Comparison Operators
var x = 34;
var y = 56;
// console.log(x == y);     //false
// console.log(x >= y);     //false
// console.log(x <= y);
// console.log(x > y);
// console.log(x < y);

// Logical Operators

// Logical and
// console.log(true && true)    //true
// console.log(true && false)
// console.log(false && true)
// console.log(false && false)

// Logical or
// console.log(true || true)
// console.log(true || false)
// console.log(false || true)
// console.log(false || false)

// Logical not
// console.log(!false); //true
// console.log(!true);


// Function in JavaScript
function avg(a, b) {
    c = (a + b) / 2;
    return c;
}
c1 = avg(4, 6);
c2 = avg(14, 16);
// console.log(c1, c2);


// Conditionals in JavaScript
/*
var age = 41;
// Single if statement
if(age > 18){
    console.log('You can drink rasna water');
}
// if - else statement
// if(age > 18){
//     console.log('You can drink rasna water');
// }
// else{
//     console.log('You cannot drink rasna water');
// }


age = 25;
// if-else Ladder
if(age > 32){
    console.log("You are not a kid");
}
else if(age >26){
    console.log("Bachhe nahi rahe");
}
else if(age >22){
    console.log("Yes Bachhe nahi rahe");
}
else if(age >18){
    console.log("18 Bachhe nahi rahe");
}
else{
    console.log("Bachhe rahe");
}
console.log("End of ladder");
*/


//array
var arr = [1, 2, 3, 4, 5, 6, 7];
// console.log(arr);
// for(var i=0;i<arr.length;i++){
//     if(i==2){
//         // break;
//         continue;
//     }
//     console.log(arr[i])
// }


//forEach loop
var arr = [1, 2, "bablu", 4, 5]
// arr.forEach(function(element){
//     console.log(element);
// })   
 //o/p=>
  1
  2
  bablu
  4
  5



// const ac = 0;
// ac++;           //error
// ac = ac +1;      //error


//while loop
// let j = 0;
// while(j<arr.length){
//     console.log(arr[j]);
//     j ++;
// }


//do while loop
// do{
//     console.log(arr[j]);
//     j++;
// } while (j < arr.length);
// **********************************************************************


// Array Methods
let myArr = ["Fan", "Camera", 34, null, true];

// console.log(myArr.length);   //5

// myArr.pop();      //true - ["Fan", "Camera", 34, null] -remove last elem

// myArr.push("harry")    //5 -  ["Fan", "Camera", 34, null, "harry"]

// myArr.shift()  //"Fan" - ["Camera", 34, null, "harry"] remove first element

// const newLen = myArr.unshift("Harry") //["Harry", "Camera", 34, null, "harry"] //insert first element

// console.log(newLen); //5   new length

// console.log(myArr); ["Harry", "Camera", 34, null, "harry"]


// **********************************************************************

// String Methods in JavaScript
let myLovelyString = "Harry is a good boy good good Harry";
// console.log(myLovelyString.length) //35
// console.log(myLovelyString.indexOf("good"))//11
// console.log(myLovelyString.lastIndexOf("good"))//25
// console.log(myLovelyString.slice(1,4)) //arr

d = myLovelyString.replace("Harry", "Rohan");//"Rohan is a good boy good good Harry"

// d = d.replace("good", "bad");//"Rohan is a bad boy good good Harry"

// console.log(d, myLovelyString)//Rohan is a bad boy good good Harry Harry is a good boy good good Harry

// **********************************************************************


let myDate = new Date();
// console.log(myDate.getTime());//1622367407701
// console.log(myDate.getFullYear());//2021
// console.log(myDate.getDay());0
// console.log(myDate.getMinutes());//6
// console.log(myDate.getHours());15
 
// **********************************************************************


// DOM Manipulation
let elemdom= document.getElementById('click');
// console.log(elemdom);
// look the any id click keyword then it is print on console
//o/p=<buttton id="click">click mi</buttton>

// **********************************************************************
let elemClass1 = document.getElementsByClassName("container")
// console.log(elemClass1);
// look the class name container and it is display on console material
//o/p= HTMLCollection(2) [div.container, div.container]
 //                           0               1
// 0: div.container
// 1: div.container
// length: 2

// **********************************************************************
// elemClass1[0].style.background = "yellow";
//add css 
elemClass1[0].classList.add("bg-primary")
elemClass1[0].classList.add("text-success")


// console.log(elemClass1.innerHTML);
// console.log(elemClass1.innerText); 

// create element help for javascript
// console.log(elemClass1[0].innerHTML);
//o/p = <p>this is my 1st para</p>
// console.log(elemClass1[0].innerText); 
//o/p= this is my 1st para

// **********************************************************************
tn = document.getElementsByTagName('div')
// console.log(tn)
//o/p = HTMLCollection(2) [div.container, div.container]
// 0: div.container
// 1: div.container
// length: 2
// **********************************************************************

tn = document.getElementsByTagName('div');
createdElement = document.createElement('p');
//<p></p>
createdElement.innerText = "This is a created para";
// "This is a created para"
tn[0].appendChild(createdElement);
//o/p=<p>This is a created para</p>
// **********************************************************************

tn = document.getElementsByTagName('div');
createdElement2 = document.createElement('b');
createdElement2.innerText = "This is a created bold";
tn[0].replaceChild(createdElement2, createdElement);
//o/p=This is a created bold
 
// removeChild(element); ---> removes an element


// **********************************************************************
// Selecting using Query
// sel = document.querySelector('.container')
// console.log(sel)  //give the first container class
// sel = document.querySelectorAll('.container')
// console.log(sel)  //give the all container class


// **********************************************************************
//EVENTS
// function clicked(){
//     console.log('The button was clicked');
// }

// window.onload = function(){
//     console.log('The document was loaded')
// }

// *********************************************************************
// Events in JavaScript
// firstContainer.addEventListener('click', function(){
//     document.querySelectorAll('.container')[1].innerHTML = "<b> We have clicked</b>"
//     console.log("Clicked on Container")
// })

// firstContainer.addEventListener('mouseover', function(){
//     console.log("Mouse on Container")
// })

// firstContainer.addEventListener('mouseout', function(){
//     console.log("Mouse out of Container");
// })

// ************************************************************************
// let prevHTML = document.querySelectorAll('.container')[1].innerHTML;
// firstContainer.addEventListener('mouseup', function(){
//     document.querySelectorAll('.container')[1].innerHTML = prevHTML;
//     console.log("Mouse up when clicked on Container");
// })

// firstContainer.addEventListener('mousedown', function(){
//     document.querySelectorAll('.container')[1].innerHTML = "<b> We have clicked</b>"
//     console.log("Mouse down when clicked on Container");
// })
// **************************************************************************

// Arrow Functions second way write to function
// function summ(a, b){
//     return a+b;
// }
summ = (a,b)=>{
    return a+b;
}



// *****************************************************************
logKaro = ()=>{
    document.querySelectorAll('.container')[1].innerHTML = "<b> Set interval fired</b>"
    console.log("I am your log")
}
// SetTimeout and setinterval
// clr = setTimeout(logKaro, 5000);
// clr = setInterval(logKaro, 2000);
// use clearInterval(clr)/clearTimeout(clr) to cancel setInterval/setTimeout
// **********************************************************************

// JavaScript localStorage
// localStorage.setItem('name', 'Nikita') 
// localStorage //Storage {name: "Nikita", length: 1}
// localStorage.getItem('name') //"Nikita"
// localStorage.removeItem('name')
// localStorage.clear();



// **********************************************************************
// Json (javascript object notation)
// obj = {name: "harry", length: 1, a: {this: 'tha"t'}}
// jso = JSON.stringify(obj);
// console.log(typeof jso)
// console.log(jso)
// parsed = JSON.parse(`{"name":"harry","length":1,"a":{"this":"that"}}`)
// console.log(parsed);


// **********************************************************************
// Template literals - Backticks
a = 34;
console.log(`this is my ${a}`)
// **********************************************************************
