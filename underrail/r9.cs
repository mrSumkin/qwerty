using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AA2 RID: 6818
[eiz("CDSE")]
[Serializable]
public sealed class r9 : els, ISerializable
{
	// Token: 0x060093F1 RID: 37873 RVA: 0x003A468C File Offset: 0x003A288C
	private r9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.d = (A_0.GetValue("CDSE:E", typeof(e3r)) as e3r);
	}

	// Token: 0x060093F2 RID: 37874 RVA: 0x003A46B8 File Offset: 0x003A28B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CDSE:E", this.d);
	}

	// Token: 0x060093F3 RID: 37875 RVA: 0x003A46D8 File Offset: 0x003A28D8
	public r9(DamageType A_0) : base("chemicalDestabilization:" + A_0.ToString(), "Химическая неустойчивость: " + A_0.ToString(), ci8.c)
	{
		base.MaxStacks = r9.b;
		base.Duration = r9.c * d0u.b;
		base.Icon = "Status.ChemicalDestabilization." + A_0.ToString();
		this.d = new e3r(A_0, r9.a * (double)base.Stacks);
		base.StaticEffects.Add(this.d);
	}

	// Token: 0x060093F4 RID: 37876 RVA: 0x003A4780 File Offset: 0x003A2980
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/ChemicalDestabilization", new object[]
		{
			(int)(this.d.Value * 100.0),
			this.d.DamageType.ToString().ToLowerInvariant()
		});
	}

	// Token: 0x060093F5 RID: 37877 RVA: 0x003A47DC File Offset: 0x003A29DC
	protected override void c8()
	{
		this.d.Value = r9.a * (double)base.Stacks;
	}

	// Token: 0x040038DA RID: 14554
	public new static readonly double a = 0.25;

	// Token: 0x040038DB RID: 14555
	public static readonly int b = 2;

	// Token: 0x040038DC RID: 14556
	public new static readonly int c = 2;

	// Token: 0x040038DD RID: 14557
	private new e3r d;
}
