using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014C1 RID: 5313
[eiz("PGT7")]
[Serializable]
public sealed class abv : c11, ISerializable
{
	// Token: 0x06007767 RID: 30567 RVA: 0x00324E94 File Offset: 0x00323094
	private abv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007768 RID: 30568 RVA: 0x00324EA0 File Offset: 0x003230A0
	public override bool db()
	{
		return false;
	}

	// Token: 0x06007769 RID: 30569 RVA: 0x00324EA4 File Offset: 0x003230A4
	public override double? dc()
	{
		return new double?(0.55);
	}

	// Token: 0x0600776A RID: 30570 RVA: 0x00324EB4 File Offset: 0x003230B4
	public override bool dd()
	{
		return false;
	}

	// Token: 0x0600776B RID: 30571 RVA: 0x00324EB8 File Offset: 0x003230B8
	public abv()
	{
	}

	// Token: 0x0600776C RID: 30572 RVA: 0x00324EC0 File Offset: 0x003230C0
	protected override string de()
	{
		return "objects\\traps\\spiritPoisonBearTrap";
	}

	// Token: 0x0600776D RID: 30573 RVA: 0x00324EC8 File Offset: 0x003230C8
	protected override string df()
	{
		return "ArmBearTrap";
	}

	// Token: 0x0600776E RID: 30574 RVA: 0x00324ED0 File Offset: 0x003230D0
	protected override string dg()
	{
		return "DisarmBearTrap";
	}

	// Token: 0x0600776F RID: 30575 RVA: 0x00324ED8 File Offset: 0x003230D8
	protected override Point dh(coh A_0)
	{
		return Point.Zero;
	}

	// Token: 0x06007770 RID: 30576 RVA: 0x00324EE0 File Offset: 0x003230E0
	protected override string di()
	{
		return "Капкан с ядом призрак";
	}

	// Token: 0x06007771 RID: 30577 RVA: 0x00324EE8 File Offset: 0x003230E8
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new b6y(A_0, A_1);
	}
}
