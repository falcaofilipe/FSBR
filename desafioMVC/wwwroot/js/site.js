// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    $("#npu").inputmask("mask", {
        "mask": "9999999-99.9999.9.99.9999"
    }, {
        reverse: false
    });
})
