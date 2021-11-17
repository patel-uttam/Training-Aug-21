$("span" , ".prac_1").parent().css("font-size","25px");

    
let prac_2_class ;
$("span" , ".prac_2").click(function()
{
     prac_2_class =  $(this).parents("div").length;
     console.log(prac_2_class);

});

$(".prac_3").children().css("background-color" , "yellow")
$(".prac_3").children(".prac_3_1").css("color" , "red")

$(".prac_4").find("span").css("background-color","green")


$("h2" , ".prac_5").siblings().css("color" , "red");


$(".prac_6 p").first().css("background-color" , "grey");
$(".prac_6 p").eq(3).css("background-color" , "blue"); // for particular index

