using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020011E6 RID: 4582
[eiz("BGT")]
[Serializable]
public sealed class oe : ya, ISerializable, l2
{
	// Token: 0x06006251 RID: 25169 RVA: 0x002A8834 File Offset: 0x002A6A34
	private oe(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("BGT:E", typeof(EntityAspectReference<dd9, dd9>)) as EntityAspectReference<dd9, dd9>);
	}

	// Token: 0x06006252 RID: 25170 RVA: 0x002A8860 File Offset: 0x002A6A60
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BGT:E", this.a);
	}

	// Token: 0x06006253 RID: 25171 RVA: 0x002A887C File Offset: 0x002A6A7C
	public EntityAspectReference<dd9, dd9> a()
	{
		return this.a;
	}

	// Token: 0x06006254 RID: 25172 RVA: 0x002A8884 File Offset: 0x002A6A84
	public oe(dd9 A_0)
	{
		if (A_0 != null)
		{
			this.a = new EntityAspectReference<dd9, dd9>(A_0);
		}
	}

	// Token: 0x06006255 RID: 25173 RVA: 0x002A88A0 File Offset: 0x002A6AA0
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && this.a != null && this.a.ao() != null)
		{
			this.a.ao().a(c5x);
		}
	}

	// Token: 0x06006256 RID: 25174 RVA: 0x002A88F0 File Offset: 0x002A6AF0
	public void jl(aud A_0)
	{
		if (this.a != null && this.a.afl() != null)
		{
			this.a = new EntityAspectReference<dd9, dd9>(A_0, this.a.afl().Value);
		}
	}

	// Token: 0x040029A6 RID: 10662
	private EntityAspectReference<dd9, dd9> a;
}
