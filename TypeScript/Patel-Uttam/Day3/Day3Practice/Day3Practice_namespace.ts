// NameScape

///<reference path='NameSpace1.ts'/>
///<reference path='NameSpaces.ts'/>

let stringcheck_obj = new TypeChecker._StringChecker();
let result:boolean = stringcheck_obj.isstring("hello123");
console.log(result);
result = stringcheck_obj.isstring(1234);
console.log(result);

let numbercheck_obj = new TypeChecker._NumberChecker();
let result2:boolean = numbercheck_obj.isnumber(1234567);
console.log(result2);