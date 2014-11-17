﻿$(document).ready(function() {
    //Zoom
    $('#product-image-details').elevateZoom({
        zoomType: "inner",
        cursor: "crosshair",
        zoomWindowFadeIn: 500,
        zoomWindowFadeOut: 750
    });

    //Counter --
    $('#decrease_quantity').click(function() {
        var value = $('#quantity_counter').val();
        if (value > 1)
            value--;
        $('#quantity_counter').val(value);
    });

    $('#add-to-cart-animation').hide();

    //Counter key control
    $("#quantity_counter").keypress(function(e) {
        if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57))
            return false;
        if ($('#quantity_counter').val().length == 0 && e.which == 48)
            return false;
    });


    //Ajax add to cart from details
    $('.add-to-cart-button').click(function() {
        var url = $('#addtocartform').attr("action");
        var formData = $('#addtocartform').serialize();
        $.ajax({
            url: url,
            type: "POST",
            data: formData
        }).success(function(data) {
            var target = $('#CartTotalValue');
            target.empty();
            target.append(data);
        });
    });
});