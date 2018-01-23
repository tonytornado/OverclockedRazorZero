// Write your Javascript code.

// GOOGLE MAPS CODE //
function myMap() {
    var mapProp = {
        center: new google.maps.LatLng(38.200946, -85.601353),
        zoom: 10,
    };
    var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);
}

// SLIDE IN CODE //
var scrollText = $('body div.parallax');

scrollText.delay(2000).fadeIn(2000);