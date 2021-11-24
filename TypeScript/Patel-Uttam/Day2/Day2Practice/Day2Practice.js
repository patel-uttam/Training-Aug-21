// Import stylesheets
// import './style.css';
// // Write TypeScript code!
// const appDiv: HTMLElement = document.getElementById('app');
// appDiv.innerHTML = `<h1>TypeScript Starter</h1>`;
console.log('TypeScript Day2 Practice');
// tuple
var tuple1;
tuple1 = [1, 2];
//function
//fill
tuple1.fill(2, 0);
console.log(tuple1);
//concat
console.log(tuple1.concat(tuple1.fill(3, 0)));
//filter
console.log(tuple1.filter(function (tuple1, i, arr) {
    return tuple1.valueOf() > 2;
}));
//pop
console.log(tuple1.pop());
// union
var union_variable_1;
console.log((union_variable_1 = 12));
console.log((union_variable_1 = 'Hello'));
function union_func(arg1) {
    console.log(arg1);
}
union_func(5);
union_func('hi');
var union_array = [1, 'A'];
union_array.push(3);
union_array.push('A');
console.log('union_array : ' + union_array);
// class
var Student = /** @class */ (function () {
    function Student(id, name, percent) {
        this.Id = id;
        this.Name = name;
        this.Percentage = percent;
    }
    Student.prototype.getdetails = function () {
        console.log('Id : ' +
            this.Id +
            ' , ' +
            'Name : ' +
            this.Name +
            ' , ' +
            'Percentage : ' +
            this.Percentage);
    };
    return Student;
}());
var student1 = new Student(1, 'smith', 70);
console.log(student1.Name + ' is accessible');
student1.getdetails();
// enum
var Dir1;
(function (Dir1) {
    Dir1[Dir1["Up"] = 0] = "Up";
    Dir1[Dir1["Down"] = 1] = "Down";
    Dir1[Dir1["Left"] = 2] = "Left";
    Dir1[Dir1["Right"] = 3] = "Right";
})(Dir1 || (Dir1 = {}));
console.log(Dir1.Up);
var Dir2;
(function (Dir2) {
    Dir2[Dir2["Up"] = 0] = "Up";
    Dir2[Dir2["Down"] = 1] = "Down";
    Dir2[Dir2["Left"] = 2] = "Left";
    Dir2[Dir2["Right"] = 3] = "Right";
})(Dir2 || (Dir2 = {}));
console.log(Dir2.Up);
var Dir3;
(function (Dir3) {
    Dir3[Dir3["Yes"] = 1] = "Yes";
    Dir3[Dir3["No"] = 0] = "No";
})(Dir3 || (Dir3 = {}));
console.log(Dir3.No);
console.log(16 /* square */);
// declare enum Dir3 {
//   Yes = 0,
//   No = 1,
//   Defualt = 'def'
// }
console.log(Dir3.Yes);
var implement_interface1 = /** @class */ (function () {
    function implement_interface1(id, name) {
        this.Id = id;
        this.Name = this.Name;
    }
    implement_interface1.prototype.GetDetails = function () {
        console.log('Id is : ' + this.Id + ' and ' + 'Name is: ' + this.Name);
    };
    return implement_interface1;
}());
var implement_interface2_as_type = {
    subject1: 'Maths',
    subject2: 'History',
    subject3: '23'
};
var concate_func = function (arg1, arg2) {
    return arg1 + arg2;
};
var implement_interaface3_as_func = concate_func;
var implement_interaface3_as_func_anwser = implement_interaface3_as_func(2, 2);
console.log(implement_interaface3_as_func_anwser);
var array_initialized = [1, 2, 3, 4];
var implement_interface4_as_array = array_initialized;
console.log(implement_interface4_as_array);
// anonymous fuction
var anonymous_func = function () { return "Anonymous function"; };
console.log(anonymous_func);
