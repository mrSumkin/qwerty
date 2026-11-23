using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014C8 RID: 5320
[eiz("PBT6")]
[Serializable]
public sealed class co : c11, ISerializable
{
	// Token: 0x060077AB RID: 30635 RVA: 0x003251D0 File Offset: 0x003233D0
	private co(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060077AC RID: 30636 RVA: 0x003251DC File Offset: 0x003233DC
	public override bool db()
	{
		return false;
	}

	// Token: 0x060077AD RID: 30637 RVA: 0x003251E0 File Offset: 0x003233E0
	public override double? dc()
	{
		return new double?(0.55);
	}

	// Token: 0x060077AE RID: 30638 RVA: 0x003251F0 File Offset: 0x003233F0
	public override bool dd()
	{
		return false;
	}

	// Token: 0x060077AF RID: 30639 RVA: 0x003251F4 File Offset: 0x003233F4
	public co()
	{
	}

	// Token: 0x060077B0 RID: 30640 RVA: 0x003251FC File Offset: 0x003233FC
	protected override string de()
	{
		return "objects\\traps\\caveEarPoisonBearTrap";
	}

	// Token: 0x060077B1 RID: 30641 RVA: 0x00325204 File Offset: 0x00323404
	protected override string df()
	{
		return "ArmBearTrap";
	}

	// Token: 0x060077B2 RID: 30642 RVA: 0x0032520C File Offset: 0x0032340C
	protected override string dg()
	{
		return "DisarmBearTrap";
	}

	// Token: 0x060077B3 RID: 30643 RVA: 0x00325214 File Offset: 0x00323414
	protected override Point dh(coh A_0)
	{
		return Point.Zero;
	}

	// Token: 0x060077B4 RID: 30644 RVA: 0x0032521C File Offset: 0x0032341C
	protected override string di()
	{
		return "Капкан с ядом пещерного уха";
	}

	// Token: 0x060077B5 RID: 30645 RVA: 0x00325224 File Offset: 0x00323424
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new ex5(A_0, A_1);
	}
}
