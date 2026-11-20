using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x02001283 RID: 4739
[eiz("FDEA")]
[Serializable]
public sealed class anz : Aspect<c5x>, bp1, c98
{
	// Token: 0x060066F2 RID: 26354 RVA: 0x002BBB18 File Offset: 0x002B9D18
	private anz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("FDEA:F");
		this.b = A_0.GetSingle("FDEA:D");
		if (ell.a() >= 495)
		{
			this.c = A_0.GetBoolean("FDEA:E");
		}
	}

	// Token: 0x060066F3 RID: 26355 RVA: 0x002BBB88 File Offset: 0x002B9D88
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FDEA:F", this.a);
		info.AddValue("FDEA:D", this.b);
		info.AddValue("FDEA:E", this.c);
	}

	// Token: 0x060066F4 RID: 26356 RVA: 0x002BBBD0 File Offset: 0x002B9DD0
	public float d()
	{
		return this.a;
	}

	// Token: 0x060066F5 RID: 26357 RVA: 0x002BBBD8 File Offset: 0x002B9DD8
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060066F6 RID: 26358 RVA: 0x002BBBE4 File Offset: 0x002B9DE4
	public float a()
	{
		return this.b;
	}

	// Token: 0x060066F7 RID: 26359 RVA: 0x002BBBEC File Offset: 0x002B9DEC
	public void b(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060066F8 RID: 26360 RVA: 0x002BBBF8 File Offset: 0x002B9DF8
	public bool b()
	{
		return this.c;
	}

	// Token: 0x060066F9 RID: 26361 RVA: 0x002BBC00 File Offset: 0x002B9E00
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060066FA RID: 26362 RVA: 0x002BBC0C File Offset: 0x002B9E0C
	public anz(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060066FB RID: 26363 RVA: 0x002BBC30 File Offset: 0x002B9E30
	public void mx()
	{
		if (bpo.GetService<cnk>() != null)
		{
			this.a(new float?(0f));
			return;
		}
		this.a(null);
	}

	// Token: 0x060066FC RID: 26364 RVA: 0x002BBC68 File Offset: 0x002B9E68
	public void my()
	{
		if (bpo.GetService<cnk>() != null)
		{
			this.a(new float?(0f));
			return;
		}
		this.a(null);
	}

	// Token: 0x060066FD RID: 26365 RVA: 0x002BBCA0 File Offset: 0x002B9EA0
	public void r7(eds A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area == base.a8().Area)
		{
			double num = aw1.b(base.a8(), serviceOrThrow.aqu().v().b());
			float a_ = d05.b(0f, (float)((double)(this.a + this.b) - num) / this.b, 1f);
			this.a(a_, A_0.b.TotalMilliseconds);
			return;
		}
		this.a(new float?(0f));
	}

	// Token: 0x060066FE RID: 26366 RVA: 0x002BBD70 File Offset: 0x002B9F70
	private void a(float A_0, double A_1)
	{
		if (base.a8() != null)
		{
			float valueOrDefault = base.a8().ae.GetValueOrDefault(1f);
			float num = (float)(A_1 * 0.001);
			if (valueOrDefault < A_0)
			{
				this.a(new float?(Math.Min(A_0, valueOrDefault + num)));
				return;
			}
			if (valueOrDefault > A_0)
			{
				this.a(new float?(Math.Max(A_0, valueOrDefault - num)));
			}
		}
	}

	// Token: 0x060066FF RID: 26367 RVA: 0x002BBDE4 File Offset: 0x002B9FE4
	private void a(float? A_0)
	{
		if (base.a8() != null)
		{
			base.a8().ae = A_0;
		}
		if (base.a8().s.b != null)
		{
			base.a8().s.b.g(A_0 == null || A_0.Value > 0f);
		}
		if (!this.c && base.a8().h.b != null)
		{
			bool flag = A_0 != null && A_0.Value == 0f;
			if (flag != base.a8().h.b.aa().Ethereal)
			{
				base.a8().h.b.aa().EtherealBase = flag;
				base.a8().h.b.aa().bl();
			}
		}
	}

	// Token: 0x04002AAA RID: 10922
	private float a = 2f;

	// Token: 0x04002AAB RID: 10923
	private float b = 3f;

	// Token: 0x04002AAC RID: 10924
	private bool c;
}
