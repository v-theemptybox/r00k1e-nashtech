import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import { CategoryService } from '../services/category.service';

const Category = () => {
    const [categoryList, setCategoryList] = useState([]);

    useEffect(() => {
        CategoryService.GetAllCategory().then((response) => {
            setCategoryList(response.data);
        })
    },[])

    const btnDelete = (id) => {
        CategoryService.GetAllCategory().then(setCategoryList(categoryList.filter(x => x.categoryId != id)));
        CategoryService.DeleteCategory(id);
    }

    return (
        <div className="container">
            <table className="table table-striped mt-3">
                <tbody>
                    <tr>
                        <th>Category Id</th>
                        <th>Category Name</th>
                        <th>Description</th>
                        <th>Function</th>
                    </tr>
                </tbody>
                {categoryList.map((item, index) => {
                    return (
                        <tr key={index}>
                            <td scope="row">{item.categoryId}</td>
                            <td> {item.categoryName}</td>
                            <td> {item.description}</td>
                            <td>
                                <div>
                                    <Link to={`/category/update/${item.categoryId}`} className="btn btn-primary" style={{ width: '100%', height: 'auto' }} >Update</Link>
                                    <br></br>
                                    <a className="btn btn-danger" style={{ width: '100%', height: 'auto' }} onClick={() =>  btnDelete(item.categoryId)}>Edit</a>
                                </div>
                            </td>
                        </tr>
                    )
                })}
            </table>
        </div>
    )
}

export default Category;