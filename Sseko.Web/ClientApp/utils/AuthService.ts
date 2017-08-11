﻿import * as Cookies from 'universal-cookie';
import * as Decoder from 'jwt-decode';

export const GetRole = () => {
    var cookies = new Cookies();
    var token = cookies.get('token');
    var decodedToken = Decoder(token);

    return decodedToken.role;
}

export const Logout = () => {
    var cookies = new Cookies();
    cookies.remove('token');
    window.location.href = '/Login';
}