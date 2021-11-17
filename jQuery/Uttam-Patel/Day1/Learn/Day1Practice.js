
        $(document).ready(() => {
            $(document.body).prepend($("#headig").html("<p>Practice Exercise</p>"))
             
             //Practice 1
             var p = $('<div id="p_tag"><p></p></div>').text('It is Dummy Text');
             p.css('background-color', 'blue')
             p.appendTo('body')
 
             //Practice 2
             var span = $('<span id="helpText"></span>').text('Hover mouse to hide this text')
             $('body').append(span)
             $("#helpText").wrap("<div id='dummyText'></div>")
 
             $('#helpText').hover(function () 
             { 
                 $("#helpText").hide()
 
             }, 
             function () 
             { 
                 $("#helpText").show() 
                 $(this).css("color","red","width","100px")
             }) 
              
             //Practice 3
             $("#select").html("Please select your technology :")
             $(':radio').on('click',function(){
                 $('#selected').text("")
                 var radio_value = $(this).val();
                 $('#selected').text(("You have selected: " + radio_value))})
             })
 
 