using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200101E RID: 4126
[eiz("SAJ")]
[Serializable]
public sealed class ds7 : cze
{
	// Token: 0x06005519 RID: 21785 RVA: 0x0025A4F4 File Offset: 0x002586F4
	private ds7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SAJ:T");
	}

	// Token: 0x0600551A RID: 21786 RVA: 0x0025A510 File Offset: 0x00258710
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SAJ:T", this.a);
	}

	// Token: 0x0600551B RID: 21787 RVA: 0x0025A52C File Offset: 0x0025872C
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600551C RID: 21788 RVA: 0x0025A534 File Offset: 0x00258734
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600551D RID: 21789 RVA: 0x0025A540 File Offset: 0x00258740
	public ds7()
	{
	}

	// Token: 0x0600551E RID: 21790 RVA: 0x0025A548 File Offset: 0x00258748
	public ds7(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600551F RID: 21791 RVA: 0x0025A558 File Offset: 0x00258758
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			cxc.c(this.a);
		}
	}

	// Token: 0x040022B4 RID: 8884
	private new string a;
}
