
export interface Category {
    categoryId: number;
    name: string;
    createdDate: Date;
}
export interface Product {
    productId: number;
    name: string;
    description: string;
    price: number;
    quantityAvailable: number;
    categoryId: number;
    category: Category; // Include a property for the category
    discount: number;
    isInStock: boolean;
    createdDate: Date;
    imageUrl: string;
    priceAfterDiscount: number;
}
