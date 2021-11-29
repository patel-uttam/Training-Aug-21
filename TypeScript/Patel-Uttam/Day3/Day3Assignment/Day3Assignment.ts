console.log("TypeScript Day3 Assignment");

import * as applicant from './ApplicantData'; 
import * as interview from './Interviews';
import * as Vacancies from './vacancies';
///<reference path='vacancies.ts'/>

let vacancy = new Vacancies.Class_Vacancy();

console.log("*********************************")
console.log("Vacancies");

vacancy.Add_Vacancy(5,'Angular');
vacancy.Add_Vacancy(2,'React');
vacancy.Add_Vacancy(2,'vue');
vacancy.Display_Vacancy();
console.log("*********************************"+"\n\n")

let Applicants = new applicant.DataInsert();
Applicants.Insert_Data(1,'Dhruv',2021,'B.E',8.1,'GEC','Angular');
Applicants.Insert_Data(2,'Dhairya',2021,'B.E',9.0,'GEC','React');
Applicants.Insert_Data(3,'Harshil',2021,'B.E',8.6,'GEC','vue');

Applicants.Display_Data();

console.log("################################");
console.log("Interviews")
interview.Schedule_Iterview([1,'Dhruv',2021,'B.E',8.1,'GEC','Angular'],'Chandrakant');
interview.Schedule_Iterview([3,'Harsh',2021,'B.E',7.7,'GEC','vue'],'Rajesh');
interview.Display_Interview();
console.log("################################"+"\n\n");

console.log("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");