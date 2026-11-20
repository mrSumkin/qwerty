using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200125A RID: 4698
[eiz("PKJB")]
[Serializable]
public sealed class ajl : cze
{
	// Token: 0x06006592 RID: 26002 RVA: 0x002B3F54 File Offset: 0x002B2154
	private ajl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("PKJB:I", typeof(Guid?)) as Guid?);
		this.b = A_0.GetString("PKJB:A");
		this.c = A_0.GetInt32("PKJB:S");
		this.d = (A_0.GetValue("PKJB:V", typeof(Point?)) as Point?);
		this.e = (b14)A_0.GetValue("PKJB:C", typeof(b14));
		this.f = A_0.GetString("PKJB:N");
	}

	// Token: 0x06006593 RID: 26003 RVA: 0x002B4014 File Offset: 0x002B2214
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PKJB:I", this.a);
		info.AddValue("PKJB:A", this.b);
		info.AddValue("PKJB:S", this.c);
		info.AddValue("PKJB:V", this.d);
		info.AddValue("PKJB:C", this.e);
		info.AddValue("PKJB:N", this.f);
	}

	// Token: 0x06006594 RID: 26004 RVA: 0x002B40A0 File Offset: 0x002B22A0
	public Guid? a()
	{
		return this.a;
	}

	// Token: 0x06006595 RID: 26005 RVA: 0x002B40A8 File Offset: 0x002B22A8
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006596 RID: 26006 RVA: 0x002B40B4 File Offset: 0x002B22B4
	public string b()
	{
		return this.b;
	}

	// Token: 0x06006597 RID: 26007 RVA: 0x002B40BC File Offset: 0x002B22BC
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006598 RID: 26008 RVA: 0x002B40C8 File Offset: 0x002B22C8
	public int c()
	{
		return this.c;
	}

	// Token: 0x06006599 RID: 26009 RVA: 0x002B40D0 File Offset: 0x002B22D0
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600659A RID: 26010 RVA: 0x002B40DC File Offset: 0x002B22DC
	public Point? d()
	{
		return this.d;
	}

	// Token: 0x0600659B RID: 26011 RVA: 0x002B40E4 File Offset: 0x002B22E4
	public void a(Point? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600659C RID: 26012 RVA: 0x002B40F0 File Offset: 0x002B22F0
	public b14 e()
	{
		return this.e;
	}

	// Token: 0x0600659D RID: 26013 RVA: 0x002B40F8 File Offset: 0x002B22F8
	public void a(b14 A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600659E RID: 26014 RVA: 0x002B4104 File Offset: 0x002B2304
	public string f()
	{
		return this.f;
	}

	// Token: 0x0600659F RID: 26015 RVA: 0x002B410C File Offset: 0x002B230C
	public void b(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060065A0 RID: 26016 RVA: 0x002B4118 File Offset: 0x002B2318
	public ajl()
	{
	}

	// Token: 0x060065A1 RID: 26017 RVA: 0x002B4130 File Offset: 0x002B2330
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.Zone != null)
		{
			c5x c5x2 = null;
			if (this.a != null)
			{
				aud aud = null;
				if (!string.IsNullOrEmpty(this.b))
				{
					aud = c5x.Zone.n(this.b);
				}
				if (aud == null)
				{
					aud = c5x.Area;
				}
				c5x2 = (new ar7(this.a.Value, aud).ao() as c5x);
			}
			if (c5x2 != null && c5x.i.b != null)
			{
				ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
				bx5 bx = new bx5(c5x);
				bx.l(new EventHandler<EventArgs>(this.a));
				c5x.i.b.a(bx, atp.a, true, false);
				serviceOrThrow.ana(c5x2, this, this.e, this.c, this.d, this.f);
			}
		}
	}

	// Token: 0x060065A2 RID: 26018 RVA: 0x002B421C File Offset: 0x002B241C
	[dcc("PKJB:mOIC")]
	private void a(object A_0, EventArgs A_1)
	{
		if (A_0 is bx5)
		{
			bpo.GetServiceOrThrow<ps>().anb(this);
		}
	}

	// Token: 0x04002A44 RID: 10820
	private new Guid? a;

	// Token: 0x04002A45 RID: 10821
	private string b;

	// Token: 0x04002A46 RID: 10822
	private int c = 8;

	// Token: 0x04002A47 RID: 10823
	private Point? d;

	// Token: 0x04002A48 RID: 10824
	private b14 e = b14.b;

	// Token: 0x04002A49 RID: 10825
	private string f;
}
