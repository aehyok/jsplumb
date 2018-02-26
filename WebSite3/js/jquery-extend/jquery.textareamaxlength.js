$(function () {
	$("textarea[maxlength]").change(function () {
		limitTextareaMaxLength($(this));
	});
	$("textarea[maxlength]").keyup(function () {
		limitTextareaMaxLength($(this));
	});
	//$("textarea[maxlength]").bind("paste", function () {
	//	//alert("onpaste");
	//	limitTextareaMaxLength($(this));
	//});
});

function limitTextareaMaxLength(e) {
	var maxLength = e.attr("maxlength");
	var text = e.val();
	if (text.length > maxLength) {
		e.val(text.substring(0, maxLength));
	}
}