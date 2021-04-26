import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import { CategoryService } from '../services/category.service';

const UpdateCategory = (props) => {
    const [category, setCategory] = useState([]);
    const [id, setId] = useState(0);

    useEffect(() => {
        setId(props.match.params.id);
        CategoryService.GetCategoryById(props.match.params.id).then((response) =>{
            setCategory(response.data);
        })
    })

    const ButtonClick = () =>{
        let categoryName = document.getElementById("categoryName").value;
        let description = document.getElementById("description").value;

        if (categoryName === '' || description === '') {
            document.getElementById('error').innerHTML = "Không chừa trống dữ liệu!";
        }
        else {
            let params = {
                categoryName: categoryName,
                description: description,
            }

            if (id) {
                CategoryService.UpdateCategory(id, params).then((response) => {
                    //history.push('/category');
                });
            }
            // else {
            //     CategoryService.CreateCategory(params, cookies.get('user').access_token).then((response) => {
            //        // history.push('/category');
            //     });
            // }
        }
    }

    return (
        <div className="container">
            <div class="form-group">
                <label class="control-label col-md-2"><b>Tên loại: </b></label>
                <div class="col-md-5">
                    <input type='text' className="form-control" defaultValue={category.categoryName} id="categoryName" name='name' placeholder='Nhập tên sản phẩm...' />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2"><b>Mô tả</b></label>
                <div class="col-md-7">
                    <textarea className="form-control" id="description" defaultValue={category.description} name='name' placeholder='Nhập tên sản phẩm...' />
                </div>
            </div>

            <div class="col-md-offset-2 col-md-10">
                <p id="error" className="text-danger"></p>
                <Link  to={"/category"} onClick={ButtonClick}  class="btn btn-primary"> {id ? "Cập nhật" : "Thêm mới"}</Link>
            </div>
        </div>
    )
}

export default UpdateCategory;