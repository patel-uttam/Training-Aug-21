"use strict";
exports.__esModule = true;
exports.Class_Vacancy = void 0;
console.log('Vacancies');
var Vacancy_tuple;
var Vacancy_array = [];
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
exports.Class_Vacancy = Class_Vacancy;
