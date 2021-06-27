const fs=require("fs");//include module
let text=fs.readFileSync("file.txt","utf-8");
console.log(text);