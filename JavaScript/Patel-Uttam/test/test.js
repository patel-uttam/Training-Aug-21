function fetch_data()
{
        $.getJSON("https://gorest.co.in/public/v1/posts",function(json_data,status){
        var tr_data;
        $(json_data.data).each(function()
        {
            tr_data += "<tr>";
            tr_data += "<td class=\"text-danger\">"+this.id+"</td>";
            tr_data += "<td>"+this.user_id+"</td>";
            tr_data += "<td>"+this.title+"</td>";
            tr_data += "<td>"+this.body+"</td>";
            tr_data += "</tr>";
        });
        $("#data_for_table").append(tr_data);
        $("#data_for_table caption h3").append('This data is Fetch from "https://gorest.co.in/public/v1/posts"');
        if(status == "success")
        {
            $("#fetch_status_p").text("Fetch complete status is : "+status);
        }
        if(status == "error")
        {
            $("#fetch_status_p").text("Fetch not complete status is : "+status);
        }       
    });

}