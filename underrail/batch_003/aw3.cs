using System;
using System.Runtime.Serialization;

// Token: 0x02001AD7 RID: 6871
[eiz("TIMB")]
[Serializable]
public sealed class aw3 : els, ISerializable
{
	// Token: 0x060094EC RID: 38124 RVA: 0x003A8088 File Offset: 0x003A6288
	private aw3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094ED RID: 38125 RVA: 0x003A8094 File Offset: 0x003A6294
	public override bool sk()
	{
		return false;
	}

	// Token: 0x060094EE RID: 38126 RVA: 0x003A8098 File Offset: 0x003A6298
	public aw3(int A_0) : base(aw3.a, "Обездвиженность", ci8.c)
	{
		base.Icon = "Misc.0";
		base.Silent = true;
		base.Duration = A_0;
		base.StaticEffects.Add(new ap0());
	}

	// Token: 0x060094EF RID: 38127 RVA: 0x003A80E0 File Offset: 0x003A62E0
	public override string cb(ll A_0)
	{
		return "InvisiblyImmobilized";
	}

	// Token: 0x0400395A RID: 14682
	public new static readonly string a = "invisiblyImmobilized";
}
