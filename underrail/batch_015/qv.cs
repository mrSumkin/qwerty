using System;
using System.Collections.Generic;
using System.IO;
using Ouroboros.Core.Logging;

// Token: 0x020018FC RID: 6396
public static class qv
{
	// Token: 0x060087E9 RID: 34793 RVA: 0x00384DF8 File Offset: 0x00382FF8
	public static string b(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return string.Empty;
		}
		string[] array = A_0.Split(new string[]
		{
			"/"
		}, StringSplitOptions.RemoveEmptyEntries);
		string text = array[0];
		string text2 = (array.Length > 1) ? array[1] : null;
		if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
		{
			string text3 = aji.a(text, text2);
			if (!string.IsNullOrEmpty(text3))
			{
				return text3;
			}
			arz arz = qv.a(text);
			if (arz != null)
			{
				string empty = string.Empty;
				arz.a.TryGetValue(text2.ToLowerInvariant(), out empty);
				return empty;
			}
		}
		return string.Empty;
	}

	// Token: 0x060087EA RID: 34794 RVA: 0x00384EAC File Offset: 0x003830AC
	public static string a(string A_0, params object[] A_1)
	{
		string result = string.Empty;
		string text = qv.b(A_0);
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				result = string.Format(text, A_1);
			}
			catch (Exception ex)
			{
				result = "ОШИБКА: " + ex.Message;
			}
		}
		return result;
	}

	// Token: 0x060087EB RID: 34795 RVA: 0x00384F08 File Offset: 0x00383108
	public static void a()
	{
		qv.b.Clear();
		qv.c.Clear();
	}

	// Token: 0x060087EC RID: 34796 RVA: 0x00384F20 File Offset: 0x00383120
	private static arz a(string A_0)
	{
		if (A_0 != null)
		{
			arz arz;
			qv.b.TryGetValue(A_0, out arz);
			if (arz == null && !qv.c.Contains(A_0))
			{
				try
				{
					string text = Path.ChangeExtension(Path.Combine(Path.Combine(dr3.d().lf(), d5x.k), A_0), "k");
					if (!File.Exists(text))
					{
						qv.c.Add(A_0);
						return null;
					}
					arz = eoq.DeserializeFromBinaryFileCompressed<arz>(text, dds.a(), true);
					if (arz != null)
					{
						qv.b[A_0] = arz;
					}
					else
					{
						qv.c.Add(A_0);
					}
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "Failed to load knowledge item '{0}'", new object[]
					{
						A_0
					});
					qv.c.Add(A_0);
				}
				return arz;
			}
			return arz;
		}
		return null;
	}

	// Token: 0x060087ED RID: 34797 RVA: 0x0038500C File Offset: 0x0038320C
	public static arz a(string A_0, string A_1 = "::")
	{
		if (!File.Exists(A_0))
		{
			return null;
		}
		arz result;
		try
		{
			string[] array = File.ReadAllText(A_0).Split(new string[]
			{
				A_1
			}, StringSplitOptions.RemoveEmptyEntries);
			arz arz = new arz();
			foreach (string text in array)
			{
				int num = text.IndexOf("\r\n");
				string key = text.Substring(0, num).ToLowerInvariant();
				string value;
				if (text.Length > num + 2)
				{
					value = text.Substring(num + 2).TrimEnd(new char[]
					{
						' ',
						'\r',
						'\n'
					});
				}
				else
				{
					value = string.Empty;
				}
				arz.a[key] = value;
			}
			result = arz;
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x040035ED RID: 13805
	public const string a = "StaticEffects";

	// Token: 0x040035EE RID: 13806
	private static Dictionary<string, arz> b = new Dictionary<string, arz>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x040035EF RID: 13807
	private static HashSet<string> c = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
}
