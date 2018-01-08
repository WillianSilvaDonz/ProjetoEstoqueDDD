$(document).ready(function () {
    $(".atualizarestoque").on("click", function () {
        var atuprodinput = $(this);
        var textatual = $(this).text();
        var produtoid = $(this).parent().find(".produto").val();
        var val1 = $(this).parent().find(".atuprod").val();
        $.post("/estoque/modificarestoque", { type: textatual, produtoid: produtoid}, function (data) {
            if (textatual == '+') {
                var total = parseInt(val1) + 1;
            } else {
                var total = parseInt(val1) - 1;
            }
            atuprodinput.parent().find(".atuprod").val(total);

            $(".alert-success").html(data).removeClass("hide").animate("show", 500);
            setTimeout(function () { $(".alert-success").addClass("hide"); }, 2000);
        });
    });

    $(".columns").sortable({
        connectWith: ".columns",
        handle: ".rowlinha"
    });
});