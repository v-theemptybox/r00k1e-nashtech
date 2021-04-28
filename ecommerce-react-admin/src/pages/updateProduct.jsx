import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import { ProductServices } from '../services/product.service';
import {Button} from 'reactstrap';

const UpdateProduct = (props) => {
    const [product, setProduct] = useState([]);
    const [id, setId] = useState(0);

    useEffect(() => {
        setId(props.match.params.id);
        ProductServices.GetProductById(props.match.params.id).then((response) =>{
            setProduct(response.data);
            //console.log(response.data);
        })
    },[])


    const ButtonClick = () =>{
        let images = document.getElementById("productImg").files;
        let productName = document.getElementById("productName").value;
        let price = document.getElementById("price").value;
        let description = document.getElementById("description").value;
        let createdDate = document.getElementById("createdDate").value;
        let updatedDate = document.getElementById("updatedDate").value;
        let brandId = document.getElementById("brandId").value;
        let categoryId = document.getElementById("categoryId").value;

        console.log(images);
        // const formData = new FormData();
        //     formData.append("images", images, images.name);
        // console.log(formData);  
        if (productName === '' || description === '') {
            document.getElementById('error').innerHTML = "Empty value!";
        }
        else {
            
            const formData = new FormData();
            formData.append("images", images[0], images[0].name);
            formData.append('productName', productName.toString());
            formData.append('description', description.toString());
            formData.append('price', price.toString());
            formData.append('categoryId', categoryId.toString());
            formData.append('createdDate', createdDate.toString());
            formData.append('updatedDate', updatedDate.toString());
            formData.append('brandId', brandId.toString());

            
            // let params = {
            //     images: images,
            //     productName: productName,
            //     price: price,
            //     description: description,
            //     createdDate: createdDate,
            //     updatedDate: updatedDate,
            //     brandId: brandId,
            //     categoryId: categoryId
            // }

            if (id) {
                console.log(formData);
                ProductServices.UpdateProduct(id, formData).then((response) => {
                    
                });
            }

        }
    }

    return (
        <div className="container">
            <div class="form-group">
                <label class="control-label col-md-2"><b>Image</b></label>
                <div class="col-md-5">
                    <img src={process.env.REACT_APP_URL_BACKEND + product.images} alt="img cap"/>
                    <input type='file' className="form-control" id="productImg" name='name' placeholder='Input product image' />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2"><b>Product Name</b></label>
                <div class="col-md-5">
                    <input type='text' className="form-control" id="productName" defaultValue={product.productName} name='name' placeholder='Input product name' />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2"><b>Price</b></label>
                <div class="col-md-5">
                    <input type='text' className="form-control" id="price" defaultValue={product.price} name='name' placeholder='Input product price' />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2"><b>Description</b></label>
                <div class="col-md-7">
                    <textarea className="form-control" id="description" defaultValue={product.description} name='name' placeholder='Input description' />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2"><b>Brand Id</b></label>
                <div class="col-md-5">
                    <input type='text' className="form-control" id="brandId" value="1" name='name' placeholder='Input brand id' />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2"><b>Category Id</b></label>
                <div class="col-md-5">
                    <input type='text' className="form-control" id="categoryId" defaultValue={product.categoryId} name='name' placeholder='Input category id' />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2"><b>Created Date</b></label>
                <div class="col-md-5">
                    <input type='datetime' className="form-control" id="createdDate" value={product.createdDate} name='name' placeholder='Input created date' />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-md-2"><b>Updated Date</b></label>
                <div class="col-md-5">
                    <input type='datetime' className="form-control" id="updatedDate" value={product.updatedDate} name='name' placeholder='Input updated date' />
                </div>
            </div>

            <div class="col-md-offset-2 col-md-10">
                <p id="error" className="text-danger"></p>
                
                <Link  to={"/products"} onClick={ButtonClick}  class="btn btn-primary"> {id ? "Update" : "Create"}</Link>
            </div>
        </div>
    )

}

export default UpdateProduct;