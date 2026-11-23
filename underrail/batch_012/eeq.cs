using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x020005C2 RID: 1474
public sealed class eeq : ae1
{
	// Token: 0x06002730 RID: 10032 RVA: 0x000E3E50 File Offset: 0x000E2050
	public override string gr()
	{
		return "itemDefinitionPath";
	}

	// Token: 0x06002731 RID: 10033 RVA: 0x000E3E58 File Offset: 0x000E2058
	public override object gs(string A_0)
	{
		if (A_0 != null && A_0.StartsWith("!"))
		{
			return this.a(A_0.Substring(1));
		}
		return A_0;
	}

	// Token: 0x06002732 RID: 10034 RVA: 0x000E3E84 File Offset: 0x000E2084
	protected override List<object> gt()
	{
		List<object> list = new List<object>();
		string text = Path.Combine(bpo.GetServiceOrThrow<d67>().lf(), d5x.ai);
		foreach (string text2 in Directory.GetFiles(text, "*.item", 1))
		{
			try
			{
				string text3 = text2.Substring(text.Length, text2.Length - (text.Length + 5)).ToLowerInvariant().TrimStart(new char[]
				{
					'\\'
				});
				list.Add(text3);
				string text4 = "!" + Path.GetFileNameWithoutExtension(text3);
				if (!list.Contains(text4))
				{
					list.Add(text4);
				}
				else
				{
					int num = 0;
					string item;
					do
					{
						string str = text4;
						string str2 = "^";
						int num2;
						num = (num2 = num + 1);
						item = str + str2 + num2.ToString();
					}
					while (list.Contains(item));
					list.Add(item);
				}
			}
			catch
			{
			}
		}
		return list;
	}

	// Token: 0x06002733 RID: 10035 RVA: 0x000E3F90 File Offset: 0x000E2190
	public string a(string A_0)
	{
		if (A_0 != null)
		{
			string text = A_0;
			int num = 0;
			int num2 = A_0.IndexOf('^');
			if (num2 != -1)
			{
				text = A_0.Substring(0, num2);
				if (string.IsNullOrEmpty(text))
				{
					return null;
				}
				if (num2 < A_0.Length - 1)
				{
					int.TryParse(A_0.Substring(num2 + 1), out num);
				}
				else
				{
					num = 1;
				}
			}
			List<object> list = base.a();
			int num3 = 0;
			foreach (object obj in list)
			{
				string text2 = (string)obj;
				if (!text2.StartsWith("!") && text2.EndsWith("\\" + text, StringComparison.OrdinalIgnoreCase))
				{
					if (num3 == num)
					{
						return text2;
					}
					num3++;
				}
			}
		}
		return null;
	}
}
