using System;
using System.Runtime.Serialization;

// Token: 0x02001A80 RID: 6784
[eiz("YCUSE")]
[Serializable]
public sealed class c32 : els, ISerializable
{
	// Token: 0x06009351 RID: 37713 RVA: 0x003A1E60 File Offset: 0x003A0060
	private c32(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x1700026F RID: 623
	// (get) Token: 0x06009352 RID: 37714 RVA: 0x003A1E6C File Offset: 0x003A006C
	public override bool Visible
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06009353 RID: 37715 RVA: 0x003A1E70 File Offset: 0x003A0070
	public c32(int A_0, string A_1) : base(c32.a, "uch", ci8.a)
	{
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Misc.0";
		base.Stacking = axm.b;
		this.b = A_1;
	}

	// Token: 0x06009354 RID: 37716 RVA: 0x003A1EBC File Offset: 0x003A00BC
	public override string cb(ll A_0)
	{
		return "";
	}

	// Token: 0x04003889 RID: 14473
	public new static readonly string a = "uch";

	// Token: 0x0400388A RID: 14474
	public string b;
}
