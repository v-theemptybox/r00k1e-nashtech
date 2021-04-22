$(document).ready(function () {
    //add view more btn
    var list = $(".item");
    var numToShow = 4;
    var allBtn = $("#all");


    var button = $("#next");
    var numInList = list.length;
    list.hide();
    //show all item
    if (numInList <= numToShow)
        allBtn.hide();
    allBtn.click(function () {
        list.show();
        button.hide();
    })

    if (numInList > numToShow) {
        button.show();
    }
    //show từ 0-4 item
    list.slice(0, numToShow).show();
    //event click view 4 item mỗi lần click
    button.click(function () {
        var showing = list.filter(':visible').length;
        list.slice(showing - 1, showing + numToShow).fadeIn();
        var nowShowing = list.filter(':visible').length;
        if (nowShowing >= numInList) {
            button.hide();
        }
    });

});