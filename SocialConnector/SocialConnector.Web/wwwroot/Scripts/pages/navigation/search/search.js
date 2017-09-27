$(function () {
    var searchLogo = $("span.social-search");
    var searchInput = $("#socialSearch");
    var searchPanel = $("#searchPanel");

    var options = {
        url: function (phrase) {
            return searchSettings.searchUrl + "?phrase=" + phrase;
        }
    }
    searchInput.easyAutocomplete(options);
    searchLogo.on("click",
        function (e) {
            if (searchPanel.is(":visible")) {
                searchPanel.hide("slow");
            } else {
                searchPanel.show("slow");
            }
        });
});