console.log('TypeScript Day1');
// DataType primitive
//number
var num1 = 12;
var num2 = 0x124ff;
var num3 = 7;
var num4 = 1234.56788;
var num5 = -1234.554;
//number methods
var num4expo = num4.toExponential(3);
var num4fix = num4.toFixed(2);
var num2locate = num2.toLocaleString();
var nm5pe = num5.toPrecision();
var num1str = num1.toString();
var num2value = num2.valueOf();
//string
var str1 = ' Hello World ';
var str2 = 'Hello There';
var str3 = 'Stackblitz';
//string method
var str1charat = str1.charAt(3);
var str12concat = str1.concat(',', str2);
var str2Indexof = str2.indexOf('o');
var str3rreplace = str3.replace('stack', '_');
var split_str12oncat = str12concat.split(',');
var str3upper = str3.toUpperCase();
var str2locateupper = str2.toLocaleLowerCase();
var str1trim = str1.trim();
var str2charcodeat = str2.charCodeAt(3);
var str3nds = str3.endsWith('z');
var strstart = str3.startsWith('b');
//boolean
var bool1 = true;
//
console.log('str1 value ' + str1);
// string template
console.log("Num1 Value ".concat(num1, " ; num2 Value ").concat(num2, " ; num3 Value ").concat(num3));
// Datatype user define
// array
var arr1 = [1, 2, 4, 5, 6, 7];
var arr2 = ['Hi', 'Hello', 'Fine'];
var arr3 = ['hi', 1, 'hello', 2, 3, 'ok'];
var arr4 = [];
// array loop access
for (var i in arr2) {
    console.log("".concat(i));
}
for (var _i = 0, arr2_1 = arr2; _i < arr2_1.length; _i++) {
    var arr2value = arr2_1[_i];
    console.log("".concat(arr2value));
}
// array methods
var arr2filter = arr2.filter(function (arr2, i, arr) {
    return arr2.length > 2;
});
var arr4fill = arr4.fill(1, 4);
var arr3shift = arr3.shift();
