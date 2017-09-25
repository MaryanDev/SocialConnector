$(function () {
    var optionalDataSection = $("#otionalData");

    var expander = $("#optDataExpander");

    expander.on("click",
        function(e) {
            if (optionalDataSection.is(":visible")) {
                optionalDataSection.hide();
                expander.text("Show optional data");
            } else {
                optionalDataSection.show();
                expander.text("Hide optional data");
            }
        });
});