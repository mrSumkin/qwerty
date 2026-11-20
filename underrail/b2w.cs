using System;
using System.Runtime.Serialization;

// Token: 0x02001AB7 RID: 6839
[eiz("OSE")]
[Serializable]
public sealed class b2w : els, ISerializable
{
	// Token: 0x0600944E RID: 37966 RVA: 0x003A5E54 File Offset: 0x003A4054
	private b2w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600944F RID: 37967 RVA: 0x003A5E60 File Offset: 0x003A4060
	public b2w(int A_0, int A_1 = 0) : base(b2w.a, "Дозор", ci8.b)
	{
		base.Stacking = axm.b;
		base.Duration = A_1;
		base.Icon = "Misc.0";
		base.Power = A_0;
		base.StaticEffects.Add(new ap0());
	}

	// Token: 0x06009450 RID: 37968 RVA: 0x003A5EB0 File Offset: 0x003A40B0
	public override string cb(ll A_0)
	{
		return "";
	}

	// Token: 0x04003908 RID: 14600
	public new static readonly string a = "overwatch";
}
