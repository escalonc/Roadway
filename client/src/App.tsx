import React from "react";
import "./App.css";
import Dashboard from "./containers/Dashboard";
import RegisterCar from "./containers/Cars/components/Register";
import Cars from "./containers/Cars";
import Home from "./containers/Home";
import { Router } from "@reach/router";

function App() {
  return (
    <div className="App">
      <Dashboard>
        <Router>
          <Home path="/" />
          <Cars path="cars" />
          <RegisterCar path="cars/register" />
        </Router>
      </Dashboard>
    </div>
  );
}

export default App;
