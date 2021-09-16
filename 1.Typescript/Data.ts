class Base
{
    no1 : number;
    no2 : number;
    constructor(x : number,y : number)
    {
        console.log("Base class constructor")
        this.no1 = x
        this.no2 = y
    }
    fun()
    {
        console.log("Inside fun of base");
        console.log(this.no1);
        console.log(this.no2);
    }
}

class Derived extends Base
{
    value : number;
    constructor(a : number,b:number,c:number)
    {
        super(a,b)
        console.log("Derived class constructor")

        this.value = c;
    }
    gun()
    {
        console.log("Derived gun");
        console.log(this.value)
    }
}

var dobj : Derived = new Derived(11,21,51)
dobj.fun();
dobj.gun()