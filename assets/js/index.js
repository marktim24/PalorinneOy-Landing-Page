function initSwiper() {
	swiper = new Swiper('.swiper-container', {
		slidesPerView: 3,
		spaceBetween: 10,
		navigation: {
			nextEl: '.swiper-button-next',
			prevEl: '.swiper-button-prev',
		},
	})

	if (breakpoint.matches) {
		swiper.navigation.enable()
	} else {
		swiper.navigation.disable()
	}
}

function moveTextBlock() {
	var windowWidth = $(window).width()
	if (windowWidth < 1200) {
		$('#slider-heading').prependTo('#col-7')
	} else {
		// Move the block back to its original position for larger screens
		$('#slider-heading').prependTo('#container')
	}
}

$(document).ready(function () {
	$('.wrapper__slider-testi').slick({
		slidesToShow: 1,
		slidesToScroll: 1,
		dots: false,
		arrows: true,
		prevArrow: '.wrapper__arrows .left',
		nextArrow: '.wrapper__arrows .right',
	})

	$("a[href^='#click-']").on('click', function (e) {
		e.preventDefault()
		$('html, body').animate(
			{
				scrollTop: $($(this).attr('href')).offset().top,
			},
			1000
		)
	})

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

	initSwiper()
	$(window).resize(initSwiper)
	breakpoint.addListener(initSwiper)

	moveTextBlock()
	$(window).resize(moveTextBlock)
	initSwiper()
	breakpoint.addListener(initSwiper)
})
