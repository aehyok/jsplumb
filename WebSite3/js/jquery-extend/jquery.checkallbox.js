function checkAllBox(keyword, checkbox) {
	$(":checkbox:enabled").each(function () {
		var name = $(this).attr("name");
		if (name != $(checkbox).attr("name") && name.toUpperCase().indexOf(keyword.toUpperCase()) != -1) {
			if (checkbox.checked)
				$(this).attr("checked", "checked");
			else
				$(this).removeAttr("checked");
		}
	});
}