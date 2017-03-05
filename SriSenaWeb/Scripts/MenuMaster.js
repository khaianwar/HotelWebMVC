dojo.addOnLoad(function () {
    dojo.NodeList.prototype.hover = function (over, out) {
        return this.onmouseenter(over).onmouseleave(out || over);
    };
    dojo.query(".leader-wrap").style("display", "block");
    dojo.query(".swiper-wrap").style("display", "block");

    if ((dojo.query(".midColumn_noleftnav")[0] != undefined) && (dojo.query(".midColumn_norightnav")[0] != undefined)) {
        dojo.query(".midColumn").addClass("midColumnFull");
    }
    if ((dojo.query(".midColumn_prepare")[0] != undefined) && (dojo.query(".midColumn_norightnav")[0] != undefined)) {
        dojo.query(".midColumn").addClass("midColumnFull");
    }

    if (dojo.query(".leftnav") != undefined) {
        if (dojo.query(".leftnav")[0] != undefined) {
            if (dojo.query(".leftnav")[0].innerHTML.replace(/^\s+|\s+$/g, '') == "") {
                dojo.query(".leftnav").style("display", "none");
                dojo.query(".bodycontent").addClass("bodycontent_landingpage");
            }
        }
    }

    if (dojo.query(".landingbodycontent") != undefined) {
        if (dojo.query(".landingbodycontent")[0] == undefined) {
            dojo.query('.pagecontent .bodycontent table').forEach(function (selectTable) {
                if (!dojo.hasClass(selectTable, "noborder")) {
                    var toggle = true;

                    dojo.query(selectTable).query('td:last-child').addClass("lastchild");

                    dojo.query(selectTable).query('tr').forEach(function (selectRow) {
                        if (toggle) {
                            dojo.query(selectRow).addClass("shaded");
                            toggle = false;
                        }
                        else {
                            toggle = true;
                        }
                    });
                }
            });
        }
    }

    if (mobile.detect()) {
        dojo.query(".iframeVideo").style("display", "block");
        dojo.query(".flashVideo").style("display", "none");
    }

    dojo.query(".relatedlinks").forEach(function (selectRelatedLinks) {
        dojo.query(selectRelatedLinks).query('a').forEach(function (selectLink) {
            if (dojo.query(selectLink).attr("href") == "" || dojo.query(selectLink).attr("href") == document.URL) {
                dojo.query(selectRelatedLinks).style("display", "none");
            }
            else {
                dojo.query(selectRelatedLinks).style("display", "block");
            }
        });
    });
});

$(document).ready(function () {
    $("iframe").hide();
    $(".homeicon").focus();
    $("iframe").show();

    var previousMenuItem;
    $('.siteMap ul li').each(function () {
        if (previousMenuItem != null) {
            if ($(this).hasClass("l3")) {
                if (previousMenuItem.hasClass("l2")) {
                    if (previousMenuItem.children('a').attr("href")) {
                        previousMenuItem.children('a').attr("x-href", previousMenuItem.children('a').attr("href"));
                        previousMenuItem.children('a').removeAttr("href");
                        previousMenuItem.children('a').addClass('nonlink');
                    }
                }
            }
            if ($(this).hasClass("l4")) {
                if (previousMenuItem.hasClass("l3")) {
                    if (previousMenuItem.children('a').attr("href")) {
                        previousMenuItem.children('a').attr("x-href", previousMenuItem.children('a').attr("href"));
                        previousMenuItem.children('a').removeAttr("href");
                        previousMenuItem.children('a').addClass('nonlink');
                    }
                }
            }
        }
        previousMenuItem = $(this);
    });

});

var mobile = function () {
    return {
        detect: function () {
            var uagent = navigator.userAgent.toLowerCase();
            var list = this.mobiles;
            var ismobile = false;
            for (var d = 0; d < list.length; d += 1) {
                if (uagent.indexOf(list[d]) != -1) {
                    ismobile = true;
                }
            }
            return ismobile;
        },
        mobiles: [
			"midp", "240x320", "blackberry", "netfront", "nokia", "panasonic",
			"portalmmm", "sharp", "sie-", "sonyericsson", "symbian",
			"windows ce", "benq", "mda", "mot-", "opera mini",
			"philips", "pocket pc", "sagem", "samsung", "sda",
			"sgh-", "vodafone", "xda", "palm", "iphone", "ipad", "playbook",
			"ipod", "android"
		]
    };
} (); 