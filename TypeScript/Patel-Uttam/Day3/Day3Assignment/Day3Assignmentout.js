console.log('Vacancies');
var Vacancy_tuple;
var Vacancy_array = [];
var Vacancies;
(function (Vacancies) {
    var Class_Vacancy = /** @class */ (function () {
        function Class_Vacancy() {
        }
        Class_Vacancy.prototype.Display_Vacancy = function () {
            for (var items in Vacancy_array) {
                console.log("Current " + items[0] + " Vacancy for " + items[1]);
            }
        };
        Class_Vacancy.prototype.Add_Vacancy = function (count, vacancy) {
            Vacancy_tuple = [count, vacancy];
            Vacancy_array.push(Vacancy_tuple);
            console.log(count + " Vacancy for " + vacancy);
        };
        return Class_Vacancy;
    }());
    Vacancies.Class_Vacancy = Class_Vacancy;
})(Vacancies || (Vacancies = {}));
define("ApplicantData", ["require", "exports"], function (require, exports) {
    "use strict";
    exports.__esModule = true;
    exports.DataInsert = void 0;
    console.log('ApplicantData');
    var DataInsert = /** @class */ (function () {
        function DataInsert() {
            this.Applicants = [];
            this.ApplicantData = [];
            // Display_
            // Delete_Data(id:number):void
            // {
            //     // delete this.Applicants[this.Applicants.findIndex(this.Applicants)]
            //     // this.Applicants = this.Applicants.filter(this.Applicants);
            // }
        }
        DataInsert.prototype.Insert_Data = function (id, name, passingyear, degree, cgpa, college, apply) {
            this.ApplicantID = id;
            this.ApplicantName = name;
            this.ApplicantPassingYear = passingyear;
            this.ApplicantDegree = degree;
            this.ApplicantCGPA = cgpa;
            this.ApplicantCollege = college;
            this.ApplyFor = apply;
            this.ApplicantData.push(this.ApplicantID);
            this.ApplicantData.push(this.ApplicantName);
            this.ApplicantData.push(this.ApplicantPassingYear);
            this.ApplicantData.push(this.ApplicantDegree);
            this.ApplicantData.push(this.ApplicantCGPA);
            this.ApplicantData.push(this.ApplicantCollege);
            this.ApplicantData.push(this.ApplyFor);
            this.Applicants.push(this.ApplicantData);
            this.ApplicantData = [];
        };
        DataInsert.prototype.Display_Data = function () {
            console.log("Id" + '  |  ' + "Name" + '  |  ' + "Passing Year" + '  |  ' + "Degree" + '  |  ' + "CGPA" + '  |  ' + "College" + '  |  ' + "Apply for");
            console.log('\n');
            for (var i in this.Applicants) {
                console.log(this.Applicants[i][0] + '\t' + this.Applicants[i][1] + '\t' + this.Applicants[i][2] + '\t' + this.Applicants[i][3] + '\t' + this.Applicants[i][4] + '\t' + this.Applicants[i][5] + '\t' + this.Applicants[i][6]);
            }
        };
        return DataInsert;
    }());
    exports.DataInsert = DataInsert;
});
define("Interviews", ["require", "exports"], function (require, exports) {
    "use strict";
    exports.__esModule = true;
    exports.Display_Interview = exports.Schedule_Iterview = void 0;
    var Interviews = [];
    var Interview;
    function Schedule_Iterview(Applicant, interviewer) {
        Interview = [parseInt(Applicant[0].toString()), interviewer];
        Interviews.push(Interview);
    }
    exports.Schedule_Iterview = Schedule_Iterview;
    function Display_Interview() {
        for (var i in Interviews) {
            console.log("Interview for Applicant ID " + Interviews[i][0] + " schedule with " + Interviews[i][1]);
        }
    }
    exports.Display_Interview = Display_Interview;
});
define("Day3Assignment", ["require", "exports"], function (require, exports) {
    "use strict";
    exports.__esModule = true;
    console.log("TypeScript Day3 Assignment");
    ///<reference path='vacancies.ts'/>
    var vacancy = new Vacancies.Class_Vacancy();
    console.log("*********************************");
    console.log("Vacancies");
    vacancy.Add_Vacancy(5, 'Angular');
    vacancy.Add_Vacancy(2, 'React');
    vacancy.Add_Vacancy(2, 'vue');
    vacancy.Display_Vacancy();
    console.log("*********************************" + "\n\n");
    // let Applicants = new applicant.DataInsert();
    // Applicants.Insert_Data(1,'Dhruv',2021,'B.E',8.1,'GEC','Angular');
    // Applicants.Insert_Data(1,'Dhairya',2021,'B.E',9.0,'GEC','React');
    // Applicants.Insert_Data(1,'Harshil',2021,'B.E',8.6,'GEC','vue');
    // Applicants.Display_Data();
    // console.log("################################");
    // console.log("Interviews")
    // interview.Schedule_Iterview([1,'Dhruv',2021,'B.E',8.1,'GEC','Angular'],'Chandrakant');
    // interview.Schedule_Iterview([1,'Harshil',2021,'B.E',8.6,'GEC','vue'],'Rajesh');
    // interview.Display_Interview();
    // console.log("################################"+"\n\n");
    console.log("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
});
