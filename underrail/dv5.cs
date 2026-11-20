using System;
using System.Runtime.Serialization;

// Token: 0x02000079 RID: 121
[eiz("SI1")]
[Serializable]
public sealed class dv5 : ISerializable
{
	// Token: 0x06000276 RID: 630 RVA: 0x0000C4EC File Offset: 0x0000A6EC
	private dv5(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("SI1:I");
			this.b = A_0.GetString("SI1:N");
			this.c = A_0.GetString("SI1:SP");
			this.d = A_0.GetSingle("ST1:VM");
			if (ell.b() >= 32)
			{
				this.e = A_0.GetString("ST1:D");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(dv5))
			{
				this.a = A_0.GetString("_Id");
				this.b = A_0.GetString("_Name");
				this.c = A_0.GetString("_SourcePath");
				return;
			}
			this.a = A_0.GetString("SfxInfo+_Id");
			this.b = A_0.GetString("SfxInfo+_Name");
			this.c = A_0.GetString("SfxInfo+_SourcePath");
		}
	}

	// Token: 0x06000277 RID: 631 RVA: 0x0000C5F8 File Offset: 0x0000A7F8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SI1:I", this.a);
		info.AddValue("SI1:N", this.b);
		info.AddValue("SI1:SP", this.c);
		info.AddValue("ST1:VM", this.d);
		info.AddValue("ST1:D", this.e);
	}

	// Token: 0x06000278 RID: 632 RVA: 0x0000C65C File Offset: 0x0000A85C
	public string c()
	{
		return this.a;
	}

	// Token: 0x06000279 RID: 633 RVA: 0x0000C664 File Offset: 0x0000A864
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600027A RID: 634 RVA: 0x0000C670 File Offset: 0x0000A870
	public string d()
	{
		return this.b;
	}

	// Token: 0x0600027B RID: 635 RVA: 0x0000C678 File Offset: 0x0000A878
	public void c(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600027C RID: 636 RVA: 0x0000C684 File Offset: 0x0000A884
	public string b()
	{
		return this.c;
	}

	// Token: 0x0600027D RID: 637 RVA: 0x0000C68C File Offset: 0x0000A88C
	public void d(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600027E RID: 638 RVA: 0x0000C698 File Offset: 0x0000A898
	public float e()
	{
		return this.d;
	}

	// Token: 0x0600027F RID: 639 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
	public void a(float A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000280 RID: 640 RVA: 0x0000C6AC File Offset: 0x0000A8AC
	public string a()
	{
		return this.e;
	}

	// Token: 0x06000281 RID: 641 RVA: 0x0000C6B4 File Offset: 0x0000A8B4
	public void a(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
	public dv5()
	{
	}

	// Token: 0x040003AF RID: 943
	private string a;

	// Token: 0x040003B0 RID: 944
	private string b;

	// Token: 0x040003B1 RID: 945
	private string c;

	// Token: 0x040003B2 RID: 946
	private float d = 1f;

	// Token: 0x040003B3 RID: 947
	private string e;
}
