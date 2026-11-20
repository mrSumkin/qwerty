using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014C5 RID: 5317
[eiz("PL1")]
[Serializable]
public sealed class c4w : c11, ISerializable
{
	// Token: 0x0600778D RID: 30605 RVA: 0x0032507C File Offset: 0x0032327C
	private c4w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600778E RID: 30606 RVA: 0x00325088 File Offset: 0x00323288
	public c4w()
	{
	}

	// Token: 0x0600778F RID: 30607 RVA: 0x00325090 File Offset: 0x00323290
	protected override string de()
	{
		return "objects\\traps\\cryoliquidBlobTrap";
	}

	// Token: 0x06007790 RID: 30608 RVA: 0x00325098 File Offset: 0x00323298
	protected override string df()
	{
		return "ArmChemicalTrap";
	}

	// Token: 0x06007791 RID: 30609 RVA: 0x003250A0 File Offset: 0x003232A0
	protected override string dg()
	{
		return "DisarmChemicalTrap";
	}

	// Token: 0x06007792 RID: 30610 RVA: 0x003250AC File Offset: 0x003232AC
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

	// Token: 0x06007793 RID: 30611 RVA: 0x003250FC File Offset: 0x003232FC
	protected override string di()
	{
		return "Ловушка с крио-жидкостью";
	}

	// Token: 0x06007794 RID: 30612 RVA: 0x00325104 File Offset: 0x00323304
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new sn(A_0, A_1);
	}
}
