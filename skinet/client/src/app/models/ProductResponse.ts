export interface ProductResponse {
	pageIndex: number;
	pageSize: number;
	count: number;
	data: ProductResponseData[];
}
export interface ProductResponseData {
	id: string;
	name: string;
	category: string;
	description: string;
	price: number;
	pictureUrl: string;
	productType: string;
	productBrand: string;
	tags: any[];
	colors: any[];
	sizes: any[];
}