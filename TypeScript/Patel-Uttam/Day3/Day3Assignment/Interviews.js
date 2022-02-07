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
