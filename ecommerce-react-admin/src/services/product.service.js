import api from '../utilities/api.config';

const GetAllProduct = () =>{
    return api.get('/api/Products');
}

const GetProductById = (id) => {
    return api.get('/api/Products/' + id);
}

const UpdateProduct = async (id, params) => {
    return await api.put('/api/Products/' + id, params).then((res) =>{});
}

const CreateProduct = (params) => {
    return api.post('/api/Products/' , params);
}

const DeleteProduct = (id) => {
    return api.delete('/api/Products/' + id);
}

export const ProductServices = {
    GetAllProduct,
    GetProductById,
    UpdateProduct,
    DeleteProduct,
    CreateProduct
};
