angular.module("ShoppingCartApp").controller("shoppingCartCtrl", function ($scope, $http, shoppingCartService) {
    $scope.message = "";
    $scope.showPaymentInformation = false;
    var loadShoppingCart = function () {
        $scope.totalPrice = shoppingCartService.cartTotalPrice;
        $scope.cartItens = shoppingCartService.cartItens;
    }
    $scope.removeFromCart = function (cartItem) {
        shoppingCartService.remove(cartItem);
        loadShoppingCart();
    }
    $scope.getTotalPrice = function (cartItem) {
        shoppingCartService.changeQuantity(cartItem.Quantity, cartItem.Product);
        $scope.totalPrice = shoppingCartService.cartTotalPrice;
    }
    $scope.enablePaymentInformation = function () {
        $scope.showPaymentInformation = true;
    }
    $scope.done = function () {
        $scope.cart = {
            cartItens: shoppingCartService.cartItens,
            paymentInformation: $scope.paymentInformation
        };
        $http.post("http://localhost:64768/api/Cart", $scope.cart).success(function (data) {
            $scope.showPaymentInformation = false;
            $scope.cartItens = [];
            shoppingCartService.cartTotalPrice = 0,
            shoppingCartService.cartItens = [],
            $scope.message = "You purchase was completed";
        });
    }

    loadShoppingCart();
});