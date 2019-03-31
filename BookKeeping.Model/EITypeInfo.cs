/**  版本信息模板在安装目录下，可自行修改。
* EITypeInfo.cs
*
* 功 能： N/A
* 类 名： EITypeInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/3/31 18:41:07   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace BookKeeping.Model
{
	/// <summary>
	/// EITypeInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EITypeInfo
	{
		public EITypeInfo()
		{}
		#region Model
		private int _eiid;
		private string _eititle;
		/// <summary>
		/// 
		/// </summary>
		public int EIId
		{
			set{ _eiid=value;}
			get{return _eiid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EItitle
		{
			set{ _eititle=value;}
			get{return _eititle;}
		}
		#endregion Model

	}
}

