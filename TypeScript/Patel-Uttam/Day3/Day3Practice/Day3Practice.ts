console.log("TypeScript Day3 Practice");


// Generic

// Generics is used when we required a return type as a same as type of passed argument.

function generic1_func<T>(arg1:T):T
{
    return arg1;
}

console.log(generic1_func<number>(2));

console.log(generic1_func<string>('Hello'));

console.log(generic1_func<Array<number|string>>(['first',2,'third',4]));

let str1:string = "web dev";
console.log(generic1_func<string>(str1)); 


function generic2_func<Type>(arg1:Type , arg2:Type ,arg3:Type,arg4:Type):Type
{
    if(arg1 == arg2)
    {
        return arg3;
    }
    else
    {
        return arg4;
    }
}

console.log(generic2_func<string>("Hello World","Hello World","arg1 and arg2 same","arg1 and arg2 not same"));


// generic class 

interface generic_interface1<Type>
{
    i:Type;
    j:Type;

    Display<Type>(arg1:Type[]):void;
}

class generic_class1<Type> implements generic_interface1<Type>
{
    i:Type
    j:Type

    constructor(arg1:Type , arg2:Type)
    {
        this.i = arg1;
        this.j = arg2;
    }
    Display<Type>(arg1:Type[]):void
    {
        console.log(arg1.length)
    }
}

let class1 = new generic_class1<number>(5,5);
class1.Display([1,2,3,4,5,6,7,8,9,0]);


// generic constraint

interface L {
    length: number;
  }
   
  function Identity<T extends L>(arg: T): T {
    console.log(arg.length); // Now we know it has a .length property, so no more error
    return arg;
  }

  function getProperty<T, K extends keyof T>(obj: T, key: K) {
    return obj[key];
  }
   
  let x = { a: 1, b: 2, c: 3, d: 4 };
   
  getProperty(x, "a");

// module

//
import export_default , * as mod_all from './Modules'; 

import './Modules';

export_default;

//
import {export_array , object} from './Modules';

console.log(mod_all.export_array);

console.log(mod_all.object.ID);

//
const import_interface = require('./Modules');

let arr:Array<number> = import_interface.export_array;
arr = [1,2,3,4];
console.log(arr);
