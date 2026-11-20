using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020011E8 RID: 4584
[eiz("GST")]
[Serializable]
public sealed class djd : ya, ISerializable, l2
{
	// Token: 0x0600625F RID: 25183 RVA: 0x002A8BF0 File Offset: 0x002A6DF0
	private djd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("GST:E", typeof(EntityAspectReference<cry, cry>)) as EntityAspectReference<cry, cry>);
		this.b = A_0.GetString("GST:C");
	}

	// Token: 0x06006260 RID: 25184 RVA: 0x002A8C2C File Offset: 0x002A6E2C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GST:E", this.a);
		info.AddValue("GST:C", this.b);
	}

	// Token: 0x06006261 RID: 25185 RVA: 0x002A8C58 File Offset: 0x002A6E58
	public EntityAspectReference<cry, cry> b()
	{
		return this.a;
	}

	// Token: 0x06006262 RID: 25186 RVA: 0x002A8C60 File Offset: 0x002A6E60
	public string a()
	{
		return this.b;
	}

	// Token: 0x06006263 RID: 25187 RVA: 0x002A8C68 File Offset: 0x002A6E68
	public djd(cry A_0, string A_1)
	{
		if (A_0 != null)
		{
			this.a = new EntityAspectReference<cry, cry>(A_0);
		}
		this.b = A_1;
	}

	// Token: 0x06006264 RID: 25188 RVA: 0x002A8C8C File Offset: 0x002A6E8C
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && this.a != null && this.a.ao() != null)
		{
			this.a.ao().gx(c5x);
		}
	}

	// Token: 0x06006265 RID: 25189 RVA: 0x002A8CDC File Offset: 0x002A6EDC
	public void jl(aud A_0)
	{
		if (this.a != null && this.a.afl() != null)
		{
			this.a = new EntityAspectReference<cry, cry>(A_0, this.a.afl().Value);
		}
	}

	// Token: 0x040029A9 RID: 10665
	private EntityAspectReference<cry, cry> a;

	// Token: 0x040029AA RID: 10666
	private string b;
}
