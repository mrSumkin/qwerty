using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Rules;

// Token: 0x020006B0 RID: 1712
public static class a4i
{
	// Token: 0x06002C63 RID: 11363 RVA: 0x000FDED4 File Offset: 0x000FC0D4
	public static void d()
	{
		if (!a4i.a)
		{
			a4i.a = true;
			a4i.b = new Dictionary<string, b58>();
			a4i.c = new Dictionary<string, e1j>();
			a4i.d = new Dictionary<string, vl>();
			a4i.c();
			a4i.b();
			a4i.a();
		}
	}

	// Token: 0x06002C64 RID: 11364 RVA: 0x000FDF14 File Offset: 0x000FC114
	public static void a(cyt A_0, bool A_1)
	{
		a4i.d();
		if (A_0.aj == null)
		{
			A_0.aj = new Random(A_0.l() / 2 + "fragmentRandomization".GetHashCode());
		}
		List<b58> list = new List<b58>();
		using (Dictionary<string, b58>.ValueCollection.Enumerator enumerator = a4i.b.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				b58 b = enumerator.Current;
				int num = Math.Max(1, b.k());
				for (int i = 0; i < num; i++)
				{
					list.Add(b);
				}
			}
			goto IL_28D;
		}
		IL_94:
		int num2 = A_0.aj.Next(list.Count);
		b58 b2 = list[num2];
		if (b2.k() < 2)
		{
			list.RemoveAt(num2);
		}
		else
		{
			int num3 = 1;
			bool flag = num2 < list.Count - 1;
			bool flag2 = num2 > 0;
			int index = num2;
			int num4 = 1;
			for (;;)
			{
				if (flag2)
				{
					if (num2 - num3 < 0 && list[num2 - num3] == b2)
					{
						index = num2 - num3;
						num4++;
					}
					else
					{
						flag2 = false;
					}
				}
				if (flag)
				{
					if (num2 + num3 >= list.Count && list[num2 + num3] == b2)
					{
						num4++;
					}
					else
					{
						flag = false;
					}
				}
				if (!flag2 && !flag)
				{
					break;
				}
				num3++;
			}
			for (int j = 0; j < num4; j++)
			{
				list.RemoveAt(index);
			}
		}
		if (!A_0.ah.Contains(b2.m()))
		{
			A_0.ah.Add(b2.m());
			if ((!b2.i() || A_1) && (string.IsNullOrWhiteSpace(b2.l()) || dk2.b(b2.l())) && b2.af0(A_0))
			{
				bool flag3 = false;
				if (b2.j().Count > 0)
				{
					foreach (string a_ in b2.j())
					{
						alg alg = A_0.a(a_, false);
						if (alg != null && alg.a)
						{
							flag3 = true;
							break;
						}
					}
				}
				if (!flag3 && a4i.a(A_0, b2.q()))
				{
					b2.afz(A_0);
				}
			}
		}
		IL_28D:
		if (list.Count <= 0)
		{
			return;
		}
		goto IL_94;
	}

	// Token: 0x06002C65 RID: 11365 RVA: 0x000FE1D8 File Offset: 0x000FC3D8
	public static List<vl> b(cyt A_0, cl3 A_1)
	{
		List<vl> list = new List<vl>();
		if (!string.IsNullOrEmpty(A_1.f()))
		{
			int num;
			if (A_1.b() != null)
			{
				num = A_1.b().Value;
			}
			else
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				bfc bfc = serviceOrThrow.ar0(A_1.f(), serviceOrThrow.aqu());
				if (bfc != null)
				{
					num = bfc.BaseLevel;
				}
				else
				{
					num = 1;
				}
			}
			foreach (vl vl in a4i.d.Values)
			{
				if (!A_0.ak.Contains(vl.Id) && (vl.MinLevel == null || vl.MinLevel.Value <= num) && (vl.MaxLevel == null || vl.MaxLevel.Value >= num) && vl.AvailableEntrances.Contains(A_1.e()))
				{
					bool flag = false;
					foreach (string item in A_1.d())
					{
						if (vl.Categories.Contains(item))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						list.Add(vl);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06002C66 RID: 11366 RVA: 0x000FE3AC File Offset: 0x000FC5AC
	public static vl a(cyt A_0, cl3 A_1)
	{
		List<vl> list = a4i.b(A_0, A_1);
		if (list.Count > 0)
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int num in Enumerable.Select<vl, int>(list, new Func<vl, int>(a4i.a.a.a)))
			{
				hashSet.Add(num);
			}
			int num2 = Enumerable.Sum(hashSet);
			List<vl> list2 = new List<vl>();
			foreach (vl vl in list)
			{
				int num3 = Math.Max(1, Convert.ToInt32((double)num2 / (double)Math.Max(1, vl.Rarity)));
				for (int i = 0; i < num3; i++)
				{
					list2.Add(vl);
				}
			}
			vl vl2 = list2[A_0.aj.Next(list2.Count)];
			A_0.ak.Add(vl2.Id);
			return vl2;
		}
		return null;
	}

	// Token: 0x06002C67 RID: 11367 RVA: 0x000FE4FC File Offset: 0x000FC6FC
	public static void a(cyt A_0)
	{
		bu6 service = bpo.GetService<bu6>();
		if (service != null && service.aq2() >= GameDifficulty.Dominating)
		{
			string text = "messages\\goran/";
			string a_ = null;
			if (A_0.r().GetPrimitivePropertyValue<bool>("dungeon_dun_cc_sBombers", new bool?(false)).Value)
			{
				text += "dominating_skullSmasher";
				a_ = "Крушитель черепов";
			}
			else if (A_0.r().GetPrimitivePropertyValue<bool>("frag_dun_up_utilityTowerDom", new bool?(false)).Value)
			{
				string classPropertyValue = A_0.r().GetClassPropertyValue<string>("dungeon_dun_up_utilityTower_entry");
				if (classPropertyValue != null)
				{
					text = text + "dominating_" + classPropertyValue + "_tower";
					a_ = "Доминирует!";
				}
			}
			cqh cqh = new cqh(text, a_, new string[0]);
			cqh.Author = "Горан";
			cqh.Portrait = "Goran";
			A_0.w().Insert(1, cqh);
			cqh cqh2 = new cqh("messages\\goran/skullSmasher_re", "Ура!", new string[0]);
			cqh2.Author = "Горан";
			cqh2.Portrait = "Goran";
			A_0.w().Insert(2, cqh2);
			A_0.r()["npc_sgs_goran_sentDominatingMail"] = true;
		}
	}

	// Token: 0x06002C68 RID: 11368 RVA: 0x000FE640 File Offset: 0x000FC840
	private static void c()
	{
		string text = d5x.d();
		if (Directory.Exists(text))
		{
			string[] files = Directory.GetFiles(text, "*.obj");
			if (files != null && files.Length != 0)
			{
				foreach (string text2 in files)
				{
					try
					{
						b58 b = eoq.DeserializeFromBinaryFile<b58>(text2, dds.a(), true);
						if (b != null)
						{
							if (string.IsNullOrWhiteSpace(b.m()))
							{
								dux.b(LogSeverity.Error, "Random fragment loaded from {0} had empty id.", new object[]
								{
									text2
								});
							}
							else if (!a4i.b.ContainsKey(b.m()))
							{
								a4i.b.Add(b.m(), b);
							}
							else
							{
								dux.b(LogSeverity.Error, "Random fragment loaded from {0} had duplicate id.", new object[]
								{
									text2
								});
							}
						}
						else
						{
							dux.b(LogSeverity.Error, "Не удалось загрузить случайный фрагмент из {0}.", new object[]
							{
								text2
							});
						}
					}
					catch (Exception a_)
					{
						dux.a(LogSeverity.Error, a_, "Не удалось загрузить случайный фрагмент из {0}.", new object[]
						{
							text2
						});
					}
				}
			}
		}
	}

	// Token: 0x06002C69 RID: 11369 RVA: 0x000FE76C File Offset: 0x000FC96C
	private static void b()
	{
		string text = d5x.c();
		if (Directory.Exists(text))
		{
			string[] files = Directory.GetFiles(text, "*.obj");
			if (files != null && files.Length != 0)
			{
				foreach (string text2 in files)
				{
					try
					{
						e1j e1j = eoq.DeserializeFromBinaryFile<e1j>(text2, dds.a(), true);
						if (e1j != null)
						{
							if (string.IsNullOrWhiteSpace(e1j.d()))
							{
								dux.b(LogSeverity.Error, "Fragment randomization category loaded from {0} had empty id.", new object[]
								{
									text2
								});
							}
							else if (!a4i.c.ContainsKey(e1j.d()))
							{
								a4i.c.Add(e1j.d(), e1j);
							}
							else
							{
								dux.b(LogSeverity.Error, "Fragment randomization category loaded from {0} had duplicate id.", new object[]
								{
									text2
								});
							}
						}
						else
						{
							dux.b(LogSeverity.Error, "Не удалось загрузить категорию рандомизации фрагмента из {0}.", new object[]
							{
								text2
							});
						}
					}
					catch (Exception a_)
					{
						dux.a(LogSeverity.Error, a_, "Не удалось загрузить категорию рандомизации фрагмента из {0}.", new object[]
						{
							text2
						});
					}
				}
			}
		}
	}

	// Token: 0x06002C6A RID: 11370 RVA: 0x000FE898 File Offset: 0x000FCA98
	private static void a()
	{
		string text = d5x.b();
		if (Directory.Exists(text))
		{
			string[] files = Directory.GetFiles(text, "*.obj");
			if (files != null && files.Length != 0)
			{
				foreach (string text2 in files)
				{
					try
					{
						vl vl = eoq.DeserializeFromBinaryFile<vl>(text2, dds.a(), true);
						if (vl != null)
						{
							if (string.IsNullOrWhiteSpace(vl.Id))
							{
								dux.b(LogSeverity.Error, "Dungeon definition loaded from {0} had empty id.", new object[]
								{
									text2
								});
							}
							else if (!a4i.d.ContainsKey(vl.Id))
							{
								a4i.d.Add(vl.Id, vl);
							}
							else
							{
								dux.b(LogSeverity.Error, "Dungeon definition loaded from {0} had duplicate id.", new object[]
								{
									text2
								});
							}
						}
						else
						{
							dux.b(LogSeverity.Error, "Не удалось загрузить определение подземелья из {0}.", new object[]
							{
								text2
							});
						}
					}
					catch (Exception a_)
					{
						dux.a(LogSeverity.Error, a_, "Не удалось загрузить определение подземелья из {0}.", new object[]
						{
							text2
						});
					}
				}
			}
		}
	}

	// Token: 0x06002C6B RID: 11371 RVA: 0x000FE9C4 File Offset: 0x000FCBC4
	private static bool a(cyt A_0, string A_1)
	{
		e1j e1j;
		if (a4i.c.TryGetValue(A_1, out e1j))
		{
			double? a_ = null;
			double value;
			if (A_0.ai.TryGetValue(e1j.d(), out value))
			{
				a_ = new double?(value);
			}
			a_ = new double?(e1j.c(a_));
			A_0.ai[e1j.d()] = a_.Value;
			return A_0.aj.NextDouble() < a_.Value;
		}
		return false;
	}

	// Token: 0x0400192F RID: 6447
	private static bool a;

	// Token: 0x04001930 RID: 6448
	private static Dictionary<string, b58> b;

	// Token: 0x04001931 RID: 6449
	private static Dictionary<string, e1j> c;

	// Token: 0x04001932 RID: 6450
	private static Dictionary<string, vl> d;

	// Token: 0x020006B1 RID: 1713
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06002C6E RID: 11374 RVA: 0x000FEA5C File Offset: 0x000FCC5C
		internal int a(vl A_0)
		{
			return Math.Max(1, A_0.Rarity);
		}

		// Token: 0x04001933 RID: 6451
		public static readonly a4i.a a = new a4i.a();

		// Token: 0x04001934 RID: 6452
		public static Func<vl, int> b;
	}
}
