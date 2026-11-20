using System;
using System.Collections.Generic;
using Ouroboros.Playfield.Space;

// Token: 0x020014CF RID: 5327
public abstract class ccw : eqz
{
	// Token: 0x060077E5 RID: 30693 RVA: 0x00325518 File Offset: 0x00323718
	public override bool w1()
	{
		return true;
	}

	// Token: 0x060077E6 RID: 30694 RVA: 0x0032551C File Offset: 0x0032371C
	public override bool afa()
	{
		return true;
	}

	// Token: 0x060077E7 RID: 30695 RVA: 0x00325520 File Offset: 0x00323720
	public override List<HorizontalDirection> ae8(object A_0)
	{
		return new List<HorizontalDirection>
		{
			HorizontalDirection.North,
			HorizontalDirection.South,
			HorizontalDirection.East,
			HorizontalDirection.West,
			HorizontalDirection.Northeast,
			HorizontalDirection.Northwest,
			HorizontalDirection.Southeast,
			HorizontalDirection.Southwest
		};
	}

	// Token: 0x060077E8 RID: 30696 RVA: 0x0032556C File Offset: 0x0032376C
	public override m7 e0()
	{
		return m7.l;
	}
}
