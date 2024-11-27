import React from "react";


function Header({name}){
    return(
        <div className="header ">
            <div className="row ">
                <div className="col-6  ">Bem vindo(a),{name} </div>
                <div className="col-3 ">Bem vindo(a),{name} </div>
                
                <div className="col-3  btn btn-secondary btn-nav-o ">Imptel Online </div>

            </div>
        
        </div>
    );
}

export default Header;