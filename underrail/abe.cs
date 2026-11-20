using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014CA RID: 5322
[eiz("PH1")]
[Serializable]
public sealed class abe : c11, ISerializable
{
	// Token: 0x060077C1 RID: 30657 RVA: 0x00325290 File Offset: 0x00323490
	private abe(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060077C2 RID: 30658 RVA: 0x0032529C File Offset: 0x0032349C
	public abe()
	{
	}

	// Token: 0x060077C3 RID: 30659 RVA: 0x003252A4 File Offset: 0x003234A4
	protected override string de()
	{
		return "objects\\traps\\acidBlobTrap";
	}

	// Token: 0x060077C4 RID: 30660 RVA: 0x003252AC File Offset: 0x003234AC
	protected override string df()
	{
		return "ArmChemicalTrap";
	}

	// Token: 0x060077C5 RID: 30661 RVA: 0x003252B4 File Offset: 0x003234B4
	protected override string dg()
	{
		return "DisarmChemicalTrap";
	}

	// Token: 0x060077C6 RID: 30662 RVA: 0x003252C0 File Offset: 0x003234C0
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

	// Token: 0x060077C7 RID: 30663 RVA: 0x00325310 File Offset: 0x00323510
	protected override string di()
	{
		return "Кислотная ловушка";
	}

	// Token: 0x060077C8 RID: 30664 RVA: 0x00325318 File Offset: 0x00323518
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new atm(A_0, A_1);
	}
}
