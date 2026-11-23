using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014C9 RID: 5321
[eiz("BT5")]
[Serializable]
public sealed class buz : c11, ISerializable
{
	// Token: 0x060077B6 RID: 30646 RVA: 0x00325230 File Offset: 0x00323430
	private buz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060077B7 RID: 30647 RVA: 0x0032523C File Offset: 0x0032343C
	public override bool db()
	{
		return false;
	}

	// Token: 0x060077B8 RID: 30648 RVA: 0x00325240 File Offset: 0x00323440
	public override double? dc()
	{
		return new double?(0.55);
	}

	// Token: 0x060077B9 RID: 30649 RVA: 0x00325250 File Offset: 0x00323450
	public override bool dd()
	{
		return false;
	}

	// Token: 0x060077BA RID: 30650 RVA: 0x00325254 File Offset: 0x00323454
	public buz()
	{
	}

	// Token: 0x060077BB RID: 30651 RVA: 0x0032525C File Offset: 0x0032345C
	protected override string de()
	{
		return "objects\\traps\\bearTrap";
	}

	// Token: 0x060077BC RID: 30652 RVA: 0x00325264 File Offset: 0x00323464
	protected override string df()
	{
		return "ArmBearTrap";
	}

	// Token: 0x060077BD RID: 30653 RVA: 0x0032526C File Offset: 0x0032346C
	protected override string dg()
	{
		return "DisarmBearTrap";
	}

	// Token: 0x060077BE RID: 30654 RVA: 0x00325274 File Offset: 0x00323474
	protected override Point dh(coh A_0)
	{
		return Point.Zero;
	}

	// Token: 0x060077BF RID: 30655 RVA: 0x0032527C File Offset: 0x0032347C
	protected override string di()
	{
		return "Капкан";
	}

	// Token: 0x060077C0 RID: 30656 RVA: 0x00325284 File Offset: 0x00323484
	protected override cos dj(c5x A_0, coh A_1)
	{
		return new azv(A_0, A_1);
	}
}
