$(document).ready(function () {

    var counter = 0;
    var startSliceL2 = 0;
    var endSliceL2 = 0;
    var level2WrapperCounter = 0;

    var isfirst = true;

    $('#menu ul li').each(function () {
        // check this li's class
        if ($(this).hasClass("l1")) {
            counter++;
            $(this).attr('id', 'navLevel1id' + counter);

            // skip the first item for the divider - the divider draws before the level one item (hence prepend)
            if (!isfirst) {
                $(this).prepend('<div class="l1_divider"></div>');
            }
            isfirst = false;
        }
    });

    counter = 0;

    // go though the list and add the level 2 wrapper
    $('#menu ul li').each(function () {
        // check this li's class
        if ($(this).hasClass("l1")) {
            if (counter != 0) {
                startSliceL2++;
                endSliceL2++;
                if (startSliceL2 < endSliceL2) {
                    level2WrapperCounter++;
                    $('#menu ul li').slice(startSliceL2, endSliceL2).wrapAll('<div class="navLevel2wrapper" id="navLevel2Wrapperid' + level2WrapperCounter + '"></div>');
                }
            }
            startSliceL2 = counter;
        }
        else { // l2						
            endSliceL2 = counter;
        }
        counter++;
    });

    if (counter != 0) {
        startSliceL2++;
        endSliceL2++;
        if (startSliceL2 < endSliceL2) {
            level2WrapperCounter++;
            $('#menu ul li').slice(startSliceL2, endSliceL2).wrapAll('<div class="navLevel2wrapper" id="navLevel2Wrapperid' + level2WrapperCounter + '"></div>');
        }
    }

    var startSliceL3 = 0;
    var endSliceL3 = 0;
    var level3WrapperCounter = 0;
    counter = 0;

    // go though the list and add the level 3 wrapper
    $('#menu ul li').each(function () {
        // check this li's class
        if ($(this).hasClass("l1")) {
            if (counter != 0) {
                startSliceL3++;
                endSliceL3++;
                if (startSliceL3 < endSliceL3) {
                    level3WrapperCounter++;
                    $('#menu ul li').slice(startSliceL3 - 1, endSliceL3).wrapAll('<div class="navLevel3wrapper" id="navLevel3id' + level3WrapperCounter + '"></div>');
                }
            }
            startSliceL3 = counter;
        }
        else if ($(this).hasClass("l2")) {

            if (counter != 0) {
                startSliceL3++;
                endSliceL3++;
                if (startSliceL3 < endSliceL3) {
                    level3WrapperCounter++;
                    $('#menu ul li').slice(startSliceL3 - 1, endSliceL3).wrapAll('<div class="navLevel3wrapper" id="navLevel3id' + level3WrapperCounter + '"></div>');
                }
            }
            startSliceL3 = counter;
        }
        else { // l3
            endSliceL3 = counter;
        }
        counter++;
    });

    if (counter != 0) {
        startSliceL3++;
        endSliceL3++;
        if (startSliceL3 < endSliceL3) {
            level3WrapperCounter++;
            $('#menu ul li').slice(startSliceL3 - 1, endSliceL3).wrapAll('<div class="navLevel3wrapper" id="navLevel3id' + level3WrapperCounter + '"></div>');
        }
    }

    // traverse list and add 'level3_dropdown' and disable level 2 and level 3 links
    var previousMenuItem;
    $('#menu ul li').each(function () {
        // check this li's class
        if (previousMenuItem != null) {
            // if this is l3 and previous one was l2 then disable the l2
            if ($(this).hasClass("l3")) {
                if (previousMenuItem.hasClass("l2")) {
                    if (previousMenuItem.children('a').attr("href")) {
                        previousMenuItem.children('a').attr("x-href", previousMenuItem.children('a').attr("href"));
                        previousMenuItem.children('a').removeAttr("href");
                    }
                    previousMenuItem.children('a').bind('click', disableLevel2Links);
                    previousMenuItem.addClass('level2_nonclickable');
                }
            }
            // if this is l4 and previous one was l3 then disable the l3
            if ($(this).hasClass("l4")) {
                if (previousMenuItem.hasClass("l3")) {
                    if (previousMenuItem.children('a').attr("href")) {
                        previousMenuItem.children('a').attr("x-href", previousMenuItem.children('a').attr("href"));
                        previousMenuItem.children('a').removeAttr("href");
                    }
                    previousMenuItem.addClass('level3_dropdown');
                    previousMenuItem.children('a').bind('click', disableLevel3Links);
                }
            }
        }
        previousMenuItem = $(this);
    });

    var startSliceL4 = 0;
    var endSliceL4 = 0;
    var level4WrapperCounter = 0;
    counter = 0;

    // go though the list and add the level 4 wrapper
    $('#menu ul li').each(function () {
        // check this li's class
        if ($(this).hasClass("l1")) {
            if (counter != 0) {
                startSliceL4++;
                endSliceL4++;
                if (startSliceL4 < endSliceL4) {
                    level4WrapperCounter++;
                    $('#menu ul li').slice(startSliceL4 - 1, endSliceL4).wrapAll('<span></span>');
                    $('#menu ul li').slice(startSliceL4, endSliceL4).wrapAll('<div class="navLevel4wrapper" id="navLevel4id' + level4WrapperCounter + '"></div>');
                }
            }
            startSliceL4 = counter;
        }
        else if ($(this).hasClass("l2")) {

            if (counter != 0) {
                startSliceL4++;
                endSliceL4++;
                if (startSliceL4 < endSliceL4) {
                    level4WrapperCounter++;
                    $('#menu ul li').slice(startSliceL4 - 1, endSliceL4).wrapAll('<span></span>');
                    $('#menu ul li').slice(startSliceL4, endSliceL4).wrapAll('<div class="navLevel4wrapper" id="navLevel4id' + level4WrapperCounter + '"></div>');
                }
            }
            startSliceL4 = counter;
        }
        else if ($(this).hasClass("l3")) {

            if (counter != 0) {
                startSliceL4++;
                endSliceL4++;
                if (startSliceL4 < endSliceL4) {
                    level4WrapperCounter++;
                    $('#menu ul li').slice(startSliceL4 - 1, endSliceL4).wrapAll('<span></span>');
                    $('#menu ul li').slice(startSliceL4, endSliceL4).wrapAll('<div class="navLevel4wrapper" id="navLevel4id' + level4WrapperCounter + '"></div>');
                }
            }
            startSliceL4 = counter;
        }
        else { // l4
            endSliceL4 = counter;
        }
        counter++;
    });

    if (counter != 0) {
        startSliceL4++;
        endSliceL4++;
        if (startSliceL4 < endSliceL4) {
            level4WrapperCounter++;
            $('#menu ul li').slice(startSliceL4 - 1, endSliceL4).wrapAll('<span></span>');
            $('#menu ul li').slice(startSliceL4, endSliceL4).wrapAll('<div class="navLevel4wrapper" id="navLevel4id' + level4WrapperCounter + '"></div>');
        }
    }

    // level 1 clicked - used for mobile
    function disableLevel1Links(e) {
        // cancels the event
        e.preventDefault();
        return false;
    }

    // level 2 clicked
    function disableLevel2Links(e) {
        // cancels the event
        e.preventDefault();
        return false;
    }

    // level 3 clicked
    function disableLevel3Links(e) {
        $("*").removeClass("level3_dropdown_active");
        $("*").removeClass("l4_hover");
        $(".navLevel4wrapper").css({ 'display': 'none' });
        $(this).parents().children('.navLevel4wrapper').css({ 'display': 'block' });
        $(this).parent().addClass('level3_dropdown_active');
        e.preventDefault();
        return false;
    }

    $('.navLevel3wrapper').mouseover(function () {
        if (!mobile.detect()) {
            $('.l2').removeClass("l2_hover");
            $(this).children('li.l2').addClass('l2_hover');
        }
    });

    if (mobile.detect()) {
        $('#menu ul li.l1').each(function () {
            if ($(this).children('a')[0].innerHTML.replace(/^\s+|\s+$/g, '') != "Banking" && $(this).children('a')[0].innerHTML.replace(/^\s+|\s+$/g, '') != "Banque") {
                $(this).children('a').bind('click', disableLevel1Links);
            }
        });
        $('#menu ul .navLevel2wrapper').each(function () {
            var homelabel = " - Home";
            if ($('body').hasClass("langFR")) {
                homelabel = " - Accueil";
            }
            if ($(this).attr('id') == "navLevel2Wrapperid1") {
                $(this).prepend('<div class="l1_mobilelink"><a href="' + $('#menu ul #navLevel1id2 a').attr("href") + '">' + $('#menu ul #navLevel1id2 a').text() + homelabel + '</a></div><div class="closemenu"></div>');
            }
            if ($(this).attr('id') == "navLevel2Wrapperid2") {
                $(this).prepend('<div class="l1_mobilelink"><a href="' + $('#menu ul #navLevel1id3 a').attr("href") + '">' + $('#menu ul #navLevel1id3 a').text() + homelabel + '</a></div><div class="closemenu"></div>');
            }
            if ($(this).attr('id') == "navLevel2Wrapperid3") {
                $(this).prepend('<div class="l1_mobilelink"><a href="' + $('#menu ul #navLevel1id4 a').attr("href") + '">' + $('#menu ul #navLevel1id4 a').text() + homelabel + '</a></div><div class="closemenu"></div>');
            }
            if ($(this).attr('id') == "navLevel2Wrapperid4") {
                $(this).prepend('<div class="l1_mobilelink"><a href="' + $('#menu ul #navLevel1id5 a').attr("href") + '">' + $('#menu ul #navLevel1id5 a').text() + homelabel + '</a></div><div class="closemenu"></div>');
            }
            if ($(this).attr('id') == "navLevel2Wrapperid5") {
                $(this).prepend('<div class="l1_mobilelink"><a href="' + $('#menu ul #navLevel1id6 a').attr("href") + '">' + $('#menu ul #navLevel1id6 a').text() + homelabel + '</a></div><div class="closemenu"></div>');
            }
            if ($(this).attr('id') == "navLevel2Wrapperid6") {
                $(this).prepend('<div class="l1_mobilelink"><a href="' + $('#menu ul #navLevel1id7 a').attr("href") + '">' + $('#menu ul #navLevel1id7 a').text() + homelabel + '</a></div><div class="closemenu"></div>');
            }
            if ($(this).attr('id') == "navLevel2Wrapperid7") {
                $(this).prepend('<div class="l1_mobilelink"><a href="' + $('#menu ul #navLevel1id8 a').attr("href") + '">' + $('#menu ul #navLevel1id8 a').text() + homelabel + '</a></div><div class="closemenu"></div>');
            }
        });
    }

    var topNavVisibleDropDown = null;
    var topNavCloseTimer = null;

    function hidemenu() {
        if (topNavVisibleDropDown == null) {
            resetmenu();
        }
    }

    function resetmenu() {
        $(".l1").removeClass("l1_hover");
        $(".navLevel2wrapper").css({ display: "none" });
        $('.l2').removeClass("l2_hover");
        $('.l3').removeClass("l3_hover");
        $('.l4').removeClass("l4_hover");
        $('.l3').removeClass("level3_dropdown_hover");
        $('.l3').removeClass("level3_dropdown_active");
        $(".navLevel4wrapper").css({ display: "none" });
    }


    function showmenu() {
        if (topNavVisibleDropDown != null) {
            resetmenu();
            $(topNavVisibleDropDown).addClass("l1_hover");
            $(topNavVisibleDropDown).next('div').fadeIn(333);

        }
    }
    $(".l3").hover(function (e) {
        $('.l3').removeClass("l3_hover");
        $('.l3').removeClass("level3_dropdown_hover");
        $(this).addClass("l3_hover");
    });

    $(".l4").hover(function (e) {
        $(".l4").removeClass("l4_hover");
        $(this).addClass("l4_hover");
    }, function (e) {
    });
    $(".level3_dropdown").hover(function (e) {
        $('.l3').removeClass("level3_dropdown_hover");
        $(this).addClass("level3_dropdown_hover");
    }, function (e) {
    });
    $(".l1").hover(function (e) {
        topNavVisibleDropDown = this;
        showmenu();
    }, function (e) { hidemenu(); });

    $('#menu').hover(
        function (e) { },
        function (e) { resetmenu(); });
});