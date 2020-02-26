import React, { useState } from "react";

import { Layout, Menu, Icon } from "antd";
import { Link } from "@reach/router";
import "./index.css";
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
            <Icon type="home" theme="filled" />
            <span>Inicio</span>
            <Link to="/" />
          </Menu.Item>
          <SubMenu
            key="cars"
            title={
              <span>
                <Icon type="car" theme="filled" />
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
          <Icon
            className="trigger"
            type={collapsed ? "menu-unfold" : "menu-fold"}
            onClick={toggle}
          />
        </Header>
        <Content
          style={{
            margin: "24px 16px",
            padding: 24,
            background: "#fff",
            minHeight: 280
          }}
        >
          {children}
        </Content>
      </Layout>
    </Layout>
  );
}

export default Dashboard;
