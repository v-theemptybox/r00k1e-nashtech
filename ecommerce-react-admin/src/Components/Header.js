import React, { useState } from 'react';
import { Collapse, Navbar, NavbarToggler, NavbarBrand, Nav, NavItem, NavLink, FormFeedback } from 'reactstrap';
import { Button, Modal, ModalHeader, ModalBody, ModalFooter, Form, FormGroup, Label, Input } from 'reactstrap';
import {AccountService} from '../services/account.service';
import { instanceOf } from 'prop-types';
import { withCookies, Cookies } from 'react-cookie';

const Example = (props) => {
  const [collapsed, setCollapsed] = useState(true);
  const toggleNavbar = () => setCollapsed(!collapsed);

  const {
    buttonLabel,
    className
  } = props;
  const [modal, setModal] = useState(false);
  const toggle = () => setModal(!modal);

  const propTypes = {
    cookies: instanceOf(Cookies).isRequired
  };

  const btnLogin = () => {
    let email = document.getElementById("txtEmail").value;
    let pwd = document.getElementById("txtPwd").value;
    
    AccountService.LoginService(email, pwd).then((res) => {
      console.log("this is")
      console.log(res);
      //Check if email or password invalid       
      if (res.status == 400) {
          document.getElementById('emailErr').innerHTML = "Wrong password or email!";
          document.getElementById('pwdErr').innerHTML = "Wrong password or email!";
      }
      else if(res.status == 200){
        window.location.reload();
        window.alert("Login success!");
      }
      
    })
  }

  return (
    <div>
      <Navbar color="faded" light>
        <NavbarBrand href="/" className="mr-auto">Admin.Site</NavbarBrand>
        <Nav>
          <Button color="warning" onClick={toggle}>{buttonLabel}Login</Button>
          <Modal isOpen={modal} toggle={toggle} className={className}>
            <ModalHeader toggle={toggle}>V-eshop Login</ModalHeader>
            <ModalBody>
              <Form>
              <FormGroup>
                <Label for="exampleEmail">Email</Label>
                <Input invalid type="email" name="email" id="txtEmail" placeholder="example@mail.com" />
                <FormFeedback id="emailErr">Please enter your email</FormFeedback>
              </FormGroup>
              <FormGroup>
                <Label for="examplePassword">Password</Label>
                <Input invalid type="password" name="password" id="txtPwd" placeholder="Ex@mp1e" />
                <FormFeedback id="pwdErr">Please enter your password</FormFeedback>
              </FormGroup>
              </Form>
            </ModalBody>
            <ModalFooter>
              <Button color="primary" onClick={toggle, btnLogin}>Login</Button>{' '}
              <Button color="secondary" onClick={toggle}>Cancel</Button>
            </ModalFooter>
          </Modal>

          <NavLink href="/category">Categories</NavLink>
          <NavLink href="/products">Products</NavLink>
          <NavLink href="/users">Users</NavLink>

        </Nav>
        <NavbarToggler onClick={toggleNavbar} className="mr-2" />
        <Collapse isOpen={!collapsed} navbar>
          <Nav navbar>
            <NavItem>
              <NavLink href="/category">Categories</NavLink>
            </NavItem>
            <NavItem>
              <NavLink href="/products">Products</NavLink>
            </NavItem>
            <NavItem>
              <NavLink href="/users">Users</NavLink>
            </NavItem>
          </Nav>
        </Collapse>
      </Navbar>
    </div>
  );
}

export default withCookies(Example);
