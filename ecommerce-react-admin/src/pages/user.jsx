import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import { UserServices } from '../services/user.service';

const Users = () => {
    const [userList, setUserList] = useState([]);

    useEffect(() => {
        UserServices.GetAllUser().then((response) => {
            setUserList(response.data);
        })
    })

    return (
        <div className="container">
            <table className="table table-striped mt-3">
                <tbody>
                    <tr>
                        <th>User Id</th>
                        <th>Full Name</th>
                        <th>Email</th>
                        <th>Function</th>
                    </tr>
                </tbody>
                {userList.map((item, index) => {
                    return (
                        <tr key={index}>
                            <td scope="row">{item.userId}</td>
                            <td> {item.userFName}</td>
                            <td> {item.email}</td>
                            <td>
                            <div>
                                    <Link to={`/users/update/${item.UserId}`} className="btn btn-primary" style={{ width: '100%', height: 'auto' }} >Update</Link>
                                    <br></br>
                                    <a className="btn btn-danger" style={{ width: '100%', height: 'auto' }} href="#">Delete</a>
                                </div>
                            </td>
                        </tr>
                    )
                })}
            </table>
        </div>
    )
}

export default Users;