using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014C2 RID: 5314
[eiz("PBR7")]
[Serializable]
public sealed class bs9 : c11, ISerializable
{
	// Token: 0x06007772 RID: 30578 RVA: 0x00324EF4 File Offset: 0x003230F4
	private bs9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007773 RID: 30579 RVA: 0x00324F00 File Offset: 0x00323100
	public override bool db()
	{
		return false;
	}

	// Token: 0x06007774 RID: 30580 RVA: 0x00324F04 File Offset: 0x00323104
	public override double? dc()
	{
		return new double?(0.55);
	}

	// Token: 0x06007775 RID: 30581 RVA: 0x00324F14 File Offset: 0x00323114
	public override bool dd()
	{
		return false;
	}

	// Token: 0x06007776 RID: 30582 RVA: 0x00324F18 File Offset: 0x00323118
	public bs9()
	{
	}

	// Token: 0x06007777 RID: 30583 RVA: 0x00324F20 File Offset: 0x00323120
	protected override string de()
	{
		return "objects\\traps\\blackDragonPoisonBearTrap";
	}

	// Token: 0x06007778 RID: 30584 RVA: 0x00324F28 File Offset: 0x00323128
	protected override string df()
	{
		return "ArmBearTrap";
	}

	// Token: 0x06007779 RID: 30585 RVA: 0x00324F30 File Offset: 0x00323130
	protected override string dg()
	{
		return "DisarmBearTrap";
	}

	// Token: 0x0600777A RID: 30586 RVA: 0x00324F38 File Offset: 0x00323138
	protected override Point dh(coh A_0)
	{
		return Point.Zero;
	}

	// Token: 0x0600777B RID: 30587 RVA: 0x00324F40 File Offset: 0x00323140
	protected override string di()
	{
		return "Капкан с ядом чёрного дракона";
	}

	// Token: 0x0600777C RID: 30588 RVA: 0x00324F48 File Offset: 0x00323148
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new b9j(A_0, A_1);
	}
}
