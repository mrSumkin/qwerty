using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014BD RID: 5309
[eiz("PLT8")]
[Serializable]
public sealed class c19 : c11, ISerializable
{
	// Token: 0x0600773C RID: 30524 RVA: 0x00324CC0 File Offset: 0x00322EC0
	private c19(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600773D RID: 30525 RVA: 0x00324CCC File Offset: 0x00322ECC
	public override bool db()
	{
		return false;
	}

	// Token: 0x0600773E RID: 30526 RVA: 0x00324CD0 File Offset: 0x00322ED0
	public override double? dc()
	{
		return new double?(0.55);
	}

	// Token: 0x0600773F RID: 30527 RVA: 0x00324CE0 File Offset: 0x00322EE0
	public override bool dd()
	{
		return false;
	}

	// Token: 0x06007740 RID: 30528 RVA: 0x00324CE4 File Offset: 0x00322EE4
	public c19()
	{
	}

	// Token: 0x06007741 RID: 30529 RVA: 0x00324CEC File Offset: 0x00322EEC
	protected override string de()
	{
		return "objects\\traps\\xpbl_leperPoisonBearTrap";
	}

	// Token: 0x06007742 RID: 30530 RVA: 0x00324CF4 File Offset: 0x00322EF4
	protected override string df()
	{
		return "ArmBearTrap";
	}

	// Token: 0x06007743 RID: 30531 RVA: 0x00324CFC File Offset: 0x00322EFC
	protected override string dg()
	{
		return "DisarmBearTrap";
	}

	// Token: 0x06007744 RID: 30532 RVA: 0x00324D04 File Offset: 0x00322F04
	protected override Point dh(coh A_0)
	{
		return Point.Zero;
	}

	// Token: 0x06007745 RID: 30533 RVA: 0x00324D0C File Offset: 0x00322F0C
	protected override string di()
	{
		return "Капкан с ядом прокажённого змея";
	}

	// Token: 0x06007746 RID: 30534 RVA: 0x00324D14 File Offset: 0x00322F14
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new a2c(A_0, A_1);
	}
}
