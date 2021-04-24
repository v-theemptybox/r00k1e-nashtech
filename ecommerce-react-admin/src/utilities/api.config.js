import axios from 'axios';

//Get base url backend to axios
const api = axios.create({
  baseURL: process.env.REACT_APP_URL_BACKEND,
});

export default api;