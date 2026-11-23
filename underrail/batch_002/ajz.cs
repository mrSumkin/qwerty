using System;
using System.Runtime.Serialization;

// Token: 0x02001B1B RID: 6939
[eiz("EMSE")]
[Serializable]
public sealed class ajz : els, ISerializable
{
	// Token: 0x06009625 RID: 38437 RVA: 0x003AC9AC File Offset: 0x003AABAC
	private ajz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("EMSE:E", typeof(a6z)) as a6z);
	}

	// Token: 0x06009626 RID: 38438 RVA: 0x003AC9D8 File Offset: 0x003AABD8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EMSE:E", this.b);
	}

	// Token: 0x06009627 RID: 38439 RVA: 0x003AC9F8 File Offset: 0x003AABF8
	public ajz(int A_0) : base(ajz.a, "Манёвр уворота", ci8.b)
	{
		base.Duration = enw.c * d0u.b;
		base.Icon = "EvasiveManeuvers";
		this.b = new a6z(A_0);
		base.StaticEffects.Add(this.b);
	}

	// Token: 0x06009628 RID: 38440 RVA: 0x003ACA50 File Offset: 0x003AAC50
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/EvasiveManeuvers", new object[]
		{
			this.b.c()
		});
	}

	// Token: 0x040039C6 RID: 14790
	public new static readonly string a = "evasiveManeuvers";

	// Token: 0x040039C7 RID: 14791
	private a6z b;
}
