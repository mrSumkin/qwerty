using System;
using System.Runtime.Serialization;

// Token: 0x02001A98 RID: 6808
[eiz("CFSE")]
[Serializable]
public sealed class b3i : els, ISerializable
{
	// Token: 0x060093C2 RID: 37826 RVA: 0x003A3C64 File Offset: 0x003A1E64
	private b3i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 394)
		{
			this.b = A_0.GetInt32("CFSE:S");
		}
	}

	// Token: 0x060093C3 RID: 37827 RVA: 0x003A3C90 File Offset: 0x003A1E90
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CFSE:S", this.b);
	}

	// Token: 0x17000274 RID: 628
	// (get) Token: 0x060093C4 RID: 37828 RVA: 0x003A3CAC File Offset: 0x003A1EAC
	public int Spec
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x060093C5 RID: 37829 RVA: 0x003A3CB4 File Offset: 0x003A1EB4
	public b3i(int A_0) : base(b3i.a, "Плотный огонь", ci8.c)
	{
		this.b = A_0;
		base.Power = this.b;
		base.Duration = d0u.b;
		base.Icon = "Status.ConcentratedFire";
		base.MaxStacks = c12.a;
		base.Stacking = axm.b;
	}

	// Token: 0x060093C6 RID: 37830 RVA: 0x003A3D10 File Offset: 0x003A1F10
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/ConcentratedFire", new object[]
		{
			(int)((double)base.Stacks * (c12.b + (double)this.b * enf.a) * 100.0)
		});
	}

	// Token: 0x040038C7 RID: 14535
	public new static readonly string a = "concentratedFire";

	// Token: 0x040038C8 RID: 14536
	private int b;
}
