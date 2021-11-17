// Ancestors
    // parent()
    $( ".item-1" ).parent().css( "background-color", "red" );

 
    $( "p" ).parent( ".selected_p" ).css( "background", "yellow" );
    
    // parents()
    
    $(".item-i").parents("ul").css("background-color", "blue")

    $(".div_").append($("<p>div depth is</p>"));
    $(".span_").click(function(){
        let div_depth = $(this).parents("div").length;
        $(this).css("transition","5s");
        $(this).css("color","red");

        $(".div_ p").text( this.id+" span has" + " : "+div_depth + " parent div");
    
    })

    // parentUntil()
        $(" .div_li_1_1_1").parentsUntil(".div_1_1").css("background-color", "blue");
        $(" .div_li_1_1_2").parentsUntil(".div_1_1").css("border", "1px solid grey" );
        $(" .div_li_1_1_2").parentsUntil(".div_1_1").css("margin","10px");
        $(" .div_li_1_2_1").parentsUntil(".div_1_2").css("background-color", "yellow");
        $(" .div_li_1_3").parentsUntil(".div_1_3").css("background-color", "red");


    // Descendants

    // Children()
    $(".div_1_1_2").children().css("color" , "orange");

    $("#div_child").css("border","2px solid grey");
    $("#div_child").css("margin","20px");
    $("#div_child").css("padding","20px 100px");
    $("#div_child").children(".selected").css("color" , "blue")

    // Find()

    $("li.item-ii" , ".div_find").find("li").css("color","red")
    



    // Filtering
    // first()


    // last()
    
    
    // eq()
    
    $("ul .li_eq", ".div_eq" ).eq(3).css("background-color" , "red");
    $("ul .li_eq", ".div_eq" ).eq(-4).css("background-color" , "red"); // negative indexing
    // filter()
    $("ul .li_filter", ".div_filter" ).filter(".index-i").css("background-color" , "blue");
    $("ul .li_filter", ".div_filter" ).filter(":nth-child(2n)").css("color" , "orange");
    $("ul .li_filter", ".div_filter" ).filter(function(index){
        return index % 2 == 0;
    }).css("font-size" , "25px");

    // $("ul .li_filter", ".div_filter" ).filter(-4).css("background-color" , "red"); // negative indexing


    // not()
    $("ul .li_filter", ".div_filter" ).not(".li_not2").css("border","1px solid pink");

    $("ul .li_not").not(".li_not2").css("visibility","hidden"); 


// AJAX

    //load
    $("#div_load_1").load("Day2text.txt #p1 , #p2").css("background-color" , "blue");

    $("#div_load_2").load("Day2text.txt #div_").css("background-color" , "gray");

    function load_text()
    {
        $("#div_load").load("Day2text.txt" , function(responseTxt , statusTxt , xhr)
        {
            if(statusTxt == "success")
            {
                alert("Day2text load complete");
            }
            if(statusTxt == "error")
            {
                alert("Day2text load not complete   "+" error is  "+xhr.status +" : "+xhr.statusTxt );
            }
        })
    }

    // get

    function get_data()
    {
        $.get("Day2get.php",function(data,status)
        {
            alert("Data from file : "+data+ " \n "+"Status for request : "+status);
        });
    }

    // post
    function put_data()
    {
        $.post("Day2Learn.js",
        function(data){
          alert("Data: " + data );
        });
    }

    // get json 1
    function getJSON_data_1()
    {   $("#div_getJSON_p_1").text("");
        $.getJSON("Day2JSON1.json",function(data,status){
            $.each(data,function(key,value){
            $("#div_getJSON_p_1").append(value+" ");
            })
        });;
    }


    // get json 2
    function getJSON_data_2()
    {   
        $.getJSON("Day2JSON2.json",function(data,status){
            $("#div_getJSON_p_2").text("");
            $.each(data.Employees,function(){
            $("#div_getJSON_p_2").append("[ "+"Id" +" : "+this.ID+" , "+"Name"+" : "+this.Name+" ] ");
            })
        });;
    }