﻿import * as React from 'react';
import './TopHeader.css';
import { NavLink } from 'react-router-dom';
import { Dropdown } from 'react-bootstrap';
import { FellowLinkGroup } from '../SideNav/FellowLinkGroup';
import { AdminLinkGroup } from '../SideNav/AdminLinkGroup';
import { smoothlyMenu } from '../Helpers';
const loginLogo = require<string>('../../img/logo-login.png');
declare let $: any;

interface TopHeaderProps {
    role: string
}

interface TopHeaderState {
    sideNavCollapsed: boolean
}

class TopHeader extends React.Component<TopHeaderProps, TopHeaderState> {
    constructor(props) {
        super(props);
        this.state = { sideNavCollapsed: false };
    }

    // From Inspinia Template
    toggleNavigation = (e) => {
        e.preventDefault();
        $("body").toggleClass("mini-navbar");
        smoothlyMenu();
        // TODO scale() the datatable
        this.setState((prevState) => ({ sideNavCollapsed: !prevState.sideNavCollapsed }));
    }

    render() {
        const today = new Date();
        const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
        const months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];

        return (
            <nav className="navbar navbar-fixed-top navbar-margin-bottom" role="navigation">
                <div className="navbar-header">
                    <span className={"hamburger" + (this.state.sideNavCollapsed ? "" : " open")} onClick={this.toggleNavigation}>
                        <span className="hamburger-top"></span>
                        <span className="hamburger-middle"></span>
                        <span className="hamburger-bottom"></span>
                    </span>
                    <img src={loginLogo} />
                    <div className="headerText">
                        <span>Welcome <strong>Genavieve Moyer</strong>.</span>
                        <span>Today is  {days[today.getDay()]}, <strong>{months[today.getMonth()]} {today.getDate()}, {today.getFullYear()}</strong></span>
                    </div>
                </div>
                <ul className="nav navbar-top-links navbar-right">
                    <li>
                        <div className="profile-box">
                            <i className="fa fa-user-circle" aria-hidden="true"></i>
                        </div>
                    </li>
		        </ul>
	        </nav>
        )
    }
}

export default TopHeader