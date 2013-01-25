(function ($) {
    $(function () {
        $(document).foundationMediaQueryViewer();

        $(document).foundationAlerts();
        $(document).foundationAccordion();
        $(document).tooltips();
        $('input, textarea').placeholder();
        $(document).foundationButtons();
        $(document).foundationNavigation();
        $(document).foundationCustomForms();
        $(document).foundationTabs({ callback: $.foundation.customForms.appendCustomMarkup });

        $("#featured").orbit({
            bullets: true,
            bulletThumbs: true
        });
        
        /* Open all links that start with 'http' in a new window */
        $("a[href^='http']").bind("click", function () {
            window.open($(this).attr('href'));
            return false;
        });

        // UNCOMMENT THE LINE YOU WANT BELOW IF YOU WANT IE8 SUPPORT AND ARE USING .block-grids
        // $('.block-grid.two-up>li:nth-child(2n+1)').css({clear: 'left'});
        // $('.block-grid.three-up>li:nth-child(3n+1)').css({clear: 'left'});
        // $('.block-grid.four-up>li:nth-child(4n+1)').css({clear: 'left'});
        // $('.block-grid.five-up>li:nth-child(5n+1)').css({clear: 'left'});
    });

})(jQuery);
