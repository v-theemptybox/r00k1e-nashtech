import api from '../utilities/api.config';

const GetAllCategory = () =>{
    return api.get('/api/Categories');
}

const GetCategoryById = async (id) => {
    return await api.get('/api/Categories/' + id);
}

const UpdateCategory = async (id, params) => {
    return await api.put('/api/Categories/' + id, params);
}

const CreateCategory =  async (params) => {
    return await api.post('/api/Categories/', params);
}

const DeleteCategory = async (id) => {
    return await api.delete('/api/Categories/' + id);
}

export const CategoryService = {
    GetAllCategory,
    GetCategoryById,
    UpdateCategory,
    DeleteCategory,
    CreateCategory
};
