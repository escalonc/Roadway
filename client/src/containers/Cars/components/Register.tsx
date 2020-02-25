import React from "react";
import { Card, Form } from "antd";
// import Brand from "../../Brands";
import { FormComponentProps } from "antd/lib/form";
import { RouteComponentProps } from "@reach/router";
// import AddBrand from "../../Brands/components/AddBrand";

interface Props extends FormComponentProps, RouteComponentProps {}

function Register(props: Props) {
  // const { form } = props;

  return (
    <Form>
      <Card>
        {/* <Brand form={form} /> */}
        <p>Hello!!!</p>
      </Card>
    </Form>
  );
}

export default Form.create<Props>()(Register);
