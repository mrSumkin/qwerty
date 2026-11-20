using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014C0 RID: 5312
[eiz("PBT8")]
[Serializable]
public sealed class abt : c11, ISerializable
{
	// Token: 0x0600775C RID: 30556 RVA: 0x00324E34 File Offset: 0x00323034
	private abt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600775D RID: 30557 RVA: 0x00324E40 File Offset: 0x00323040
	public override bool db()
	{
		return false;
	}

	// Token: 0x0600775E RID: 30558 RVA: 0x00324E44 File Offset: 0x00323044
	public override double? dc()
	{
		return new double?(0.55);
	}

	// Token: 0x0600775F RID: 30559 RVA: 0x00324E54 File Offset: 0x00323054
	public override bool dd()
	{
		return false;
	}

	// Token: 0x06007760 RID: 30560 RVA: 0x00324E58 File Offset: 0x00323058
	public abt()
	{
	}

	// Token: 0x06007761 RID: 30561 RVA: 0x00324E60 File Offset: 0x00323060
	protected override string de()
	{
		return "objects\\traps\\xpbl_blindingPoisonBearTrap";
	}

	// Token: 0x06007762 RID: 30562 RVA: 0x00324E68 File Offset: 0x00323068
	protected override string df()
	{
		return "ArmBearTrap";
	}

	// Token: 0x06007763 RID: 30563 RVA: 0x00324E70 File Offset: 0x00323070
	protected override string dg()
	{
		return "DisarmBearTrap";
	}

	// Token: 0x06007764 RID: 30564 RVA: 0x00324E78 File Offset: 0x00323078
	protected override Point dh(coh A_0)
	{
		return Point.Zero;
	}

	// Token: 0x06007765 RID: 30565 RVA: 0x00324E80 File Offset: 0x00323080
	protected override string di()
	{
		return "Капкан с ядом слепитель";
	}

	// Token: 0x06007766 RID: 30566 RVA: 0x00324E88 File Offset: 0x00323088
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new czk(A_0, A_1);
	}
}
