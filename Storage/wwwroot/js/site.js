// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Add a closure named mainController that has the function pleaseWait() in it
var mainController = (function () {
    // ************************************
    // Private Functions
    // ************************************
    //Disable Links and Buttons Using jQuery
    function disableAllClicks() {
        $("a").css("cursor", "arrow").click(false);
        $("input[type='button']").attr("disabled", "disabled");
        $("button").attr("disabled", "disabled");
    }
   
       function pleaseWait(ctl) {

          
           // Was a control passed in?
        if (ctl) {
            // Look for a data-waitmsg="message"
            // on the control clicked on
            let msg = $(ctl).data("waitmsg");
            if (msg) {
                $("#theWaitMessage").html(msg);
            }
        }

        $("#pleaseWait").removeClass("d-none");
        $("header").addClass("pleaseWaitArea");
        $("main").addClass("pleaseWaitArea");
        $("footer").addClass("pleaseWaitArea");
        //disableAllClicks();
        }

    // ************************************
    // Public Functions
    // ************************************
    


    return {
        "pleaseWait": pleaseWait
        //"disableAllClicks": disableAllClicks
       
    }
})();

