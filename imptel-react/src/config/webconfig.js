$(document).ready(function() {
    setMainContentHeight();

    $(window).resize(function() {
        setMainContentHeight();
    })
});


function setMainContentHeight() {
    $("main").css({
        height: `${$(this).height() + 300}px` 
    })
}