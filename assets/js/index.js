$(document).ready(function () {
	$('.accordion-toggle').each(function (index) {
		if (index !== 1) {
			// Exclude the second accordion (index 1)
			$(this).next('.accordion-list').hide()
		}
	})

	$('.accordion-toggle').click(function () {
		$(this).toggleClass('open')
		$(this).next('.accordion-list').slideToggle('fast')
	})
})
