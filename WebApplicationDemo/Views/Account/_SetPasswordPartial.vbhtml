﻿@ModelType ManageUserViewModel

<p class="text-info">
    你没有此站点的本地用户名/密码。请添加一个本地
    帐户，以便你可以在没有外部登录名的情况下登录。
</p>

@Using Html.BeginForm("Manage", "Account", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
    @Html.AntiForgeryToken()

    @<text>
        <h4>创建本地登录名</h4>
        <hr />
         @Html.ValidationSummary("", New With {.class = "text-danger"})
         <div class="form-group">
            @Html.LabelFor(Function(m) m.NewPassword, New With {.class = "col-md-2 control-label"})
            <div class="controls">
                @Html.PasswordFor(Function(m) m.NewPassword, New With {.class = "form-control"})
            </div>
        </div>
        <div class="form-group">
            @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "col-md-2 control-label"})
            <div class="controls">
                @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control"})
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="设置密码" class="btn btn-default" />
            </div>
        </div>
    </text>
End Using
