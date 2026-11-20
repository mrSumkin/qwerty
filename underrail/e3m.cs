using System;

// Token: 0x02000687 RID: 1671
public static class e3m
{
	// Token: 0x06002AE8 RID: 10984 RVA: 0x000F579C File Offset: 0x000F399C
	public static string a()
	{
		string result = null;
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqw() != null && service.aqw().y8().StartsWith("xpbl_", StringComparison.OrdinalIgnoreCase) && (service.aqw().y8().Length == 7 || service.aqw().y8().Length == 8))
		{
			string text = service.aqw().y8().Substring(5, 1);
			int num;
			if (int.TryParse(service.aqw().y8().Substring(6, service.aqw().y8().Length - 6), out num))
			{
				result = text.ToUpperInvariant() + num.ToString();
			}
		}
		return result;
	}
}
