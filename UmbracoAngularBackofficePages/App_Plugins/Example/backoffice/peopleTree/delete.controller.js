angular.module("umbraco")
.controller("People.PersonDeleteController",
	function ($scope, personResource, navigationService,treeService) {
	    $scope.delete = function (id) {
	        personResource.deleteById(id).then(function () {
	            treeService.removeNode($scope.currentNode);
	            navigationService.hideNavigation();
	            
	        });

	    };
	    $scope.cancelDelete = function () {
	        navigationService.hideNavigation();
	    };
	});