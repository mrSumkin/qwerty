using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014BC RID: 5308
[eiz("PHBT8")]
[Serializable]
public sealed class bw2 : c11, ISerializable
{
	// Token: 0x06007731 RID: 30513 RVA: 0x00324C60 File Offset: 0x00322E60
	private bw2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007732 RID: 30514 RVA: 0x00324C6C File Offset: 0x00322E6C
	public override bool db()
	{
		return false;
	}

	// Token: 0x06007733 RID: 30515 RVA: 0x00324C70 File Offset: 0x00322E70
	public override double? dc()
	{
		return new double?(0.55);
	}

	// Token: 0x06007734 RID: 30516 RVA: 0x00324C80 File Offset: 0x00322E80
	public override bool dd()
	{
		return false;
	}

	// Token: 0x06007735 RID: 30517 RVA: 0x00324C84 File Offset: 0x00322E84
	public bw2()
	{
	}

	// Token: 0x06007736 RID: 30518 RVA: 0x00324C8C File Offset: 0x00322E8C
	protected override string de()
	{
		return "objects\\traps\\xpbl_heartbreakPoisonBearTrap";
	}

	// Token: 0x06007737 RID: 30519 RVA: 0x00324C94 File Offset: 0x00322E94
	protected override string df()
	{
		return "ArmBearTrap";
	}

	// Token: 0x06007738 RID: 30520 RVA: 0x00324C9C File Offset: 0x00322E9C
	protected override string dg()
	{
		return "DisarmBearTrap";
	}

	// Token: 0x06007739 RID: 30521 RVA: 0x00324CA4 File Offset: 0x00322EA4
	protected override Point dh(coh A_0)
	{
		return Point.Zero;
	}

	// Token: 0x0600773A RID: 30522 RVA: 0x00324CAC File Offset: 0x00322EAC
	protected override string di()
	{
		return "Капкан с ядом сердцеед";
	}

	// Token: 0x0600773B RID: 30523 RVA: 0x00324CB4 File Offset: 0x00322EB4
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new bnn(A_0, A_1);
	}
}
