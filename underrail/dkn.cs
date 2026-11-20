using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020011D3 RID: 4563
[eiz("SGWBT")]
[Serializable]
public sealed class dkn : ya, ISerializable, l2
{
	// Token: 0x060061EA RID: 25066 RVA: 0x002A780C File Offset: 0x002A5A0C
	private dkn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("SGWBT:E", typeof(EntityAspectReference<e6o, e6o>)) as EntityAspectReference<e6o, e6o>);
	}

	// Token: 0x060061EB RID: 25067 RVA: 0x002A7838 File Offset: 0x002A5A38
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGWBT:E", this.a);
	}

	// Token: 0x060061EC RID: 25068 RVA: 0x002A7854 File Offset: 0x002A5A54
	public EntityAspectReference<e6o, e6o> a()
	{
		return this.a;
	}

	// Token: 0x060061ED RID: 25069 RVA: 0x002A785C File Offset: 0x002A5A5C
	public dkn(e6o A_0)
	{
		if (A_0 != null)
		{
			this.a = new EntityAspectReference<e6o, e6o>(A_0);
		}
	}

	// Token: 0x060061EE RID: 25070 RVA: 0x002A7878 File Offset: 0x002A5A78
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && this.a != null && this.a.ao() != null)
		{
			this.a.ao().a(c5x);
		}
	}

	// Token: 0x060061EF RID: 25071 RVA: 0x002A78C8 File Offset: 0x002A5AC8
	public void jl(aud A_0)
	{
		if (this.a != null && this.a.afl() != null)
		{
			this.a = new EntityAspectReference<e6o, e6o>(A_0, this.a.afl().Value);
		}
	}

	// Token: 0x04002991 RID: 10641
	private EntityAspectReference<e6o, e6o> a;
}
