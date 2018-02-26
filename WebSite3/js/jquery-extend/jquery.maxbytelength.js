$(function () {
	//:text[maxbytelength],textarea[maxbytelength]
	//input[maxbytelength]
	//[maxbytelength]

	$(":text[maxbytelength],textarea[maxbytelength]").change(function () {
		limitMaxByteLength($(this));
	});
	$(":text[maxbytelength],textarea[maxbytelength]").keyup(function () {
		limitMaxByteLength($(this));
	});
	//$(":text[maxbytelength],textarea[maxbytelength]").bind("paste", function () {
	//	//alert("onpaste");
	//	limitMaxByteLength($(this));
	//});
});

function limitMaxByteLength(e) {
	var maxByteLength = e.attr("maxbytelength");
	var text = e.val();
	var byteLength = 0;
	for (var i = 0; i < text.length; i++) {
		if (text.charCodeAt(i) > 255)
			byteLength += 2;
		else
			byteLength++;

		if (byteLength > maxByteLength) {
			e.val(text.substring(0, i));
			break;
		}
	}
}