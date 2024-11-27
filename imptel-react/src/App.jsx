import React from "react";
import SideBar from "./components/SideBar";
import Header from "./components/Header";
import Banner from "./components/BannerHome";

function App() {
    return (
        <div className="container-fluid">
            {/* Menu lateral */}
            <SideBar />

            {/* Conteúdo principal */}
            <div className="main-content">
                <Header />
                <Banner />
            </div>
        </div>
    );
}

export default App;
