(function ($) {
 "use strict";
    

	

/* ================================
	Hero Slider
================================ */
$('.hero-slider').slick({
    arrows: false,
    autoplay: false,
    dots: true,
    fade: true,
    infinite: true,
    slidesToShow: 1,
    responsive: [
        {
          breakpoint: 600,
          settings: {
            dots: false,
            autoplay: true,
            autoplaySpeed: 7000,
          }
        },
    ]
});
	


/*----------------------------
    Testimonial Carousel
------------------------------ */  
    $(".testimonial-carousel").owlCarousel({
        autoPlay: false, 
        slideSpeed:2000,
        pagination:false,
        navigation:true,	  
        items : 1,
        navigationText:["<i class='fa fa-angle-left'></i>","<i class='fa fa-angle-right'></i>"],
        itemsDesktop : [1199,1],
        itemsDesktopSmall : [980,1],
        itemsTablet: [768,1],
        itemsMobile : [479,1],
    });
/*--------------------------------
	Testimonial Small Carousel
-----------------------------------*/
$('.testimonial-small-text-slider').slick({
	slidesToShow: 1,
	slidesToScroll: 1,
	arrows: false,
	draggable: false,
	fade: true,
	asNavFor: '.slider-nav'
});
/*------------------------------------
	Testimonial Small Carousel as Nav
--------------------------------------*/
$('.testimonial-small-image-slider').slick({
	slidesToShow: 3,
	slidesToScroll: 1,
	asNavFor: '.testimonial-small-text-slider',
	dots: false,
	arrows: false,
	centerMode: true,
	focusOnSelect: true,
	centerPadding: '10px',
	responsive: [
		{
		  breakpoint: 450,
		  settings: {
			dots: false,
			slidesToShow: 3,  
			centerPadding: '0px',
			}
		},
		{
		  breakpoint: 420,
		  settings: {
			autoplay: true,
			dots: false,
			slidesToShow: 1,
			centerMode: false,
			}
		}
	]
});

/*----------------------------
    Brand Carousel
------------------------------ */  
    $(".brand-carousel").owlCarousel({
        autoPlay: true, 
        slideSpeed:2000,
        pagination:false,
        navigation:false,	  
        items : 5,
        itemsDesktop : [1199,5],
        itemsDesktopSmall : [980,4],
        itemsTablet: [768,2],
        itemsMobile : [479,1],
    }); 

/* ================================
	Scroll Up
================================ */
$.scrollUp({
	easingType: 'linear',
	scrollSpeed: 900,
	animation: 'fade',
	scrollText: '<i class="fa fa-angle-up"></i>',
});


 // Blog Masonry
 $('.blog_masonry').imagesLoaded( function() {
  if($.fn.isotope){
   var $portfolio = $('.blog_masonry');
   $portfolio.isotope({
    itemSelector: '.grid-item',
    filter: '*',
    resizesContainer: true,
    layoutMode: 'masonry',
    transitionDuration: '0.8s'   
   });
  };
 });





    
})(jQuery); 