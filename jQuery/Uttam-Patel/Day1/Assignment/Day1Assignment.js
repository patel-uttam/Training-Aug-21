function select(){
    $(document.body).prepend($("<b></b>").html("Select Country from below list"))
    $("select").wrap("<div id='select_country'></div>")
    $("#select_country").css("margin","10px")
    $("label").text("Slected Country will show here")
    $('select').on('click',function()
    {
            $('label').text('')
            $('label').css("color" , "blue")
            $('label').text(("Your Selected Country: "+$(this).val()))
    }
    )
}
