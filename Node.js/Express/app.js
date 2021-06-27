const express = require("express")

const app = express();
const port = 80;

app.get("/", (req, res) => {
    res.send("This is my first express app with nikita");
});
app.get("/about", (req, res) => {
    res.send("This is my about express app with nikita");
});
app.post("/about", (req, res) => {
    res.send("This is my post express app with nikita");
});
app.get("/this", (req, res) => {
    res.send("This is my page express app with nikita");
});
app.listen(port, () => {
    console.log(`The application started successfully on port ${port}`);

});