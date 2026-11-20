using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014C6 RID: 5318
[eiz("PBT7")]
[Serializable]
public sealed class can : c11, ISerializable
{
	// Token: 0x06007795 RID: 30613 RVA: 0x00325110 File Offset: 0x00323310
	private can(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007796 RID: 30614 RVA: 0x0032511C File Offset: 0x0032331C
	public override bool db()
	{
		return false;
	}

	// Token: 0x06007797 RID: 30615 RVA: 0x00325120 File Offset: 0x00323320
	public override double? dc()
	{
		return new double?(0.55);
	}

	// Token: 0x06007798 RID: 30616 RVA: 0x00325130 File Offset: 0x00323330
	public override bool dd()
	{
		return false;
	}

	// Token: 0x06007799 RID: 30617 RVA: 0x00325134 File Offset: 0x00323334
	public can()
	{
	}

	// Token: 0x0600779A RID: 30618 RVA: 0x0032513C File Offset: 0x0032333C
	protected override string de()
	{
		return "objects\\traps\\crawlerPoisonBearTrap";
	}

	// Token: 0x0600779B RID: 30619 RVA: 0x00325144 File Offset: 0x00323344
	protected override string df()
	{
		return "ArmBearTrap";
	}

	// Token: 0x0600779C RID: 30620 RVA: 0x0032514C File Offset: 0x0032334C
	protected override string dg()
	{
		return "DisarmBearTrap";
	}

	// Token: 0x0600779D RID: 30621 RVA: 0x00325154 File Offset: 0x00323354
	protected override Point dh(coh A_0)
	{
		return Point.Zero;
	}

	// Token: 0x0600779E RID: 30622 RVA: 0x0032515C File Offset: 0x0032335C
	protected override string di()
	{
		return "Капкан с ядом краулера";
	}

	// Token: 0x0600779F RID: 30623 RVA: 0x00325164 File Offset: 0x00323364
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new cxn(A_0, A_1);
	}
}
