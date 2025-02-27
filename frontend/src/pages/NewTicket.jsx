import React from 'react';
import { useEffect, useState } from 'react';
import {useSelector, useDispatch } from 'react-redux'
import { useNavigate } from 'react-router-dom';
import {create, reset} from '../features/tickets/ticketSlice'
import { toast } from 'react-toastify'
import Spinner from '../components/Spinner'
import BackButton from '../components/BackButton'

function NewTicket() {
    const {user} = useSelector((state) => state.auth)
    const {isLoading, isError, isSuccess, message} = useSelector((state) => state.ticket)
    const [name] = useState(user.name)
    const [email] = useState(user.email)
    const [product, setProduct] = useState('iPhone')
    const [description, setDescription] = useState('')

    const dispatch = useDispatch()
    const navigate = useNavigate()

    useEffect(() => {
        if (isError)
            toast.error(message)
        if (isSuccess) {
            dispatch(reset())
            navigate('/')
        }
        dispatch(reset())
    }, [isError, isSuccess, message, navigate, dispatch])

    const onSubmit = (e) => {
        e.preventDefault()

        const ticket = {
            user: user.id,
            product,
            description
        }
        dispatch(create(ticket))
    }

    if (isLoading)
        return <Spinner />

    return (
        <>
            <BackButton url='/' />
            <section className="heading">
                <h1>Create new ticket</h1>
                <p>Please fill out the form below</p>
            </section>
            <section className="form">
                <div className="form-group">
                    <label htmlFor="name">Customer name</label>
                    <input type="text" className="form-control" value={name} disabled />
                </div>
                <div className="form-group">
                    <label htmlFor="email">Customer email</label>
                    <input type="text" className="form-control" value={email} disabled />
                </div>
                <form onSubmit={onSubmit}>
                    <div className="form-group">
                        <label htmlFor="product">Product</label>
                        <select name="product" id="product" value={product} className="form-control" onChange={(e) => setProduct(e.target.value)}>
                            <option value="iPhone">iPhone</option>
                            <option value="MacBook Pro">MacBook Pro</option>
                            <option value="iMac">iMac</option>
                            <option value="iPad">iPad</option>
                        </select>
                    </div>
                    <div className="form-group">
                        <label htmlFor="description">Description of the issue</label>
                        <textarea name="description" id="description" className='form-control' value={description} placeholder="Description" onChange={(e) => setDescription(e.target.value)}></textarea>
                    </div>
                    <div className="form-group">
                        <button className="btn btn-block">
                            Submit
                        </button>
                    </div>
                </form>
            </section>
        </>
    );
}

export default NewTicket