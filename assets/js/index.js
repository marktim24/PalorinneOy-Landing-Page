$(document).ready(function () {
	$('.accordion-toggle').each(function (index) {
		if (index !== 1) {
			// Exclude the second accordion (index 1)
			$(this).next('.accordion-list').hide()
		}
	})
	$('.img').click(function () {
		$('img').removeClass('blog-active-image')
		$(this).addClass('blog-active-image')

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

	var swiper = new Swiper('.swiper-container', {
		slidesPerView: 1,
		spaceBetween: 10,
		navigation: {
			nextEl: '.swiper-button-next',
			prevEl: '.swiper-button-prev',
		},
		pagination: {
			el: '.swiper-pagination',
			clickable: true,
		},
		breakpoints: {
			768: {
				enabled: true,
			},
		},
	})
})
