var Slides = (function($, undefined) {
    var _initializeSlides = function(params) {
        var $body = $("#impress"),
            $menuItems = $("#menu-items").hide();

        params = {
            positions: params.positions || []
        };

        var isMenuOpen = false;

        $("#show-menu").on("click", function() {
            if (isMenuOpen)
                $(this).text("Tartalomjegyzék >");
            else
                $(this).text("Tartalomjegyzék <");
            $menuItems.slideToggle(200);
            isMenuOpen = !isMenuOpen;
        });

        var $slides = $(".slide")
            .detach()
            .each(function(index) {
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

                if (templateId === "standard")
                    $('<li><a href="#/step-' + (index + 1) + '">' + title + "</a></li>").appendTo($menuItems);
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

    var updateListItems = function() {
        $("li").replaceWith(function() {
            return "<li><span>" + $(this).html() + "</span></li>";
        });
    };

    impress().init();

    SyntaxHighlighter.defaults["toolbar"] = false;
    SyntaxHighlighter.defaults["html-script"] = false;
    SyntaxHighlighter.defaults["class-name"] = "code";
    SyntaxHighlighter.all();

    updateListItems();
});
