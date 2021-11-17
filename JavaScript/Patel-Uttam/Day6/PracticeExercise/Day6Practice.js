// adding json to localstrorage

async function LoadIntoTable_From_LocalStorage(src , table)
{
    const body = table.querySelector("tbody");
    const json_fetch =  await fetch(src);
    let json_data_fetch = await json_fetch.json();
    let json_data = JSON.stringify(json_data_fetch);
    console.log(json_data);
    
    // store in local storage
    localStorage.setItem("products",json_data);

    // fetch from local storage
    let json_from_local = localStorage.getItem("products");
    let json_data_parse = JSON.parse(json_from_local);
    console.log(json_data_parse);
    
    // load data in body

    for(i of json_data_parse.products)
    {
        body_tr = document.createElement("tr");
        const body_td_name  = document.createElement("td");
        const body_td_price  = document.createElement("td");
        const body_td_location = document.createElement("td");
        body_td_name.textContent = i.Name;
        body_td_price.textContent = i.Price;
        body_td_location.textContent = i.Location;
        body_tr.appendChild(body_td_name);
        body_tr.appendChild(body_td_price);
        body_tr.appendChild(body_td_location);
        console.log("done");
        body.appendChild(body_tr);
    }
    
}

LoadIntoTable_From_LocalStorage("./Practice_Data.json",document.querySelector("table"));