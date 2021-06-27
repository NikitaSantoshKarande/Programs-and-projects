const http=require('http');
const fs=require('fs');

const FileContent=fs.readFileSync("FirstProgram.html");

const server=http.createServer((req,res)=>{
    res.writeHead(200,{'content-type':'text/html'})
    res.end(FileContent);
});

server.listen(80,'127.0.0.1',()=>{
    console.log("Listning on port 80");
});