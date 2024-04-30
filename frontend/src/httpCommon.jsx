import axios from "axios";

const httpService = () => {
    const defaultOptions = {
        baseURL: 'http://localhost:5259', 
        headers: {
            'Content-Type': 'application/json',
        },
    };
    
    console.log('You are connected to the backend server');

    let instance = axios.create(defaultOptions);

    return instance;
};

export default httpService;





