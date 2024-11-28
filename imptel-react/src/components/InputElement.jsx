import React from "react";



function InputElement({placeholder , icon, label, forId, classInput}){ 
    return(
    <div >       
        <label className={classInput} for={forId} >{label}</label>
        <input type="text"  id={forId}   placeholder={placeholder}/>
        <span><img src={icon} alt="" /> </span>
    </div>    

    );

    

}

export default InputElement;