using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014C3 RID: 5315
[eiz("PH8")]
[Serializable]
public sealed class k4 : c11, ISerializable
{
	// Token: 0x0600777D RID: 30589 RVA: 0x00324F54 File Offset: 0x00323154
	private k4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600777E RID: 30590 RVA: 0x00324F60 File Offset: 0x00323160
	public k4()
	{
	}

	// Token: 0x0600777F RID: 30591 RVA: 0x00324F68 File Offset: 0x00323168
	protected override string de()
	{
		return "objects\\traps\\corrosiveAcidBlobTrap";
	}

	// Token: 0x06007780 RID: 30592 RVA: 0x00324F70 File Offset: 0x00323170
	protected override string df()
	{
		return "ArmChemicalTrap";
	}

	// Token: 0x06007781 RID: 30593 RVA: 0x00324F78 File Offset: 0x00323178
	protected override string dg()
	{
		return "DisarmChemicalTrap";
	}

	// Token: 0x06007782 RID: 30594 RVA: 0x00324F84 File Offset: 0x00323184
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

	// Token: 0x06007783 RID: 30595 RVA: 0x00324FD4 File Offset: 0x003231D4
	protected override string di()
	{
		return "Ловушка с едкой кислотой";
	}

	// Token: 0x06007784 RID: 30596 RVA: 0x00324FDC File Offset: 0x003231DC
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new zn(A_0, A_1);
	}
}
