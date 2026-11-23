using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001852 RID: 6226
[eiz("SAEAA")]
[Serializable]
public sealed class g1 : dvv, ISerializable
{
	// Token: 0x060084C5 RID: 33989 RVA: 0x003733B4 File Offset: 0x003715B4
	private g1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("SAEAA:E", typeof(EntityAspectReference<ny, ny>)) as EntityAspectReference<ny, ny>);
		this.b = (atp)A_0.GetValue("SAEAA:T", typeof(atp));
		this.c = (A_0.GetValue("SAEAA:A", typeof(cst)) as cst);
		this.d = A_0.GetBoolean("SAEAA:C");
	}

	// Token: 0x060084C6 RID: 33990 RVA: 0x0037343C File Offset: 0x0037163C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SAEAA:E", this.a);
		info.AddValue("SAEAA:T", this.b);
		info.AddValue("SAEAA:A", this.c);
		info.AddValue("SAEAA:C", this.d);
	}

	// Token: 0x060084C7 RID: 33991 RVA: 0x0037349C File Offset: 0x0037169C
	public g1(ny A_0, cst A_1, atp A_2 = atp.a, bool A_3 = false) : this(new EntityAspectReference<ny, ny>(A_0), A_1, A_2, A_3)
	{
	}

	// Token: 0x060084C8 RID: 33992 RVA: 0x003734B0 File Offset: 0x003716B0
	public g1(EntityAspectReference<ny, ny> A_0, cst A_1, atp A_2 = atp.a, bool A_3 = false)
	{
		this.a = A_0;
		this.b = A_2;
		this.c = A_1;
		this.d = A_3;
	}

	// Token: 0x060084C9 RID: 33993 RVA: 0x003734D8 File Offset: 0x003716D8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a != null && this.a.ao() != null && this.c != null)
		{
			this.a.ao().a(this.c, this.b, this.d, false);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x040032E1 RID: 13025
	private new EntityAspectReference<ny, ny> a;

	// Token: 0x040032E2 RID: 13026
	private atp b;

	// Token: 0x040032E3 RID: 13027
	private cst c;

	// Token: 0x040032E4 RID: 13028
	private bool d;
}
