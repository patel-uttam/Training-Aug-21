
console.log("Module in Day3Practice");

export default function export_default():void
{
    console.log("default export");
}

export function export_function(arg:string):void
{
    console.log("passed values is : "+arg);
}

export interface export_interface
{
    [value:number]:number
}

let export_array:Array<string|number>=[];

let object =
{
    ID:"1",
    Name:"uttam"
}


export {export_array,object};