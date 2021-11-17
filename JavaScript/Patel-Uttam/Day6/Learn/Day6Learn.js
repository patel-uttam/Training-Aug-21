/* web fetch api*/

///////////////////////////////////////////////////////
async function LoadIntoTable(src , table)
{
    const head = table.querySelector("thead");
    const body = table.querySelector("tbody");
    const json_fetch =  await fetch(src);
    const { headers , rows } = await json_fetch.json();
    
    

    // cleaning table data
    head.innerHTML = "<tr></tr>";
    body.innerHTML = "<tr></tr>";

    // load data in header

    for (const header_data of headers)
    {
        const header_th  = document.createElement("th");
        header_th.textContent = header_data;
        head.querySelector("tr").appendChild(header_th);
    }

    console.log(rows);
    for (const row of rows)
    {
        const body_tr  = document.createElement("tr");
        for (const body_data of row)
        {
            const body_td  = document.createElement("td");
            body_td.textContent = body_data;
            body_tr.appendChild(body_td);
        }
        body.appendChild(body_tr);
    }    
}

LoadIntoTable("./Data.json" , document.querySelector("table"));

///////////////////////////////////////////////////////////////////


/* web storage api*/

///////////////////////////////////////////////////////////////////

// /* localstorage */
// console.log("Local Storage");
// localStorage.setItem("Name","Uttam");
// console.log(localStorage.getItem("Name"));
// localStorage.setItem("Email","qwe@asd.com");
// console.log(localStorage.getItem("Email"));
// localStorage.removeItem("Name");
// console.log("after removing item");
// console.log(localStorage.getItem("Name"));
// console.log(localStorage.getItem("Email"));
// console.log("After clear ");
// localStorage.clear();
// console.log(localStorage.getItem("Name"));
// console.log(localStorage.getItem("Email"));
// localStorage.setItem("Name","Uttam");
// console.log(localStorage.getItem("Name"));
// localStorage.setItem("Email","qwe@asd.com");
// console.log(localStorage.getItem("Email"));
// console.log("/n");
// console.log("/n");
// /* sessionstorage */
// console.log("Session Storage");
// sessionStorage.setItem("Name","Uttam");
// console.log(sessionStorage.getItem("Name"));
// sessionStorage.setItem("Email","qwe@asd.com");
// console.log(sessionStorage.getItem("Email"));
// sessionStorage.removeItem("Name");
// console.log("after removing item");
// console.log(sessionStorage.getItem("Name"));
// console.log(sessionStorage.getItem("Email"));
// console.log("After clear ");
// sessionStorage.clear();
// console.log(sessionStorage.getItem("Name"));
// console.log(sessionStorage.getItem("Email"));
// sessionStorage.setItem("Name","Uttam");
// console.log(sessionStorage.getItem("Name"));
// sessionStorage.setItem("Email","qwe@asd.com");
// console.log(sessionStorage.getItem("Email"));

///////////////////////////////////////////////////////////////////


/* web geolocation api */
///////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////

 
