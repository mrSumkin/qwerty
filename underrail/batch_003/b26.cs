using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014CB RID: 5323
[eiz("PE0")]
[Serializable]
public sealed class b26 : c11, ISerializable
{
	// Token: 0x060077C9 RID: 30665 RVA: 0x00325324 File Offset: 0x00323524
	private b26(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060077CA RID: 30666 RVA: 0x00325330 File Offset: 0x00323530
	public b26()
	{
	}

	// Token: 0x060077CB RID: 30667 RVA: 0x00325338 File Offset: 0x00323538
	protected override string de()
	{
		return "objects\\traps\\empMine";
	}

	// Token: 0x060077CC RID: 30668 RVA: 0x00325340 File Offset: 0x00323540
	protected override string df()
	{
		return "ArmEmpMine";
	}

	// Token: 0x060077CD RID: 30669 RVA: 0x00325348 File Offset: 0x00323548
	protected override string dg()
	{
		return "DisarmEmpMine";
	}

	// Token: 0x060077CE RID: 30670 RVA: 0x00325354 File Offset: 0x00323554
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

	// Token: 0x060077CF RID: 30671 RVA: 0x003253A4 File Offset: 0x003235A4
	protected override string di()
	{
		return "ЭМИ-мина";
	}

	// Token: 0x060077D0 RID: 30672 RVA: 0x003253AC File Offset: 0x003235AC
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new djt(A_0, A_1);
	}

	// Token: 0x060077D1 RID: 30673 RVA: 0x003253B8 File Offset: 0x003235B8
	protected override Color tf()
	{
		return new Color(2, 185, 251);
	}

	// Token: 0x060077D2 RID: 30674 RVA: 0x003253CC File Offset: 0x003235CC
	protected override Color tg()
	{
		return new Color(2, 219, 251);
	}
}
