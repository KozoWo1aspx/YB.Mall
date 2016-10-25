﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YB.Mall.Extend.Helper;
using YB.Mall.Model;
using YB.Mall.Model.QueryModel;
using YB.Mall.Model.ViewModel;
using YB.Mall.Service;
using YB.Mall.Web.Controllers;
namespace YB.Mall.Web.Areas.SystemManage.Controllers
{
    public class RoleController : BaseController
    {
        private readonly IRoleService roleService;
        public RoleController(IRoleService _roleService)
        {
            this.roleService = _roleService;
        }
        [HttpGet]
        public JsonResult RoleGrid(RoleQueryModel query)
        {
            var grid = roleService.RoleGrid(query);
            return Json(grid, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult InitTree(MenuQueryModel query)
        {
            return Json(null, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult InitForm(int? keyValue)
        {
            return Json(roleService.InitForm(s => s.RoleId == keyValue), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult InitRoleType()
        {
            return Json(EnumHelper.ToDescriptionDictionary<RoleType>().Select(s => new TreeSelectModel
            {
                id = s.Value,
                text = s.Key
            }), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult InitOrganizeType()
        {
            return Json(EnumHelper.ToDescriptionDictionary<OrganizeType>().Select(s => new TreeSelectModel
            {
                id = s.Value,
                text =  s.Key
            }), JsonRequestBehavior.AllowGet);
        }
    }
}