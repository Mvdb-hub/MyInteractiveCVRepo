// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(window).scroll(function (e) {

    // add/remove class to navbar when scrolling to hide/show
    var scroll = $(window).scrollTop();
    if (scroll >= 10) {
        $('.navbar').addClass("navbar-bg-white").removeClass("navbar-bg-clear");
    } else {
        $('.navbar').removeClass("navbar-bg-white").addClass("navbar-bg-clear");
    }

});

$(function () {
    ChangeNavbarActiveClass();
    SmoothPageRollOnClick();
});

function ChangeNavbarActiveClass() {
    $('ul.navbar-nav li').on('click', function () {
        $(this).parent().find('li.active').removeClass('active');
        $(this).addClass('active');
    });
}

function SmoothPageRollOnClick() {
    $('a[href^="#"]').on('click', function (event) {
        // Prevent default anchor click behavior
        event.preventDefault();

        // Store hash
        var hash = this.hash;

        // Using jQuery's animate() method to add smooth page scroll
        $('html, body').animate({
            scrollTop: $(hash).offset().top
        }, 500, function () {

            // Add hash (#) to URL when done scrolling (default click behavior)
            window.location.hash = hash;
        });
    });
}