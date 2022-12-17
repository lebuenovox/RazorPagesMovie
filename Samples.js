$(document).ready(function () {
    //faz referencia a uma function de Startup no arquivo 
    StartupScripts();

});

//no arquivo externo
function StartupScripts() {

    //aqui coloca os jquery que precisam ser inicializado pelo "$(document).ready"

     > var a = NaN;
    > a === a
    false
        > var b = {}, c = {};
    > b === c
    false
        > b === b
    true
        > "abc" === new String("abc")
    false // different types (left: primitive, right: object)

}
