$body = $("body");

$(document).on({
    ajaxStart: function () { $body.addClass("Loading"); },
    ajaxStop: function () { $body.removeClass("Loading"); }
});

$(document).ready(async function () {
debugger
    let url = "../Parametros/RecuperaTodosOsParametros";
    var listaParametros = await RequestAjax(url, null, "GET");
    $(listaParametros).each(function (index, parametro) {
        var element = $('.parametros').find(`[data-idParametro='${parametro.idParametro}']`);
        $(element.prevObject[0]).val(parametro.valorParametro);
    });
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

    let data = { listaparametros: parametros }
    let url = "../Parametros/GravarParametros";
    let response = await RequestAjax(url, data, "POST");
    alert(response);
});