import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import { ProductServices } from '../services/product.service';
import TextTruncate from 'react-text-truncate';

const Products = () => {
    const [productList, setProductList] = useState([]);

    useEffect(() => {
        ProductServices.GetAllProduct().then((response) => {
            setProductList(response.data);
        })
    },[])

    const btnDelete = (id) => {
        ProductServices.DeleteProduct(id);
        ProductServices.GetAllProduct().then(setProductList(productList.filter(x => x.productId != id)));
    }

    return (
        
        <div className="container">
            <Link to={"/products/create/"} type="button" class="btn btn-success">
                    &#10010; Create
                </Link>
            <table className="table table-striped mt-3">
                <tbody>
                    <tr>
                        <th>Product Id</th>
                        <th>Image</th>
                        <th>Product Name</th>
                        <th>Price</th>
                        <th>Description</th>
                        <th>Updated Date</th>
                        <th>Management</th>
                    </tr>
                </tbody>
                {productList.map((item, index) => {
                    return (
                        <tr key={index}>
                            <td scope="row">{item.productId}</td>
                            <td><img style={{maxWidth: '100%', height: 'auto'}} src={process.env.REACT_APP_URL_BACKEND + item.images} alt="product img cap"/></td>
                            <td> {item.productName}</td>
                            <td> {item.price}$</td>
                            <td> <TextTruncate
                                line={5}
                                element="p"
                                truncateText="…"
                                text={item.description}            
                            /></td>
                            <td> {item.updatedDate}</td>
                            <td>
                                <div>
                                    <Link to={`/products/update/${item.productId}`} className="btn btn-primary" style={{ width: '100%', height: 'auto' }} >&#9851;Edit</Link>
                                    <br></br>
                                    <a className="btn btn-danger" style={{ width: '100%', height: 'auto' }} onClick={() => btnDelete(item.productId)}>&#10060;Delete</a>
                                </div>
                            </td>
                        </tr>
                    )
                })}
            </table>
        </div>
    )
}

export default Products;