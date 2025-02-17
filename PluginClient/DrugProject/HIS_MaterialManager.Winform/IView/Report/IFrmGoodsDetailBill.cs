﻿using System.Data;
using EFWCoreLib.WinformFrame.Controller;

namespace HIS_MaterialManage.Winform.IView.Report
{
    /// <summary>
    /// 物资明细账查询
    /// </summary>
    public  interface IFrmGoodsDetailBill: IBaseView
    { 
        /// <summary>
        /// 绑定库房下拉框
        /// </summary>
        /// <param name="dtDept">科室数据</param>
        void BindDeptRoom(DataTable dtDept);

        /// <summary>
        /// 绑定药品信息ShowCard
        /// </summary>
        /// <param name="dt">药品信息</param>
        void BindMaterialInfoCard(DataTable dt);

        /// <summary>
        /// 绑定会计年
        /// </summary>
        /// <param name="dtYear">年</param>
        void BindYear(DataTable dtYear);

        /// <summary>
        /// 绑定会计月
        /// </summary>
        /// <param name="dtMonth">月</param>
        void BindMonth(DataTable dtMonth);

        /// <summary>
        /// 绑定汇总信息
        /// </summary>
        /// <param name="dt">汇总信息</param>
        void BindTotalInfo(DataTable dt);
    }
}
