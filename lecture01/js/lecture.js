var Slides = (function($, undefined) {
    var _initializeSlides = function(params) {
        var $body = $("body");

        params = {
            positions: params.positions || []
        };

        var $slides = $(".slide").detach();
        $slides.each(function(index) {
            var $slide = $(this),
                title = $slide.find(".title").html() || $slide.data("title") || "",
                content = $slide.find(".content").html() || $slide.html() || "",
                templateId = $slide.data("template") || "standard",
                template = $("script[type=slide-template][id="+ templateId +"]").html()

            var regex = /\$\s*index(\s*(\+|-|\*|\/)\s*\d+(\.\d+)?)*\s*\$/g;
            template = template.replace(regex, function(match) {
                return eval(match.replace(/\$/g, ""));
            });

            var slideContent = template.replace(/\$content\$/g, content)
                                       .replace(/\$title\$/g, title)
                                       .replace(/\$index\$/g, index);

            var $slideContent = $(slideContent);
            $slideContent.appendTo($body);
        });
    }

    return {
        initialize: _initializeSlides
    };
})(jQuery);

$(function() {
    Slides.initialize({
        positions: [ { x: -1000, y: 0} ]
    });

    impress().init();

    SyntaxHighlighter.defaults["toolbar"] = false;
    SyntaxHighlighter.defaults["html-script"] = false;
    SyntaxHighlighter.all();
});
