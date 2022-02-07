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
