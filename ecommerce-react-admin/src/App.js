import React from 'react';
import {BrowserRouter as Router, Route} from 'react-router-dom'
import Header from './Components/Header'
import Footer from './Components/Footer'
import 'bootstrap/dist/css/bootstrap.min.css'
import Category from "./pages/category";
import UpdateCategory from "./pages/updateCategory";
import Product from "./pages/product";


function App() {
  return (
    <div className="App">
      <Router>
        <Header></Header>
        <Route exact path="/category">
          <Category />
        </Route>
        <Route exact path="/products">
          <Product />
        </Route>
        <Route exact path="/category/update/:id?" render={(props) => <UpdateCategory {...props} />}/> 
        <Footer></Footer>
      </Router>
    </div>
  );
}
export default App;
