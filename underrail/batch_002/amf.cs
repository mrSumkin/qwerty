using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020018E6 RID: 6374
[eiz("VHCD")]
[Serializable]
public sealed class amf : ISerializable
{
	// Token: 0x060086F5 RID: 34549 RVA: 0x0037E144 File Offset: 0x0037C344
	private amf(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() >= 423)
		{
			this.b = (A_0.GetValue("VHCD:F", typeof(agt)) as agt);
			di7.ReadList<c38>("VHCD:P", ref this.c, A_0);
			if (ell.a() >= 370)
			{
				this.d = A_0.GetString("VHCD:N");
			}
			if (ell.a() >= 404)
			{
				this.e = A_0.GetBoolean("VHCD:E");
				this.f = (Color)A_0.GetValue("VHCD:C", typeof(Color));
			}
			if (ell.a() >= 419)
			{
				this.g = A_0.GetSingle("VHCD:S");
				this.h = A_0.GetSingle("VHCD:D");
			}
			if (ell.a() >= 420)
			{
				this.i = A_0.GetSingle("VHCD:T");
				return;
			}
		}
		else
		{
			this.b = (A_0.GetValue("_Frame", typeof(agt)) as agt);
			this.c = (A_0.GetValue("_Parts", typeof(List<c38>)) as List<c38>);
			this.d = A_0.GetString("_Name");
			try
			{
				this.e = A_0.GetBoolean("_EmitsLight");
				this.f = (Color)A_0.GetValue("_LightColor", typeof(Color));
			}
			catch
			{
			}
			try
			{
				this.g = A_0.GetSingle("_VisualSideExtensionBonus");
				this.h = A_0.GetSingle("_VisualDiagonalExtensionBonus");
			}
			catch
			{
			}
			try
			{
				this.i = A_0.GetSingle("_TrailExtensionBonus");
			}
			catch
			{
			}
		}
	}

	// Token: 0x060086F6 RID: 34550 RVA: 0x0037E354 File Offset: 0x0037C554
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("VHCD:F", this.b);
		di7.WriteList<c38>("VHCD:P", this.c, info);
		info.AddValue("VHCD:N", this.d);
		info.AddValue("VHCD:E", this.e);
		info.AddValue("VHCD:C", this.f);
		info.AddValue("VHCD:S", this.g);
		info.AddValue("VHCD:D", this.h);
		info.AddValue("VHCD:T", this.i);
	}

	// Token: 0x060086F7 RID: 34551 RVA: 0x0037E3F0 File Offset: 0x0037C5F0
	public string d()
	{
		return this.d;
	}

	// Token: 0x060086F8 RID: 34552 RVA: 0x0037E3F8 File Offset: 0x0037C5F8
	public void c(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060086F9 RID: 34553 RVA: 0x0037E404 File Offset: 0x0037C604
	public agt g()
	{
		return this.b;
	}

	// Token: 0x060086FA RID: 34554 RVA: 0x0037E40C File Offset: 0x0037C60C
	public void a(agt A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060086FB RID: 34555 RVA: 0x0037E418 File Offset: 0x0037C618
	public List<c38> e()
	{
		return this.c;
	}

	// Token: 0x060086FC RID: 34556 RVA: 0x0037E420 File Offset: 0x0037C620
	public void a(List<c38> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060086FD RID: 34557 RVA: 0x0037E42C File Offset: 0x0037C62C
	public bool f()
	{
		return this.e;
	}

	// Token: 0x060086FE RID: 34558 RVA: 0x0037E434 File Offset: 0x0037C634
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060086FF RID: 34559 RVA: 0x0037E440 File Offset: 0x0037C640
	public Color b()
	{
		return this.f;
	}

	// Token: 0x06008700 RID: 34560 RVA: 0x0037E448 File Offset: 0x0037C648
	public void a(Color A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06008701 RID: 34561 RVA: 0x0037E454 File Offset: 0x0037C654
	public float h()
	{
		return this.g;
	}

	// Token: 0x06008702 RID: 34562 RVA: 0x0037E45C File Offset: 0x0037C65C
	public void c(float A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06008703 RID: 34563 RVA: 0x0037E468 File Offset: 0x0037C668
	public float a()
	{
		return this.h;
	}

	// Token: 0x06008704 RID: 34564 RVA: 0x0037E470 File Offset: 0x0037C670
	public void b(float A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06008705 RID: 34565 RVA: 0x0037E47C File Offset: 0x0037C67C
	public float c()
	{
		return this.i;
	}

	// Token: 0x06008706 RID: 34566 RVA: 0x0037E484 File Offset: 0x0037C684
	public void a(float A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06008707 RID: 34567 RVA: 0x0037E490 File Offset: 0x0037C690
	public amf()
	{
	}

	// Token: 0x06008708 RID: 34568 RVA: 0x0037E4A4 File Offset: 0x0037C6A4
	public void b(string A_0)
	{
		eoq.SerializeToBinaryFileCompressed<amf>(A_0, this, dds.a(), eh9.c, true);
	}

	// Token: 0x06008709 RID: 34569 RVA: 0x0037E4B8 File Offset: 0x0037C6B8
	public static amf a(string A_0)
	{
		return eoq.DeserializeFromBinaryFileCompressed<amf>(A_0, dds.a(), true);
	}

	// Token: 0x0400348C RID: 13452
	public static readonly string a = "vd";

	// Token: 0x0400348D RID: 13453
	private agt b;

	// Token: 0x0400348E RID: 13454
	private List<c38> c = new List<c38>();

	// Token: 0x0400348F RID: 13455
	private string d;

	// Token: 0x04003490 RID: 13456
	private bool e;

	// Token: 0x04003491 RID: 13457
	private Color f;

	// Token: 0x04003492 RID: 13458
	private float g;

	// Token: 0x04003493 RID: 13459
	private float h;

	// Token: 0x04003494 RID: 13460
	private float i;
}
