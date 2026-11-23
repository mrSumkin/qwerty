using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200148C RID: 5260
[eiz("FV1")]
[Serializable]
public sealed class id : a6k, ISerializable
{
	// Token: 0x0600768C RID: 30348 RVA: 0x00322A98 File Offset: 0x00320C98
	private id(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600768D RID: 30349 RVA: 0x00322AA4 File Offset: 0x00320CA4
	public id()
	{
	}

	// Token: 0x0600768E RID: 30350 RVA: 0x00322AB0 File Offset: 0x00320CB0
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
		c9b c9b = pa.a(base.vg().q().h.b, base.vg().e().b9() as coh);
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
					a7v.a(new h0("У вас не хватает силы чтобы открыть вентиляционную решётку.", new Color?(adi.m)));
					bmj.a(c5x, new d53("Не хватает силы", adi.m, null, false));
				}
				id.a(c5x);
				result = dc4.e;
			}
		}
		else
		{
			if (flag)
			{
				a7v.a(new h0("Вы силой открываете вентиляционную решётку.", null));
				bmj.a(c5x, new d53("Вентиляционная решётка открыта силой", adi.h, null, false));
			}
			id.b(c5x);
			result = dc4.c;
		}
		c3g aspect = pa.a8().GetAspect<c3g>();
		if (aspect != null)
		{
			aspect.a(base.vg().q().h.b);
		}
		return result;
	}

	// Token: 0x0600768F RID: 30351 RVA: 0x00322C40 File Offset: 0x00320E40
	private static void b(c5x A_0)
	{
		A_0.c().a("open-close", "VentilationShaftForced", 1f, c9z.a, false, false);
		eym.a(A_0, (double)aju.bq);
	}

	// Token: 0x06007690 RID: 30352 RVA: 0x00322C6C File Offset: 0x00320E6C
	private static void a(c5x A_0)
	{
	}
}
