import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import { CategoryService } from '../services/category.service';

const Category = () => {
    const [categoryList, setCategoryList] = useState([]);

    useEffect(() => {
        CategoryService.GetAllCategory().then((response) => {
            setCategoryList(response.data);
        })
    })

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
                                    <Link to={`/category/update/${item.categoryId}`} className="badge badge-info" style={{ width: 70, height: 20 }} >Cập nhập</Link>
                                    <a className="badge badge-danger" style={{ width: 70, height: 20 }} onClick={() => this.DeleteCategory(item.categoryID)} href="#">Xóa</a>
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