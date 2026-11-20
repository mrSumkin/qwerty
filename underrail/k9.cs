using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014BA RID: 5306
[eiz("RH8")]
[Serializable]
public sealed class k9 : c11, ISerializable
{
	// Token: 0x06007719 RID: 30489 RVA: 0x00324300 File Offset: 0x00322500
	private k9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600771A RID: 30490 RVA: 0x0032430C File Offset: 0x0032250C
	public k9()
	{
	}

	// Token: 0x0600771B RID: 30491 RVA: 0x00324314 File Offset: 0x00322514
	protected override string de()
	{
		return "objects\\traps\\rustingAcidBlobTrap";
	}

	// Token: 0x0600771C RID: 30492 RVA: 0x0032431C File Offset: 0x0032251C
	protected override string df()
	{
		return "ArmChemicalTrap";
	}

	// Token: 0x0600771D RID: 30493 RVA: 0x00324324 File Offset: 0x00322524
	protected override string dg()
	{
		return "DisarmChemicalTrap";
	}

	// Token: 0x0600771E RID: 30494 RVA: 0x00324330 File Offset: 0x00322530
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

	// Token: 0x0600771F RID: 30495 RVA: 0x00324380 File Offset: 0x00322580
	protected override string di()
	{
		return "Ржа-кислотная ловушка";
	}

	// Token: 0x06007720 RID: 30496 RVA: 0x00324388 File Offset: 0x00322588
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new biy(A_0, A_1);
	}
}
