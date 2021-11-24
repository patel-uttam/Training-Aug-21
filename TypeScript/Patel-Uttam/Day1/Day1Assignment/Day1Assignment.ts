


console.log("TypeScript Day1 Assignment");
console.log("\n");
// array with field ID,FirstName,LastName,Address,Salary;

let employee_array:Array<number|string>[] = [] ;

// inserting new 
// var employee1:Array<number|string> = [1,'Pramath','Patel','b-23,Radhe Villa,gandhinagar,gujarat',20000]
// var employee2:Array<number|string> = [2,'Sahil','Patel','b-23,Radhe Villa,gandhinagar,gujarat',21000];  
// var employee3:Array<number|string> = [3,'Bhushan','Vagh','b-23,Radhe Villa,gandhinagar,gujarat',22000];  
// var employee4:Array<number|string> = [4,'Kunj','Patel','b-23,Radhe Villa,gandhinagar,gujarat',19000];  
// var employee5:Array<number|string> = [5,'Dhruv','Patel','b-23,Radhe Villa,gandhinagar,gujarat',15000];  


function employee_insert(Id:number, FirstName:string, SecondName:string, Address:string, Salary:number):void
{
    let employee:Array<number|string>=[];
    employee[0] = Id;
    employee[1] = FirstName;
    employee[2] = SecondName;
    employee[3] = Address;
    employee[4] = Salary;

    employee_array.push(employee);

}

//call
employee_insert(1,'Pramath','Patel','b-23,Radhe Villa,gandhinagar,gujarat',20000);
employee_insert(2,'Sahil','Patel','b-23,Radhe Villa,gandhinagar,gujarat',21000);
employee_insert(3,'Bhushan','Vagh','b-23,Radhe Villa,gandhinagar,gujarat',22000);
employee_insert(4,'Kunj','Patel','b-23,Radhe Villa,gandhinagar,gujarat',19000);
employee_insert(5,'Dhruv','Patel','b-23,Radhe Villa,gandhinagar,gujarat',15000);

//
for(var value of employee_array)
{
    console.log(value);
}

var readline = require('readline');
let input_value_index = readline.createInterface({
    input: process.stdin,
    output: process.stdout
  });

  let input_value_id = readline.createInterface({
    input: process.stdin,
    output: process.stdout
  });

// search my index

    function search_by_index(index:number):void 
    {
        var search_employee_index:Array<number|string> = employee_array[index];
        console.log("Employee At Index "+ index + " is : " + search_employee_index);
    
    }

search_by_index(3);

console.log('\n');

// search by id

    function search_by_id(id:number):void
    {
        for(var i in employee_array)
        {
            if(employee_array[i][0] == id)
            {
                var search_employee_id:Array<number|string> = employee_array[i]; 
                console.log("Employee with Id "+id+" is : " + search_employee_id);
                break;
            }
        }

    }
search_by_id(1);
console.log('\n\n');

//delete employee

console.log("deleted employee :- " + employee_array.pop() +'\n');


// concatenate employee_array_second to employee_array

function employee_Array_concate(Id:number, FirstName:string, SecondName:string, Address:string, Salary:number):void
{
    let employee_array_second:Array<number|string>[] = [];
    let employee:Array<string|number> = [];
    employee[0] = Id;
    employee[1] = FirstName;
    employee[2] = SecondName;
    employee[3] = Address;
    employee[4] = Salary;
    employee_array_second.push(employee);
    employee_array = employee_array.concat(employee_array_second);
    console.log("joining array to employee_array :-  " + employee_array[employee_array.length-1] + '\n\n');

}

//call
employee_Array_concate(6,'Dhruvit','Dhar','b-23,Radhe Villa,gandhinagar,gujarat',25000)
//


// display details
function employee_display():void
{
    for(var value of employee_array)
    {
        console.log(value);
        // console.log("EmployeeID : " + employee_array[1][0] + "\n");
        // console.log("Employee FullName : " + employee_array[i][1]+" "+employee_array[i][2] + '\n');
        // var employee_address_row:string = employee_array[i][3].toString();
        // var employee_address:string[] = employee_address_row.split(',');
        // console.log("Employee Address : { " + "HouseNumber : "+employee_address[0] +","+ "society : "+employee_address[1] +","+ "city : "+employee_address[2] +","+ "State : "+employee_address[3]+" }"+ '\n');
        // var employee_PF_string:string = employee_array[i][4].toString();
        // var employee_PF:number= parseInt(employee_PF_string);
        // console.log("Employee's PF : "+ employee_PF*0.12);
        // console.log("---------------------------------");
    }

}

//call
employee_display();
//


// input_value_index.close();  
// input_value_id.close();