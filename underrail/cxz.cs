using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200101A RID: 4122
[eiz("XJL")]
[Serializable]
public sealed class cxz : cze
{
	// Token: 0x0600550C RID: 21772 RVA: 0x0025A430 File Offset: 0x00258630
	private cxz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("XJL:J");
	}

	// Token: 0x0600550D RID: 21773 RVA: 0x0025A44C File Offset: 0x0025864C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XJL:J", this.a);
	}

	// Token: 0x0600550E RID: 21774 RVA: 0x0025A468 File Offset: 0x00258668
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600550F RID: 21775 RVA: 0x0025A470 File Offset: 0x00258670
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005510 RID: 21776 RVA: 0x0025A47C File Offset: 0x0025867C
	public cxz()
	{
	}

	// Token: 0x06005511 RID: 21777 RVA: 0x0025A484 File Offset: 0x00258684
	public cxz(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005512 RID: 21778 RVA: 0x0025A498 File Offset: 0x00258698
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			af7 af = ea5.b(this.a);
			if (af != null)
			{
				af(A_0 as c5x, A_1 as c5x, A_2);
			}
		}
	}

	// Token: 0x040022B2 RID: 8882
	private new string a;
}
