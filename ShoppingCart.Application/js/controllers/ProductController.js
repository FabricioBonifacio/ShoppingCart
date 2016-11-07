angular.module("ShoppingCartApp").controller("productCtrl", function ($scope, $http, shoppingCartService) {
    var loadProducts = function () {
        $http.get("http://localhost:64768/api/Product").success(function (data) {
            $scope.products = data;
        });
    }
    $scope.addToCart = function (product) {
        shoppingCartService.add(product);
        itensQuantity();
    }

    var itensQuantity = function () {
        if (shoppingCartService.cartItens.length > 0) {
            $scope.cartItemQuantity = shoppingCartService.cartItens.length;
        }
        else {
            $scope.cartItemQuantity = "Empty";
        }
    }
    
    loadProducts();
    itensQuantity();
});