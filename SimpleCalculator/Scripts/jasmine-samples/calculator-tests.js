/// <reference path="../angular-mocks.js" />

describe('CalculatorControllerTests', function () {

    beforeEach(module('SimpleCalculator.Controllers'));

    var $controller;

    beforeEach(inject(function (_$controller_) {
        $controller = _$controller_;
    }));

    describe('$scope.display', function () {

        it('intial value should be zero', function () {

            var $scope = {};
            var controller = $controller('CalculatorController', { $scope: $scope });
            expect('0').toEqual('1');

        });

    });

});