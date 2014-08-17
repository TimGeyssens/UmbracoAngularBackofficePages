angular.module("umbraco")
.controller("People.PersonDeleteController",
	function ($scope, personResource, navigationService) {
	    $scope.delete = function (id) {
	        personResource.deleteById(id).then(function () {
	            navigationService.hideNavigation();
	            navigationService.syncTree({ tree: 'peopleTree', path: ["-1", $scope.currentNode.id], forceReload: true });
	        });

	    };
	    $scope.cancelDelete = function () {
	        navigationService.hideNavigation();
	    };
	});