
$(document)
    .ready(function () {


        $('.variable-width').slick({
            mobileFirst: true,
            infinite: true,
            speed: 300,
            slidesToShow: 1,
            centerMode: false,
            variableWidth: false,
            focusOnSelect: true,
            responsive: [
                {
                    breakpoint: 1024,
                    settings: {
                        mobileFirst: true,
                        infinite: true,
                        speed: 300,
                        slidesToShow: 1,
                        centerMode: false,
                        variableWidth: true,
                        focusOnSelect: true

                    }
                }
            ]
        });


        $('.overlay.example .overlay')
            .visibility({
                type: 'fixed'
            })
            ;

      // fix menu when passed
      $('.masthead')
        .visibility({
          once: false,
          onBottomPassed: function() {
            $('.fixed.menu').transition('fade in');
          },
          onBottomPassedReverse: function() {
            $('.fixed.menu').transition('fade out');
          }
        })
      ;
      // create sidebar and attach to menu open
      $('.ui.sidebar')
        .sidebar('attach events', '.toc.item')
      ;


      $('.ui.dropdown').dropdown();
      $('.activating.element')
          .popup()
          ;

      $('.showroom').slick({
          dots: true,
          infinite: true,
          speed: 1000,
          slidesToShow: 1,
          adaptiveHeight: true,
          arrows: true,
           autoplay: true,
          autoplaySpeed: 3000
      });

      $('.slider-for').slick({
          slidesToShow: 1,
          slidesToScroll: 1,
          arrows: false,
          fade: true,
          asNavFor: '.slider-nav'
      });
      $('.slider-nav').slick({
          slidesToShow: 4,
          slidesToScroll: 1,
          asNavFor: '.slider-for',
          centerMode: false,
          focusOnSelect: true,
             arrows: true,
      });
    })
    ;
