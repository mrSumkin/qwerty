using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020008DC RID: 2268
[eiz("GSNPP")]
[Serializable]
public class aea : c13, ISerializable
{
	// Token: 0x0600385A RID: 14426 RVA: 0x0014E294 File Offset: 0x0014C494
	private aea(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600385B RID: 14427 RVA: 0x0014E29C File Offset: 0x0014C49C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600385C RID: 14428 RVA: 0x0014E2A0 File Offset: 0x0014C4A0
	public List<c5x> ok(string A_0, IEnumerable<csd> A_1)
	{
		List<c5x> list = new List<c5x>();
		if (A_1 != null)
		{
			gx gx = new gx();
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			bool flag = false;
			bool flag2 = false;
			foreach (csd csd in A_1)
			{
				List<cze> list2 = new List<cze>();
				if (serviceOrThrow != null)
				{
					List<cze> list3 = list2;
					x6 x = new x6();
					x.a(true);
					x.a(1);
					x.a("loc_" + serviceOrThrow.aqw().y8() + "_genericJetSkiersKilled");
					list3.Add(x);
				}
				if (!flag)
				{
					if (cuo.a.Next(0, 101) < 2 && this.a(serviceOrThrow.aqw().y8()))
					{
						flag2 = true;
					}
					flag = true;
				}
				c5x c5x;
				if (flag2)
				{
					c5x = gx.a(csd, new int?(20), "Generic_Jetski", "Флибустьер", asp.ar, "Sailors", null, true, list2, false);
				}
				else
				{
					bool flag3 = true;
					using (List<csd>.Enumerator enumerator2 = Enumerable.ToList<csd>(csd.Zone.Waypoints).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.Name == csd.Name.Remove(csd.Name.Length - 3, 1).Insert(csd.Name.Length - 3, (int.Parse(csd.Name.Substring(csd.Name.Length - 3, 1)) + 2).ToString()))
							{
								flag3 = false;
								break;
							}
						}
					}
					if (!flag3)
					{
						if (cuo.a.Next(0, 101) < 30)
						{
							c5x = gx.a(csd, new int?(10), "Generic_Jetski", "Гонщик", asp.fa, "Sailors", "support\\xpbl\\gc_jetSki_talkative", true, list2, false);
						}
						else
						{
							c5x = gx.a(csd, new int?(10), "Generic_Jetski", "Гонщик", asp.fa, "Sailors", "support\\xpbl\\gc_jetSki_untalkative", true, list2, false);
						}
					}
					else
					{
						c5x = gx.a(csd, new int?(10), "Generic_Jetski", "Гонщик", asp.fa, "Sailors", "support\\xpbl\\gc_jetSki_passing", true, list2, false);
					}
				}
				if (c5x != null)
				{
					if (c5x.h.b != null)
					{
						c5x.h.b.aa().HostilityBroadcastMode = c2n.b;
					}
					bfe.a(c5x, 1f, 0.75f);
					bfe.a(c5x, false);
					list.Add(c5x);
				}
			}
		}
		return list;
	}

	// Token: 0x0600385D RID: 14429 RVA: 0x0014E5A0 File Offset: 0x0014C7A0
	private bool a(string A_0)
	{
		if (A_0.Contains("xpbl_rig"))
		{
			return false;
		}
		bool result = true;
		int num = int.Parse(A_0.Substring(3));
		if (Enumerable.Contains<int>(Enumerable.Range(8, 15), num))
		{
			result = false;
		}
		else if (Enumerable.Contains<int>(Enumerable.Range(22, 30), num))
		{
			result = false;
		}
		else if (Enumerable.Contains<int>(Enumerable.Range(44, 48), num))
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600385E RID: 14430 RVA: 0x0014E61C File Offset: 0x0014C81C
	public aea()
	{
	}
}
