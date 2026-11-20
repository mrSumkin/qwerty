using System;
using System.Text.RegularExpressions;
using Ouroboros.Core.Logging;

// Token: 0x0200013E RID: 318
public static class eb2
{
	// Token: 0x060007DA RID: 2010 RVA: 0x00021A28 File Offset: 0x0001FC28
	public static string a(bq8 A_0, bq8 A_1, string A_2)
	{
		if (string.IsNullOrEmpty(A_2))
		{
			return string.Empty;
		}
		Regex regex = new Regex("\\$\\(([^\\)]*)\\)");
		if (regex.IsMatch(A_2))
		{
			Match match = regex.Match(A_2);
			while (match.Success)
			{
				if (match.Groups.Count == 2)
				{
					string value = match.Groups[1].Value;
					string newValue = "[" + value + "]";
					if (!value.StartsWith("#"))
					{
						goto IL_E9;
					}
					if (value.Length > 1)
					{
						try
						{
							eb2.a(A_0, value.Substring(1), ref newValue);
							goto IL_14D;
						}
						catch (Exception ex)
						{
							cvq service = bpo.GetService<cvq>();
							if (service != null && service.n8() && service.n9(LogSeverity.Error, 115))
							{
								string a_ = string.Format("[Dialog Manager] - Failed to replace gender token {0}. Exception: {1}.", value, ex.ToString());
								service.n7(LogSeverity.Error, 115, a_);
							}
							goto IL_14D;
						}
						goto IL_E9;
					}
					IL_14D:
					A_2 = A_2.Replace(match.Groups[0].Value, newValue);
					goto IL_167;
					IL_E9:
					try
					{
						newValue = d8z.a(A_0, A_1, value).ToString();
					}
					catch (Exception ex2)
					{
						cvq service2 = bpo.GetService<cvq>();
						if (service2 != null && service2.n8() && service2.n9(LogSeverity.Error, 115))
						{
							string a_2 = string.Format("[Dialog Manager] - Failed to replace token {0}. Exception: {1}.", value, ex2.ToString());
							service2.n7(LogSeverity.Error, 115, a_2);
						}
					}
					goto IL_14D;
				}
				IL_167:
				match = regex.Match(A_2);
			}
		}
		return A_2;
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x00021BCC File Offset: 0x0001FDCC
	public static void a(bq8 A_0, string A_1, ref string A_2)
	{
		aun classPropertyValue = A_0.GetClassPropertyValue<aun>("GenderTokenResolver");
		if (classPropertyValue != null)
		{
			string[] array = A_1.Split(new string[]
			{
				"/"
			}, StringSplitOptions.None);
			if (array.Length == 2)
			{
				A_2 = classPropertyValue.ar6(array[0], array[1]);
			}
		}
	}
}
