console.log('TypeScript Day4 Assignment');
//inser employee data
var Employee = [
    { 'ID': 1, 'Name': "Meet", 'City': "Ahmedabad", 'DOJ': new Date("2019-04-14").getFullYear() },
    { 'ID': 2, 'Name': "Raj", 'City': "Mumbai", 'DOJ': new Date("2020-05-13").getFullYear() },
    { 'ID': 3, 'Name': "Shubh", 'City': "Mumbai", 'DOJ': new Date("2021-02-23").getFullYear() },
    { 'ID': 4, 'Name': "Harsh", 'City': "Mumbai", 'DOJ': new Date("2018-07-12").getFullYear() },
    { 'ID': 5, 'Name': "Jay", 'City': "Ahmedabad", 'DOJ': new Date("2019-04-14").getFullYear() }
];
// Display
for (var i in Employee) {
    console.log(Employee[i]);
}
console.log('\n\n');
console.log("search by 2020");
for (var _i = 0, Employee_1 = Employee; _i < Employee_1.length; _i++) {
    var items = Employee_1[_i];
    if (items.DOJ == 2020) {
        console.log(items);
    }
}
console.log('\n\n');
console.log("search by mumbai and >2020");
for (var _a = 0, Employee_2 = Employee; _a < Employee_2.length; _a++) {
    var items = Employee_2[_a];
    if (items.City == "Mumbai" && items.DOJ >= 2020) {
        console.log(items);
    }
}