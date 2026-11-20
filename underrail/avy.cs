using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020011D7 RID: 4567
[eiz("BLO1")]
[Serializable]
public sealed class avy : ya, ISerializable, l2
{
	// Token: 0x060061FC RID: 25084 RVA: 0x002A7A7C File Offset: 0x002A5C7C
	private avy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("BLO1:E", typeof(EntityAspectReference<e1d, e1d>)) as EntityAspectReference<e1d, e1d>);
	}

	// Token: 0x060061FD RID: 25085 RVA: 0x002A7AA8 File Offset: 0x002A5CA8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BLO1:E", this.a);
	}

	// Token: 0x060061FE RID: 25086 RVA: 0x002A7AC4 File Offset: 0x002A5CC4
	public EntityAspectReference<e1d, e1d> a()
	{
		return this.a;
	}

	// Token: 0x060061FF RID: 25087 RVA: 0x002A7ACC File Offset: 0x002A5CCC
	public avy(e1d A_0)
	{
		if (A_0 != null)
		{
			this.a = new EntityAspectReference<e1d, e1d>(A_0);
		}
	}

	// Token: 0x06006200 RID: 25088 RVA: 0x002A7AEC File Offset: 0x002A5CEC
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && this.a != null && this.a.ao() != null)
		{
			this.a.ao().a(c5x);
		}
	}

	// Token: 0x06006201 RID: 25089 RVA: 0x002A7B3C File Offset: 0x002A5D3C
	public void jl(aud A_0)
	{
		if (this.a != null && this.a.afl() != null)
		{
			this.a = new EntityAspectReference<e1d, e1d>(A_0, this.a.afl().Value);
		}
	}

	// Token: 0x04002994 RID: 10644
	private EntityAspectReference<e1d, e1d> a;
}
