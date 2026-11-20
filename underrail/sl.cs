using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020011E2 RID: 4578
[eiz("CCX9")]
[Serializable]
public sealed class sl : ya, ISerializable, l2
{
	// Token: 0x0600623E RID: 25150 RVA: 0x002A850C File Offset: 0x002A670C
	private sl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("CCX9:E", typeof(EntityAspectReference<ey7, ey7>)) as EntityAspectReference<ey7, ey7>);
	}

	// Token: 0x0600623F RID: 25151 RVA: 0x002A8538 File Offset: 0x002A6738
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCX9:E", this.a);
	}

	// Token: 0x06006240 RID: 25152 RVA: 0x002A8554 File Offset: 0x002A6754
	public EntityAspectReference<ey7, ey7> a()
	{
		return this.a;
	}

	// Token: 0x06006241 RID: 25153 RVA: 0x002A855C File Offset: 0x002A675C
	public sl(ey7 A_0)
	{
		if (A_0 != null)
		{
			this.a = new EntityAspectReference<ey7, ey7>(A_0);
		}
	}

	// Token: 0x06006242 RID: 25154 RVA: 0x002A857C File Offset: 0x002A677C
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && this.a != null && this.a.ao() != null)
		{
			this.a.ao().a(c5x);
		}
	}

	// Token: 0x06006243 RID: 25155 RVA: 0x002A85CC File Offset: 0x002A67CC
	public void jl(aud A_0)
	{
		if (this.a != null && this.a.afl() != null)
		{
			this.a = new EntityAspectReference<ey7, ey7>(A_0, this.a.afl().Value);
		}
	}

	// Token: 0x040029A3 RID: 10659
	private EntityAspectReference<ey7, ey7> a;
}
