const fs = require("fs");//include module

//Synchronization
// line by line execution//bloking
let text=fs.readFileSync("file.txt","utf-8");
console.log(text);


// ------------------------------------------------------------------
//ASynchronization
// Not line by line exection
// callback//Nonblocking
fs.readFile("file.txt", "utf-8", (err, data) => {
    console.log(data);
});
console.log("This is message");
