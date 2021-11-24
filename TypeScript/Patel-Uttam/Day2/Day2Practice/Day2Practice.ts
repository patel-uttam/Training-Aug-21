// Import stylesheets
// import './style.css';

// // Write TypeScript code!
// const appDiv: HTMLElement = document.getElementById('app');
// appDiv.innerHTML = `<h1>TypeScript Starter</h1>`;

console.log('TypeScript Day2 Practice');

// tuple

let tuple1: [number, number];
tuple1 = [1, 2];

//function

//fill
tuple1.fill(2, 0);
console.log(tuple1);

//concat
console.log(tuple1.concat(tuple1.fill(3, 0)));

//filter
console.log(
  tuple1.filter((tuple1, i, arr) => {
    return tuple1.valueOf() > 2;
  })
);

//pop
console.log(tuple1.pop());

// union

let union_variable_1: string | number;
console.log((union_variable_1 = 12));
console.log((union_variable_1 = 'Hello'));

function union_func(arg1: string | number): void {
  console.log(arg1);
}
union_func(5);
union_func('hi');
let union_array:(Array<string>|Array<number>|Array<number|string>) = [1,'A'];
union_array.push(3);
union_array.push('A');
console.log('union_array : '+union_array);
// class

class Student {
  protected Id: number;
  public Name: string;
  private Percentage: number;

  constructor(id: number, name: string, percent: number) {
    this.Id = id;
    this.Name = name;
    this.Percentage = percent;
  }

  getdetails(): void {
    console.log(
      'Id : ' +
        this.Id +
        ' , ' +
        'Name : ' +
        this.Name +
        ' , ' +
        'Percentage : ' +
        this.Percentage
    );
  }
}
let student1 = new Student(1, 'smith', 70);
console.log(student1.Name + ' is accessible');
student1.getdetails();

// enum
enum Dir1 {
  Up, //0
  Down, //1
  Left,
  Right, //3
}
console.log(Dir1.Up);

enum Dir2 {
  Up, //0
  Down, //1
  Left,
  Right, //3
}
console.log(Dir2.Up);

 enum Dir3 {
  Yes = 1, 
  No =0
}
console.log(Dir3.No);

const enum Dir4 {
  number = 4,
  square = number * number,
}
console.log(Dir4.square);

// declare enum Dir3 {
//   Yes = 0,
//   No = 1,
//   Defualt = 'def'
// }
console.log(Dir3.Yes);

// interface
interface interface1 {
  Id;
  Name;

  GetDetails: (number, string) => void;
}

class implement_interface1 implements interface1 {
  Id: number;
  Name: string;

  constructor(id: number, name: string) {
    this.Id = id;
    this.Name = this.Name;
  }
  GetDetails(): void {
    console.log('Id is : ' + this.Id + ' and ' + 'Name is: ' + this.Name);
  }
}

// interface as type

interface interface2 {
  subject1: string;
  subject2: string;
  subject3: string;
}

let implement_interface2_as_type: interface2 = {
  subject1: 'Maths',
  subject2: 'History',
  subject3: '23',
};

// interface as function

interface interface3 {
  (arg1: number | string, arg2: number | string): void;
}

let concate_func: any = function (arg1: any, arg2: any): any {
  return arg1 + arg2;
};

let implement_interaface3_as_func: interface3 = concate_func;
let implement_interaface3_as_func_anwser = implement_interaface3_as_func(2, 2);
console.log(implement_interaface3_as_func_anwser);



// interface for array

interface interface4
{
    [args:number]:number;
}

let array_initialized:number[]=[1,2,3,4];
let implement_interface4_as_array : interface4 = array_initialized;
console.log(implement_interface4_as_array); 


// anonymous fuction

let anonymous_func = function():string{return "Anonymous function"};
console.log(anonymous_func);