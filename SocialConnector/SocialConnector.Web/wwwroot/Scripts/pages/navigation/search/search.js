$(function () {
    var searchLogo = $("span.social-search");
    var searchInput = $("#socialSearch");

    var options = {
        url: function (phrase) {
            return searchSettings.searchUrl + "?phrase=" + phrase;
        }
    }
    searchInput.easyAutocomplete(options);
    searchLogo.on("click",
        function (e) {
            if (searchInput.is(":visible")) {
                searchInput.parent().hide("slow");
                searchInput.hide();
            } else {
                searchInput.show("slow");
                searchInput.parent().show("slow");
            }
        });
});