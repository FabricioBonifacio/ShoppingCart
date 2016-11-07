angular.module("ShoppingCartApp").config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise('/');
    $stateProvider
		.state('index', {
		    url: '/',
		    templateUrl: 'product/Product.html',
		    controller: 'productCtrl'
		})
        .state('shoppingCart', {
            url: '/shoppingCart',
            templateUrl: 'shoppingCart/ShoppingCart.html',
            controller: 'shoppingCartCtrl'
        })
});