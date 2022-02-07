console.log("Namespace1");
///<reference path='./NameSpace1.ts'/>
var TypeChecker;
(function (TypeChecker) {
    var _StringChecker = /** @class */ (function () {
        function _StringChecker() {
        }
        _StringChecker.prototype.isstring = function (arg) {
            if (typeof arg == typeof 'String') {
                console.log("Type of Parameter is string ");
                return true;
            }
            else {
                console.log("Passed parameter is not string type");
                return false;
            }
        };
        return _StringChecker;
    }());
    TypeChecker._StringChecker = _StringChecker;
    var _NumberChecker = /** @class */ (function () {
        function _NumberChecker() {
        }
        _NumberChecker.prototype.isnumber = function (arg) {
            if (typeof arg === typeof 1111) {
                console.log("Type of parameter is number");
                return true;
            }
            else {
                console.log("Passed parameter is not number type");
                return false;
            }
        };
        return _NumberChecker;
    }());
    TypeChecker._NumberChecker = _NumberChecker;
})(TypeChecker || (TypeChecker = {}));
// NameScape
///<reference path='NameSpace1.ts'/>
///<reference path='NameSpaces.ts'/>
var stringcheck_obj = new TypeChecker._StringChecker();
var result = stringcheck_obj.isstring("hello123");
console.log(result);
result = stringcheck_obj.isstring(1234);
console.log(result);
var numbercheck_obj = new TypeChecker._NumberChecker();
var result2 = numbercheck_obj.isnumber(1234567);
console.log(result2);
