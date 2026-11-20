using System;
using Microsoft.Xna.Framework.Audio;

// Token: 0x0200007F RID: 127
public sealed class e8a
{
	// Token: 0x060002DC RID: 732 RVA: 0x0000D798 File Offset: 0x0000B998
	public string e()
	{
		return this.a;
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
	public b0b i()
	{
		return this.b;
	}

	// Token: 0x060002DE RID: 734 RVA: 0x0000D7A8 File Offset: 0x0000B9A8
	public string a()
	{
		return this.c;
	}

	// Token: 0x060002DF RID: 735 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
	public float b()
	{
		return this.d;
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
	public void b(float A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x0000D7C4 File Offset: 0x0000B9C4
	public bool g()
	{
		return this.e;
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x0000D7CC File Offset: 0x0000B9CC
	public c9z d()
	{
		return this.f;
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x0000D7D4 File Offset: 0x0000B9D4
	public Guid? f()
	{
		return this.g;
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x0000D7DC File Offset: 0x0000B9DC
	public bool c()
	{
		return this.h;
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
	public e8a(string A_0, b0b A_1, string A_2, float A_3, bool A_4, c9z A_5)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
		this.f = A_5;
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x0000D81C File Offset: 0x0000BA1C
	public bool a(bool A_0)
	{
		dd7 serviceOrThrow = bpo.GetServiceOrThrow<dd7>();
		this.g = serviceOrThrow.aeb(this.c, this.d * this.i, this.e, this.f, A_0);
		this.h = false;
		return this.g != null;
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x0000D870 File Offset: 0x0000BA70
	public bool b(bool A_0)
	{
		return bpo.GetServiceOrThrow<dd7>().ad7(this.g.Value, A_0);
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x0000D888 File Offset: 0x0000BA88
	public bool d(bool A_0)
	{
		dd7 serviceOrThrow = bpo.GetServiceOrThrow<dd7>();
		if (A_0)
		{
			this.h = true;
		}
		return serviceOrThrow.ad8(this.g.Value);
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x0000D8B0 File Offset: 0x0000BAB0
	public bool c(bool A_0)
	{
		dd7 serviceOrThrow = bpo.GetServiceOrThrow<dd7>();
		this.h = false;
		return A_0 && serviceOrThrow.ad9(this.g.Value);
	}

	// Token: 0x060002EA RID: 746 RVA: 0x0000D8E4 File Offset: 0x0000BAE4
	public SoundState? h()
	{
		return bpo.GetServiceOrThrow<dd7>().aec(this.g.Value);
	}

	// Token: 0x060002EB RID: 747 RVA: 0x0000D900 File Offset: 0x0000BB00
	public void a(float A_0)
	{
		dd7 serviceOrThrow = bpo.GetServiceOrThrow<dd7>();
		float num = serviceOrThrow.aed(this.g.Value);
		this.i = A_0;
		float num2 = this.d * this.i;
		if (num != num2)
		{
			serviceOrThrow.aea(this.g.Value, num2);
		}
	}

	// Token: 0x040003CE RID: 974
	private string a;

	// Token: 0x040003CF RID: 975
	private b0b b;

	// Token: 0x040003D0 RID: 976
	private string c;

	// Token: 0x040003D1 RID: 977
	private float d;

	// Token: 0x040003D2 RID: 978
	private bool e;

	// Token: 0x040003D3 RID: 979
	private c9z f;

	// Token: 0x040003D4 RID: 980
	private Guid? g;

	// Token: 0x040003D5 RID: 981
	private bool h;

	// Token: 0x040003D6 RID: 982
	private float i;
}
