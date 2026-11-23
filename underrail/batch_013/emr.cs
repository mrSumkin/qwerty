using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014C7 RID: 5319
[eiz("PBT5")]
[Serializable]
public sealed class emr : c11, ISerializable
{
	// Token: 0x060077A0 RID: 30624 RVA: 0x00325170 File Offset: 0x00323370
	private emr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060077A1 RID: 30625 RVA: 0x0032517C File Offset: 0x0032337C
	public override bool db()
	{
		return false;
	}

	// Token: 0x060077A2 RID: 30626 RVA: 0x00325180 File Offset: 0x00323380
	public override double? dc()
	{
		return new double?(0.55);
	}

	// Token: 0x060077A3 RID: 30627 RVA: 0x00325190 File Offset: 0x00323390
	public override bool dd()
	{
		return false;
	}

	// Token: 0x060077A4 RID: 30628 RVA: 0x00325194 File Offset: 0x00323394
	public emr()
	{
	}

	// Token: 0x060077A5 RID: 30629 RVA: 0x0032519C File Offset: 0x0032339C
	protected override string de()
	{
		return "objects\\traps\\poisonedBearTrap";
	}

	// Token: 0x060077A6 RID: 30630 RVA: 0x003251A4 File Offset: 0x003233A4
	protected override string df()
	{
		return "ArmBearTrap";
	}

	// Token: 0x060077A7 RID: 30631 RVA: 0x003251AC File Offset: 0x003233AC
	protected override string dg()
	{
		return "DisarmBearTrap";
	}

	// Token: 0x060077A8 RID: 30632 RVA: 0x003251B4 File Offset: 0x003233B4
	protected override Point dh(coh A_0)
	{
		return Point.Zero;
	}

	// Token: 0x060077A9 RID: 30633 RVA: 0x003251BC File Offset: 0x003233BC
	protected override string di()
	{
		return "Капкан с ядом могильщика";
	}

	// Token: 0x060077AA RID: 30634 RVA: 0x003251C4 File Offset: 0x003233C4
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new cfu(A_0, A_1);
	}
}
