using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014BE RID: 5310
[eiz("HT5")]
[Serializable]
public sealed class cb1 : c11, ISerializable
{
	// Token: 0x06007747 RID: 30535 RVA: 0x00324D20 File Offset: 0x00322F20
	private cb1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007748 RID: 30536 RVA: 0x00324D2C File Offset: 0x00322F2C
	public override bool db()
	{
		return false;
	}

	// Token: 0x06007749 RID: 30537 RVA: 0x00324D30 File Offset: 0x00322F30
	public override double? dc()
	{
		return new double?(0.55);
	}

	// Token: 0x0600774A RID: 30538 RVA: 0x00324D40 File Offset: 0x00322F40
	public override bool dd()
	{
		return false;
	}

	// Token: 0x0600774B RID: 30539 RVA: 0x00324D44 File Offset: 0x00322F44
	public cb1()
	{
	}

	// Token: 0x0600774C RID: 30540 RVA: 0x00324D4C File Offset: 0x00322F4C
	protected override string de()
	{
		return "objects\\traps\\hopperTrap";
	}

	// Token: 0x0600774D RID: 30541 RVA: 0x00324D54 File Offset: 0x00322F54
	protected override string df()
	{
		return "ArmBearTrap";
	}

	// Token: 0x0600774E RID: 30542 RVA: 0x00324D5C File Offset: 0x00322F5C
	protected override string dg()
	{
		return "DisarmBearTrap";
	}

	// Token: 0x0600774F RID: 30543 RVA: 0x00324D64 File Offset: 0x00322F64
	protected override Point dh(coh A_0)
	{
		return Point.Zero;
	}

	// Token: 0x06007750 RID: 30544 RVA: 0x00324D6C File Offset: 0x00322F6C
	protected override string di()
	{
		return "Ловушка на пещерника";
	}

	// Token: 0x06007751 RID: 30545 RVA: 0x00324D74 File Offset: 0x00322F74
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new zd(A_0, A_1);
	}
}
