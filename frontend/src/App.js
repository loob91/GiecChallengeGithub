import React from 'react';
import {BrowserRouter as Router, Routes, Route} from 'react-router-dom'
import Header from './components/Header';
import Home from './pages/Home';
import Login from './pages/Login';
import Register from './pages/Register';
import NewPurchase from './pages/NewPurchase';
import NewProduct from './pages/NewProduct';
import PrivateRoute from './components/PrivateRoute';
import Purchase from './pages/Purchase';
import {ToastContainer} from 'react-toastify'
import 'react-toastify/dist/ReactToastify.css'

function App() {
  return (
    <>
      <Router>
        <div className='container'>
          <Header />
          <Routes>
            <Route path="/" element={<PrivateRoute />}>
              <Route path="/" element={<Home />} />
            </Route>
            <Route path="/login" element={<Login />} />
            <Route path="/register" element={<Register />} />
            <Route path="/new-purchase" element={<PrivateRoute />}>
              <Route path="/new-purchase" element={<NewPurchase />} />
            </Route>
            <Route path="/new-product" element={<PrivateRoute />}>
              <Route path="/new-product" element={<NewProduct />} />
            </Route>
            <Route path="/purchase/:id" element={<PrivateRoute />}>
              <Route path="/purchase/:id" element={<Purchase />} />
            </Route>
          </Routes>
        </div>
      </Router>
      <ToastContainer />
    </>
  );
}

export default App;
