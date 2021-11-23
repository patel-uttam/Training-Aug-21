console.log("TypeScript Day1 Assignment");
// array with field ID,FirstName,LastName,Address,Salary
// type employee = {ID:number,};
var employee_array = [];
// inserting new 
var employee1 = [1, 'Pramath', 'Patel', 'b-23,Radhe Villa,gandhinagar,gujarat', 20000];
var employee2 = [2, 'Sahil', 'Patel', 'b-23,Radhe Villa,gandhinagar,gujarat', 21000];
var employee3 = [3, 'Bhushan', 'Vagh', 'b-23,Radhe Villa,gandhinagar,gujarat', 22000];
var employee4 = [4, 'Kunj', 'Patel', 'b-23,Radhe Villa,gandhinagar,gujarat', 19000];
var employee5 = [5, 'Dhruv', 'Patel', 'b-23,Radhe Villa,gandhinagar,gujarat', 15000];
employee_array.push(employee1);
employee_array.push(employee2);
employee_array.push(employee3);
employee_array.push(employee4);
employee_array.push(employee5);
// search my index
var while_flag_index = 1;
while (while_flag_index < 4) {
    var index = 1;
    var search_employee_index = employee_array[index];
    console.log(search_employee_index);
    index++;
    while_flag_index++;
}
// search by id
var while_flag_id = 1;
while (while_flag_id < 4) {
    var id = 3;
    for (var i in employee_array) {
        if (employee_array[i][0] == id) {
            var search_employee_id = employee_array[i];
            console.log(search_employee_id);
            while_flag_id = 4;
        }
        else {
            console.log("Not Employee with id " + id + "\n");
        }
    }
    while_flag_id++;
}
//delete employee
console.log("deleted employee" + employee_array.pop() + '\n');
// concatenate employee_array_second to employee_array
var employee_array_second = [];
employee_array_second.push(employee5);
employee_array = employee_array.concat(employee_array_second);
console.log("join array to employee_array" + employee_array + '\n\n');
for (var i in employee_array) {
    console.log("EmployeeID : " + employee_array[i][0] + "\n");
    console.log("Employee FullName : " + employee_array[i][1] + " " + employee_array[i][2] + '\n');
    var employee_address_row = employee_array[i][3].toString();
    var employee_address = employee_address_row.split(',');
    console.log("Employee Address : { " + "HouseNumber : " + employee_address[0] + "," + "society : " + employee_address[1] + "," + "city : " + employee_address[2] + "," + "State : " + employee_address[3] + " }" + '\n');
    var employee_PF_string = employee_array[i][4].toString();
    var employee_PF = parseInt(employee_PF_string);
    console.log("Employee's PF : " + employee_PF * 0.12);
}
