﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace toIconCom.model {
	public class Lang {
		public static readonly Lang ins = new Lang();

		public string nowLang = "";
		Dictionary<string, Action> funLang = new Dictionary<string, Action>();

		public List<string> lstLang = new List<string>() {
			"自动", "",
			"English", "en-US",
			"简体中文", "zh-CN",
		};

		public Lang() {
			funLang[""] = setEn;
			funLang["en-US"] = setEn;
			funLang["zh-CN"] = setZhCn;

			setLang("");
		}

		public void setLang(string lang) {
			if (lang == nowLang) {
				return;
			}
			nowLang = lang;

			// auto language
			if (lang == "") {
				lang = Thread.CurrentThread.CurrentCulture.Name;
			}

			// lang not exist
			if (!funLang.ContainsKey(lang)) {
				lang = "";
			}

			funLang[lang]();

			lstLang[0] = langAuto;
		}

		private void setEn() {
			langAppName = "toIcon";
			langSetting = "Setting";
			langBpp = " Bpp";
			langExportMulti = "Export Multi";
			langDragImageHere = "Drag Image Here";
			langOk = "Ok";

			langStrPopWin1 = "File<";
			langStrPopWin2 = "> exist，sure to replace？";

			langReplace = "Replace";
			langReplaceAll = "Replace All";
			langJump = "Jump";
			langCancel = "Cancel";
			langRename = "Rename";
			langWhenFileExist = "File Exist:";
			langOutType = "Out Type";
			langAuto = "Auto";
			langAutoDesc = "Auto：ico to png, image to ico, orther to png";
			langMergeOutput = "Merge Output";
			langMerge = "Merge";
			langIcoValid = "Valid when the output format is ICO";
			langMoreSetting = "More";

			langRegFile = "Reg to File";
			langRegDir = "Reg to folder";
			langUnRegFile = "Unreg to File";
			langUnRegDir = "Unreg to folder";
			langLanguage = "Language";

			langHelpSrc = "multiple source file. file1 file2 ...";
			langHelpDst = "out file directory, output to source directory if is empty";
			langHelpType = "out file type\r\noptional: auto,ico,bmp,jpg,png. default is auto:\r\nout png if src is ico\r\nout ico if src is image\r\nout png if src is orther file";
			langHelpOperate = "operate when file exist\r\noptional: rename,jump,overwrite\r\ndefault is rename";
			langHelpBppSize = "size and bpp, multiple out split by ';', bpp can be ignore\r\nusage: [size1],[bpp1];[size2]...\r\ne.g. 48,32;24,16;64\r\ndefault is 48,32";
			langHelpMergeOutput = "merge output, Valid when the output format is ICO";
			langHelpVersion = "version";
			langHelpHelp = "help";
		}

		private void setZhCn() {
			langAppName = "toIcon";
			langSetting = "设置";
			langBpp = "位";
			langExportMulti = "导出多个";
			langDragImageHere = "拖拽图片到这里";
			langOk = "确定";

			langStrPopWin1 = "文件<";
			langStrPopWin2 = "> 已存在，确定替换？";

			langReplace = "替换";
			langReplaceAll = "替换所有";
			langJump = "跳过";
			langCancel = "取消";
			langRename = "重命名";
			langWhenFileExist = "文件存在时：";
			langOutType = "输出格式";
			langAuto = "自动";
			langAutoDesc = "自动：ico转png，图片转ico，其他转png";
			langMergeOutput = "合并输出";
			langMerge = "合并";
			langIcoValid = "输出格式为ico时有效";
			langMoreSetting = "更多设置";

			langRegFile = "注册到文件";
			langRegDir = "注册到目录背景";
			langUnRegFile = "取消注册到文件";
			langUnRegDir = "取消注册到目录背景";
			langLanguage = "语言";

			langHelpSrc = "源文件或目录路径。file1 file2 ...";
			langHelpDst = "输出目录，如果为空则输出到源文件目录";
			langHelpType = "输出文件格式\r\n可选项：auto,ico,bmp,jpg,png。默认为auto：\r\n当源文件为ico时输出png\r\n当源文件为图片时输出ico\r\n当源文件为其他文件时输出png";
			langHelpOperate = "输出文件存在时的操作\r\n可选项：rename,jump,overwrite\r\n为默认值rename";
			langHelpBppSize = "尺寸和bpp，多个输出用';'分割，bpp可忽略\r\n用法：[size1],[bpp1?];[size2]...\r\n例： 48,32;24,16;64\r\n默认为 48,32";
			langHelpMergeOutput = "合并输出，输出格式为ico时有效";
			langHelpVersion = "版本号";
			langHelpHelp = "帮助";

		}

		public static bool IsSimpleChinese() {
			return Thread.CurrentThread.CurrentCulture.Name == "zh-CN";
		}

		public string langAppName = "toIcon";
		public string langSetting = "设置";
		public string langBpp = "位";
		public string langExportMulti = "导出多个";
		public string langDragImageHere = "拖拽图片到这里";
		public string langOk = "确定";

		public string langStrPopWin1 = "文件<";
		public string langStrPopWin2 = "> 已存在，确定替换？";

		public string langReplace = "替换";
		public string langReplaceAll = "替换所有";
		public string langJump = "跳过";
		public string langCancel = "取消";
		public string langRename = "重命名";
		public string langWhenFileExist = "文件存在时：";
		public string langOutType = "输出格式";
		public string langAuto = "自动";
		public string langAutoDesc = "自动：ico转png，图片转ico，其他转png";
		public string langMergeOutput = "合并输出";
		public string langMerge = "合并";
		public string langIcoValid = "输出格式为ico时有效";
		public string langMoreSetting = "更多设置";

		public string langRegFile = "注册到文件";
		public string langRegDir = "注册到目录背景";
		public string langUnRegFile = "取消注册到文件";
		public string langUnRegDir = "取消注册到目录背景";
		public string langLanguage = "语言";

		public string langHelpSrc = "源文件或目录路径。file1 file2 ...";
		public string langHelpDst = "输出目录，如果为空则输出到源文件目录";
		public string langHelpType = "输出文件格式\r\n可选项：auto,ico,bmp,jpg,png。默认为auto：\r\n当源文件为ico时输出png\r\n当源文件为图片时输出ico\r\n当源文件为其他文件时输出png";
		public string langHelpOperate = "输出文件存在时的操作\r\n可选项：rename,jump,overwrite\r\n为默认值rename";
		public string langHelpBppSize = "尺寸和bpp，多个输出用';'分割，bpp可忽略\r\n用法：[size1],[bpp1?];[size2]...\r\n例： 48,32;24,16;64\r\n默认为 48,32";
		public string langHelpMergeOutput = "合并输出，输出格式为ico时有效";
		public string langHelpVersion = "版本号";
		public string langHelpHelp = "帮助";
	}
}
