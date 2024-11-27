import { useState } from "react";
import React from "react";

function MenuItem({icon, label, isActive, route, onClick}){

    return(
    <div className="menu container-fluid d-flex ">
        <div className="row">
                <button className={`menu-item   ${isActive?"active":"" }`} 
                    onClick={onClick} >
                    <img src={icon}  alt={label} className="menu-item-icon "  />
                    {label}
                </button>            
        </div>
    </div>
)}

export default MenuItem;