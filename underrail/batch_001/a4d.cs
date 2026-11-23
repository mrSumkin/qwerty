using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001483 RID: 5251
[eiz("RF9")]
[Serializable]
public sealed class a4d : a6k, ISerializable
{
	// Token: 0x0600766C RID: 30316 RVA: 0x00321600 File Offset: 0x0031F800
	private a4d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600766D RID: 30317 RVA: 0x0032160C File Offset: 0x0031F80C
	public a4d()
	{
	}

	// Token: 0x0600766E RID: 30318 RVA: 0x00321614 File Offset: 0x0031F814
	public static awx a(cgd A_0, c5x A_1)
	{
		int num = (int)Math.Ceiling((double)A_0.MaxBattery - A_0.Battery);
		SortedDictionary<int, List<coh>> sortedDictionary = new SortedDictionary<int, List<coh>>();
		foreach (coh coh in A_1.h.b.aa().Bag.z2())
		{
			sz sz = coh.Definition as sz;
			if (sz != null)
			{
				int value = sz.a7().GetPrimitivePropertyValue<int>(vo.g, new int?(0)).Value;
				if (value > 0)
				{
					List<coh> list;
					sortedDictionary.TryGetValue(value, ref list);
					if (list == null)
					{
						list = new List<coh>();
						sortedDictionary[value] = list;
					}
					list.Add(coh);
				}
			}
		}
		if (sortedDictionary.Count == 0)
		{
			if (A_1.IsPlayer)
			{
				bmj.a(A_1, new d53("Больше нет батареек", adi.l, null, false));
			}
			return null;
		}
		Dictionary<coh, int> dictionary = new Dictionary<coh, int>();
		List<coh> list2 = new List<coh>();
		while (num > 0 && sortedDictionary.Count > 0)
		{
			int? num2 = null;
			foreach (KeyValuePair<int, List<coh>> keyValuePair in sortedDictionary)
			{
				if (num2 == null || (keyValuePair.Key > num2.Value && keyValuePair.Key <= num) || (num2.Value > num && num2.Value - num > keyValuePair.Key - num))
				{
					num2 = new int?(keyValuePair.Key);
				}
			}
			if (num2 == null)
			{
				break;
			}
			coh coh2 = Enumerable.First<coh>(sortedDictionary[num2.Value]);
			list2.Add(coh2);
			num -= num2.Value;
			int num3;
			dictionary.TryGetValue(coh2, out num3);
			num3 = (dictionary[coh2] = num3 + 1);
			if (num3 >= coh2.Stacks)
			{
				sortedDictionary[num2.Value].Remove(coh2);
			}
			if (sortedDictionary[num2.Value].Count == 0)
			{
				sortedDictionary.Remove(num2.Value);
			}
		}
		if (list2.Count > 0)
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | (m7.b | m7.c));
			awx.b(true);
			awx.c(true);
			foreach (coh a_ in list2)
			{
				eu7 a_2 = ecf.a(dgk.Get<a25>(), new eru(new EntityAspectReference<amc, amc>(A_1.h.b)), a_) as eu7;
				awx.ad().Add(cp.a(a_2, A_1, A_0));
			}
			return awx;
		}
		return null;
	}

	// Token: 0x0600766F RID: 30319 RVA: 0x00321940 File Offset: 0x0031FB40
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		cgd cgd = base.vg().e().b9() as cgd;
		if (cgd == null)
		{
			return dc4.e;
		}
		awx awx = a4d.a(cgd, base.vg().q());
		if (awx != null && base.vg().q().i.b != null)
		{
			base.vg().q().i.b.a(awx, atp.a, true, false);
			return dc4.c;
		}
		return dc4.e;
	}
}
