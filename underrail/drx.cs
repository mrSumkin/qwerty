using System;
using System.Runtime.Serialization;

// Token: 0x02001B35 RID: 6965
[eiz("CTSE")]
[Serializable]
public sealed class drx : els, ISerializable
{
	// Token: 0x060096A3 RID: 38563 RVA: 0x003AE3E4 File Offset: 0x003AC5E4
	private drx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("CTSE:MPRE", typeof(bxr)) as bxr);
	}

	// Token: 0x060096A4 RID: 38564 RVA: 0x003AE410 File Offset: 0x003AC610
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CTSE:MPRE", this.a);
	}

	// Token: 0x060096A5 RID: 38565 RVA: 0x003AE430 File Offset: 0x003AC630
	public drx() : base("cerebralTrauma", "Мозговая травма", ci8.c)
	{
		base.Icon = "Status.4";
		base.MaxStacks = 3;
		base.Stacking = axm.b;
		this.a = new bxr(0.0)
		{
			Priority = int.MaxValue
		};
		base.StaticEffects.Add(this.a);
		this.a();
	}

	// Token: 0x060096A6 RID: 38566 RVA: 0x003AE4A0 File Offset: 0x003AC6A0
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/CerebralTrauma", new object[]
		{
			(int)Math.Abs(this.a.a() * 100.0)
		});
	}

	// Token: 0x060096A7 RID: 38567 RVA: 0x003AE4D8 File Offset: 0x003AC6D8
	protected override void c8()
	{
		base.c8();
		this.a();
	}

	// Token: 0x060096A8 RID: 38568 RVA: 0x003AE4E8 File Offset: 0x003AC6E8
	protected override void dp()
	{
		base.dp();
		this.a();
	}

	// Token: 0x060096A9 RID: 38569 RVA: 0x003AE4F8 File Offset: 0x003AC6F8
	private void a()
	{
	}

	// Token: 0x040039F2 RID: 14834
	private new bxr a;
}
