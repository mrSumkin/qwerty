using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x020005C6 RID: 1478
public sealed class o9 : ae1
{
	// Token: 0x06002740 RID: 10048 RVA: 0x000E4224 File Offset: 0x000E2424
	public override string gr()
	{
		return "entityDefinitionPath";
	}

	// Token: 0x06002741 RID: 10049 RVA: 0x000E422C File Offset: 0x000E242C
	public override object gs(string A_0)
	{
		return A_0;
	}

	// Token: 0x06002742 RID: 10050 RVA: 0x000E4234 File Offset: 0x000E2434
	protected override List<object> gt()
	{
		List<object> list = new List<object>();
		d6j serviceOrThrow = bpo.GetServiceOrThrow<d6j>();
		if (serviceOrThrow.dv().e() != null)
		{
			foreach (string text in serviceOrThrow.dv().e().Keys)
			{
				string text2;
				if (text.StartsWith("locale\\", StringComparison.OrdinalIgnoreCase))
				{
					text2 = text.Substring("locale\\".Length);
				}
				else
				{
					text2 = text;
				}
				list.Add(text2);
				list.Add("!" + Path.GetFileNameWithoutExtension(text2));
			}
			foreach (string text3 in Directory.GetFiles(serviceOrThrow.dv().j(), "*.upeb", 1))
			{
				try
				{
					string text4 = text3.Substring(serviceOrThrow.dv().j().Length, text3.Length - (serviceOrThrow.dv().j().Length + 5)).ToLowerInvariant().TrimStart(new char[]
					{
						'\\'
					});
					if (text4.StartsWith("locale\\", StringComparison.OrdinalIgnoreCase))
					{
						text4 = text4.Substring("locale\\".Length);
					}
					list.Add(text4);
					list.Add("!" + Path.GetFileNameWithoutExtension(text4));
				}
				catch
				{
				}
			}
		}
		return list;
	}

	// Token: 0x06002743 RID: 10051 RVA: 0x000E43D8 File Offset: 0x000E25D8
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
