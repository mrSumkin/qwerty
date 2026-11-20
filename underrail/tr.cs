using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014C4 RID: 5316
[eiz("PL2")]
[Serializable]
public sealed class tr : c11, ISerializable
{
	// Token: 0x06007785 RID: 30597 RVA: 0x00324FE8 File Offset: 0x003231E8
	private tr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007786 RID: 30598 RVA: 0x00324FF4 File Offset: 0x003231F4
	public tr()
	{
	}

	// Token: 0x06007787 RID: 30599 RVA: 0x00324FFC File Offset: 0x003231FC
	protected override string de()
	{
		return "objects\\traps\\incendiaryBlobTrap";
	}

	// Token: 0x06007788 RID: 30600 RVA: 0x00325004 File Offset: 0x00323204
	protected override string df()
	{
		return "ArmChemicalTrap";
	}

	// Token: 0x06007789 RID: 30601 RVA: 0x0032500C File Offset: 0x0032320C
	protected override string dg()
	{
		return "DisarmChemicalTrap";
	}

	// Token: 0x0600778A RID: 30602 RVA: 0x00325018 File Offset: 0x00323218
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

	// Token: 0x0600778B RID: 30603 RVA: 0x00325068 File Offset: 0x00323268
	protected override string di()
	{
		return "Зажигательная ловушка";
	}

	// Token: 0x0600778C RID: 30604 RVA: 0x00325070 File Offset: 0x00323270
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new e07(A_0, A_1);
	}
}
