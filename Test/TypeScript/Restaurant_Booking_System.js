"use strict";
exports.__esModule = true;
exports.Restaurant_Booking_System = void 0;
console.log("List Of Restaurant");
var Restaurant_Booking_System = /** @class */ (function () {
    function Restaurant_Booking_System() {
        //restaurant_details
        // ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        this.Restaurants = [];
        this.Restaurant = [];
        // ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Dinnig_room details
        // ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Dinning_room:[string,number][];
        // Add_Dinning_room(registerNo:string,no_of_dinning_room:number):void
        // {
        //     for(var i in this.Restaurants)
        //     {
        //         if(registerNo == this.Restaurants[i][0])
        //         {
        //             this.Dinning_room.push([registerNo,no_of_dinning_room]);
        //         }
        //     }
        // }
        // ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Dinnig_table details
        // ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        this.Dinnig_table = [];
        // //////////////////////////////////////////////////////////////////////////////////////////////////
        // Appoinment(name:string,city:string):void    {
        // }
        this.Bookings = [];
        this.Booking = [];
    }
    Restaurant_Booking_System.prototype.Add_Restaurant = function (registerNo, name, type, room, serve, addressline, city, state) {
        for (var i in this.Restaurants) {
            if (registerNo == this.Restaurants[i][0]) {
                console.log("\n\n" + "|---Warning---|");
                console.log("There is already a Restaurant Added");
                console.log("|-----------|" + "\n\n");
                break;
            }
        }
        this.Restaurant_RegisterNo = registerNo;
        this.Restaurant_Name = name;
        this.Restaurant_Type = type;
        if (type == "Dinning") {
            this.Restaurant_Dinning_Room = room;
        }
        else {
            this.Restaurant_Dinning_Room = null;
        }
        this.Food_Serve = serve;
        this.Restaurant_AddressLine = addressline;
        this.Restaurant_City = city;
        this.Restaurant_State = state;
        this.Restaurant.push(this.Restaurant_RegisterNo);
        this.Restaurant.push(this.Restaurant_Name);
        this.Restaurant.push(this.Restaurant_Type);
        this.Restaurant.push(this.Restaurant_Dinning_Room);
        this.Restaurant.push(this.Food_Serve);
        this.Restaurant.push(this.Restaurant_AddressLine);
        this.Restaurant.push(this.Restaurant_City);
        this.Restaurant.push(this.Restaurant_State);
        this.Restaurants.push(this.Restaurant);
        this.Restaurant = [];
    };
    Restaurant_Booking_System.prototype.Display_Restaurant = function () {
        for (var i in this.Restaurants) {
            console.log(this.Restaurants[i]);
        }
    };
    Restaurant_Booking_System.prototype.Search_Restaurant = function (name, city) {
        var Searched_Restaurant = [];
        console.log("\n\n" + "|---Searched Restaurant ---|");
        for (var i in this.Restaurants) {
            if (this.Restaurants[i][1] == name) {
                console.log("Restaurant Name : " + this.Restaurants[i][1] + "\t" + "Restaurant Type : " + this.Restaurants[i][2] + "\t" + "Food Serve : " + this.Restaurants[i][4] + "City : " + this.Restaurants[i][6]);
                console.log("\n");
                if (this.Dinnig_table[i][1] == name) {
                    console.log("Room " + this.Dinnig_table[i][4] + " has  Tables " + this.Dinnig_table[i][2] + " with capacity of " + this.Dinnig_table[i][3] + " for one table");
                }
                Searched_Restaurant.push(this.Restaurants[i]);
            }
        }
        console.log("|-----------|" + "\n\n");
        return Searched_Restaurant;
    };
    Restaurant_Booking_System.prototype.Add_Dinning_table = function (registerNo, table_count, capacity) {
        for (var i in this.Restaurants) {
            if (registerNo == this.Restaurants[i][0]) {
                if (this.Restaurants[i][3] == null) {
                    this.Dinnig_table.push([registerNo, this.Restaurants[i][1].toString(), table_count, capacity, 1]);
                }
                else {
                    for (var j = 1; j <= this.Restaurants[i][3]; j++) {
                        var i_1 = 1;
                        this.Dinnig_table.push([registerNo, this.Restaurants[i_1][1].toString(), table_count, capacity, j.toString()]);
                    }
                }
            }
        }
    };
    Restaurant_Booking_System.prototype.Display_Dinning_table = function () {
        for (var i in this.Dinnig_table) {
            console.log("In " + this.Dinnig_table[i][1] + " Room " + this.Dinnig_table[i][4] + " Has " + this.Dinnig_table[i][2] + " Total Table sitting");
        }
    };
    Restaurant_Booking_System.prototype.Booking_Appoinment = function (user, mobile, guest, date, Restaurant_Name) {
        var available_restaurant = this.Search_Restaurant(Restaurant_Name, '');
        console.log(available_restaurant);
        for (var i in this.Restaurants) {
            var today = new Date();
            today.setHours(today.getHours() + 6);
            var max = new Date();
            max.setDate(max.getDate() + 30);
            if (date > today && date < max) {
                if (this.Restaurants[i][1] == Restaurant_Name && this.Dinnig_table[i][1] == Restaurant_Name) {
                    if (guest > (parseInt(this.Dinnig_table[i][2].toString()) * parseInt(this.Dinnig_table[i][3].toString()))) {
                        console.log("Not enough sitting Availlable.");
                    }
                    else {
                        var required_table = (guest / parseInt(this.Dinnig_table[i][3].toString()));
                        var minus_table = Math.ceil(required_table);
                        this.Dinnig_table[i][2] = parseInt(this.Dinnig_table[i][2].toString()) - minus_table;
                        return true;
                    }
                }
            }
        }
    };
    return Restaurant_Booking_System;
}());
exports.Restaurant_Booking_System = Restaurant_Booking_System;
/// calling ///
var res = new Restaurant_Booking_System();
res.Add_Restaurant('KD123', 'Mild', 'Casual Dinning', 3, ['Gujarati', 'Punjabi', 'Maxican'], "Near fire station", "Kadi", "Gujarat");
res.Add_Restaurant('CHH123', 'Amrit', 'Dinning', 3, ['Gujarati', 'Punjabi', 'Maxican'], "Near HighWay", "Chhatral", "Gujarat");
res.Add_Dinning_table('KD123', 7, 6);
res.Add_Dinning_table('CHH123', 17, 6);
console.log("\n\n" + "***************************************");
res.Display_Restaurant();
console.log("***************************************" + "\n\n");
res.Display_Dinning_table();
console.log("***************************************" + "\n\n");
res.Search_Restaurant('Mild', 'Kadi');
console.log("***************************************" + "\n\n");
var booking_date = new Date();
booking_date.setDate(booking_date.getDate() + 10);
var confirm = res.Booking_Appoinment('Raj', 9876543210, 12, booking_date, 'Amrit');
if (confirm == true) {
    console.log("Your booking is confirm!");
    console.log("Your Token number : " + 213);
}
else {
    console.log("Your Booking is Not Confirm.");
}
// after booking for 12 people available table are 15 now (before it 17.)
console.log("***************************************" + "\n\n");
res.Search_Restaurant('Amrit', 'Kadi');
console.log("***************************************" + "\n\n");
