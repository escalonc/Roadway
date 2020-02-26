import React from "react";
import { Form, Input, Button } from "antd";
import { FormComponentProps } from "antd/lib/form";
import { RouteComponentProps } from "@reach/router";

interface Props extends FormComponentProps, RouteComponentProps {}

function Register(props: Props) {
  const formItemLayout = {
    labelCol: {
      xs: { span: 24 },
      sm: { span: 8 }
    },
    wrapperCol: {
      xs: { span: 24 },
      sm: { span: 16 }
    }
  };
  const tailFormItemLayout = {
    wrapperCol: {
      xs: {
        span: 24,
        offset: 0
      },
      sm: {
        span: 16,
        offset: 8
      }
    }
  };

  const { getFieldDecorator } = props.form;

  const handleSubmit = () => {};

  return (
    <Form {...formItemLayout} onSubmit={handleSubmit}>
      <Form.Item label="E-mail">
        {getFieldDecorator("email", {
          rules: [
            {
              type: "email",
              message: "The input is not valid E-mail!"
            },
            {
              required: true,
              message: "Please input your E-mail!"
            }
          ]
        })(<Input />)}
      </Form.Item>
      <Form.Item {...tailFormItemLayout}>
        <Button type="primary" htmlType="submit">
          Register
        </Button>
      </Form.Item>
    </Form>
  );
}

export default Form.create<Props>()(Register);
