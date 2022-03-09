
function set_service(evt, level) {


    /*  disable tab*/
    var ch = parseInt(level.charAt(2));

    for (j = ch + 1; j <= 4; j++) {

        document.getElementById("form" + j + "Btn").disabled = true;

    }

    /*  tab click*/
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
        var tabImg = "";
        tabImg = tablinks[i].children[0].src;
        if (tabImg.includes("-")) {

            var tabdashindex = tabImg.lastIndexOf("-");
            var tabpath = tabImg.substring(tabdashindex + 1, tabImg.length);

            tablinks[i].children[0].src = "";
            tablinks[i].children[0].src = (" ../image/" + tabpath);

        }


    }

    document.getElementById(level).style.display = "block";
    evt.currentTarget.className += " active";


    var imgSrc = evt.currentTarget.children[0].src;
    var slashindex = imgSrc.lastIndexOf("/");

    var path = imgSrc.substring(slashindex + 1, imgSrc.length);


    evt.currentTarget.children[0].src = "";
    evt.currentTarget.children[0].src = (" ../image/" + "white-" + path);

}


function extrabtnclick(id, i) {

    var discount = parseInt(document.getElementById("discount").innerHTML);
    var promo = parseInt(document.getElementById("promo").innerHTML);


    if (document.getElementById(id).checked) {
        document.getElementById(id + "Img").src = (" ../image/" + i + "-green.png");

        document.getElementById("extra" + i).style.display = "block";

        var total_time = parseFloat(document.getElementById("total_hours").innerHTML);
        document.getElementById("total_hours").innerHTML = total_time + 0.5;

        var total_price = parseFloat(document.getElementById("total_price").innerHTML);
        document.getElementById("total_price").innerHTML = total_price + 12.5;
        document.getElementById("priceAfterDiscount").innerHTML = total_price + 12.5 - discount;
        document.getElementById("priceAfterPromo").innerHTML = total_price + 12.5 - discount - promo;



    } else {
        document.getElementById(id + "Img").src = (" ../image/" + i + ".png");

        document.getElementById("extra" + i).style.display = "none";

        var total_time = parseFloat(document.getElementById("total_hours").innerHTML);
        document.getElementById("total_hours").innerHTML = total_time - 12.5;

        var total_price = parseFloat(document.getElementById("total_price").innerHTML);
        document.getElementById("total_price").innerHTML = total_price - 12.5;
        document.getElementById("priceAfterDiscount").innerHTML = total_price - 12.5 - discount;
        document.getElementById("priceAfterPromo").innerHTML = total_price - 12.5 - discount - promo;


    }
}

document.getElementById("defaultOpen").click();

function ClickFunction(id) {
    document.getElementById(id).click();

}


function Disable(id) {
    document.getElementById(id).disabled = true;
}
function Clickable(id) {
    document.getElementById(id).disabled = false;
}



Disable('form2Btn');
Disable('form3Btn');
Disable('form4Btn');








function postalSubmit() {

    var data = $("#form1").serialize();



    $.ajax({
        type: 'POST',
        url: '/Customer/ValidPostalCode',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: data,
        success: function (result) {
            if (result.value == "true") {
                Clickable("form2Btn");
                ClickFunction("form2Btn");

            }
            else if (result.value == "false") {
                alert("No service avaliable ");
            }
            else {
                alert("Invalid Postal code");
            }
        },
        error: function () {
            alert('Failed to receive the Data');

            console.log('Failed ');
        }
    });

}




function scheduleSubmit() {
    var data = $("#form2").serialize();
    console.log(data);

    alert(data.toString());

    //document.getElementById("form3").innerHTML="<h4>"+data.toString()+"</h4>";



    $.ajax({
        type: 'POST',
        url: '/Customer/ScheduleService',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: data,
        success: function (result) {
            if (result.value == "true") {
                Clickable("form3Btn");
                ClickFunction("form3Btn");
                loadAddress();

            }
            else {
                alert("schedule is not valid");
            }
        },
        error: function () {
            alert('Failed to receive the Data');
            console.log('Failed ');
        }
    });
}


function loadAddress() {

    var data = $("#form1").serialize();

    alert("Inside load address")

    $.ajax({
        type: 'get',
        url: '/customer/detailsservice',
        contenttype: 'application/x-www-form-urlencoded; charset=utf-8',
        data: data,

        success: function (result) {
            var address = $("#address");
            address.empty();
            address.append('<p>Please select your addreee:</p>');
            if (result.length == 0) {
                ClickFunction("addAddressBtn");
            }
            for (let i = 0; i < result.length; i++) {
                var checked = "";
                if (result[i].isDefault == true) {
                    checked = "checked";
                }



                address.append(' <div class="row radiobutton">' +
                    '<div style="max-width: 10px" class="col-1"><input type="radio" id=" ' + i + ' " ' + checked + ' name="address" value="' + result[i].addressId + '" /></div>' +
                    ' <div class="col-11"><label for="' + i + '"><span>Address:</span><br><span>' + result[i].addressLine1 + '</span>,&nbsp;<span>' + result[i].addressLine2 + '</span><br><span>' + result[i].city + '</span>&nbsp;<span>' + result[i].postalCode + '</span>' +
                    '<br><span>PHONE NUMBER:</span> ' + result[i].mobile + ' <span></span></label></div> </div>');




                checked = "";
            }
            console.log(result);
        },
        error: function () {
            alert('failed to receive the data');
            console.log('failed ');
        }
    });
}


function addAddressdiv() {
    document.getElementById('addAddressBtn').style.display = "none";
    document.getElementById('addNewaddressDiv').style.display = "block";
    document.getElementById('addAddressPostalCode').value = document.getElementById("postalcode").value;
    document.getElementById('addAddressPostalCode').disabled = true;

    getCityFromPostalCode(document.getElementById("postalcode").value);


}


function saveAddress() {



    var data = {};
    data.AddressLine1 = document.getElementById("AddressLine1").value;
    data.AddressLine2 = document.getElementById("AddressLine2").value;
    data.PostalCode = document.getElementById("addAddressPostalCode").value;
    data.City = document.getElementById("City").value;
    data.State = document.getElementById("State").value;
    data.Mobile = document.getElementById("Mobile").value;
    




    $.ajax({
        type: 'POST',
        url: '/Customer/AddNewAddress',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: data,
        success: function (result) {
            if (result.value == "true") {


                ClickFunction("addressCancelBtn");
                loadAddress();

            }
            else {
                //$("#detailServiceAlert").removeClass("d-none").text("Sorry! Something went wrong please try again later.");
            }
        },
        error: function () {
            alert('Failed to receive the Data');
            console.log('Failed ');
        }
    });
}




function cancelAddress() {
    document.getElementById("addNewaddressDiv").style.display = "none";
    document.getElementById('addAddressBtn').style.display = "block";


}





function completeBookService() {
    var data = {};
    var extrahour = 0;
    var cabinet = document.getElementById("InsideCabinat");
    var window = document.getElementById("InsideWindow");
    var fridge = document.getElementById("InsideFridge");
    var oven = document.getElementById("InsideOven");
    var laundry = document.getElementById("InsideLaundry");

    if (cabinet.checked == true) {
        extrahour += 0.5;
        data.cabinet = true;
    }
    if (window.checked == true) {
        extrahour += 0.5;
        data.window = true;
    }
    if (fridge.checked == true) {
        extrahour += 0.5;
        data.fridge = true;
    }
    if (oven.checked == true) {
        extrahour += 0.5;
        data.oven = true;
    }
    if (laundry.checked == true) {
        extrahour += 0.5;
        data.laundry = true;
    }
    data.postalCode = document.getElementById("postalcode").value;

    //var temp=document.getElementById("Date");
    //alert(temp.value);
    //var date=new Date(temp.value);
    //alert(date);

    //date.setHours(data.startTime,0,0,0);
    //alert(date+"after set hours")
    // const a = date.toISOString().split('T')[0];
    // const b = date.toTimeString().split(' ')[0];
    //date=a+" "+b;

    var temp = document.getElementById("Date").value;
    data.serviceStartDate = temp + " " + document.getElementById("Time").value;



    data.serviceHours = document.getElementById("Duration").value;
    data.extraHours = extrahour;
    var duration = parseFloat(document.getElementById("Duration").value);
    var extra = parseFloat(extrahour);
    // data.subTotal = (extrahour * 25) + ((document.getElementById("Duration").value) * 25);
    data.subTotal = (extra + duration) * 25;
    data.totalCost = data.subTotal; //Discount 0(out of scope)
    data.comments = document.getElementById("comments").value;

    data.HasPets = document.getElementById("flexCheckDefault").checked;
    alert(document.getElementById("flexCheckDefault").checked);



    //data.addressId = $('#addresses div input[type=radio]:checked').val();
    data.addressId = document.querySelector('input[name="address"]:checked').value;
    alert(data.addressId);

    $.ajax({
        type: 'post',
        url: '/customer/completebooking',
        contenttype: 'application/x-www-form-urlencoded; charset=utf-8',
        data: data,
        success: function (result) {
            if (result.value == "false") {

                $('#ModalLabel_SID').text("Opps! Something Went wrong").css("color", "red");
                $('#Model_SID').text("Please Try again");
                ClickFunction("complete");

            }
            else {
                $('#ModalLabel_SID').text("Service Request has been Created Successfully").css("color", "Green");
                $('#Model_SID').text("Your service id : " + result.value);
                ClickFunction("complete");

            }
        },

        error: function () {
            alert('failed to receive the data');
            console.log('failed ');
        }
    });
}





$(document).ready(function () {


    var ServiceTime = $(".ForTime option:selected").text();
    document.querySelector(".SIForTime").innerHTML = ServiceTime;

    $(".ForTime").on("change", function () {
        var ChangeServiceTime = $(".ForTime option:selected").text();
        document.querySelector(".SIForTime").innerHTML = ChangeServiceTime;

    });

});




$(document).ready(function () {


    var Duration = $(".ForDuration option:selected").val();
    document.querySelector(".SIForDuration").innerHTML = Duration;

    $(".ForDuration").on("change", function () {
        var basic_time = $(".SIForDuration").text();
        var total_time = $("#total_hours").text();
        var extra_time = parseFloat(total_time - basic_time);
        var ChangeDuration = $(".ForDuration option:selected").val();
        var newtotal_time = parseFloat(ChangeDuration) + extra_time;
        var discount = parseInt(document.querySelector("#discount").innerHTML);
        var promo = parseInt(document.querySelector("#promo").innerHTML);
        var new_price = newtotal_time * 25;
        document.querySelector(".SIForDuration").innerHTML = ChangeDuration;
        document.querySelector("#total_hours").innerHTML = newtotal_time;
        document.querySelector("#total_price").innerHTML = new_price;
        document.querySelector('#priceAfterDiscount').innerHTML = new_price - discount;
        document.querySelector('#priceAfterPromo').innerHTML = new_price - discount - promo;

    });

});







$(document).ready(function () {
   

    selected = $(".ForDate").val();
    document.querySelector('.SIForDate').innerHTML = selected;


    $(".ForDate").on("change", function () {
        selected = $(this).val();

        document.querySelector('.SIForDate').innerHTML = selected;

    });

   
});








$(document).ready(function () {

    Counter = 0;
    Disable("addAddressSubmit");
    // Street Validation
    $('.street').on('focusout', function () {
        var Streetname = $(this).val();
        var validName = /^[a-zA-Z ]*$/;
        if (Streetname.length == 0) {
            $('.street-msg').addClass('Validation-Error').text("Street is required")
            Disable("addAddressSubmit");

        }
        else if (!validName.test(Streetname)) {
            $('.street-msg').addClass('Validation-Error').text('please enter valid input');
            Disable("addAddressSubmit");

        }
        else {
            $('.street-msg').empty();
            Counter = Counter + 1;
            if (Counter == 3) {
                Clickable("addAddressSubmit")
            }
        }
    });

    //   Phone Number validation
    $('.mobile').on('focusout', function () {
        var mobileNum = $(this).val();
        var validNumber = /\(?([0-9]{3})\)?([ .-]?)([0-9]{3})\2([0-9]{4})/;
        if (mobileNum.length == 0) {
            Disable("addAddressSubmit");
            $('.mobile-msg').addClass('Validation-Error').text('Mobile Number is required');
        }
        else if (!validNumber.test(mobileNum)) {
            Disable("addAddressSubmit");
            $('.mobile-msg').addClass('Validation-Error').text('Invalid Mobile Number');
        }
        else {
            $('.mobile-msg').empty();
            Counter = Counter + 1;
            if (Counter == 3) {
                Clickable("addAddressSubmit")
            }
        }
    });

 
    $('.houseno').on('focusout', function () {
        var houseNum = $(this).val();
 
        if (houseNum.length == 0) {
            Disable("addAddressSubmit");
            $('.houseno-msg').addClass('Validation-Error').text('House Number is required');

        }
       
        else {
            $('.house-msg').empty();
            Counter = Counter + 1;
            if (Counter == 3) {
                Clickable("addAddressSubmit")
            }
        }
    });
});


function getCityFromPostalCode(zip) {
    $.ajax({
        
        method: "GET",
        url: "https://api.postalpincode.in/pincode/" + zip,
        dataType: 'json',
        cache: false,
        success: function (result) {
            if (result[0].status == "Error" || result[0].status == "404") {
                $("#mSaddAddressAlert").removeClass("alert-success d-none").addClass("alert-danger").text("Enter Valid PostalCode.");

            }
            else {

                $("#City").val(result[0].PostOffice[0].District);
                $("#State").val(result[0].PostOffice[0].State).prop("disabled", true);
                $("#City").prop("disabled", true);
                $("#State").prop("disabled", true);
            }
        },
        error: function (error) {

        }
    });
}





