import React from "react";
import logo from "../assets/images/logo.svg"
import enrollmentIcon from "../assets/images/fi-br-user-add.png"
import studentIcon from "../assets/images/fi-br-user-add.png"


const SideBar = () => {
    return (
        <div className="sidebar">
            <img src={logo} alt="Logótipo" />
            <nav className="nav flex-column">
                <a href="" className="nav-link"> <img src={studentIcon} />  Ínicio</a>
                <a href="" className="nav-link"> <img src={enrollmentIcon} /> Ínicio</a>
                <a href="" className="nav-link">Ínicio</a>
                <a href="" className="nav-link">Ínicio</a>
                <a href="" className="nav-link">Ínicio</a>
                <a href="" className="nav-link">Ínicio</a>
                <a href="" className="nav-link">Ínicio</a>
                <a href="" className="nav-link">Ínicio</a>
                <a href="" className="nav-link">Ínicio</a>

            </nav>


        </div>
    )
}

export default SideBar;