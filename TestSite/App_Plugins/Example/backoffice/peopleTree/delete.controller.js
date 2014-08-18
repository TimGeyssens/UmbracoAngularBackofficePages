angular.module("umbraco")
.controller("People.PersonDeleteController",
	function ($scope, personResource, navigationService) {
	    $scope.delete = function (id) {
	        personResource.deleteById(id).then(function () {
	            navigationService.syncTree({ tree: 'peopleTree', path: [-1, -1], forceReload: true });
	            navigationService.hideNavigation();
	            
	        });

	    };
	    $scope.cancelDelete = function () {
	        navigationService.hideNavigation();
	    };
	});