import React from "react";
import { RouteComponentProps } from "@reach/router";

interface HomeProps extends RouteComponentProps {}
export default function index(props: HomeProps) {
  return <p>You can see some stats</p>;
}
