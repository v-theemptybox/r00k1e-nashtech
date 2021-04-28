import api from '../utilities/api.config';

const GetAllCategory = () =>{
    return api.get('/api/Categories');
}

const GetCategoryById = (id) => {
    return api.get('/api/Categories/' + id);
}

const UpdateCategory = (id, params) => {
    return api.put('/api/Categories/' + id, params);
}
const DeleteCategory = (id) => {
    return api.delete('/api/Categories/' + id);
}

export const CategoryService = {
    GetAllCategory,
    GetCategoryById,
    UpdateCategory,
    DeleteCategory
};
