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

    //let result = window.confirm("Want to delete?");
    const btnDelete = (id) => {
        var result = window.confirm("Want to delete?");
        if (result){
            CategoryService.DeleteCategory(id).then(response => {
                console.log({response});
                if (response.status == 200){
                    CategoryService.GetAllCategory().then(setCategoryList(categoryList.filter(x => x.categoryId != id)));
                }
                else 
                    window.alert("There are still products in the category");
            });
        }
        
        
    }
    
    return (
        <div className="container">
            <div>
                <Link to={"/category/create/"} type="button" class="btn btn-success">
                    &#10010; Create
                </Link>
            </div>
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
                                    <Link to={`/category/update/${item.categoryId}`} className="btn btn-primary" style={{ width: '100%', height: 'auto' }} >&#9851;Edit</Link>
                                    <br></br>
                                    <a className="btn btn-danger" style={{ width: '100%', height: 'auto' }} onClick={() =>  btnDelete(item.categoryId)}>&#10060;Delete</a>
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