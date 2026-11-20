using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02001908 RID: 6408
public static class bk0
{
	// Token: 0x0600880D RID: 34829 RVA: 0x003859EC File Offset: 0x00383BEC
	public static Dictionary<coh, List<dbj>> a(efk A_0)
	{
		Dictionary<coh, List<dbj>> dictionary = new Dictionary<coh, List<dbj>>();
		List<coh> list = A_0.Gear.i();
		HashSet<Guid> hashSet = new HashSet<Guid>();
		foreach (coh coh in list)
		{
			if (hashSet.Contains(coh.Id))
			{
				coh.c = Guid.NewGuid();
			}
			hashSet.Add(coh.c);
			if (coh.ItemEffects.Count > 0)
			{
				dictionary[coh] = new List<dbj>(coh.ItemEffects);
			}
		}
		return dictionary;
	}

	// Token: 0x0600880E RID: 34830 RVA: 0x00385A9C File Offset: 0x00383C9C
	public static void b(efk A_0, efk A_1, cd1 A_2, cmn A_3)
	{
		foreach (KeyValuePair<coh, List<dbj>> keyValuePair in bk0.a(A_0))
		{
			bool a_ = keyValuePair.Key == A_2;
			foreach (dbj dbj in keyValuePair.Value)
			{
				dbj.aie(A_0, A_1, A_2, a_, A_3);
			}
		}
	}

	// Token: 0x0600880F RID: 34831 RVA: 0x00385B44 File Offset: 0x00383D44
	public static void a(efk A_0, efk A_1, cd1 A_2, cmn A_3)
	{
		foreach (KeyValuePair<coh, List<dbj>> keyValuePair in bk0.a(A_0))
		{
			bool a_ = keyValuePair.Key == A_2;
			foreach (dbj dbj in keyValuePair.Value)
			{
				dbj.ajr(A_0, A_1, A_2, a_, A_3);
			}
		}
	}

	// Token: 0x06008810 RID: 34832 RVA: 0x00385BEC File Offset: 0x00383DEC
	public static void b(efk A_0, Guid? A_1, bool A_2)
	{
		foreach (KeyValuePair<coh, List<dbj>> keyValuePair in bk0.a(A_0))
		{
			bool a_ = A_1 != null && keyValuePair.Key.Id == A_1.Value;
			foreach (dbj dbj in Enumerable.ToList<dbj>(keyValuePair.Value))
			{
				if (dbj.aif(a_) && A_2)
				{
					dbj dbj2 = dbj;
					int num = dbj2.RemainingTicks - 1;
					dbj2.RemainingTicks = num;
					if (num <= 0)
					{
						keyValuePair.Key.ItemEffects.Remove(dbj);
					}
				}
			}
		}
	}

	// Token: 0x06008811 RID: 34833 RVA: 0x00385CF4 File Offset: 0x00383EF4
	public static void a(efk A_0, Guid? A_1, bool A_2)
	{
		foreach (KeyValuePair<coh, List<dbj>> keyValuePair in bk0.a(A_0))
		{
			bool a_ = A_1 != null && keyValuePair.Key.Id == A_1.Value;
			foreach (dbj dbj in keyValuePair.Value)
			{
				if (dbj.qm(a_) && A_2)
				{
					dbj dbj2 = dbj;
					int num = dbj2.RemainingTicks - 1;
					dbj2.RemainingTicks = num;
					if (num <= 0)
					{
						keyValuePair.Key.ItemEffects.Remove(dbj);
					}
				}
			}
		}
	}

	// Token: 0x06008812 RID: 34834 RVA: 0x00385DF8 File Offset: 0x00383FF8
	public static List<edm> a(efk A_0, cd1 A_1)
	{
		List<edm> list = new List<edm>();
		foreach (edm item in A_1.TypedDefinition.aa())
		{
			list.Add(item);
		}
		foreach (KeyValuePair<coh, List<dbj>> keyValuePair in bk0.a(A_0))
		{
			bool a_ = keyValuePair.Key == A_1;
			foreach (dbj dbj in keyValuePair.Value)
			{
				List<edm> list2 = dbj.qo(A_1, a_);
				if (list2 != null)
				{
					list.AddRange(list2);
				}
			}
		}
		return list;
	}
}
