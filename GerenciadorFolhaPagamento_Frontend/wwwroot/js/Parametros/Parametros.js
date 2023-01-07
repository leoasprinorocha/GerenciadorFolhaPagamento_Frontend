$body = $("body");

$(document).on({
    ajaxStart: function () { $body.addClass("loading"); },
    ajaxStop: function () { $body.removeClass("loading"); }
});

$('#btnSalvarParametros').on("click", async function () {
    var parametros = new Array();
    $(".parametros").each(function (index, parametro) {
        var parametro = {
            IdParametro: Number($(parametro).attr("data-idParametro")),
            ValorParametro: $(parametro).val(),
            NomeParametro: 'Testes'
        };
        parametros.push(parametro);
    });

    let data = { listaparametros: parametros}
    let url = "../Parametros/GravarParametros";
    let response = await RequestAjax(url, data, "POST");
    alert(response);
});