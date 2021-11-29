import { randomInt } from "crypto";

console.log("List Of Restaurant");

export class Restaurant_Booking_System
{
    //restaurant_details
    // ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
    Restaurants:Array<string|number|Array<string>>[] =[];
    Restaurant:Array<string|number|Array<string>>=[];

    Restaurant_RegisterNo:string;
    Restaurant_Name:string;
    Restaurant_Type:string;
    Restaurant_Dinning_Room:number;
    Food_Serve:Array<string>;
    Restaurant_AddressLine:string;
    Restaurant_City:string;
    Restaurant_State:string;

    Add_Restaurant(registerNo:string,name:string,type:string,room:number,serve:Array<string>,addressline:string,city:string,state:string):void
    {
        for(var i in this.Restaurants)
        {
            if( registerNo == this.Restaurants[i][0])
            {
                console.log("\n\n"+"|---Warning---|");
                console.log("There is already a Restaurant Added");
                console.log("|-----------|"+"\n\n");
                break;
            }
        }

        this.Restaurant_RegisterNo = registerNo;
        this.Restaurant_Name = name;
        this.Restaurant_Type = type;
        if(type == "Dinning")
        {
            this.Restaurant_Dinning_Room = room;
        }
        else
        {
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

    }
    
    Display_Restaurant():void
    {
        for(var i in this.Restaurants)
        {
            console.log(this.Restaurants[i]);
        }
    }

    Search_Restaurant(name:string,city:string):Array<string|number|Array<string>>[]
    {
        let Searched_Restaurant:Array<string|number|Array<string>>[]=[];
        console.log("\n\n"+"|---Searched Restaurant ---|");
        for(var i in this.Restaurants)
        {
            if(this.Restaurants[i][1]==name)
            {
                
                console.log("Restaurant Name : "+this.Restaurants[i][1]+"\t"+"Restaurant Type : "+this.Restaurants[i][2]+"\t"+"Food Serve : "+this.Restaurants[i][4]+"City : "+this.Restaurants[i][6]);
                console.log("\n");
                if(this.Dinnig_table[i][1]==name)
                {

                    console.log("Room "+this.Dinnig_table[i][4]+" has  Tables "+this.Dinnig_table[i][2]+ " with capacity of "+this.Dinnig_table[i][3]+" for one table");

  
                }
                Searched_Restaurant.push(this.Restaurants[i]);
                
            }
        }
        console.log("|-----------|"+"\n\n");
        return Searched_Restaurant;

    }

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

    Dinnig_table:Array<string|number|boolean>[]=[];
    
    Add_Dinning_table(registerNo:string,table_count:number,capacity:number):void
    {
        for(var i in this.Restaurants)
        {
            if(registerNo == this.Restaurants[i][0])
            {
                if(this.Restaurants[i][3]==null)
                {
                    this.Dinnig_table.push([registerNo,this.Restaurants[i][1].toString(),table_count,capacity,1]);
                }
                else
                {
                    for(var j=1;j<=this.Restaurants[i][3];j++)
                    {
                        let i=1
                        this.Dinnig_table.push([registerNo,this.Restaurants[i][1].toString(),table_count,capacity,j.toString()]);
                    }
                }
            }
        }
    }

    Display_Dinning_table():void
    {
        for(var i in this.Dinnig_table)
        {
                console.log("In "+this.Dinnig_table[i][1]+" Room "+this.Dinnig_table[i][4]+" Has "+this.Dinnig_table[i][2] + " Total Table sitting");
        }
    }

    // //////////////////////////////////////////////////////////////////////////////////////////////////

    // Appoinment(name:string,city:string):void    {

    // }

    Bookings:Array<string|number|Array<string>>[] =[];

    Booking:Array<string|number|Array<string>>=[];
    Booking_Appoinment(user:string,mobile:number,guest:number,date:Date,Restaurant_Name:string):boolean
    {
        let available_restaurant:Array<string|number|Array<string>>[] = this.Search_Restaurant(Restaurant_Name,'');
        console.log(available_restaurant);
        
        for(var i in this.Restaurants)
        {
            let today:Date = new Date();
            today.setHours(today.getHours()+6);
            let max:Date = new Date();
            max.setDate(max.getDate()+30);
            if(date>today && date<max)
            {
                if(this.Restaurants[i][1]==Restaurant_Name && this.Dinnig_table[i][1]==Restaurant_Name)
                {
                    if(guest>(parseInt(this.Dinnig_table[i][2].toString())*parseInt(this.Dinnig_table[i][3].toString())))
                    {
                        console.log("Not enough sitting Availlable.");
                    }
                    else
                    {
                        let required_table:number = (guest/parseInt(this.Dinnig_table[i][3].toString()));
                        let minus_table = Math.ceil(required_table);
                        this.Dinnig_table[i][2] = parseInt(this.Dinnig_table[i][2].toString())-minus_table;
                        return true;
                    }
                }
    
            }
        }
    }
}





/// calling ///

let res = new Restaurant_Booking_System();
res.Add_Restaurant('KD123','Mild','Casual Dinning',3,['Gujarati','Punjabi','Maxican'],"Near fire station","Kadi","Gujarat");
res.Add_Restaurant('CHH123','Amrit','Dinning',3,['Gujarati','Punjabi','Maxican'],"Near HighWay","Chhatral","Gujarat");

res.Add_Dinning_table('KD123',7,6);
res.Add_Dinning_table('CHH123',17,6);

console.log("\n\n"+"***************************************")

res.Display_Restaurant();

console.log("***************************************"+"\n\n")

res.Display_Dinning_table();

console.log("***************************************"+"\n\n")
res.Search_Restaurant('Mild','Kadi');

console.log("***************************************"+"\n\n")
let booking_date:Date =new Date();
booking_date.setDate(booking_date.getDate()+10); 
let confirm:boolean = res.Booking_Appoinment('Raj',9876543210,12,booking_date,'Amrit');

if(confirm == true)
{
    console.log("Your booking is confirm!")
    console.log("Your Token number : "+ 213);
}
else
{
    console.log("Your Booking is Not Confirm.")
}

// after booking for 12 people available table are 15 now (before it 17.)

console.log("***************************************"+"\n\n")
res.Search_Restaurant('Amrit','Kadi');

console.log("***************************************"+"\n\n")