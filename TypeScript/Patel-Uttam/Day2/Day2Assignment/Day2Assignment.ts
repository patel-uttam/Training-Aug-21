console.log("typescript Day2 assignment");

interface inventory
{
    Product:string;
    In_Stock:number;

    Add_Product_To_Invertory:(string,number)=>void

    Purchase_Product:(string,number)=>void

    Order_Stock_for_Product:(string,number)=>void
}

class Shop implements inventory
{
    Product:string;
    In_Stock:number;

    Products:Array<string|number>[]=[];
    
    Add_Product_To_Invertory(product_name:string,product_quantity:number):void
    {
        this.Product = product_name;
        this.In_Stock = product_quantity;
        let product_tuple:[string,number];
        product_tuple=[this.Product,this.In_Stock];
        this.Products.push(product_tuple);

        for(var value of this.Products)
        {
            console.log(value[0]+' : '+value[1]);
        }
        console.log('\n\n');
    }

    Purchase_Product(product_name:string,product_quantity:number):void
    {
        let product_tuple:[string,number];
        product_tuple=[product_name,product_quantity];

        for(var i in this.Products)
        {
            if( this.Products[i][0] == product_tuple[0])
            {
                let stock:any = this.Products[i][1] ;
                if(parseInt(stock) <= 5)
                {
                    this.Order_Stock_for_Product(this.Products[i][0].toString(),100)
                }
                stock = this.Products[i][1];
                let after_purchase = parseInt(stock)-product_quantity;
                this.Products[i][1] = after_purchase;
                console.log("\n\n");
                console.log("Purchase Summary");
                console.log('-------------------');
                console.log("You Purchased "+product_quantity+' '+product_name);
                console.log('-------------------');
                this.Product_summary_in_Invetory();
            }
        }
        
    }

    Order_Stock_for_Product(product_name:string,product_quantity:number):void
    {
        for(var i in this.Products)
        {
            if(this.Products[i][0]==product_name)
            {
                let stock:any = this.Products[i][1] ;
                let after_purchase = parseInt(stock)+product_quantity;
                this.Products[i][1] = after_purchase;
                console.log("stock added for "+product_name);
                this.Product_summary_in_Invetory();
            }
        }

    }

    Product_summary_in_Invetory():void
    {
        console.log('\n\n');
        console.log('-------------------------------------------------')
        console.log("Products_Summary")
        console.log('\n');
        for(var value of this.Products)
        {
            console.log(value[0]+'\t||\t'+value[1]);
        }
        console.log('-------------------------------------------------')
        console.log('\n\n');
    }

}

let shop = new Shop();

// Add new Product

console.log("\n\n");
console.log('***********************************');
console.log("New Product added");
console.log("Product"+'\t||\t'+"Stock");
shop.Add_Product_To_Invertory('Mobile',100);
shop.Add_Product_To_Invertory('Data-Cable',5);
shop.Add_Product_To_Invertory('Charge',100);
console.log('***********************************');

//purchase product
console.log('^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^');
shop.Purchase_Product('Data-Cable',3);
console.log('^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^');


//
console.log("--finished--");