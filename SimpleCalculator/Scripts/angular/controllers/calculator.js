angular.module('SimpleCalculator.Controllers')

.controller('CalculatorController', [

    // Dependencies.
    '$scope',

    function (

    $scope

    ) {

        angular.extend($scope, {

            display: '0',
            digits: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9],
            digit_row_grouping: 3,
            parenthesis_row_grouping: 2,
            operators: {
                open_parenthesis : '(',
                closed_parenthesis : ')',
                exponent : '^',
                multiply : 'x',
                divide : '/',
                add : '+',
                subtract : '-',
                equal: '=',
                decimal_point: '.'
            }

        });

    }]);