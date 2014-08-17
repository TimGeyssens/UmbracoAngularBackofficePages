angular.module("umbraco")
.controller("People.PersonDeleteController",
	function ($scope, personResource, navigationService) {
	    $scope.delete = function (id) {
	        personResource.deleteById(id).then(function () {
	            navigationService.hideNavigation();
	            
	        });

	    };
	    $scope.cancelDelete = function () {
	        navigationService.hideNavigation();
	    };
	});