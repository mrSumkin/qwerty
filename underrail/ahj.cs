using System;
using System.Runtime.Serialization;

// Token: 0x02000C66 RID: 3174
[eiz("DLCIIC")]
[Serializable]
public sealed class ahj : dnh
{
	// Token: 0x06004765 RID: 18277 RVA: 0x001D7370 File Offset: 0x001D5570
	private ahj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("DLCIIC");
		if (ell.a() >= 665)
		{
			this.b = A_0.GetBoolean("DLCIIC:I");
		}
	}

	// Token: 0x06004766 RID: 18278 RVA: 0x001D73AC File Offset: 0x001D55AC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DLCIIC", this.a);
		info.AddValue("DLCIIC:I", this.b);
	}

	// Token: 0x06004767 RID: 18279 RVA: 0x001D73D8 File Offset: 0x001D55D8
	public string a()
	{
		return this.a;
	}

	// Token: 0x06004768 RID: 18280 RVA: 0x001D73E0 File Offset: 0x001D55E0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004769 RID: 18281 RVA: 0x001D73EC File Offset: 0x001D55EC
	public bool c()
	{
		return this.b;
	}

	// Token: 0x0600476A RID: 18282 RVA: 0x001D73F4 File Offset: 0x001D55F4
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600476B RID: 18283 RVA: 0x001D7400 File Offset: 0x001D5600
	public ahj()
	{
	}

	// Token: 0x0600476C RID: 18284 RVA: 0x001D740C File Offset: 0x001D560C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		if (!string.IsNullOrEmpty(this.a))
		{
			flag = dk2.b(this.a);
		}
		return flag ^ this.b;
	}

	// Token: 0x0600476D RID: 18285 RVA: 0x001D7440 File Offset: 0x001D5640
	public string b()
	{
		return null;
	}

	// Token: 0x04001C96 RID: 7318
	private string a;

	// Token: 0x04001C97 RID: 7319
	private bool b;
}
