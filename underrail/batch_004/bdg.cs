using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Common.Settings;

// Token: 0x020006C8 RID: 1736
public static class bdg
{
	// Token: 0x06002CCC RID: 11468 RVA: 0x000FF838 File Offset: 0x000FDA38
	public static d22 g()
	{
		return new d22(bdg.f(), Color.LightGray);
	}

	// Token: 0x06002CCD RID: 11469 RVA: 0x000FF84C File Offset: 0x000FDA4C
	public static string f()
	{
		wj wj = wj.a();
		if (wj.d != UiSize.Classic)
		{
			return wj.dh;
		}
		return egg.ad;
	}

	// Token: 0x06002CCE RID: 11470 RVA: 0x000FF878 File Offset: 0x000FDA78
	public static List<ce8> e()
	{
		List<ce8> list = new List<ce8>();
		foreach (ce8 item in Enumerable.OrderBy<ce8, string>(bdg.b.Values, new Func<ce8, string>(bdg.a.a.a)))
		{
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06002CCF RID: 11471 RVA: 0x000FF90C File Offset: 0x000FDB0C
	public static ecs d()
	{
		return bdg.h;
	}

	// Token: 0x06002CD0 RID: 11472 RVA: 0x000FF914 File Offset: 0x000FDB14
	public static void a(string A_0, params object[] A_1)
	{
		List<KeyValuePair<string[], string>> list = zy.a(string.Format(A_0, A_1));
		dl6 dl = new dl6();
		foreach (KeyValuePair<string[], string> keyValuePair in list)
		{
			if (!string.IsNullOrEmpty(keyValuePair.Value))
			{
				d22 d = null;
				if (keyValuePair.Key != null && keyValuePair.Key.Length != 0)
				{
					for (int i = keyValuePair.Key.Length - 1; i >= 0; i--)
					{
						string key = keyValuePair.Key[i];
						if (bdg.k.TryGetValue(key, out d))
						{
							break;
						}
					}
				}
				if (d == null)
				{
					d = bdg.g();
				}
				d.a = bdg.f();
				dl.a.Add(new bph(d, keyValuePair.Value, null));
			}
		}
		bdg.g.a.Add(dl);
		if (bdg.g.a.Count > bdg.f)
		{
			bdg.g.a.RemoveRange(0, bdg.g.a.Count - bdg.f);
		}
		esj esj = bpo.GetServiceOrThrow<bef>().k4();
		if (bdg.i != null)
		{
			int? num = bdg.i;
			int num2 = esj.c - 2 * bdg.j;
			if (num.GetValueOrDefault() == num2 & num != null)
			{
				ecs ecs = Enumerable.First<ecs>(new ecs
				{
					a = 
					{
						eoq.Clone<dl6>(dl)
					}
				}.a(bdg.i.Value, int.MaxValue));
				bdg.h.a.AddRange(ecs.a);
				if (bdg.h.a.Count > bdg.f)
				{
					bdg.h.a.RemoveRange(0, bdg.h.a.Count - bdg.f);
				}
				return;
			}
		}
		bdg.i = new int?(esj.c - 2 * bdg.j);
		bdg.h = Enumerable.First<ecs>(eoq.Clone<ecs>(bdg.g).a(bdg.i.Value, int.MaxValue));
	}

	// Token: 0x06002CD1 RID: 11473 RVA: 0x000FFB78 File Offset: 0x000FDD78
	public static void c()
	{
		if (!bdg.a)
		{
			bdg.a = true;
			bdg.k = new Dictionary<string, d22>();
			bdg.k["val"] = new d22("f", Color.Cyan);
			bdg.k["value"] = bdg.k["val"];
			bdg.k["prop"] = new d22("f", Color.Green);
			bdg.k["error"] = new d22("f", Color.Red);
			bdg.k["param"] = new d22("f", Color.Pink);
			bdg.k["cmd"] = new d22("f", Color.Yellow);
			bdg.k["war"] = new d22("f", Color.Orange);
			bdg.k["warning"] = bdg.k["war"];
			bdg.b = new Dictionary<string, ce8>();
			bdg.c = new Dictionary<Type, ae1>();
			bdg.b();
			bdg.a();
		}
	}

	// Token: 0x06002CD2 RID: 11474 RVA: 0x000FFCB0 File Offset: 0x000FDEB0
	public static void c(string A_0)
	{
		bdg.d.Insert(0, A_0);
		if (bdg.d.Count > bdg.e)
		{
			bdg.d.RemoveRange(bdg.e, bdg.d.Count - bdg.e);
		}
		if (!string.IsNullOrWhiteSpace(A_0))
		{
			List<string> list = bdg.a(A_0);
			ce8 ce;
			if (list.Count > 0 && bdg.b.TryGetValue(list[0].ToLowerInvariant(), out ce))
			{
				List<object> list2 = new List<object>();
				int i = 0;
				while (i < ce.Args.Count)
				{
					ayk ayk = ce.Args[i];
					if (ayk.a != null)
					{
						if (list.Count > i + 1)
						{
							string a_ = list[i + 1];
							ae1 ae;
							if (bdg.c.TryGetValue(ayk.a, out ae))
							{
								try
								{
									object item = ae.gs(a_);
									list2.Add(item);
									goto IL_199;
								}
								catch (Exception ex)
								{
									bdg.a("[error]Error occurred while parsing arg [val]'{0}'[/val]: {1}", new object[]
									{
										ayk.c ?? ae.gr(),
										ex.Message
									});
									return;
								}
							}
							bdg.a("[error]Argument definition not found [val]'{0}'", new object[]
							{
								ayk.a.Name
							});
							return;
						}
						if (!ayk.b)
						{
							ce.b();
							return;
						}
						IL_199:
						i++;
					}
					else
					{
						if (!string.IsNullOrEmpty(ayk.c))
						{
							bdg.a("[error]Argument type not set for [val]'{0}'", new object[]
							{
								ayk.c
							});
							return;
						}
						bdg.a("[error]Argument type not set'", new object[0]);
						return;
					}
				}
				lu lu = null;
				try
				{
					lu = ce.c7(list2);
				}
				catch (Exception ex2)
				{
					bdg.a("[error]Error occurred while executing command: {0}", new object[]
					{
						ex2.Message
					});
					ce.b();
					return;
				}
				if (lu != null)
				{
					if (lu is rl)
					{
						bdg.a("Select tile...", new object[0]);
					}
					else if (lu is d0m)
					{
						bdg.a("Select entity...", new object[0]);
					}
					bi3 service = bpo.GetService<bi3>();
					if (service != null)
					{
						if (service.aij() != null)
						{
							service.aim();
						}
						bj7 a_2 = new bj7(lu, ce, list2);
						service.ail(a_2);
					}
				}
			}
		}
	}

	// Token: 0x06002CD3 RID: 11475 RVA: 0x000FFF3C File Offset: 0x000FE13C
	public static T GetArgument<T>() where T : ae1
	{
		return bdg.a(typeof(T)) as T;
	}

	// Token: 0x06002CD4 RID: 11476 RVA: 0x000FFF58 File Offset: 0x000FE158
	public static ae1 a(Type A_0)
	{
		ae1 result;
		bdg.c.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x06002CD5 RID: 11477 RVA: 0x000FFF74 File Offset: 0x000FE174
	public static string b(string A_0)
	{
		List<string> list = bdg.a(A_0, 1, true);
		if (list != null)
		{
			return Enumerable.FirstOrDefault<string>(list);
		}
		return null;
	}

	// Token: 0x06002CD6 RID: 11478 RVA: 0x000FFF98 File Offset: 0x000FE198
	public static List<string> a(string A_0, int A_1 = 1, bool A_2 = true)
	{
		if (string.IsNullOrWhiteSpace(A_0))
		{
			return null;
		}
		bool flag;
		List<string> list = bdg.a(A_0, out flag);
		int num = Math.Max(0, list.Count - 1);
		if (list.Count > 0 && A_0.EndsWith(" ") && !flag)
		{
			num++;
		}
		if (num == 0)
		{
			string a_ = (list.Count > 0) ? list[0] : "";
			return bdg.a(bdg.b.Keys, a_, A_1, A_2);
		}
		ce8 ce;
		if (list.Count > 0 && bdg.b.TryGetValue(list[0].ToLowerInvariant(), out ce) && ce.Args.Count > num - 1)
		{
			ayk ayk = ce.Args[num - 1];
			ae1 ae;
			if (ayk.a != null && bdg.c.TryGetValue(ayk.a, out ae))
			{
				return bdg.a(ae.a(), (list.Count > num) ? list[num] : "", A_1, A_2);
			}
		}
		return null;
	}

	// Token: 0x06002CD7 RID: 11479 RVA: 0x001000CC File Offset: 0x000FE2CC
	private static List<string> a(IEnumerable A_0, string A_1, int A_2 = 1, bool A_3 = true)
	{
		SortedList<string, string> sortedList = new SortedList<string, string>();
		if (A_0 != null)
		{
			foreach (object obj in A_0)
			{
				if (obj != null)
				{
					string text = obj.ToString();
					if ((A_1 == "" || text.ToLowerInvariant().StartsWith(A_1.ToLowerInvariant())) && !sortedList.ContainsKey(text))
					{
						sortedList.Add(text, text);
					}
				}
			}
		}
		int num = 0;
		List<string> list = new List<string>();
		foreach (string text2 in sortedList.Keys)
		{
			if (A_3)
			{
				list.Add(text2.Substring(A_1.Length));
			}
			else
			{
				list.Add(text2);
			}
			if (++num >= A_2)
			{
				break;
			}
		}
		return list;
	}

	// Token: 0x06002CD8 RID: 11480 RVA: 0x00100200 File Offset: 0x000FE400
	private static List<string> a(string A_0)
	{
		bool flag;
		return bdg.a(A_0, out flag);
	}

	// Token: 0x06002CD9 RID: 11481 RVA: 0x00100218 File Offset: 0x000FE418
	private static List<string> a(string A_0, out bool A_1)
	{
		A_1 = false;
		if (!string.IsNullOrWhiteSpace(A_0))
		{
			List<string> list = new List<string>();
			string text = A_0.TrimStart(new char[]
			{
				' '
			});
			while (!string.IsNullOrWhiteSpace(text))
			{
				int num = text.IndexOf(' ');
				int num2 = text.IndexOf('"');
				if (num2 != -1 && (num == -1 || num2 < num))
				{
					int num3 = text.IndexOf('"', num2 + 1);
					if (num3 == -1)
					{
						if (num2 < text.Length - 1)
						{
							string item = text.Substring(num2 + 1);
							list.Add(item);
						}
						else
						{
							list.Add("");
						}
						A_1 = true;
						text = null;
					}
					else
					{
						if (num3 - num2 > 1)
						{
							string item2 = text.Substring(num2 + 1, num3 - num2 - 1);
							list.Add(item2);
						}
						else
						{
							list.Add("");
						}
						if (num3 == text.Length - 1)
						{
							text = null;
						}
						else
						{
							text = text.Substring(num3 + 1);
						}
					}
				}
				else
				{
					if (num == -1)
					{
						list.Add(text);
						break;
					}
					string text2 = text.Substring(0, num);
					if (!string.IsNullOrEmpty(text2))
					{
						list.Add(text2);
					}
					text = text.Substring(num).TrimStart(new char[]
					{
						' '
					});
				}
			}
			return list;
		}
		return new List<string>();
	}

	// Token: 0x06002CDA RID: 11482 RVA: 0x00100380 File Offset: 0x000FE580
	private static void b()
	{
		foreach (Type type in bpo.GetServiceOrThrow<ei2>().av2(new Func<Type, bool>(bdg.a.a.b)))
		{
			try
			{
				if (type.IsClass && !type.IsAbstract)
				{
					if (type.GetConstructor(Type.EmptyTypes) != null)
					{
						ce8 ce = (ce8)Activator.CreateInstance(type);
						if (ce.Commands != null && ce.Commands.Length != 0)
						{
							foreach (string text in ce.Commands)
							{
								if (!string.IsNullOrEmpty(text))
								{
									if (!bdg.b.ContainsKey(text.ToLowerInvariant()))
									{
										bdg.b[text.ToLowerInvariant()] = ce;
									}
									else
									{
										dux.b(LogSeverity.Error, "ConsoleManager: Duplicate command string '{0}' found when processing command '{1}'.", new object[]
										{
											text,
											type.AssemblyQualifiedName
										});
									}
								}
								else
								{
									dux.b(LogSeverity.Error, "ConsoleManager: Console command '{0}' has empty command string.", new object[]
									{
										type.AssemblyQualifiedName
									});
								}
							}
						}
						else
						{
							dux.b(LogSeverity.Error, "ConsoleManager: Console command '{0}' had no command strings.", new object[]
							{
								type.AssemblyQualifiedName
							});
						}
					}
					else
					{
						dux.b(LogSeverity.Error, "ConsoleManager: Failed to instantiate console command '{0}'. Default constructor not found.", new object[]
						{
							type.AssemblyQualifiedName
						});
					}
				}
			}
			catch (Exception a_)
			{
				dux.a(LogSeverity.Error, a_, "ConsoleManager: Failed to instantiate console command.", new object[0]);
			}
		}
	}

	// Token: 0x06002CDB RID: 11483 RVA: 0x0010056C File Offset: 0x000FE76C
	private static void a()
	{
		foreach (Type type in bpo.GetServiceOrThrow<ei2>().av2(new Func<Type, bool>(bdg.a.a.a)))
		{
			try
			{
				if (type.IsClass && !type.IsAbstract)
				{
					if (type.GetConstructor(Type.EmptyTypes) != null)
					{
						ae1 value = (ae1)Activator.CreateInstance(type);
						bdg.c[type] = value;
					}
					else
					{
						dux.b(LogSeverity.Error, "ConsoleManager: Failed to instantiate console arg '{0}'. Default constructor not found.", new object[]
						{
							type.AssemblyQualifiedName
						});
					}
				}
			}
			catch (Exception a_)
			{
				dux.a(LogSeverity.Error, a_, "ConsoleManager: Failed to instantiate console arg.", new object[0]);
			}
		}
	}

	// Token: 0x04001975 RID: 6517
	private static bool a;

	// Token: 0x04001976 RID: 6518
	private static Dictionary<string, ce8> b;

	// Token: 0x04001977 RID: 6519
	private static Dictionary<Type, ae1> c;

	// Token: 0x04001978 RID: 6520
	public static List<string> d = new List<string>();

	// Token: 0x04001979 RID: 6521
	public static readonly int e = 20;

	// Token: 0x0400197A RID: 6522
	private static readonly int f = 50;

	// Token: 0x0400197B RID: 6523
	private static ecs g = new ecs();

	// Token: 0x0400197C RID: 6524
	private static ecs h = new ecs();

	// Token: 0x0400197D RID: 6525
	private static int? i;

	// Token: 0x0400197E RID: 6526
	public static readonly int j = 10;

	// Token: 0x0400197F RID: 6527
	private static Dictionary<string, d22> k;

	// Token: 0x020006C9 RID: 1737
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06002CDF RID: 11487 RVA: 0x001006C0 File Offset: 0x000FE8C0
		internal string a(ce8 A_0)
		{
			return Enumerable.FirstOrDefault<string>(A_0.Commands);
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x001006D0 File Offset: 0x000FE8D0
		internal bool b(Type A_0)
		{
			return typeof(ce8).IsAssignableFrom(A_0);
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x001006E4 File Offset: 0x000FE8E4
		internal bool a(Type A_0)
		{
			return typeof(ae1).IsAssignableFrom(A_0);
		}

		// Token: 0x04001980 RID: 6528
		public static readonly bdg.a a = new bdg.a();

		// Token: 0x04001981 RID: 6529
		public static Func<ce8, string> b;

		// Token: 0x04001982 RID: 6530
		public static Func<Type, bool> c;

		// Token: 0x04001983 RID: 6531
		public static Func<Type, bool> d;
	}
}
