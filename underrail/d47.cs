using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020011E3 RID: 4579
[eiz("TCX2")]
[Serializable]
public sealed class d47 : ya, ISerializable, l2
{
	// Token: 0x06006244 RID: 25156 RVA: 0x002A861C File Offset: 0x002A681C
	private d47(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("TCX2:E", typeof(EntityAspectReference<zb, zb>)) as EntityAspectReference<zb, zb>);
	}

	// Token: 0x06006245 RID: 25157 RVA: 0x002A8648 File Offset: 0x002A6848
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TCX2:E", this.a);
	}

	// Token: 0x06006246 RID: 25158 RVA: 0x002A8664 File Offset: 0x002A6864
	public EntityAspectReference<zb, zb> a()
	{
		return this.a;
	}

	// Token: 0x06006247 RID: 25159 RVA: 0x002A866C File Offset: 0x002A686C
	public d47(zb A_0)
	{
		if (A_0 != null)
		{
			this.a = new EntityAspectReference<zb, zb>(A_0);
		}
	}

	// Token: 0x06006248 RID: 25160 RVA: 0x002A8688 File Offset: 0x002A6888
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && this.a != null && this.a.ao() != null)
		{
			this.a.ao().a(c5x);
		}
	}

	// Token: 0x06006249 RID: 25161 RVA: 0x002A86D8 File Offset: 0x002A68D8
	public void jl(aud A_0)
	{
		if (this.a != null && this.a.afl() != null)
		{
			this.a = new EntityAspectReference<zb, zb>(A_0, this.a.afl().Value);
		}
	}

	// Token: 0x040029A4 RID: 10660
	private EntityAspectReference<zb, zb> a;
}
