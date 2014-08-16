angular.module("umbraco").controller("People.PersonEditController",
	function ($scope, $routeParams, personResource, notificationsService) {

	    //get a person id -> service
	    personResource.getById($routeParams.id).then(function (response) {
	        $scope.person = response.data;
	    });

	    $scope.save = function (person) {
	        personResource.save(person).then(function (response) {
	            $scope.person = response.data;

	            notificationsService.success("Success", person.firstName + " " + person.lastName + " has been saved");
	        });
	    };
	});