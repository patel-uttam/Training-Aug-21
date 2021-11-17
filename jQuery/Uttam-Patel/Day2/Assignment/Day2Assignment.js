$(document).ready(function () 
{
    
    $.getJSON("https://gorest.co.in/public-api/users",function(result)
    {
        var table_tr;
        $(result.data).each(function()
        {
            table_tr +='<tr>';
            table_tr +='<td>'+this.id+'</td>';
            table_tr +='<td>'+this.name+'</td>';
            table_tr +='<td>'+this.email+'</td>';
            table_tr +='<td>'+this.gender+'</td>';
            table_tr +='<td>'+this.status+'</td>';
            table_tr +='</tr>'; 
        });
        $("#data_table").append(table_tr);
    });
    
});