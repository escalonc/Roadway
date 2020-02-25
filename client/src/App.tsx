import React from "react";
import "./App.css";
import Dashboard from "./containers/Dashboard";
import RegisterCar from "./containers/Cars/components/Register";
import Cars from "./containers/Cars";

function App() {
  return (
    <div className="App">
      <Dashboard>
        <Cars path="cars" />
        <RegisterCar path="cars/register" />
      </Dashboard>
    </div>
  );
}

export default App;
