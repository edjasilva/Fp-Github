import React from "react";
import Banner from "../components/BannerHome";
import SideBar from "../components/SideBar";
import Header from "../components/Toolbar";
import InputElement from "../components/InputElement";
import searchIcon from "../assets/images/searchIcon.svg"

function Student(){
   
    return(
        <div className="">
            <form action="/" method="">
            <div className="input-lg">
            <InputElement placeholder="Pesquisar: nome ou número de estudante" icon={searchIcon} forId={"search"} classInput={"input-lg"}/>
            </div>
            <div className="input-sm" >
            <InputElement placeholder="Exemplo: 20240022" label={"Número de estudante"} forId={"idNumber"}/>
            </div>
            <div className="input-lg">
            <InputElement placeholder="Nome completo" label={"Nome"} forId={"name"}/>
            </div>
            <div className="input-md">
            <InputElement placeholder="Exemplo: 004557777HO087" label={"Número do documento de identificação"}  forId={"bi"}/>
            </div>
            <div className="input-md">
            <InputElement placeholder="dd-mm-aaaa"  label={"Data de nascimento"} forId={"birthdate"}/>
            </div>
            <div className="input-xlg">
            <InputElement placeholder="Morada completa" label={"Morada completa"} forId={"address"}/>
            </div>
            <div className="input-md">
            <InputElement placeholder="exemplo@imptel.com" label={"Morada"} forId={"completeAddress"}/>
            </div>
            <div className="input-md">
            <InputElement placeholder="900 000 000" label={"Email"} forId={"mail"}/>
            </div>
                
                
            
            

            
            
            
            </form>

        </div>



       
    );
}

export default Student;