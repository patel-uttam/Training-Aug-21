console.log('TypeScript Day1');

// DataType primitive

//number

var num1: number = 12;
var num2: number = 0x124ff;
var num3: number = 0b0111;
var num4: number = 1234.56788;
var num5: number = -1234.554;

//number methods
var num4expo: string = num4.toExponential(3);
var num4fix: string = num4.toFixed(2);
var num2locate: string = num2.toLocaleString();
var nm5pe: string = num5.toPrecision();
var num1str: string = num1.toString();
var num2value: number = num2.valueOf();

//string
var str1: string = ' Hello World ';
var str2: string = 'Hello There';
var str3: string = 'Stackblitz';

//string method
var str1charat: string = str1.charAt(3);
var str12concat: string = str1.concat(',', str2);
var str2Indexof: number = str2.indexOf('o');
var str3rreplace: string = str3.replace('stack', '_');
var split_str12oncat: string[] = str12concat.split(',');
var str3upper: string = str3.toUpperCase();
var str2locateupper: string = str2.toLocaleLowerCase();
var str1trim: string = str1.trim();
var str2charcodeat: number = str2.charCodeAt(3);
var str3nds: boolean = str3.endsWith('z');
var strstart: boolean = str3.startsWith('b');

//boolean
var bool1: boolean = true;

//
console.log('str1 value ' + str1);

// string template
console.log(`Num1 Value ${num1} ; num2 Value ${num2} ; num3 Value ${num3}`);

// Datatype user define

// array
var arr1: Array<number> = [1, 2, 4, 5, 6, 7];
var arr2: string[] = ['Hi', 'Hello', 'Fine'];
var arr3: Array<number | string> = ['hi', 1, 'hello', 2, 3, 'ok'];
var arr4: number[] = [];
// array loop access

for (var i in arr2) {
  console.log(`${i}`);
}
for (var arr2value of arr2) {
  console.log(`${arr2value}`);
}

// array methods

var arr2filter = arr2.filter((arr2, i, arr) => {
  return arr2.length > 2;
});

var arr4fill = arr4.fill(1, 4);

var arr3shift = arr3.shift();
