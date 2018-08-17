angular.
  module('opiniaoApp').
  component('opiniaoPesquisaComponent', {
      templateUrl: '../../scripts/components/opiniaoPesquisaComponent.template.html',
      controller: ['$rootScope', '$scope', '$http', function OpiniaoPesquisaController($rootScope, $scope, $http) {

          $scope.produto = '';
          $scope.opinioes = [];

          $scope.pesquisar = function () {
              $scope.opinioes = [];
              var url = 'http://localhost:6739/opiniao/pesquisar?pesquisa=' + $scope.produto;
              $rootScope.isLoading = true;
              $http({
                  method: 'GET',
                  url: url
              }).then(function successCallback(response) {
                  $scope.opinioes = response.data;
                  $rootScope.isLoading = false;
                  // this callback will be called asynchronously
                  // when the response is available
              }, function errorCallback(response) {
                  $rootScope.isLoading = false;
                  // called asynchronously if an error occurs
                  // or server returns response with an error status.
              });
          };

          $scope.produtoKeyPress = function (keyEvent) {
              if (keyEvent.which === 13) {
                  $scope.pesquisar();
              }
          };
      }]
  });