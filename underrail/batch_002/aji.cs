using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Input;

// Token: 0x020018ED RID: 6381
public static class aji
{
	// Token: 0x06008782 RID: 34690 RVA: 0x0037FE80 File Offset: 0x0037E080
	public static void c(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			aji.a = null;
			b5u.b = null;
			aji.b();
			aji.c();
			return;
		}
		if (aji.a == null || !string.Equals(aji.a.a, A_0, StringComparison.OrdinalIgnoreCase))
		{
			aji.a = aji.b(A_0);
			b5u.b = new Func<Keys, bool, char>(aji.a);
			aji.b();
			aji.c();
		}
	}

	// Token: 0x06008783 RID: 34691 RVA: 0x0037FEF8 File Offset: 0x0037E0F8
	private static void c()
	{
		aji.d.Clear();
	}

	// Token: 0x06008784 RID: 34692 RVA: 0x0037FF08 File Offset: 0x0037E108
	private static char a(Keys A_0, bool A_1)
	{
		if (aji.a != null)
		{
			char[] array;
			if (aji.d.TryGetValue(A_0, out array))
			{
				if (array == null || array.Length == 0)
				{
					return '\0';
				}
				if (array.Length == 1 || !A_1)
				{
					return array[0];
				}
				if (array.Length == 2 && A_1)
				{
					return array[1];
				}
			}
			string text = aji.a("Keyboard", A_0.ToString());
			if (!string.IsNullOrEmpty(text))
			{
				array = new char[2];
				array[0] = text[0];
				if (text.Length > 1)
				{
					array[1] = text[1];
				}
				aji.d[A_0] = array;
			}
			else
			{
				aji.d[A_0] = new char[0];
			}
		}
		return '\0';
	}

	// Token: 0x06008785 RID: 34693 RVA: 0x0037FFD4 File Offset: 0x0037E1D4
	public static void b()
	{
		aji.b.Clear();
		aji.c.Clear();
	}

	// Token: 0x06008786 RID: 34694 RVA: 0x0037FFEC File Offset: 0x0037E1EC
	private static evo b(string A_0)
	{
		return new evo
		{
			a = A_0
		};
	}

	// Token: 0x06008787 RID: 34695 RVA: 0x00380000 File Offset: 0x0037E200
	public static string a(string A_0, string A_1)
	{
		if (aji.a == null)
		{
			return null;
		}
		arz arz = aji.a(A_0);
		if (arz == null)
		{
			return null;
		}
		string result;
		arz.a.TryGetValue(A_1.ToLowerInvariant(), out result);
		return result;
	}

	// Token: 0x06008788 RID: 34696 RVA: 0x00380040 File Offset: 0x0037E240
	private static arz a(string A_0)
	{
		if (aji.c.Contains(A_0))
		{
			return null;
		}
		arz arz;
		if (!aji.b.TryGetValue(A_0, out arz))
		{
			string path = dr3.d().lf();
			string format = "Localization\\{0}\\Knowledge\\{1}.txt";
			evo evo = aji.a;
			arz = qv.a(Path.Combine(path, string.Format(format, (evo != null) ? evo.a : null, A_0)), "::");
			if (arz == null)
			{
				aji.c.Add(A_0);
			}
			else
			{
				aji.b[A_0] = arz;
			}
		}
		return arz;
	}

	// Token: 0x06008789 RID: 34697 RVA: 0x003800D4 File Offset: 0x0037E2D4
	public static List<evo> a()
	{
		try
		{
			string text = Path.Combine(dr3.d().lf(), d5x.l);
			if (Directory.Exists(text))
			{
				List<evo> list = new List<evo>();
				string[] directories = Directory.GetDirectories(text);
				if (directories.Length != 0)
				{
					for (int i = 0; i < directories.Length; i++)
					{
						try
						{
							string text2 = directories[i];
							string text3 = Path.Combine(text2, "info.txt");
							evo evo = new evo();
							evo.a = Path.GetFileNameWithoutExtension(text2);
							evo.b = evo.a;
							if (File.Exists(text3))
							{
								string[] array = File.ReadAllLines(text3);
								if (array != null && array.Length != 0)
								{
									evo.b = (array[0] ?? "").Trim();
								}
							}
							list.Add(evo);
						}
						catch
						{
						}
					}
				}
				return list;
			}
		}
		catch
		{
		}
		return null;
	}

	// Token: 0x0600878A RID: 34698 RVA: 0x003801F0 File Offset: 0x0037E3F0
	public static void a(azm A_0, string A_1)
	{
		if (aji.a == null)
		{
			return;
		}
		if (A_0 == null || string.IsNullOrEmpty(A_1))
		{
			return;
		}
		d67 service = bpo.GetService<d67>();
		if (service == null)
		{
			return;
		}
		string text = service.lf();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string text2 = Path.Combine(text, "Localization");
		text2 = Path.Combine(text2, aji.a.a);
		text2 = Path.Combine(text2, "Dialogs");
		text2 = Path.Combine(text2, A_1);
		text2 = Path.ChangeExtension(text2, "txt");
		if (!File.Exists(text2))
		{
			return;
		}
		try
		{
			arz arz = qv.a(text2, "=>");
			if (arz != null)
			{
				HashSet<d55> a_ = new HashSet<d55>();
				aji.a(A_0.b(), arz, a_);
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600878B RID: 34699 RVA: 0x003802CC File Offset: 0x0037E4CC
	private static void a(d55 A_0, arz A_1, HashSet<d55> A_2)
	{
		if (A_2.Contains(A_0))
		{
			return;
		}
		A_2.Add(A_0);
		dzc dzc = A_0 as dzc;
		if (dzc != null)
		{
			if (dzc.d != 0)
			{
				string text;
				if (A_0 is ad7)
				{
					text = "q" + dzc.d.ToString();
				}
				else if (A_0 is atr)
				{
					text = "a" + dzc.d.ToString();
				}
				else
				{
					text = null;
				}
				string text2;
				if (!string.IsNullOrEmpty(text) && A_1.a.TryGetValue(text, out text2))
				{
					if (text2.EndsWith("<end>"))
					{
						dzc.b(text2.Substring(0, text2.Length - 5));
					}
					else
					{
						dzc.b(text2);
					}
				}
			}
			ad7 ad = A_0 as ad7;
			if (ad != null)
			{
				for (int i = 0; i < ad.PossibleAnswers.Count; i++)
				{
					aji.a(ad.PossibleAnswers[i], A_1, A_2);
				}
			}
		}
		for (int j = 0; j < A_0.PossibleNextSteps.Count; j++)
		{
			aji.a(A_0.PossibleNextSteps[j], A_1, A_2);
		}
	}

	// Token: 0x040034C8 RID: 13512
	public static evo a;

	// Token: 0x040034C9 RID: 13513
	private static Dictionary<string, arz> b = new Dictionary<string, arz>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x040034CA RID: 13514
	private static HashSet<string> c = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x040034CB RID: 13515
	private static Dictionary<Keys, char[]> d = new Dictionary<Keys, char[]>();
}
