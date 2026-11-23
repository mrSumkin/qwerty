using System;
using System.Runtime.Serialization;

// Token: 0x02001B10 RID: 6928
[eiz("QTS")]
[Serializable]
public sealed class a4l : els, ISerializable
{
	// Token: 0x060095F6 RID: 38390 RVA: 0x003ABF10 File Offset: 0x003AA110
	private a4l(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095F7 RID: 38391 RVA: 0x003ABF1C File Offset: 0x003AA11C
	public a4l(int A_0) : base(a4l.a, "Быстрый взвод", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "QuickTinkering";
	}

	// Token: 0x060095F8 RID: 38392 RVA: 0x003ABF44 File Offset: 0x003AA144
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/QuickTinkering", new object[]
		{
			dg1.a((A_0 != null) ? A_0.a() : null)
		});
	}

	// Token: 0x040039B6 RID: 14774
	public new static readonly string a = "quickTinkering";
}
