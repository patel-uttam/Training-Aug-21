let table = document.getElementById("table"),rIndex;

let item_name;
let item_price;
let item_quantity = 0;
let order = {item1:[],item2:[],item3:[],item4:[]};
var order_json;
for(let i=0 ; i<table.rows.length ; i++)
{

    table.rows[i].cells[4].onclick = function(){
        rIndex=this.rowIndex;
        // console.log(table.rows[i].cells[1].innerHTML+" , "+table.rows[i].cells[2].innerHTML +" , "+table.rows[i].cells[3].innerHTML);
        
        item_name = table.rows[i].cells[1].innerHTML;
        item_price = table.rows[i].cells[2].innerHTML;
        item_quantity = table.rows[i].cells[3].innerHTML;
        if(table.rows[i].cells[1].innerHTML == "Cheese")
        {
            if(order.item1[2]==null)
            {
                order.item1 = [item_name,item_price,1];
            }
            else
            {
                order.item1 = [item_name,item_price,order.item1[2]+=1];
            }
        }
        if(table.rows[i].cells[1].innerHTML == "Pen")
        {

            if(order.item2[2]==null)
            {
                order.item2 = [item_name,item_price,1];
            }
            else
            {
                order.item2 = [item_name,item_price,order.item2[2]+=1];
            }
            
        }
        if(table.rows[i].cells[1].innerHTML == "Butter")
        {

            if(order.item3[2]==null)
            {
                order.item3 = [item_name,item_price,1];
            }
            else
            {
                order.item3 = [item_name,item_price,order.item3[2]+=1];
            }
        }
        if(table.rows[i].cells[1].innerHTML == "Pencil")
        {

            if(order.item4[2]==null)
            {
                order.item4 = [item_name,item_price,1];
            }
            else
            {
                order.item4 = [item_name,item_price,order.item4[2]+=1];
            }
        }
        
        order_json = JSON.stringify(order);
        
        table.rows[i].cells[3].innerHTML = parseInt(table.rows[i].cells[3].innerHTML) - 1 ;
        
        if(table.rows[i].cells[3].innerHTML == 0)
        {
            $(table.rows[i]).hide();   
        }
    };
}
console.log(order); 
console.log(order_json);

function add_to_localstorage()
{
    localStorage.setItem("Orders",order_json);
    // for(var i=0 ; i<table.rows.length ; i++)
    // {
    //     $(table.rows[i]).show();
        // if(table.rows[i].cells[1].innerHTML == "Cheese")
        // {
        //     table.rows[i].cells[3].innerHTML = table.rows[i].cells[3].innerHTML + parseInt(order.item1[2]);
        //     order.item1 = [];
        // }
        // if(table.rows[i].cells[1].innerHTML == "pen")
        // {
        //     table.rows[i].cells[3].innerHTML = parseInt(table.rows[i].cells[3].innerHTML) + order.item2[2];
        //     order.item2 = [];
        // }
        // if(table.rows[i].cells[1].innerHTML == "Butter")
        // {
        //     table.rows[i].cells[3].innerHTML = table.rows[i].cells[3].innerHTML + order.item3[2];
        //     order.item3 = [];
        // }
        // if(table.rows[i].cells[1].innerHTML == "Pencil")
        // {
        //     table.rows[i].cells[3].innerHTML = table.rows[i].cells[3].innerHTML + order.item4[2];
        //     order.item4 = [];
        // }
    // }
    order = {item1:[],item2:[],item3:[],item4:[]};
    order_json = "";
}


