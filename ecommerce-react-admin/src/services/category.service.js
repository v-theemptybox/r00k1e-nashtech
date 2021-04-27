import api from '../utilities/api.config';

const GetAllCategory = () =>{
    return api.get('/api/Categories');
}

const GetCategoryById = (id) => {
    return api.get('/api/Categories/' + id);
}

const UpdateCategory = (id, params) => {
    return api.put('/api/Categories/' + id, params).then((res) =>{
console.log(res);
    });
}

export const CategoryService = {
    GetAllCategory,
    GetCategoryById,
    UpdateCategory
};
