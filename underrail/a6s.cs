using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200132C RID: 4908
[eiz("WIC")]
[Serializable]
public sealed class a6s : dvv, ISerializable
{
	// Token: 0x06006F34 RID: 28468 RVA: 0x002EB208 File Offset: 0x002E9408
	private a6s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("WIC:T");
		this.c = A_0.GetDouble("WIC:C");
		this.b = (A_0.GetValue("WIC:I", typeof(EntityAspectReference<bm6, bm6>)) as EntityAspectReference<bm6, bm6>);
	}

	// Token: 0x06006F35 RID: 28469 RVA: 0x002EB260 File Offset: 0x002E9460
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("WIC:T", this.a);
		info.AddValue("WIC:C", this.c);
		info.AddValue("WIC:I", this.b);
	}

	// Token: 0x06006F36 RID: 28470 RVA: 0x002EB2A8 File Offset: 0x002E94A8
	public a6s(bm6 A_0, int A_1 = 0)
	{
		this.b = new EntityAspectReference<bm6, bm6>(A_0);
		this.a = A_1;
	}

	// Token: 0x06006F37 RID: 28471 RVA: 0x002EB2C4 File Offset: 0x002E94C4
	protected override dc4 dt()
	{
		if (this.b.ao() == null)
		{
			return dc4.e;
		}
		this.c = (double)this.a;
		return dc4.b;
	}

	// Token: 0x06006F38 RID: 28472 RVA: 0x002EB2EC File Offset: 0x002E94EC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a > 0 && (this.c -= A_1.TotalMilliseconds) <= 0.0)
		{
			return dc4.e;
		}
		if (this.b.ao() == null)
		{
			return dc4.e;
		}
		if (!this.b.ao().v())
		{
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x04002D79 RID: 11641
	private new int a;

	// Token: 0x04002D7A RID: 11642
	private EntityAspectReference<bm6, bm6> b;

	// Token: 0x04002D7B RID: 11643
	private double c;
}
