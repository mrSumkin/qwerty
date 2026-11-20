using System;
using System.Runtime.Serialization;

// Token: 0x020004AF RID: 1199
[eiz("SLS0")]
[Serializable]
public sealed class edf : ISerializable
{
	// Token: 0x06001E6B RID: 7787 RVA: 0x000A9894 File Offset: 0x000A7A94
	private edf(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetBoolean("SLS0:A");
		this.b = A_0.GetBoolean("SLS0:R");
		this.c = A_0.GetBoolean("SLS0:W");
		if (ell.a() >= 306)
		{
			this.d = A_0.GetBoolean("SLS0:L");
		}
	}

	// Token: 0x06001E6C RID: 7788 RVA: 0x000A9910 File Offset: 0x000A7B10
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SLS0:A", this.a);
		info.AddValue("SLS0:R", this.b);
		info.AddValue("SLS0:W", this.c);
		info.AddValue("SLS0:L", this.d);
	}

	// Token: 0x06001E6D RID: 7789 RVA: 0x000A9964 File Offset: 0x000A7B64
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06001E6E RID: 7790 RVA: 0x000A996C File Offset: 0x000A7B6C
	public void d(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001E6F RID: 7791 RVA: 0x000A9978 File Offset: 0x000A7B78
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06001E70 RID: 7792 RVA: 0x000A9980 File Offset: 0x000A7B80
	public void c(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001E71 RID: 7793 RVA: 0x000A998C File Offset: 0x000A7B8C
	public bool e()
	{
		return this.c;
	}

	// Token: 0x06001E72 RID: 7794 RVA: 0x000A9994 File Offset: 0x000A7B94
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001E73 RID: 7795 RVA: 0x000A99A0 File Offset: 0x000A7BA0
	public bool d()
	{
		return this.d;
	}

	// Token: 0x06001E74 RID: 7796 RVA: 0x000A99A8 File Offset: 0x000A7BA8
	public void b(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001E75 RID: 7797 RVA: 0x000A99B4 File Offset: 0x000A7BB4
	public edf()
	{
	}

	// Token: 0x06001E76 RID: 7798 RVA: 0x000A99D4 File Offset: 0x000A7BD4
	public edf a()
	{
		return new edf
		{
			a = this.a,
			b = this.b,
			c = this.c,
			d = this.d
		};
	}

	// Token: 0x04001366 RID: 4966
	private bool a = true;

	// Token: 0x04001367 RID: 4967
	private bool b = true;

	// Token: 0x04001368 RID: 4968
	private bool c = true;

	// Token: 0x04001369 RID: 4969
	private bool d;
}
