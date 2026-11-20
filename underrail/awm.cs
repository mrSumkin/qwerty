using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001296 RID: 4758
[eiz("PKHEA")]
[a(typeof(bim))]
[Serializable]
public sealed class awm : bim
{
	// Token: 0x060067E8 RID: 26600 RVA: 0x002BFFEC File Offset: 0x002BE1EC
	private awm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("PKHEA:I", typeof(Guid?)) as Guid?);
		this.b = A_0.GetString("PKHEA:A");
		this.c = A_0.GetInt32("PKHEA:S");
		this.d = (A_0.GetValue("PKHEA:V", typeof(Point?)) as Point?);
	}

	// Token: 0x060067E9 RID: 26601 RVA: 0x002C0074 File Offset: 0x002BE274
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PKHEA:I", this.a);
		info.AddValue("PKHEA:A", this.b);
		info.AddValue("PKHEA:S", this.c);
		info.AddValue("PKHEA:V", this.d);
	}

	// Token: 0x060067EA RID: 26602 RVA: 0x002C00D8 File Offset: 0x002BE2D8
	public Guid? d()
	{
		return this.a;
	}

	// Token: 0x060067EB RID: 26603 RVA: 0x002C00E0 File Offset: 0x002BE2E0
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060067EC RID: 26604 RVA: 0x002C00EC File Offset: 0x002BE2EC
	public string f()
	{
		return this.b;
	}

	// Token: 0x060067ED RID: 26605 RVA: 0x002C00F4 File Offset: 0x002BE2F4
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060067EE RID: 26606 RVA: 0x002C0100 File Offset: 0x002BE300
	public int e()
	{
		return this.c;
	}

	// Token: 0x060067EF RID: 26607 RVA: 0x002C0108 File Offset: 0x002BE308
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060067F0 RID: 26608 RVA: 0x002C0114 File Offset: 0x002BE314
	public Point? b()
	{
		return this.d;
	}

	// Token: 0x060067F1 RID: 26609 RVA: 0x002C011C File Offset: 0x002BE31C
	public void a(Point? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060067F2 RID: 26610 RVA: 0x002C0128 File Offset: 0x002BE328
	public c5x a()
	{
		if (this.a != null)
		{
			if (this.e == null)
			{
				aud aud = null;
				if (!string.IsNullOrEmpty(this.b))
				{
					aud = base.a8().Zone.n(this.b);
				}
				if (aud == null)
				{
					aud = base.a8().Area;
				}
				this.e = new ar7(this.a.Value, aud);
			}
			return this.e.ao() as c5x;
		}
		return null;
	}

	// Token: 0x060067F3 RID: 26611 RVA: 0x002C01B4 File Offset: 0x002BE3B4
	public awm(c5x A_0) : base(A_0)
	{
		this.ps(d98.b);
		base.l(false);
	}

	// Token: 0x060067F4 RID: 26612 RVA: 0x002C01D4 File Offset: 0x002BE3D4
	protected override void mz(c5x A_0, string A_1 = null)
	{
		if (this.a() != null && A_0.i.b != null)
		{
			ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
			bx5 bx = new bx5(A_0);
			bx.l(new EventHandler<EventArgs>(this.a));
			A_0.i.b.a(bx, atp.a, true, false);
			serviceOrThrow.ana(this.a(), this, b14.b, this.c, this.d, null);
		}
	}

	// Token: 0x060067F5 RID: 26613 RVA: 0x002C0248 File Offset: 0x002BE448
	[dcc("PKHEA:mOIC")]
	private void a(object A_0, EventArgs A_1)
	{
		if (A_0 is bx5)
		{
			bpo.GetServiceOrThrow<ps>().anb(this);
		}
	}

	// Token: 0x04002AF4 RID: 10996
	private new Guid? a;

	// Token: 0x04002AF5 RID: 10997
	private string b;

	// Token: 0x04002AF6 RID: 10998
	private int c = 8;

	// Token: 0x04002AF7 RID: 10999
	private Point? d;

	// Token: 0x04002AF8 RID: 11000
	[NonSerialized]
	private ar7 e;
}
