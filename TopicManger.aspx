﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TopicManger.aspx.cs" Inherits="TopicManger" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="./backstage/lib/layui-v2.5.4/css/layui.css" media="all" />
    <link rel="stylesheet" href="./backstage/css/public.css" media="all" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="layuimini-container">
            <div class="layuimini-main">
                <fieldset class="layui-elem-field layuimini-search">
                    <legend>搜索信息</legend>
                    <div class="layui-form-item">
                        <div class="layui-inline">
                            <label class="layui-form-label">发帖人</label>
                            <div class="layui-input-inline">
                                <asp:TextBox type="text" ID="Topicmangeruser" class="layui-input" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="layui-inline">
                            <label class="layui-form-label">板块名称</label>
                            <div class="layui-input-inline">
                                <asp:TextBox type="text" ID="Topicsection" class="layui-input" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="layui-inline">
                            <label class="layui-form-label">帖子标题</label>
                            <div class="layui-input-inline">
                                <asp:TextBox type="text" ID="TopicName" class="layui-input" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="layui-form-item">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <div class="layui-inline">
                                <asp:Button class="layui-btn " Text="搜索" runat="server" ID="searchbtn" OnClick="searchbtn_Click"></asp:Button>
                                <a class="layui-btn layui-btn-normal" href="TopicAdd.aspx">新增</a>
                            </div>
                    </div>
                </fieldset>
                <div style="margin: 10px 10px 10px 10px">
                    <table class="layui-table">
                        <colgroup>
                            <col width="100">
                            <col width="200">
                            <col width="200">
                            <col width="100">
                            <col width="100">
                            <col width="100">
                            <col width="200">
                            <col width="150">
                        </colgroup>
                        <thead>
                            <tr>
                                <th>发帖人</th>
                                <th>所属板块</th>
                                <th>帖子标题</th>
                                <th>浏览次数</th>
                                <th>回复次数</th>
                                <th>是否可见</th>
                                <th>创建时间</th>
                                <th>操作</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("Uname")%></td>
                                        <td><%#Eval("Sname")%></td>
                                        <td><%#Eval("Ttiele")%></td>
                                        <td><%#Eval("BrowseCount")%></td>
                                        <td><%#Eval("ReplyCount")%></td>
                                        <td><%#Eval("IsClose")%></td>
                                        <td><%#Eval("Ttime")%></td>
                                        <td>
                                            <div class="layui-table-cell">
                                                <a class="layui-btn layui-btn-xs layui-btn-normal" href="Topicedit.aspx?Topicid=<%#Eval("Tid")%>">编辑</a>

                                                <asp:Button CssClass="layui-btn layui-btn-xs layui-btn-danger" runat="server" CommandName="delTopic" OnClientClick="return confirm('删除改帖子吗?')" CommandArgument='<%#Eval("Tid")%>' ID="delTopic" Text="删除" />
                                            </div>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
