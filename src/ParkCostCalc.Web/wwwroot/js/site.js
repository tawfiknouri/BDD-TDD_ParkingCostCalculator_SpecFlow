// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// js initialization

function validateLogin() {

}
$(document).ready(function () {

    initalizePage();

    // Set up an event listener for the contact form.
    $("#parking-calc-form").submit(function (event) {
        // Stop the browser from submitting the form.
        event.preventDefault();
        calculateCost();
    });


    // Set up an event listener for the contact form.
    $("#parking-calc-contact").submit(function (event) {
        // Stop the browser from submitting the form.
        event.preventDefault();
        alert("test ojk");
        contactRequest();
    });


    //flatpickr
    var entryDateConfig = {
        enableTime: false,
        dateFormat: "Y-m-d",
        allowInput: true,
        defaultDate: new Date(),
    };

    var entryTimeConfig = {
        enableTime: true,
        noCalendar: true,
        dateFormat: "H:i",
        allowInput: true,
        defaultDate: new Date(),
    };

    $("#entry-date").flatpickr(entryDateConfig);
    $("#entry-time").flatpickr(entryTimeConfig);

    var exitDateConfig = {
        enableTime: false,
        dateFormat: "Y-m-d",
        allowInput: true,
        defaultDate: new Date(),
    };

    var exitTimeConfig = {
        enableTime: true,
        noCalendar: true,
        dateFormat: "H:i",
        allowInput: true,
        defaultDate: new Date(),
    };


    $("#exit-date").flatpickr(exitDateConfig);
    $("#exit-time").flatpickr(exitTimeConfig);

    //$("#reset").click(sendReset);
})


function setClean() {
    $("#msg-error").hide();
    $("#msg-success").hide();
}


function initalizePage() {
    $("#cost-result-success").hide();
    $("#cost-result-error").hide();
    $("#btn-calculate-cost").prop("disabled", false);
}

function calculateCost() {

    var entryDate = $("#entry-date").val();
    var exitDate = $("#exit-date").val();
    var entryTime = $("#entry-time").val();
    var exitTime = $("#exit-time").val();
    var parkingLot = $("#parking-lot").val();

    var entryDateTime = entryDate + "T" + entryTime;
    var exitDateTime = exitDate + "T" + exitTime;


    $("#cost-result-success").hide();
    $("#cost-result-error").hide();
    $("#btn-calculate-cost").prop("disabled", true);

    //$('#cost-processing-dialog').modal('show');

    var parkingData = { ParkType: parkingLot, EntryDate: entryDateTime, ExitDate: exitDateTime };

    $.ajax({
        type: 'POST',
        url: "http://localhost:5000/CostCalculator",
        data: JSON.stringify(parkingData),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        error: function (errorDetails) {

            $("#btn-calculate-cost").prop("disabled", false);

            $('#cost-processing-dialog').modal('hide');
            //$("#cost-error-message").text(errorDetails.responseJSON.error.message);
            $("#cost-error-message").text("An error occurred while processing your request."); // ????

            $("#cost-result-error").show();

        },
        success: function (result) {

            $("#btn-calculate-cost").prop("disabled", false);
            $('#cost-processing-dialog').modal('hide');
            var costMessage = "";

            var costMessage = result.days + " Day(s), " + result.hours + " Hour(s), " + result.minutes + " Minute(s)";

            $("#cost-value").text(result.cost + result.currency);
            $("#cost-message").text(costMessage);
            $("#cost-result-success").show();

        }
    });
}




function contactRequest() {

    var name = $("#contact-name").val();
    var email = $("#contact-email").val();
    var subject = $("#contact-subject").val();
    var message = $("#contact-message").val();
    


    var contactRequest = { Name: name, Email: email, Subject: subject, Message: message };

    $.ajax({
        type: 'POST',
        url: "http://localhost:5000/Contact",
        data: JSON.stringify(contactRequest),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        error: function (errorDetails) {

        },
        success: function (result) {
            alert("Thank you for your message !");
            location.reload();
        }
    });
}
