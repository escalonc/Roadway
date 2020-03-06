import React, { useState, createElement } from "react";

import { Layout, Menu } from "antd";
import {
  HomeFilled,
  CarFilled,
  MenuUnfoldOutlined,
  MenuFoldOutlined
} from "@ant-design/icons";
import { Link } from "@reach/router";
import "./index.scss";
const { Header, Sider, Content } = Layout;
const { SubMenu } = Menu;

export interface Props {
  children: JSX.Element[] | JSX.Element;
}
function Dashboard(props: Props) {
  const [collapsed, setCollapsed] = useState(false);

  const toggle = () => setCollapsed(!collapsed);

  const { children } = props;
  return (
    <Layout style={{ minHeight: "100vh" }}>
      <Sider trigger={null} collapsible collapsed={collapsed}>
        <div className="logo" />
        <Menu
          theme="dark"
          mode="inline"
          defaultSelectedKeys={["home"]}
          defaultOpenKeys={["cars"]}
        >
          <Menu.Item key="home">
            <HomeFilled />
            <span>Inicio</span>
            <Link to="/" />
          </Menu.Item>
          <SubMenu
            key="cars"
            title={
              <span>
                <CarFilled />
                <span>Autos</span>
              </span>
            }
          >
            <Menu.Item key="1">
              <span>Registro</span>
              <Link to="cars/register" />
            </Menu.Item>
          </SubMenu>
        </Menu>
      </Sider>
      <Layout>
        <Header style={{ background: "#fff", padding: 0 }}>
          {createElement(collapsed ? MenuUnfoldOutlined : MenuFoldOutlined, {
            className: "trigger",
            onClick: toggle
          })}
        </Header>
        <Content className="main-content">{children}</Content>
      </Layout>
    </Layout>
  );
}

export default Dashboard;
