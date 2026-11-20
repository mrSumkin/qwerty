using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014CD RID: 5325
[eiz("PF0")]
[Serializable]
public sealed class cof : c11, ISerializable
{
	// Token: 0x060077DB RID: 30683 RVA: 0x00325474 File Offset: 0x00323674
	private cof(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060077DC RID: 30684 RVA: 0x00325480 File Offset: 0x00323680
	public cof()
	{
	}

	// Token: 0x060077DD RID: 30685 RVA: 0x00325488 File Offset: 0x00323688
	protected override string de()
	{
		return "objects\\traps\\fragMine";
	}

	// Token: 0x060077DE RID: 30686 RVA: 0x00325490 File Offset: 0x00323690
	protected override string df()
	{
		return "ArmFragMine";
	}

	// Token: 0x060077DF RID: 30687 RVA: 0x00325498 File Offset: 0x00323698
	protected override string dg()
	{
		return "DisarmFragMine";
	}

	// Token: 0x060077E0 RID: 30688 RVA: 0x003254A4 File Offset: 0x003236A4
	protected override Point dh(coh A_0)
	{
		int num = 1;
		if (A_0 != null)
		{
			c4j c4j = A_0.Definition as c4j;
			if (c4j != null)
			{
				num = c4j.a7().GetPrimitivePropertyValue<int>("power", new int?(1)).Value;
			}
		}
		return new Point(0, num - 1);
	}

	// Token: 0x060077E1 RID: 30689 RVA: 0x003254F4 File Offset: 0x003236F4
	protected override string di()
	{
		return "Осколочная мина";
	}

	// Token: 0x060077E2 RID: 30690 RVA: 0x003254FC File Offset: 0x003236FC
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new eiv(A_0, A_1);
	}
}
