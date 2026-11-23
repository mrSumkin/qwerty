using System;
using System.Collections.Generic;
using Ouroboros.Playfield.Space;

// Token: 0x020014B3 RID: 5299
[d1q("Lockpicking")]
public sealed class ccu : cny
{
	// Token: 0x06007707 RID: 30471 RVA: 0x003241E4 File Offset: 0x003223E4
	public override afq ba()
	{
		return new cut();
	}

	// Token: 0x06007708 RID: 30472 RVA: 0x003241EC File Offset: 0x003223EC
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

	// Token: 0x06007709 RID: 30473 RVA: 0x0032422C File Offset: 0x0032242C
	public override bool w1()
	{
		return true;
	}

	// Token: 0x0600770A RID: 30474 RVA: 0x00324230 File Offset: 0x00322430
	public override bool w2()
	{
		return true;
	}

	// Token: 0x0600770B RID: 30475 RVA: 0x00324234 File Offset: 0x00322434
	public override m7 e0()
	{
		return m7.m;
	}

	// Token: 0x0600770C RID: 30476 RVA: 0x0032423C File Offset: 0x0032243C
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
