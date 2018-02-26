$(function () {

	//list-table mouseover effect
	$("table.list-table:not([class*=no-alternate-color]) tr:even").addClass("alt");

	$("table.list-table:not([class*=no-mouseover-highlight]) tr:odd").mouseover(function () {
		$(this).addClass("over");
	}).mouseout(function () {
		$(this).removeClass("over");
	});
	$("table.list-table:not([class*=no-mouseover-highlight]) tr:even").mouseover(function () {
		$(this).addClass("over");
	}).mouseout(function () {
		$(this).removeClass("over");
	});

	//clear-both
	$("div.header").append("<div class=\"clear-both\"></div>");
	$("div.subheader").append("<div class=\"clear-both\"></div>");
	$("div.pager-container").append("<div class=\"clear-both\"></div>");

	//submit button
	$(":submit").click(function () {
		var b = $(this);
		if (b.visible) {	//如果按钮自已会隐藏，则不应用此效果
			var f = $(this).parents("form");
			//alert(f.prop("tagName") + " id=" + f.attr("id"));
			f.bind("submit", function() {
				b.after("<span class=\"hightlight\">处理中...</span>");
				b.hide();
			});
		}
	});

	//$(".message").corner("5px");
	//$("table.form-table td.req").append("<font color=\"red\">*</font>");
});