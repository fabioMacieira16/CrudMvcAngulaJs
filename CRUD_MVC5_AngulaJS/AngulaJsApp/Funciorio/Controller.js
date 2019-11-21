//Controller de Funcionario

funcionarioApp.controller('funcionarioCrt', function ($scope, funcionarioService) {

    //carrega os dados do funcionario
    carregarFuncionarios();

    function carregarFuncionarios() {
        var listarFuncionarios = funcionarioService.getTodosFuncionarios();

        listarFuncionarios.then(function (d) {
            //Se tudo der certo
            $scope.Funcionarios = d.data;

        }, function () {
            alert = "Ocorreu um erro ao tentar carrregar os Funcionarios";
        });
    }
});