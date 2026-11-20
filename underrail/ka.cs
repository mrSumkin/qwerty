using System;
using System.IO;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Space;

// Token: 0x020012C5 RID: 4805
[eiz("BOE")]
[Serializable]
public sealed class ka : Aspect<c5x>, ISerializable, c02
{
	// Token: 0x06006A06 RID: 27142 RVA: 0x002CB93C File Offset: 0x002C9B3C
	private ka(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("BOE:L");
		this.b = A_0.GetString("BOE:T");
		this.c = A_0.GetInt32("BOE:M");
		this.d = A_0.GetInt32("BOE:F");
		this.e = A_0.GetString("BOE:V");
		this.f = A_0.GetBoolean("BOE:O");
		if (ell.a() >= 180)
		{
			this.h = A_0.GetSingle("BOE:S");
			this.g = A_0.GetSingle("BOE:X");
			return;
		}
		this.g = aju.d;
		this.h = aju.c;
	}

	// Token: 0x06006A07 RID: 27143 RVA: 0x002CBA18 File Offset: 0x002C9C18
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BOE:L", this.a);
		info.AddValue("BOE:T", this.b);
		info.AddValue("BOE:M", this.c);
		info.AddValue("BOE:F", this.d);
		info.AddValue("BOE:V", this.e);
		info.AddValue("BOE:O", this.f);
		info.AddValue("BOE:S", this.h);
		info.AddValue("BOE:X", this.g);
	}

	// Token: 0x06006A08 RID: 27144 RVA: 0x002CBAB8 File Offset: 0x002C9CB8
	public string g()
	{
		return this.a;
	}

	// Token: 0x06006A09 RID: 27145 RVA: 0x002CBAC0 File Offset: 0x002C9CC0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006A0A RID: 27146 RVA: 0x002CBACC File Offset: 0x002C9CCC
	public string b()
	{
		return this.b;
	}

	// Token: 0x06006A0B RID: 27147 RVA: 0x002CBAD4 File Offset: 0x002C9CD4
	public void c(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006A0C RID: 27148 RVA: 0x002CBAE0 File Offset: 0x002C9CE0
	public int e()
	{
		return this.c;
	}

	// Token: 0x06006A0D RID: 27149 RVA: 0x002CBAE8 File Offset: 0x002C9CE8
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006A0E RID: 27150 RVA: 0x002CBAF4 File Offset: 0x002C9CF4
	public int a()
	{
		return this.d;
	}

	// Token: 0x06006A0F RID: 27151 RVA: 0x002CBAFC File Offset: 0x002C9CFC
	public void b(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006A10 RID: 27152 RVA: 0x002CBB08 File Offset: 0x002C9D08
	public string d()
	{
		return this.e;
	}

	// Token: 0x06006A11 RID: 27153 RVA: 0x002CBB10 File Offset: 0x002C9D10
	public void b(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006A12 RID: 27154 RVA: 0x002CBB1C File Offset: 0x002C9D1C
	public bool h()
	{
		return this.f;
	}

	// Token: 0x06006A13 RID: 27155 RVA: 0x002CBB24 File Offset: 0x002C9D24
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006A14 RID: 27156 RVA: 0x002CBB30 File Offset: 0x002C9D30
	public float h9()
	{
		return this.g;
	}

	// Token: 0x06006A15 RID: 27157 RVA: 0x002CBB38 File Offset: 0x002C9D38
	public void b(float A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006A16 RID: 27158 RVA: 0x002CBB44 File Offset: 0x002C9D44
	public float ia()
	{
		return this.h;
	}

	// Token: 0x06006A17 RID: 27159 RVA: 0x002CBB4C File Offset: 0x002C9D4C
	public void a(float A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006A18 RID: 27160 RVA: 0x002CBB58 File Offset: 0x002C9D58
	public ka(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006A19 RID: 27161 RVA: 0x002CBB78 File Offset: 0x002C9D78
	public int i()
	{
		if (this.c > 0 && this.d >= this.c)
		{
			return this.d % this.c;
		}
		return this.d;
	}

	// Token: 0x06006A1A RID: 27162 RVA: 0x002CBBAC File Offset: 0x002C9DAC
	public string f()
	{
		string text = this.e;
		if (this.f)
		{
			text = text + "_dir" + ((int)((base.a8().VisualDirection + 1) % (HorizontalDirection)8)).ToString();
		}
		if (this.c > 0)
		{
			text = text + "_p" + (this.d / this.c).ToString();
		}
		return Path.Combine(this.b, text);
	}

	// Token: 0x04002B9D RID: 11165
	private string a;

	// Token: 0x04002B9E RID: 11166
	private string b;

	// Token: 0x04002B9F RID: 11167
	private int c;

	// Token: 0x04002BA0 RID: 11168
	private int d;

	// Token: 0x04002BA1 RID: 11169
	private string e;

	// Token: 0x04002BA2 RID: 11170
	private bool f;

	// Token: 0x04002BA3 RID: 11171
	private float g = aju.d;

	// Token: 0x04002BA4 RID: 11172
	private float h = aju.c;
}
