$(function () {
    $("#menu .l1").each(function (i) {
        var marginwidth = 0;
        for (var j = 0; j < i + 1; j++) {
            marginwidth += $("#menu .l1").eq(j).width() + 30;
        }
        $("#navLevel2Wrapperid" + (i + 1)).css("margin-left", marginwidth);
    });
});
