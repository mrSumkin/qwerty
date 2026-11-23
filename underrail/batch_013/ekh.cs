using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014CC RID: 5324
[eiz("PH0")]
[Serializable]
public sealed class ekh : c11, ISerializable
{
	// Token: 0x060077D3 RID: 30675 RVA: 0x003253E0 File Offset: 0x003235E0
	private ekh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060077D4 RID: 30676 RVA: 0x003253EC File Offset: 0x003235EC
	public ekh()
	{
	}

	// Token: 0x060077D5 RID: 30677 RVA: 0x003253F4 File Offset: 0x003235F4
	protected override string de()
	{
		return "objects\\traps\\heMine";
	}

	// Token: 0x060077D6 RID: 30678 RVA: 0x003253FC File Offset: 0x003235FC
	protected override string df()
	{
		return "ArmHeMine";
	}

	// Token: 0x060077D7 RID: 30679 RVA: 0x00325404 File Offset: 0x00323604
	protected override string dg()
	{
		return "DisarmHeMine";
	}

	// Token: 0x060077D8 RID: 30680 RVA: 0x00325410 File Offset: 0x00323610
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

	// Token: 0x060077D9 RID: 30681 RVA: 0x00325460 File Offset: 0x00323660
	protected override string di()
	{
		return "Фугасная мина";
	}

	// Token: 0x060077DA RID: 30682 RVA: 0x00325468 File Offset: 0x00323668
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new aqn(A_0, A_1);
	}
}
