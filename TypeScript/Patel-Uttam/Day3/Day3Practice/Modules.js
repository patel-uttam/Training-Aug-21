"use strict";
exports.__esModule = true;
exports.object = exports.export_array = exports.export_function = void 0;
console.log("Module in Day3Practice");
function export_default() {
    console.log("default export");
}
exports["default"] = export_default;
function export_function(arg) {
    console.log("passed values is : " + arg);
}
exports.export_function = export_function;
var export_array = [];
exports.export_array = export_array;
var object = {
    ID: "1",
    Name: "uttam"
};
exports.object = object;
