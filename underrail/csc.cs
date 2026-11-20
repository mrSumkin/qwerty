using System;
using System.Runtime.Serialization;

// Token: 0x02001AE9 RID: 6889
[eiz("HPS")]
[Serializable]
public sealed class csc : els, ISerializable
{
	// Token: 0x06009543 RID: 38211 RVA: 0x003A94D0 File Offset: 0x003A76D0
	private csc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009544 RID: 38212 RVA: 0x003A94DC File Offset: 0x003A76DC
	public csc(int A_0) : base(csc.a, "Гемопсихоз", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.Hemopsychosis";
	}

	// Token: 0x06009545 RID: 38213 RVA: 0x003A9504 File Offset: 0x003A7704
	public override string cb(ll A_0)
	{
		double num = 0.0;
		if (A_0 != null && A_0.a() != null)
		{
			num = (double)A_0.a().GetSpecializationValue<b70>(true) * b70.a;
		}
		if (num > 0.0)
		{
			return qv.a("StatusEffects/HemopsychosisReduced", new object[]
			{
				(int)(num * 100.0)
			});
		}
		return qv.b("StatusEffects/Hemopsychosis");
	}

	// Token: 0x04003975 RID: 14709
	public new static readonly string a = "Гемопсихоз";
}
