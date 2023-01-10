$body = $("body");

$(document).on({
    ajaxStart: function () { $body.addClass("loading"); },
    ajaxStop: function () { $body.removeClass("loading"); }
});

$(document).ready(async function () {
    debugger
    let url = "../Processamentos/RecuperaArquivosQueEstaoNaPastaDeProcessamento";
    var gridPartialArquivos = await RequestAjax(url, null, "GET");
    $('#gridArquivosASeremProcessados').html(gridPartialArquivos);
    $('#gridArquivosASeremProcessados').show();

    let url2 = "../Processamentos/RetornaProcessados";
    var resultadoJson = await RequestAjax(url2, null, "GET");
    $('#conteudoJson').val(resultadoJson);

});



$('#btnProcessarArquivos').on("click", async function () {
    let data = null;
    let url = "../Processamentos/ProcessarArquivos";
    let response = await RequestAjax(url, data, "POST");
    alert(response);
});


$('#btnLimparDadosProcessados').on("click", async function () {
    let data = null;
    let url = "../Processamentos/LimparDadosProcessados";
    let response = await RequestAjax(url, data, "POST");
    alert(response);
});

$('#btnAtualizar').on("click", function () {
    window.location.reload();
});