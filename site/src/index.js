import React from 'react';
import { render } from 'react-dom';

import { HashRouter } from 'react-router-dom'
import { App }  from './app/components/App.js'

import "./media/styles.css"

render((
    <HashRouter>
            <App />
    </HashRouter>
), window.document.getElementById('root'));
