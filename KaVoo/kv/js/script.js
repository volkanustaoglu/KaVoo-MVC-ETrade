/*** Document Ready Functions ***/
jQuery(document).ready(function(){

	"use strict";


 
	
 var allservice = $('.cause-tabber li');
	$('.cause-tabber li').click(function() {
		$(allservice).removeClass("active");
	});
	
	

 
 /*** MESSAGE BOX TOGGLE FUNCTION ***/
$(".message-box-title").click(function(){
	$(".message-box-title").toggleClass("opened");
	$(".message-box-title > i").toggleClass("icon-angle-down");
	$(".message-form").slideToggle();
});	
	


$('.full-section').parent().parent().parent().addClass('expand');

$(".product a").click(function(){
	$(this).parent().parent().slideUp();
});	



// Responsive Header //
$(".menu-btn").on("click", function () {
    $(".responsive-menu").addClass("slidein");
    return false;
});
$(".close-btn").on("click", function () {
    $(".responsive-menu").removeClass("slidein");
    return false;
});
$(".responsive-menu li.has-dropdown > a").on("click", function () {
    $(this).parent().siblings().children("ul").slideUp();
    $(this).parent().siblings().removeClass("active");
    $(this).parent().children("ul").slideToggle();
    $(this).parent().toggleClass("active");
    return false;
});

// Scroll Bar //
$('.responsive-menu, .scroll-sec').perfectScrollbar();

// Responsive info Toggle //
$(".responsive-topbar-info > ul > li:first-child").addClass("active");
$(".responsive-topbar-info > ul > li").on("click", function() {
    $(this).parent().find("li").removeClass("active");
    $(this).addClass("active");
});
	

/*** ACCORDIONS ***/
$('.accordion_content').not('.open').hide();

$('.accordion_toggle a').click(function(e){
	if($(this).parent().hasClass('current')) {
		$(this).parent()
			.removeClass('current')
			.next('.accordion_content').slideUp();
	} else {
		$(document).find('.current')
			.removeClass('current')
			.next('.accordion_content').slideUp();
		$(this).parent()
			.addClass('current')
			.next('.accordion_content').slideDown();
	}
	e.preventDefault();
});




/*** ACCORDIONS ***/
$('.accordion_content').not('.open').hide();

$('.accordion_toggle input').click(function(e){
	if($(this).parent().hasClass('current')) {
		$(this).parent()
			.removeClass('current')
			.next('.accordion_content').slideUp();
	} else {
		$(document).find('.current')
			.removeClass('current')
			.next('.accordion_content').slideUp();
		$(this).parent()
			.addClass('current')
			.next('.accordion_content').slideDown();
	}
	e.preventDefault();
});



$(".donate-drop-btn").click( function(){
	$(".donate-drop-down").slideToggle();
	$(this).toggleClass('down');
});		


var amount = $('.amount-btns > a');
$(".amount-btns > a").click( function(){
	amount.removeClass("selected");
	$(this).addClass("selected");
});		



/*** STICKY MENU ***/
var nav = $('.sticky');
$(window).scroll(function () {
	if ($(this).scrollTop() > 50) {
			nav.addClass("stick");
	}
	else {
			nav.removeClass("stick");
	}
});



/*** TOGGLE HEADER ***/
$(".show-header").click(function(){
	$(".toggle-header").slideToggle();
	$(".top-bar-toggle").slideToggle();
	$(this).toggleClass("move-down");
});	


/*** CHECKOUT PAGE FORM TOGGLE ICON ***/
$(".form-toggle.accordion_toggle a").click(function(){
	$(this).toggleClass("pointed");
});	



/*** Side Panel Functions ***/
$(".panel-icon").click(function(){
	$(".side-panel").toggleClass("show");
});	


$(".boxed-style").click( function(){
	$(".theme-layout").addClass("boxed");
	$("body").addClass('bg-body1');
});
$(".full-style").click( function(){
	$(".theme-layout").removeClass("boxed");
	$("body").removeClass('bg-body1');
	$("body").removeClass('bg-body2');
	$("body").removeClass('bg-body3');
	$("body").removeClass('bg-body4');
});
$(".pat1").click( function(){
	$("body").addClass('bg-body1');
	$("body").removeClass('bg-body2');
	$("body").removeClass('bg-body3');
	$("body").removeClass('bg-body4');
});
$(".pat2").click( function(){
	$("body").removeClass('bg-body1');
	$("body").addClass('bg-body2');
	$("body").removeClass('bg-body3');
	$("body").removeClass('bg-body4');
});
$(".pat3").click( function(){
	$("body").removeClass('bg-body1');
	$("body").removeClass('bg-body2');
	$("body").addClass('bg-body3');
	$("body").removeClass('bg-body4');
});
$(".pat4").click( function(){
	$("body").removeClass('bg-body1');
	$("body").removeClass('bg-body2');
	$("body").removeClass('bg-body3');
	$("body").addClass('bg-body4');
});




$("body").append("<div class='loading'></div>");

});		



jQuery(window).load(function(){
	$(".loading").fadeOut();
});
