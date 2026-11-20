using System;
using System.Runtime.Serialization;

// Token: 0x02001ABD RID: 6845
[eiz("VESE")]
[Serializable]
public sealed class cyf : els, ISerializable
{
	// Token: 0x06009468 RID: 37992 RVA: 0x003A6364 File Offset: 0x003A4564
	private cyf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009469 RID: 37993 RVA: 0x003A6370 File Offset: 0x003A4570
	public override bool sk()
	{
		return false;
	}

	// Token: 0x0600946A RID: 37994 RVA: 0x003A6374 File Offset: 0x003A4574
	public cyf(int A_0) : base(cyf.a, "Пустое ведро", ci8.a)
	{
		base.VisualEffects.Add(new ud(this, "VoidMist"));
		base.Icon = "Misc.0";
		base.Silent = true;
		base.Duration = A_0;
	}

	// Token: 0x0600946B RID: 37995 RVA: 0x003A63C4 File Offset: 0x003A45C4
	public override string cb(ll A_0)
	{
		return string.Empty;
	}

	// Token: 0x04003911 RID: 14609
	public new static readonly string a = "voidEssence";
}
