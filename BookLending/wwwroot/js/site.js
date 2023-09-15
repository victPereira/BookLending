

$(document).ready(function () {

    $('#Lending').DataTable();


    //Configurando o timeout para o alert de sucess sair da tela
    setTimeout(function () {
        $(".alert").fadeOut("slow", function () {
            $(this).alert('close');
        })
    }, 3500)

});