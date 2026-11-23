using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200148D RID: 5261
[eiz("OV1")]
[Serializable]
public sealed class dd3 : a6k, ISerializable
{
	// Token: 0x06007691 RID: 30353 RVA: 0x00322C70 File Offset: 0x00320E70
	private dd3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007692 RID: 30354 RVA: 0x00322C7C File Offset: 0x00320E7C
	public dd3()
	{
	}

	// Token: 0x06007693 RID: 30355 RVA: 0x00322C84 File Offset: 0x00320E84
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		pa pa = c5x.GetAspect<bim>() as pa;
		if (pa == null)
		{
			return dc4.e;
		}
		bool flag = (base.vg().q().g & e2b.d) > (e2b)0;
		c9b c9b = pa.b(base.vg().q().h.b, base.vg().e().b9() as coh);
		dc4 result;
		if (c9b != c9b.a)
		{
			if (c9b != c9b.b)
			{
				result = dc4.e;
			}
			else
			{
				if (flag)
				{
					a7v.a(new h0("Недостаточно навыка.", new Color?(adi.m)));
					bmj.a(c5x, new d53("Недостаточно навыка", adi.m, null, false));
				}
				dd3.a(pa.a8());
				result = dc4.e;
			}
		}
		else
		{
			if (flag)
			{
				a7v.a(new h0("Вы открываете вентиляционную решётку.", null));
				bmj.a(c5x, new d53("Вентиляционная решётка открыта.", adi.h, null, false));
			}
			dd3.b(pa.a8());
			result = dc4.c;
		}
		c3g aspect = pa.a8().GetAspect<c3g>();
		if (aspect != null)
		{
			aspect.a(base.vg().q().h.b);
		}
		return result;
	}

	// Token: 0x06007694 RID: 30356 RVA: 0x00322E20 File Offset: 0x00321020
	private static void b(c5x A_0)
	{
		A_0.c().a("open-close", "VentilationShaftOpen", 1f, c9z.a, false, false);
	}

	// Token: 0x06007695 RID: 30357 RVA: 0x00322E40 File Offset: 0x00321040
	private static void a(c5x A_0)
	{
	}
}
