import api from '../utilities/api.config';

const GetAllUser = () =>{
    return api.get('/api/users');
}

export const UserServices = {
    GetAllUser,
};