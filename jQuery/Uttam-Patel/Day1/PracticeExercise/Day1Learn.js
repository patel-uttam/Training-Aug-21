/* Selector */
$("h1").text("Hello");

$("#h4").text("World");

$(".h_common").text("common h tag");

/* Event */

// mouse
$("#click").click(function(){
    $("#click_btn").text("Click button is Clicked");
});

$("#dbl_click").dblclick(function(){
    $("#click_dblbtn").text("Double Click button is Clicked");
});

$("#mouse_over").mouseenter(function(){
    $("#over_btn").text("Mouse Over button is over ");
});

$("#mouse_away").mouseleave(function(){
    $("#away_btn").text("Mouse Away button is away");
},);

$("#hover").hover(function(){
    $("#hover_btn").text("Hover button is hover");
},
function(){
    $("#hover_btn").text("Hover button is not hover");
}
);


// form

// window event

/* Hide, show, Toggle, fadeIn, fadeout */

$("#show").click(function(){
    $("#text").show();
});

$("#hide").click(function(){
    $("#text").hide();
});

$("#hide_slow").click(function(){
    $("#text").hide("slow");
});

$("#hide_fast").click(function(){
    $("#text").hide("fast");
});

$("#hide_milisecond").click(function(){
    $("#text").hide(5000);
});


/* DOM Manipulation */

// text() 

//html()

//val()

//attr()

/* Append */


/* iterate */

//$(" ").each()


$("#button_list1" ).click(function() {
  $( ".list" ).each(function() {
    $( this ).text("Hi");
    $( this ).toggleClass( "li_class" );
  });
});

$("#button_list2" ).click(function() {
    $( ".list2" ).each(function() {
      if($(this).is("#day4"))
      {
        $("#day4").text("iteration stop");
        $(this).toggleClass("li_class");
      }
    });
  });