using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001073 RID: 4211
[eiz("S19")]
[Serializable]
public sealed class c66 : cze, ISerializable
{
	// Token: 0x060057AA RID: 22442 RVA: 0x002634C0 File Offset: 0x002616C0
	private c66(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("S19:C", typeof(Color?)) as Color?);
		this.b = A_0.GetBoolean("S19:SC");
		this.c = (A_0.GetValue("S19:A", typeof(float?)) as float?);
		this.d = A_0.GetBoolean("S19:SA");
		this.e = A_0.GetInt32("S19:FX");
		this.f = A_0.GetInt32("S19:FY");
		this.g = A_0.GetBoolean("S19:SFX");
		this.h = A_0.GetBoolean("S19:SFY");
		if (ell.a() >= 503)
		{
			this.i = A_0.GetString("S19:M");
			this.j = A_0.GetBoolean("S19:SM");
		}
	}

	// Token: 0x060057AB RID: 22443 RVA: 0x002635B8 File Offset: 0x002617B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S19:C", this.a);
		info.AddValue("S19:SC", this.b);
		info.AddValue("S19:A", this.c);
		info.AddValue("S19:SA", this.d);
		info.AddValue("S19:FX", this.e);
		info.AddValue("S19:SFX", this.g);
		info.AddValue("S19:FY", this.f);
		info.AddValue("S19:SFY", this.h);
		info.AddValue("S19:M", this.i);
		info.AddValue("S19:SM", this.j);
	}

	// Token: 0x060057AC RID: 22444 RVA: 0x00263684 File Offset: 0x00261884
	public Color? f()
	{
		return this.a;
	}

	// Token: 0x060057AD RID: 22445 RVA: 0x0026368C File Offset: 0x0026188C
	public void a(Color? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060057AE RID: 22446 RVA: 0x00263698 File Offset: 0x00261898
	public bool c()
	{
		return this.b;
	}

	// Token: 0x060057AF RID: 22447 RVA: 0x002636A0 File Offset: 0x002618A0
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060057B0 RID: 22448 RVA: 0x002636AC File Offset: 0x002618AC
	public float? g()
	{
		return this.c;
	}

	// Token: 0x060057B1 RID: 22449 RVA: 0x002636B4 File Offset: 0x002618B4
	public void a(float? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060057B2 RID: 22450 RVA: 0x002636C0 File Offset: 0x002618C0
	public bool a()
	{
		return this.d;
	}

	// Token: 0x060057B3 RID: 22451 RVA: 0x002636C8 File Offset: 0x002618C8
	public void e(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060057B4 RID: 22452 RVA: 0x002636D4 File Offset: 0x002618D4
	public int j()
	{
		return this.e;
	}

	// Token: 0x060057B5 RID: 22453 RVA: 0x002636DC File Offset: 0x002618DC
	public void b(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060057B6 RID: 22454 RVA: 0x002636E8 File Offset: 0x002618E8
	public int h()
	{
		return this.f;
	}

	// Token: 0x060057B7 RID: 22455 RVA: 0x002636F0 File Offset: 0x002618F0
	public void a(int A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060057B8 RID: 22456 RVA: 0x002636FC File Offset: 0x002618FC
	public bool b()
	{
		return this.g;
	}

	// Token: 0x060057B9 RID: 22457 RVA: 0x00263704 File Offset: 0x00261904
	public void a(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060057BA RID: 22458 RVA: 0x00263710 File Offset: 0x00261910
	public bool d()
	{
		return this.h;
	}

	// Token: 0x060057BB RID: 22459 RVA: 0x00263718 File Offset: 0x00261918
	public void c(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060057BC RID: 22460 RVA: 0x00263724 File Offset: 0x00261924
	public string e()
	{
		return this.i;
	}

	// Token: 0x060057BD RID: 22461 RVA: 0x0026372C File Offset: 0x0026192C
	public void a(string A_0)
	{
		this.i = A_0;
	}

	// Token: 0x060057BE RID: 22462 RVA: 0x00263738 File Offset: 0x00261938
	public bool i()
	{
		return this.j;
	}

	// Token: 0x060057BF RID: 22463 RVA: 0x00263740 File Offset: 0x00261940
	public void d(bool A_0)
	{
		this.j = A_0;
	}

	// Token: 0x060057C0 RID: 22464 RVA: 0x0026374C File Offset: 0x0026194C
	public c66()
	{
	}

	// Token: 0x060057C1 RID: 22465 RVA: 0x00263758 File Offset: 0x00261958
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.o.b != null)
		{
			this.a(c5x.o.b);
		}
	}

	// Token: 0x060057C2 RID: 22466 RVA: 0x00263794 File Offset: 0x00261994
	private void a(cd0 A_0)
	{
		if (this.d)
		{
			A_0.d = this.c;
		}
		if (this.b)
		{
			A_0.c = this.a;
		}
		if (this.g || this.h)
		{
			Point point = A_0.b;
			if (this.g)
			{
				point.X = this.e;
			}
			if (this.h)
			{
				point.Y = this.f;
			}
			A_0.b = point;
		}
		if (this.j)
		{
			A_0.a = this.i;
		}
	}

	// Token: 0x04002371 RID: 9073
	private new Color? a;

	// Token: 0x04002372 RID: 9074
	private bool b;

	// Token: 0x04002373 RID: 9075
	private float? c;

	// Token: 0x04002374 RID: 9076
	private bool d;

	// Token: 0x04002375 RID: 9077
	private int e;

	// Token: 0x04002376 RID: 9078
	private int f;

	// Token: 0x04002377 RID: 9079
	private bool g;

	// Token: 0x04002378 RID: 9080
	private bool h;

	// Token: 0x04002379 RID: 9081
	private string i;

	// Token: 0x0400237A RID: 9082
	private bool j;
}
