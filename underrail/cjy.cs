using System;
using System.Runtime.Serialization;

// Token: 0x02001B3B RID: 6971
[eiz("ISE1")]
[Serializable]
public sealed class cjy : els, ISerializable
{
	// Token: 0x060096C3 RID: 38595 RVA: 0x003AEBAC File Offset: 0x003ACDAC
	private cjy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060096C4 RID: 38596 RVA: 0x003AEBB8 File Offset: 0x003ACDB8
	public cjy(int A_0) : base("incapacitated", "Ошеломление", ci8.c)
	{
		base.Duration = A_0;
		base.TickPeriod = 0;
		base.Icon = "Status.3";
		base.VisualEffects.Add(new ud(this, "Incapacitated"));
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ax2());
	}

	// Token: 0x060096C5 RID: 38597 RVA: 0x003AEC1C File Offset: 0x003ACE1C
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Incapacitated");
	}
}
