$(function () {
	//input[emptytip]

	$(":text[emptytip],textarea[emptytip]").each(function () {
		if ($(this).val() == "") {
			$(this).val($(this).attr("emptytip"));
			$(this).addClass("emptytip");
		}

		$(this).bind("focus", function () {
			if ($(this).val() == $(this).attr("emptytip")) {
				$(this).val("");
				$(this).removeClass("emptytip");
			}
		}).bind("blur", function () {
			if ($(this).val() == "") {
				$(this).val($(this).attr("emptytip"));
				$(this).addClass("emptytip");
			}
		});
	});

	$("form").submit(function () {
		$(":text[emptytip],textarea[emptytip]").each(function () {
			if ($(this).val() == $(this).attr("emptytip")) {
				$(this).val("");
			}
		});
	});

	if (typeof __doPostBack == 'function') {
		var oldSubmit = __doPostBack;
		var newSubmit = function (eventTarget, eventArgument) {
			$(":text[emptytip],textarea[emptytip]").each(function () {
				if ($(this).val() == $(this).attr("emptytip")) {
					$(this).val("");
				}
			});
			return oldSubmit(eventTarget, eventArgument);
		};
		__doPostBack = newSubmit;
	}

	//$(":submit").click(function (check) {
	//	$(":text[emptytip],textarea[emptytip]").each(function () {
	//		if ($(this).val() == $(this).attr("emptytip")) {
	//			$(this).val("");
	//		}
	//	});
	//	//check.preventDefault();	//阻止表单提交
	//});
});
