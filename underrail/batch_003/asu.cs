using System;
using System.Runtime.Serialization;

// Token: 0x02001A76 RID: 6774
[eiz("DLSE")]
[Serializable]
public sealed class asu : els, ISerializable
{
	// Token: 0x0600931B RID: 37659 RVA: 0x003A1368 File Offset: 0x0039F568
	private asu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600931C RID: 37660 RVA: 0x003A1378 File Offset: 0x0039F578
	public asu() : base(asu.a, "Лазерное наведение", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Status.132";
		base.Stacking = axm.b;
		base.VisualEffects.Add(new ud(this, "DesignatorLaser"));
	}

	// Token: 0x0600931D RID: 37661 RVA: 0x003A13C8 File Offset: 0x0039F5C8
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/DesignatorLaser");
	}

	// Token: 0x0400387B RID: 14459
	public new static readonly string a = "designatorLaser";
}
