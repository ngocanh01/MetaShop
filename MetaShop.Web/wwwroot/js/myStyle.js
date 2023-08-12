$(document).ready(function () {

    
});


function pagination(clicked_id) {
	var id = clicked_id;
	$.ajax({
		type: 'GET',
		url: '/product/pagination?page=' + id,
		success: function (data) {
			$("#ProductsPagination").replaceWith(data);
		}
	});
}
