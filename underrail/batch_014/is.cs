using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020007D6 RID: 2006
public static class @is
{
	// Token: 0x06003242 RID: 12866 RVA: 0x001368AC File Offset: 0x00134AAC
	public static void a(c1a A_0, string A_1 = null, int? A_2 = null)
	{
		int num = 0;
		foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				int num2 = num;
				int? num3 = A_2;
				if (num2 >= num3.GetValueOrDefault() & num3 != null)
				{
					return;
				}
				if (c5x != null)
				{
					if (A_1 != null)
					{
						if (c5x.a(A_1))
						{
							@is.b(c5x);
						}
					}
					else
					{
						@is.b(c5x);
					}
				}
			}
		}
	}

	// Token: 0x06003243 RID: 12867 RVA: 0x0013699C File Offset: 0x00134B9C
	public static void b(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null && A_0.h.b.aa().FactionId == asp.fx)
		{
			A_0.w();
			A_0.an();
		}
	}

	// Token: 0x06003244 RID: 12868 RVA: 0x001369F0 File Offset: 0x00134BF0
	public static List<string> a(bool A_0 = true)
	{
		if (bpo.GetServiceOrThrow<cnk>() != null)
		{
			Random random = new Random();
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			list2.Add("creatures\\generichumans\\xpbl\\TranscendentMacehandHammerer");
			list2.Add("creatures\\generichumans\\xpbl\\TranscendentShieldhandSwordmaster");
			list2.Add("creatures\\generichumans\\xpbl\\TranscendentSwordhandSpearman");
			if (A_0)
			{
				list2.Add("creatures\\generichumans\\xpbl\\TranscendentTentacleshandSpearman");
				list2.Add("creatures\\generichumans\\xpbl\\TranscendentBlobberSwordmaster");
			}
			for (int i = list2.Count; i > 1; i--)
			{
				int index = random.Next(i);
				string value = list2[i - 1];
				list2[i - 1] = list2[index];
				list2[index] = value;
			}
			if (random.Next(0, 1) == 0)
			{
				list.InsertRange(0, list2);
			}
			else
			{
				list.AddRange(list2);
			}
			list2.Clear();
			list2.Add("creatures\\generichumans\\xpbl\\TranscendentMacehandKnifer");
			list2.Add("creatures\\generichumans\\xpbl\\TranscendentShieldhandSpearman");
			list2.Add("creatures\\generichumans\\xpbl\\TranscendentSwordhandHammerer");
			if (A_0)
			{
				list2.Add("creatures\\generichumans\\xpbl\\TranscendentTentacleshandSwordmaster");
				list2.Add("creatures\\generichumans\\xpbl\\TranscendentBlobberKnifer");
			}
			for (int j = list2.Count; j > 1; j--)
			{
				int index2 = random.Next(j);
				string value2 = list2[j - 1];
				list2[j - 1] = list2[index2];
				list2[index2] = value2;
			}
			if (random.Next(0, 1) == 0)
			{
				list.InsertRange(0, list2);
			}
			else
			{
				list.AddRange(list2);
			}
			list2.Clear();
			list2.Add("creatures\\generichumans\\xpbl\\TranscendentMacehandSpearman");
			list2.Add("creatures\\generichumans\\xpbl\\TranscendentShieldhandHammerer");
			list2.Add("creatures\\generichumans\\xpbl\\TranscendentSwordhandKnifer");
			if (A_0)
			{
				list2.Add("creatures\\generichumans\\xpbl\\TranscendentTentacleshandSwordmaster");
				list2.Add("creatures\\generichumans\\xpbl\\TranscendentBlobberSpearman");
			}
			for (int k = list2.Count; k > 1; k--)
			{
				int index3 = random.Next(k);
				string value3 = list2[k - 1];
				list2[k - 1] = list2[index3];
				list2[index3] = value3;
			}
			if (random.Next(0, 1) == 0)
			{
				list.InsertRange(0, list2);
			}
			else
			{
				list.AddRange(list2);
			}
			list2.Clear();
			list2.Add("creatures\\generichumans\\xpbl\\TranscendentMacehandSwordmaster");
			list2.Add("creatures\\generichumans\\xpbl\\TranscendentShieldhandKnifer");
			list2.Add("creatures\\generichumans\\xpbl\\TranscendentSwordhandSwordmaster");
			if (A_0)
			{
				list2.Add("creatures\\generichumans\\xpbl\\TranscendentTentacleshandHammerer");
				list2.Add("creatures\\generichumans\\xpbl\\TranscendentBlobberHammerer");
			}
			for (int l = list2.Count; l > 1; l--)
			{
				int index4 = random.Next(l);
				string value4 = list2[l - 1];
				list2[l - 1] = list2[index4];
				list2[index4] = value4;
			}
			if (random.Next(0, 1) == 0)
			{
				list.InsertRange(0, list2);
			}
			else
			{
				list.AddRange(list2);
			}
			list2.Clear();
			return list;
		}
		return null;
	}

	// Token: 0x06003245 RID: 12869 RVA: 0x00136CD0 File Offset: 0x00134ED0
	public static c5x a(c5x A_0)
	{
		if (A_0 != null)
		{
			if (A_0.h.b != null && euf.d(A_0.h.b.aa().Offense.u().TypedDefinition).GetValueOrDefault() == WeaponSubtype.Crossbow)
			{
				acz acz = new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\Xpbl\\VoidBolt1"))
				{
					Stacks = 2
				};
				if (acz != null)
				{
					bn.SwapIn<coh>(A_0.h.b.aa().Gear.d()[0], A_0.h.b.aa().Bag, acz);
					A_0.h.b.aa().Bag.z3(acz, true);
				}
			}
			return A_0;
		}
		return null;
	}
}
