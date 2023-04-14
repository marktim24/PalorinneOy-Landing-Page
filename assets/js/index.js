$(document).ready(function () {
	$('.accordion-toggle').each(function (index) {
		if (index !== 1) {
			// Exclude the second accordion (index 1)
			$(this).next('.accordion-list').hide()
		}
	})
	$('.img').click(function () {
		var newImageSrc = $(this).attr('src')
		var newDate = $(this).data('date')
		var newLocation = $(this).data('location')
		var newDescription = $(this).data('description')

		$('.images__blog-first').attr('src', newImageSrc)
		$('.blog-date').text(newDate)
		$('.blog-location').text(newLocation)
		$('.blog-description').text(newDescription)
	})

	$('.accordion-toggle').click(function () {
		$(this).toggleClass('open')
		$(this).next('.accordion-list').slideToggle('fast')
	})
})
