using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020011DD RID: 4573
[eiz("RCX9")]
[Serializable]
public sealed class s8 : ya, ISerializable, l2
{
	// Token: 0x0600621A RID: 25114 RVA: 0x002A7E28 File Offset: 0x002A6028
	private s8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("RCX9:E", typeof(EntityAspectReference<d16, d16>)) as EntityAspectReference<d16, d16>);
	}

	// Token: 0x0600621B RID: 25115 RVA: 0x002A7E54 File Offset: 0x002A6054
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RCX9:E", this.a);
	}

	// Token: 0x0600621C RID: 25116 RVA: 0x002A7E70 File Offset: 0x002A6070
	public EntityAspectReference<d16, d16> a()
	{
		return this.a;
	}

	// Token: 0x0600621D RID: 25117 RVA: 0x002A7E78 File Offset: 0x002A6078
	public s8(d16 A_0)
	{
		if (A_0 != null)
		{
			this.a = new EntityAspectReference<d16, d16>(A_0);
		}
	}

	// Token: 0x0600621E RID: 25118 RVA: 0x002A7E94 File Offset: 0x002A6094
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && this.a != null && this.a.ao() != null)
		{
			this.a.ao().a(c5x);
		}
	}

	// Token: 0x0600621F RID: 25119 RVA: 0x002A7EE4 File Offset: 0x002A60E4
	public void jl(aud A_0)
	{
		if (this.a != null && this.a.afl() != null)
		{
			this.a = new EntityAspectReference<d16, d16>(A_0, this.a.afl().Value);
		}
	}

	// Token: 0x0400299A RID: 10650
	private EntityAspectReference<d16, d16> a;
}
