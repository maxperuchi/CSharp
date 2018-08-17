angular.
  module('opiniaoApp').
  component('opiniaoLoadingComponent', {
      templateUrl: '../../scripts/components/opiniaoLoadingComponent.template.html',
      controller: ['$rootScope', '$scope', function OpiniaoLoadingController($rootScope, $scope) {
          $scope.loading = function () {
              return $rootScope.isLoading === true;
          };
      }]
  });