System.register(['angular2/core'], function(exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
        var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
        if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
        else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
        return c > 3 && r && Object.defineProperty(target, key, r), r;
    };
    var __metadata = (this && this.__metadata) || function (k, v) {
        if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
    };
    var core_1;
    var ProductService;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            }],
        execute: function() {
            ProductService = (function () {
                function ProductService() {
                }
                ProductService.prototype.getProducts = function () {
                    return [
                        {
                            "productId": 1,
                            "productName": "Leaf Rake",
                            "productCode": "GDN-0011",
                            "releaseDate": "March 19, 2016",
                            "description": "Leaf rake with 48-inch wooden handle.",
                            "price": 19.95,
                            "starRating": 3.2,
                            "imageUrl": "https://cdn3.tgdd.vn/Products/Images/42/72373/samsung-galaxy-note-5-14-200x200.jpg"
                        },
                        {
                            "productId": 2,
                            "productName": "Garden Cart",
                            "productCode": "GDN-0023",
                            "releaseDate": "March 18, 2016",
                            "description": "15 gallon capacity rolling garden cart",
                            "price": 32.99,
                            "starRating": 4.2,
                            "imageUrl": "https://cdn1.tgdd.vn/Products/Images/42/76481/iphone-se-64gb-2-200x200.jpg"
                        },
                        {
                            "productId": 5,
                            "productName": "Hammer",
                            "productCode": "TBX-0048",
                            "releaseDate": "May 21, 2016",
                            "description": "Curved claw steel hammer",
                            "price": 8.9,
                            "starRating": 4.8,
                            "imageUrl": "https://cdn4.tgdd.vn/Products/Images/42/77509/sony-xperia-z5-premium-pink-edition2-1-200x200.jpg"
                        },
                        {
                            "productId": 8,
                            "productName": "Saw",
                            "productCode": "TBX-0022",
                            "releaseDate": "May 15, 2016",
                            "description": "15-inch steel blade hand saw",
                            "price": 11.55,
                            "starRating": 3.7,
                            "imageUrl": "https://cdn4.tgdd.vn/Products/Images/42/75994/asus-zenfone-3-9-200x200.jpg"
                        },
                        {
                            "productId": 10,
                            "productName": "Video Game Controller",
                            "productCode": "GMG-0042",
                            "releaseDate": "October 15, 2015",
                            "description": "Standard two-button video game controller",
                            "price": 35.95,
                            "starRating": 4.6,
                            "imageUrl": "https://cdn3.tgdd.vn/Products/Images/42/73608/oppo-r7s2-3-200x200.jpg"
                        }
                    ];
                };
                ProductService = __decorate([
                    core_1.Injectable(), 
                    __metadata('design:paramtypes', [])
                ], ProductService);
                return ProductService;
            }());
            exports_1("ProductService", ProductService);
        }
    }
});
//# sourceMappingURL=product.servive.js.map