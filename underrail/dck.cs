using System;
using System.Collections.Generic;
using Ouroboros.Playfield.Space;

// Token: 0x0200149E RID: 5278
[d1q("HotwireVehicle")]
public sealed class dck : cny
{
	// Token: 0x060076CF RID: 30415 RVA: 0x00323D84 File Offset: 0x00321F84
	public override afq ba()
	{
		return new d8n();
	}

	// Token: 0x060076D0 RID: 30416 RVA: 0x00323D8C File Offset: 0x00321F8C
	public override List<HorizontalDirection> ae8(object A_0)
	{
		List<HorizontalDirection> list = base.ae8(A_0);
		if (list != null)
		{
			return list;
		}
		return new List<HorizontalDirection>
		{
			HorizontalDirection.North,
			HorizontalDirection.South,
			HorizontalDirection.East,
			HorizontalDirection.West
		};
	}

	// Token: 0x060076D1 RID: 30417 RVA: 0x00323DCC File Offset: 0x00321FCC
	public override bool w1()
	{
		return true;
	}

	// Token: 0x060076D2 RID: 30418 RVA: 0x00323DD0 File Offset: 0x00321FD0
	public override bool w2()
	{
		return true;
	}

	// Token: 0x060076D3 RID: 30419 RVA: 0x00323DD4 File Offset: 0x00321FD4
	public override m7 e0()
	{
		return m7.n;
	}

	// Token: 0x060076D4 RID: 30420 RVA: 0x00323DDC File Offset: 0x00321FDC
	public override float? ae9(object A_0)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null)
		{
			wv wv = c5x.GetAspect<bim>() as wv;
			if (wv != null && wv.g() != null && (wv.g().y() == bws.b || wv.g().y() == bws.a))
			{
				return new float?(2.5f);
			}
		}
		return null;
	}
}
