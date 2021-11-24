console.log("typescript Day2 assignment");
var Shop = /** @class */ (function () {
    function Shop() {
        this.Products = [];
    }
    Shop.prototype.Add_Product_To_Invertory = function (product_name, product_quantity) {
        this.Product = product_name;
        this.In_Stock = product_quantity;
        var product_tuple;
        product_tuple = [this.Product, this.In_Stock];
        this.Products.push(product_tuple);
        for (var _i = 0, _a = this.Products; _i < _a.length; _i++) {
            var value = _a[_i];
            console.log(value[0] + ' : ' + value[1]);
        }
        console.log('\n\n');
    };
    Shop.prototype.Purchase_Product = function (product_name, product_quantity) {
        var product_tuple;
        product_tuple = [product_name, product_quantity];
        for (var i in this.Products) {
            if (this.Products[i][0] == product_tuple[0]) {
                var stock = this.Products[i][1];
                if (parseInt(stock) <= 5) {
                    this.Order_Stock_for_Product(this.Products[i][0].toString(), 100);
                }
                stock = this.Products[i][1];
                var after_purchase = parseInt(stock) - product_quantity;
                this.Products[i][1] = after_purchase;
                console.log("\n\n");
                console.log("Purchase Summary");
                console.log('-------------------');
                console.log("You Purchased " + product_quantity + ' ' + product_name);
                console.log('-------------------');
                this.Product_summary_in_Invetory();
            }
        }
    };
    Shop.prototype.Order_Stock_for_Product = function (product_name, product_quantity) {
        for (var i in this.Products) {
            if (this.Products[i][0] == product_name) {
                var stock = this.Products[i][1];
                var after_purchase = parseInt(stock) + product_quantity;
                this.Products[i][1] = after_purchase;
                console.log("stock added for " + product_name);
                this.Product_summary_in_Invetory();
            }
        }
    };
    Shop.prototype.Product_summary_in_Invetory = function () {
        console.log('\n\n');
        console.log('-------------------------------------------------');
        console.log("Products_Summary");
        console.log('\n');
        for (var _i = 0, _a = this.Products; _i < _a.length; _i++) {
            var value = _a[_i];
            console.log(value[0] + '\t||\t' + value[1]);
        }
        console.log('-------------------------------------------------');
        console.log('\n\n');
    };
    return Shop;
}());
var shop = new Shop();
// Add new Product
console.log("\n\n");
console.log('***********************************');
console.log("New Product added");
console.log("Product" + '\t||\t' + "Stock");
shop.Add_Product_To_Invertory('Mobile', 100);
shop.Add_Product_To_Invertory('Data-Cable', 5);
shop.Add_Product_To_Invertory('Charge', 100);
console.log('***********************************');
//purchase product
console.log('^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^');
shop.Purchase_Product('Data-Cable', 3);
console.log('^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^');
//
console.log("--finished--");
