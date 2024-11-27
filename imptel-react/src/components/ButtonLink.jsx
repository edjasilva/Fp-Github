import React from "react";

function ButtonLink({ route, icon, label }) {
    return (
        <div className="button-link container-fluid d-flex">
            <div className="row">
                <button 
                    className="link-item" 
                    onClick={() => window.location.href = route} 
                >
                    <img src={icon} alt={label} className="link-item-icon" />
                    {label}
                </button>           
            </div>
        </div>
    );
}
export default ButtonLink;