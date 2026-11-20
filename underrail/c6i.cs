using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000C6B RID: 3179
[eiz("SGSCAC")]
[Serializable]
public sealed class c6i : dnh
{
	// Token: 0x06004787 RID: 18311 RVA: 0x001D77D4 File Offset: 0x001D59D4
	private c6i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SGSCAC:C");
	}

	// Token: 0x06004788 RID: 18312 RVA: 0x001D77F0 File Offset: 0x001D59F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGSCAC:C", this.a);
	}

	// Token: 0x06004789 RID: 18313 RVA: 0x001D780C File Offset: 0x001D5A0C
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600478A RID: 18314 RVA: 0x001D7814 File Offset: 0x001D5A14
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600478B RID: 18315 RVA: 0x001D7820 File Offset: 0x001D5A20
	public c6i()
	{
	}

	// Token: 0x0600478C RID: 18316 RVA: 0x001D782C File Offset: 0x001D5A2C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			HashSet<string> classPropertyValue = A_1.GetClassPropertyValue<HashSet<string>>("clueList");
			if (classPropertyValue != null)
			{
				return !classPropertyValue.Contains(this.a.ToUpperInvariant());
			}
		}
		return true;
	}

	// Token: 0x04001C9D RID: 7325
	private string a;
}
