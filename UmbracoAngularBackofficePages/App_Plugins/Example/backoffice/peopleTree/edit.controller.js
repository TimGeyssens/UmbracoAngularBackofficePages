angular.module("umbraco").controller("People.PersonEditController",
	function ($scope, $routeParams, personResource, notificationsService, navigationService, dialogService, entityResource) {

	    $scope.loaded = false;

	    if ($routeParams.id == -1) {
	        $scope.person = {};
	        $scope.loaded = true;
	    }
        else{
	    //get a person id -> service
	    personResource.getById($routeParams.id).then(function (response) {
	        $scope.person = response.data;

	        if ($scope.person.pictureId > 0){
	            entityResource.getById($scope.person.pictureId, "Media").then(function (item) {
	                $scope.node = item;
	            });
	        }

	        $scope.loaded = true;

	    });
	    }

	    $scope.openMediaPicker = function() {
	        dialogService.mediaPicker({ callback: populatePicture });
	    }

	    $scope.removePicture = function() {
	        $scope.node = undefined;
	        $scope.person.pictureId = 0;
	    }

	    $scope.save = function (person) {
	        personResource.save(person).then(function (response) {
	            $scope.person = response.data;
	            $scope.personForm.$dirty = false;
	            navigationService.syncTree({ tree: 'peopleTree', path: [-1, -1], forceReload: true });
	            notificationsService.success("Success", person.firstName + " " + person.lastName + " has been saved");
	        });
	    };

	    function populatePicture(item) {
	        $scope.node = item;
	        $scope.person.pictureId = item.id;
	    }
	});