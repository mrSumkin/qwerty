using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x020012B5 RID: 4789
[eiz("OEAX")]
[a(typeof(bim))]
[Serializable]
public sealed class d85 : bim, c98
{
	// Token: 0x06006952 RID: 26962 RVA: 0x002C6B90 File Offset: 0x002C4D90
	private d85(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<string>("OEAX:L", ref this.a, A_0);
		this.b = A_0.GetInt32("OEAX:C");
		if (ell.a() >= 493)
		{
			this.c = A_0.GetBoolean("OEAX:F");
		}
	}

	// Token: 0x06006953 RID: 26963 RVA: 0x002C6BFC File Offset: 0x002C4DFC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<string>("OEAX:L", this.a, info);
		info.AddValue("OEAX:C", this.b);
		info.AddValue("OEAX:F", this.c);
	}

	// Token: 0x06006954 RID: 26964 RVA: 0x002C6C3C File Offset: 0x002C4E3C
	public List<string> a()
	{
		return this.a;
	}

	// Token: 0x06006955 RID: 26965 RVA: 0x002C6C44 File Offset: 0x002C4E44
	public void a(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006956 RID: 26966 RVA: 0x002C6C50 File Offset: 0x002C4E50
	public bool b()
	{
		return this.c;
	}

	// Token: 0x06006957 RID: 26967 RVA: 0x002C6C58 File Offset: 0x002C4E58
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006958 RID: 26968 RVA: 0x002C6C64 File Offset: 0x002C4E64
	public d85(c5x A_0) : base(A_0)
	{
		this.ps(d98.b);
		base.c(3f);
		base.l(false);
		this.af2(true);
	}

	// Token: 0x06006959 RID: 26969 RVA: 0x002C6CAC File Offset: 0x002C4EAC
	public override void mx()
	{
		base.mx();
		this.af2(true);
		if (this.c)
		{
			if (bpo.GetService<cnk>() != null)
			{
				this.a(new float?(0f));
				return;
			}
			this.a(null);
		}
	}

	// Token: 0x0600695A RID: 26970 RVA: 0x002C6CFC File Offset: 0x002C4EFC
	public override void my()
	{
		base.my();
		if (this.c)
		{
			if (bpo.GetService<cnk>() != null)
			{
				this.a(new float?(0f));
				return;
			}
			this.a(null);
		}
	}

	// Token: 0x0600695B RID: 26971 RVA: 0x002C6D44 File Offset: 0x002C4F44
	public void r7(eds A_0)
	{
		if (this.c)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area == base.a8().Area)
			{
				double num = aw1.b(base.a8(), serviceOrThrow.aqu().v().b());
				float a_ = d05.b(0f, (float)(5.0 - num) / 3f, 1f);
				this.a(a_, A_0.b.TotalMilliseconds);
				return;
			}
			this.a(new float?(0f));
		}
	}

	// Token: 0x0600695C RID: 26972 RVA: 0x002C6E18 File Offset: 0x002C5018
	public override TimelapseCursor? ar3()
	{
		if (this.a != null && this.a.Count > 1)
		{
			return new TimelapseCursor?(TimelapseCursor.ObserveMultiple);
		}
		return new TimelapseCursor?(TimelapseCursor.Observe);
	}

	// Token: 0x0600695D RID: 26973 RVA: 0x002C6E48 File Offset: 0x002C5048
	protected override void mz(c5x A_0, string A_1 = null)
	{
		if (this.a.Count > 0 && base.a8() != null)
		{
			c0s c0s = base.a8().GetAspect<c0s>();
			if (c0s == null)
			{
				c0s = new c0s(base.a8());
				c0s.a(dsu.b);
				base.a8().SetAspect<c0s>(c0s);
			}
			int num = this.b + 1;
			this.b = num;
			if (num >= this.a.Count)
			{
				this.b = 0;
			}
			c0s.a(this.a[this.b], true, null, null);
		}
	}

	// Token: 0x0600695E RID: 26974 RVA: 0x002C6EF8 File Offset: 0x002C50F8
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

	// Token: 0x0600695F RID: 26975 RVA: 0x002C6F6C File Offset: 0x002C516C
	private void a(float? A_0)
	{
		if (base.a8() != null)
		{
			base.a8().ae = A_0;
		}
		base.g(A_0 == null || A_0.Value > 0f);
	}

	// Token: 0x04002B6C RID: 11116
	private new List<string> a = new List<string>();

	// Token: 0x04002B6D RID: 11117
	private int b = -1;

	// Token: 0x04002B6E RID: 11118
	private bool c;
}
