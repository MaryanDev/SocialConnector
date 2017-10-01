$(function () {
    var searchLogo = $("span.social-search");
    var searchInput = $("#socialSearch");
    var searchPanel = $("#searchPanel");

    var options = {
        url: function (phrase) {
            return Settings.searchUrl + "?phrase=" + phrase;
        }
    }
    searchInput.easyAutocomplete(options);
    searchLogo.on("click",
        function (e) {
            if (searchPanel.is(":visible")) {
                searchPanel.slideUp("slow");
            } else {
                searchPanel.slideDown("slow");
            }
        });
});