using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x020005BA RID: 1466
public sealed class ri : ae1
{
	// Token: 0x06002713 RID: 10003 RVA: 0x000E36AC File Offset: 0x000E18AC
	public override string gr()
	{
		return "effectName";
	}

	// Token: 0x06002714 RID: 10004 RVA: 0x000E36B8 File Offset: 0x000E18B8
	protected override List<object> gt()
	{
		List<object> list = new List<object>();
		d6j serviceOrThrow = bpo.GetServiceOrThrow<d6j>();
		if (serviceOrThrow.dv().e() != null)
		{
			foreach (string text in serviceOrThrow.dv().e().Keys)
			{
				if (text.StartsWith("locale\\effects\\", StringComparison.OrdinalIgnoreCase))
				{
					string text2 = text.Substring("locale\\effects\\".Length);
					list.Add(text2);
					list.Add("!" + Path.GetFileNameWithoutExtension(text2));
				}
			}
			foreach (string text3 in Directory.GetFiles(serviceOrThrow.dv().j(), "*.upeb", 1))
			{
				try
				{
					string text4 = text3.Substring(serviceOrThrow.dv().j().Length, text3.Length - (serviceOrThrow.dv().j().Length + 5)).ToLowerInvariant().TrimStart(new char[]
					{
						'\\'
					});
					if (text4.StartsWith("locale\\effects\\", StringComparison.OrdinalIgnoreCase))
					{
						text4 = text4.Substring("locale\\effects\\".Length);
						list.Add(text4);
						list.Add("!" + Path.GetFileNameWithoutExtension(text4));
					}
				}
				catch
				{
				}
			}
		}
		return list;
	}

	// Token: 0x06002715 RID: 10005 RVA: 0x000E3854 File Offset: 0x000E1A54
	public string a(string A_0)
	{
		foreach (object obj in base.a())
		{
			string text = (string)obj;
			if (!text.StartsWith("!") && text.EndsWith("\\" + A_0, StringComparison.OrdinalIgnoreCase))
			{
				return text;
			}
		}
		return null;
	}
}
