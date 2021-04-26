import api from '../utilities/api.config';

const GetAllProduct = () =>{
    return api.get('/api/Products');
}

const GetProductById = (id) => {
    return api.get('/api/Products/' + id);
}

const UpdateProduct = (id, params) => {
    return api.put('/api/Products/' + id, params);
}

export const ProductServices = {
    GetAllProduct,
    GetProductById,
    UpdateProduct
};
