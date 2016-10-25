﻿using System;
using System.Linq.Expressions;
using YB.Mall.Model;
using YB.Mall.Model.QueryModel;
using YB.Mall.Model.ViewModel;

namespace YB.Mall.Service
{
    public interface IMenuButtonService
    {
        jqGridPagerViewModel<MenuButtonInfo, dynamic> ButtonGrid(MenuButtonQueryModel query);
        MenuButtonInfo InitForm(Expression<Func<MenuButtonInfo, bool>> where);
        bool SubmitForm(MenuButtonInfo button, int? keyValue);
        bool Remove(Expression<Func<MenuButtonInfo, bool>> where);
    }
}