import React from "react";
import logo from "../assets/images/logo.svg"
import enrollmentIcon from "../assets/images/fi-br-chart-pie-alt.svg"
import studentIcon from "../assets/images/fi-br-user-add.svg"
import listIcon from "../assets/images/fi-br-line-width.svg"
import schoolEnrollmentIcon  from "../assets/images/fi-br-diploma.svg"
import cashIcon from "../assets/images/fi-br-sign-out-alt.svg"
import reports from "../assets/images/fi-br-dollar.svg"



const SideBar = () => {
    return (
        <div className="sidebar">
            <img src={logo} alt="Logótipo" />
            <nav className="nav flex-column">
                <a href="" className="nav-link "> <img src={studentIcon} />  Ínicio</a>
                <a href="" className="nav-link"> <img src={enrollmentIcon} /> Ínicio</a>
                <a href="" className="nav-link"> <img src={listIcon} /> Ínicio</a>
                <a href="" className="nav-link"> <img src={enrollmentIcon} /> Ínicio</a>
                <a href="" className="nav-link"> <img src={enrollmentIcon} /> Ínicio</a>
                <a href="" className="nav-link"> <img src={enrollmentIcon} /> Ínicio</a>
                <a href="" className="nav-link"> <img src={enrollmentIcon} /> Ínicio</a>
                <a href="" className="nav-link"> <img src={enrollmentIcon} /> Ínicio</a>
                <a href="" className="nav-link"> <img src={enrollmentIcon} /> Ínicio</a>

            </nav>


        </div>
    )
}

export default SideBar;