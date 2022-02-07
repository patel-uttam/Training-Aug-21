"use strict";
exports.__esModule = true;
console.log("TypeScript Day3 Practice");
// Generic
// Generics is used when we required a return type as a same as type of passed argument.
function generic1_func(arg1) {
    return arg1;
}
console.log(generic1_func(2));
console.log(generic1_func('Hello'));
console.log(generic1_func(['first', 2, 'third', 4]));
var str1 = "web dev";
console.log(generic1_func(str1));
function generic2_func(arg1, arg2, arg3, arg4) {
    if (arg1 == arg2) {
        return arg3;
    }
    else {
        return arg4;
    }
}
console.log(generic2_func("Hello World", "Hello World", "arg1 and arg2 same", "arg1 and arg2 not same"));
var generic_class1 = /** @class */ (function () {
    function generic_class1(arg1, arg2) {
        this.i = arg1;
        this.j = arg2;
    }
    generic_class1.prototype.Display = function (arg1) {
        console.log(arg1.length);
    };
    return generic_class1;
}());
var class1 = new generic_class1(5, 5);
class1.Display([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]);
function Identity(arg) {
    console.log(arg.length); // Now we know it has a .length property, so no more error
    return arg;
}
function getProperty(obj, key) {
    return obj[key];
}
var x = { a: 1, b: 2, c: 3, d: 4 };
getProperty(x, "a");
// module
//
var Modules_1 = require("./Modules"), mod_all = Modules_1;
require("./Modules");
Modules_1["default"];
console.log(mod_all.export_array);
console.log(mod_all.object.ID);
//
var import_interface = require('./Modules');
var arr = import_interface.export_array;
arr = [1, 2, 3, 4];
console.log(arr);
