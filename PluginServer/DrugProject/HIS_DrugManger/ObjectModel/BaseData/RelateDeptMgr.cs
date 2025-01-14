﻿using System;
using System.Collections.Generic;
using System.Data;
using EFWCoreLib.CoreFrame.Business;
using HIS_DrugManger.Dao;
using HIS_Entity.SqlAly;

namespace HIS_DrugManger.ObjectModel.BaseData
{
    /// <summary>
    /// 往来科室维护类
    /// </summary>
    public class RelateDeptMgr : AbstractObjectModel
    {
        /// <summary>
        /// 取得库房数据
        /// </summary>
        /// <param name="menuTypeFlag">菜单类型0药房往来科室维护，1药库往来科室维护</param>
        /// <returns>库房数据集</returns>
        public DataTable GetStoreRoomData(int menuTypeFlag)
        {
            DataTable dt = NewDao<IDGDao>().GetStoreRoomData(menuTypeFlag);
            return dt;
        }

        /// <summary>
        /// 根据科室Id获取往来科室数据
        /// </summary>
        /// <param name="andWhere">and查询条件</param>
        /// <param name="orWhere">or查询条件</param>
        /// <returns>往来科室数据</returns>
        public DataTable GetRelateDeptData(List<Tuple<string, string, SqlOperator>> andWhere, List<Tuple<string, string, SqlOperator>> orWhere)
        {
            DataTable dt = NewDao<IDGDao>().GetRelateDeptData(andWhere, orWhere);
            return dt;
        }

        /// <summary>
        /// 根据科室Id获取往来科室数据
        /// </summary>
        /// <param name="deptId">库房Id</param>
        /// <returns>往来科室数据集</returns>
        public DataTable GetRelateDeptData(int deptId)
        {
            DataTable dt = NewDao<IDGDao>().GetRelateDeptData(deptId);
            return dt;
        }

        /// <summary>
        /// 批量保存往来科室
        /// </summary>
        /// <param name="dtSave">往来科室数据集</param>
        /// <param name="empId">操作员Id</param>
        /// <returns>小于0失败</returns>
        public int BatchSaveRelateDept(DataTable dtSave, int empId)
        {
            int ret = 0;
            ret = NewDao<IDGDao>().BatchSaveRelateDept(dtSave, empId);
            return ret;
        }

        /// <summary>
        /// 删除往来科室
        /// </summary>
        /// <param name="drugDeptID">药剂科室Id</param>
        /// <param name="relationDeptID">往来科室Id</param>
        /// <returns>小于0失败</returns>
        public int DeleteRelateDept(int drugDeptID, int relationDeptID)
        {
            int ret = 0;
            ret = NewDao<IDGDao>().DeleteRelateDept(drugDeptID, relationDeptID);
            return ret;
        }
    }
}
