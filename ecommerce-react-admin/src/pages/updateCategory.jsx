import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import { CategoryService } from '../services/category.service';

const UpdateCategory = (props) => {
    const [category, setCategory] = useState([]);
    const [id, setId] = useState(0);

    useEffect(() => {
        setId(props.match.params.id);
        console.log(id);
        if(id) {
            CategoryService.GetCategoryById(props.match.params.id).then((response) =>{
            setCategory(response.data);
        })
        }
    })

    const ButtonClick = () =>{ 

        let categoryName = document.getElementById("categoryName").value;
        let description = document.getElementById("description").value;

        if (categoryName === '' || description === '') {
            document.getElementById('error').innerHTML = "Empty Value!";
        }
        else {
            let params = {
                categoryName: categoryName,
                description: description,
            }
            if (id) {             
                CategoryService.UpdateCategory(id, params).then((response) => {
                });
            }
            else {
                CategoryService.CreateCategory(params).then((response) => {
                });
            }
            
        }
    }

    return (
        <div className="container">
            <div class="form-group">
                <label class="control-label col-md-2"><b>Category Name: </b></label>
                <div class="col-md-5">
                    <input type='text' className="form-control" defaultValue={category.categoryName} id="categoryName" name='name' placeholder='Input category name' />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2"><b>Description</b></label>
                <div class="col-md-7">
                    <textarea className="form-control" id="description" defaultValue={category.description} name='desc' placeholder='Input description' />
                </div>
            </div>

            <div class="col-md-offset-2 col-md-10">
                <p id="error" className="text-danger"></p>
                <Link  to={"/category"} onClick={ButtonClick}  class="btn btn-primary"> {id ? "Update" : "Create"}</Link>
            </div>
        </div>
    )
}

export default UpdateCategory;