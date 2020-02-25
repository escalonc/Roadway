import React from "react";
import { RouteComponentProps } from "@reach/router";

export interface CarsProps extends RouteComponentProps { }

export default function Cars(props: CarsProps) {
  return <div>Hello from cars!</div>;
}
