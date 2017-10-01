$(function () {
    var avatarUploader = $("#avatar-upload").uploadFile({
        url: Settings.avatarUploadUrl,
        acceptFiles: "image/*",
        multiple: false,
        maxFileCount: 1,
        fileName: "uploadedAvatar",
        dragDrop: true,
        showPreview: true,
        previewHeight: "100px",
        previewWidth: "100px",
        statusBarWidth: 300,
        dragdropWidth: 300,
        autoSubmit: false,
        onSuccess: function (files, data, xhr, pd) {
            location.reload(true);
        },
        onError: function (files, status, errMsg, pd) {
            $("#events-message").html($("#events-message").html() + "<br/>Error for: " + JSON.stringify(errMsg));
        }
    });

    $("#upload-avatar-btn").click(function (e) {
        avatarUploader.startUpload();
    });
});