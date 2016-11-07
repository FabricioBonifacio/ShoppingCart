angular.module('ShoppingCartApp').factory('shoppingCartService', function () {
    var shoppingCartService = {
        cartTotalPrice: 0,
        cartItens: [],
        calculateCartTotalPrice: function(){
            this.cartTotalPrice = 0;
            for(i = 0; i < this.cartItens.length; i++){
                this.cartTotalPrice += this.cartItens[i].Quantity * this.cartItens[i].Product.Price;
            }
			
        },
        add: function(product){
            var existe = false;
            for (i = 0; i < this.cartItens.length; i++) {
                if (this.cartItens[i].Product.ID == product.ID) {
                    this.cartItens[i].Quantity += 1;
                    existe = true;
                }
            }
            if(!existe){
                cartItem = {Quantity : 1, Product : product}
                this.cartItens.push(cartItem);
            }
            this.calculateCartTotalPrice();
        }, 
        remove: function(cartItem){
            this.cartItens = this.cartItens.filter(function (item) {
                if (item.Product.ID != cartItem.Product.ID) {
                    return item;
                }
            });
            this.calculateCartTotalPrice();
        },
        changeQuantity: function (quantity, product) {
            for (i = 0; i < this.cartItens.length; i++) {
                if (this.cartItens[i].Product.ID == product.ID) {
                    this.cartItens[i].Quantity = quantity;
                }
            };
            this.calculateCartTotalPrice();
        }
    };

    return shoppingCartService;
});