using System;
using System.Runtime.Serialization;

// Token: 0x02001A9E RID: 6814
[eiz("BLSE")]
[Serializable]
public sealed class ak3 : els, ISerializable, bab
{
	// Token: 0x060093DC RID: 37852 RVA: 0x003A417C File Offset: 0x003A237C
	private ak3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093DD RID: 37853 RVA: 0x003A4188 File Offset: 0x003A2388
	public ak3(int A_0) : base(ak3.a, "Неожиданный удар", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.Blindsiding";
	}

	// Token: 0x060093DE RID: 37854 RVA: 0x003A41B0 File Offset: 0x003A23B0
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Blindsiding", new object[]
		{
			(int)(oh.a((A_0 != null) ? A_0.a() : null) * 100.0)
		});
	}

	// Token: 0x060093DF RID: 37855 RVA: 0x003A41F8 File Offset: 0x003A23F8
	public bool pv(a8s A_0)
	{
		if (A_0 is e5b)
		{
			base.Duration = d0u.b;
			base.TimeLeft = (double)d0u.b;
			return true;
		}
		return false;
	}

	// Token: 0x040038D1 RID: 14545
	public new static readonly string a = "Неожиданный удар";
}
