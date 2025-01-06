function pagination(clicked_id) {
	var id = clicked_id;
	var pathname = window.location.pathname;
	var keyword = window.location.href.split("=");
	if (pathname == '/product/searchProductsByName') {
		$.ajax({
			type: 'GET',
			url: '/product/searchByKeyword?keyword=' + keyword[1] + '&page=' + id,
			success: function (data) {
				console.log(data);
				$("#ProductsPagination").replaceWith(data);
			}
		});
	} else {
		$.ajax({
			type: 'GET',
			url: '/product/pagination?page=' + id,
			success: function (data) {
				$("#ProductsPagination").replaceWith(data);
			}
		});
	}
}

