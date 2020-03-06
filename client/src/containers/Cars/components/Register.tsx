import React, { useState } from "react";
import { Form, Input, Button, Row, Col, InputNumber, Select } from "antd";
import { FormComponentProps } from "antd/lib/form";
import { RouteComponentProps } from "@reach/router";
import { Fuels, Sizes, Uses } from "../carModel";

interface Props extends FormComponentProps, RouteComponentProps {}

function Register(props: Props) {
  const [displayUserForm, setDisaplayForm] = useState(false);

  const { getFieldDecorator } = props.form;
  const { Option } = Select;

  const handleSubmit = () => {};

  return (
    <Form onSubmit={handleSubmit}>
      <Row gutter={20} type="flex" justify="center">
        <Col span={5}>
          <Form.Item label="Vin">
            {getFieldDecorator("vin", {
              rules: [
                {
                  required: true
                }
              ]
            })(<Input />)}
          </Form.Item>
          <Form.Item label="Placa">
            {getFieldDecorator("licensePlate", {
              rules: [
                {
                  required: true
                }
              ]
            })(<Input />)}
          </Form.Item>
          <Form.Item label="Marca">
            {getFieldDecorator("brand", {
              rules: [
                {
                  required: true
                }
              ]
            })(<Input />)}
          </Form.Item>
          <Form.Item label="Modelo">
            {getFieldDecorator("model", {
              rules: [
                {
                  required: true
                }
              ]
            })(<Input />)}
          </Form.Item>
          <Form.Item label="Versión">
            {getFieldDecorator("version", {
              rules: [
                {
                  required: true
                }
              ]
            })(<Input />)}
          </Form.Item>
        </Col>
        <Col span={5}>
          <Form.Item label="Tipo">
            {getFieldDecorator("type", {
              initialValue: "",
              rules: [
                {
                  required: true
                }
              ]
            })(<Input />)}
          </Form.Item>

          <Form.Item label="Color">
            {getFieldDecorator("color", {
              rules: [
                {
                  required: true
                }
              ]
            })(<Input />)}
          </Form.Item>
          <Form.Item label="Combustible">
            {getFieldDecorator("fuel", {
              initialValue: Fuels.Gasoline,
              rules: [
                {
                  required: true
                }
              ]
            })(
              <Select>
                <Option value={Fuels.Gasoline}>Gasolina</Option>
                <Option value={Fuels.Diesel}>Diesel</Option>
                <Option value={Fuels.Electric}>Eléctrico</Option>
                <Option value={Fuels.Hybrid}>Híbrido</Option>
              </Select>
            )}
          </Form.Item>
          <Form.Item label="Tamaño">
            {getFieldDecorator("size", {
              initialValue: Sizes.Medium,
              rules: [
                {
                  required: true
                }
              ]
            })(
              <Select>
                <Option value={Sizes.Small}>Pequeño</Option>
                <Option value={Sizes.Medium}>Mediano</Option>
                <Option value={Sizes.Large}>Grande</Option>
                <Option value={Sizes.ExtraLarge}>Extra grande</Option>
              </Select>
            )}
          </Form.Item>
          <Form.Item label="Uso">
            {getFieldDecorator("use", {
              initialValue: Uses.Personal,
              rules: [
                {
                  required: true
                }
              ]
            })(
              <Select>
                <Option value={Uses.Personal}>Personal</Option>
                <Option value={Uses.Rental}>Rentado</Option>
                <Option value={Uses.Government}>Gobierno</Option>
                <Option value={Uses.Official}>Oficial</Option>
              </Select>
            )}
          </Form.Item>
        </Col>
        <Col span={5}>
          <Form.Item label="Banco">
            {getFieldDecorator("bank", {
              initialValue: "",
              rules: [
                {
                  required: true
                }
              ]
            })(<Input />)}
          </Form.Item>
          <Form.Item label="Compañia de seguro">
            {getFieldDecorator("insurence", {
              initialValue: "",
              rules: [
                {
                  required: true
                }
              ]
            })(<Input />)}
          </Form.Item>
          <Form.Item label="Año">
            {getFieldDecorator("year", {
              rules: [
                {
                  required: true,
                  message: "Este campo es requerido"
                },
                {
                  min: 1950,
                  max: 2030,

                  message: "El año deber ser entre 1950 y 2030"
                },
                { type: "number", message: "solo numeros son permitidos" }
              ]
            })(<InputNumber />)}
          </Form.Item>
        </Col>
      </Row>
      <Row>
        <Col offset={10}>
          <Form.Item>
            <Button type="primary" size="large" htmlType="submit">
              Register
            </Button>
          </Form.Item>
        </Col>
      </Row>
    </Form>
  );
}

export default Form.create<Props>()(Register);
