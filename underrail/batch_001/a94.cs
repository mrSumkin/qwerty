using System;
using System.Runtime.Serialization;

// Token: 0x020004B2 RID: 1202
[eiz("GS")]
[Serializable]
public sealed class a94 : ISerializable
{
	// Token: 0x06001E7F RID: 7807 RVA: 0x000A9DA0 File Offset: 0x000A7FA0
	private a94(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() >= 229)
		{
			this.a = A_0.GetBoolean("GS:A");
		}
		else
		{
			this.a = true;
		}
		if (ell.a() >= 239)
		{
			this.b = A_0.GetBoolean("GS:T");
		}
		if (ell.a() >= 244)
		{
			this.c = A_0.GetBoolean("GS:C");
		}
		else
		{
			this.c = true;
		}
		if (ell.a() >= 331)
		{
			this.d = Math.Min(5f, A_0.GetSingle("GS:M"));
			this.e = Math.Min(5f, A_0.GetSingle("GS:S"));
		}
		else
		{
			this.d = 2f;
			this.e = 1f;
		}
		if (ell.a() >= 695)
		{
			this.f = A_0.GetString("GS:L");
		}
	}

	// Token: 0x06001E80 RID: 7808 RVA: 0x000A9EC8 File Offset: 0x000A80C8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("GS:A", this.a);
		info.AddValue("GS:T", this.b);
		info.AddValue("GS:C", this.c);
		info.AddValue("GS:M", this.d);
		info.AddValue("GS:S", this.e);
		info.AddValue("GS:L", this.f);
	}

	// Token: 0x06001E81 RID: 7809 RVA: 0x000A9F3C File Offset: 0x000A813C
	public bool d()
	{
		return this.a;
	}

	// Token: 0x06001E82 RID: 7810 RVA: 0x000A9F44 File Offset: 0x000A8144
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001E83 RID: 7811 RVA: 0x000A9F50 File Offset: 0x000A8150
	public bool c()
	{
		return this.b;
	}

	// Token: 0x06001E84 RID: 7812 RVA: 0x000A9F58 File Offset: 0x000A8158
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001E85 RID: 7813 RVA: 0x000A9F64 File Offset: 0x000A8164
	public bool g()
	{
		return this.c;
	}

	// Token: 0x06001E86 RID: 7814 RVA: 0x000A9F6C File Offset: 0x000A816C
	public void c(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001E87 RID: 7815 RVA: 0x000A9F78 File Offset: 0x000A8178
	public float e()
	{
		return this.d;
	}

	// Token: 0x06001E88 RID: 7816 RVA: 0x000A9F80 File Offset: 0x000A8180
	public void b(float A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001E89 RID: 7817 RVA: 0x000A9F8C File Offset: 0x000A818C
	public float f()
	{
		return this.e;
	}

	// Token: 0x06001E8A RID: 7818 RVA: 0x000A9F94 File Offset: 0x000A8194
	public void a(float A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06001E8B RID: 7819 RVA: 0x000A9FA0 File Offset: 0x000A81A0
	public string a()
	{
		return this.f;
	}

	// Token: 0x06001E8C RID: 7820 RVA: 0x000A9FA8 File Offset: 0x000A81A8
	public void a(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06001E8D RID: 7821 RVA: 0x000A9FB4 File Offset: 0x000A81B4
	public a94()
	{
	}

	// Token: 0x06001E8E RID: 7822 RVA: 0x000A9FDC File Offset: 0x000A81DC
	public a94 b()
	{
		return new a94
		{
			a = this.a,
			b = this.b,
			c = this.c,
			d = this.d,
			e = this.e,
			f = this.f
		};
	}

	// Token: 0x04001373 RID: 4979
	private bool a;

	// Token: 0x04001374 RID: 4980
	private bool b;

	// Token: 0x04001375 RID: 4981
	private bool c = true;

	// Token: 0x04001376 RID: 4982
	private float d = 2f;

	// Token: 0x04001377 RID: 4983
	private float e = 1f;

	// Token: 0x04001378 RID: 4984
	private string f;
}
