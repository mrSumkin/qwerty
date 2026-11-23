using System;
using System.Runtime.Serialization;

// Token: 0x02001B46 RID: 6982
[eiz("SSE")]
[Serializable]
public sealed class a7k : els, ISerializable
{
	// Token: 0x060096FE RID: 38654 RVA: 0x003AFBAC File Offset: 0x003ADDAC
	private a7k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060096FF RID: 38655 RVA: 0x003AFBBC File Offset: 0x003ADDBC
	public a7k(float A_0, int A_1) : base(a7k.a, "Спринт", ci8.b)
	{
		base.Icon = "Sprint";
		base.StaticEffects.Add(new i0(A_0, true, false, false));
		base.StaticEffects.Add(new ba(A_1, true, false, false));
	}

	// Token: 0x06009700 RID: 38656 RVA: 0x003AFC10 File Offset: 0x003ADE10
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Sprint", new object[]
		{
			(base.StaticEffects[1] as ba).a
		});
	}

	// Token: 0x04003A18 RID: 14872
	public new static readonly string a = "sprint";
}
