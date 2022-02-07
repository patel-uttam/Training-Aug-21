///<reference path='./NameSpace1.ts'/>

namespace TypeChecker
{
export class _StringChecker implements StringType
{
    isstring(arg:any):boolean
    {
        if(typeof arg == typeof 'String')
        {
            console.log("Type of Parameter is string ");
            return true;
        }
        else
        {
            console.log("Passed parameter is not string type")
            return false;
        }
    }
}

export class _NumberChecker implements numberType
{
    isnumber(arg:any):boolean
    {
        if(typeof arg === typeof 1111)
        {
            console.log("Type of parameter is number");
            return true;
        }
        else
        {
            console.log("Passed parameter is not number type")
            return false;
        }
    }
}
}