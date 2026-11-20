using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x02000F90 RID: 3984
[eiz("LGWEA")]
[Serializable]
public sealed class bjt : Aspect<c5x>, ISerializable, cmm
{
	// Token: 0x06005162 RID: 20834 RVA: 0x00249FDC File Offset: 0x002481DC
	private bjt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.d = A_0.GetInt32("LGWEA:SI");
		this.e = A_0.GetDouble("LGWEA:ST");
		this.f = A_0.GetInt32("LGWEA:MGC");
		if (ell.a() >= 28)
		{
			this.g = A_0.GetInt32("LGWEA:SD");
		}
		if (ell.a() >= 119)
		{
			this.h = A_0.GetDouble("LGWEA:DT");
		}
	}

	// Token: 0x06005163 RID: 20835 RVA: 0x0024A06C File Offset: 0x0024826C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LGWEA:SI", this.d);
		info.AddValue("LGWEA:ST", this.e);
		info.AddValue("LGWEA:MGC", this.f);
		info.AddValue("LGWEA:SD", this.g);
		info.AddValue("LGWEA:DT", this.h);
	}

	// Token: 0x06005164 RID: 20836 RVA: 0x0024A0D8 File Offset: 0x002482D8
	public int f()
	{
		return this.d;
	}

	// Token: 0x06005165 RID: 20837 RVA: 0x0024A0E0 File Offset: 0x002482E0
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005166 RID: 20838 RVA: 0x0024A0EC File Offset: 0x002482EC
	public int e()
	{
		return this.f;
	}

	// Token: 0x06005167 RID: 20839 RVA: 0x0024A0F4 File Offset: 0x002482F4
	public void b(int A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005168 RID: 20840 RVA: 0x0024A100 File Offset: 0x00248300
	public bjt(c5x A_0) : base(A_0)
	{
		this.e = (double)this.d * (0.75 + cuo.a.NextDouble() / 4.0);
	}

	// Token: 0x06005169 RID: 20841 RVA: 0x0024A14C File Offset: 0x0024834C
	public void r7(eds A_0)
	{
		if (this.g > 0 && (this.h -= A_0.b.TotalMilliseconds) <= 0.0)
		{
			this.h += 2500.0 * (0.75 + cuo.a.NextDouble() / 4.0);
			this.d();
			this.g--;
			return;
		}
		if ((this.e -= A_0.b.TotalMilliseconds) <= 0.0)
		{
			this.e += (double)this.d * (0.75 + cuo.a.NextDouble() / 4.0);
			this.d();
		}
	}

	// Token: 0x0600516A RID: 20842 RVA: 0x0024A23C File Offset: 0x0024843C
	public void c9(TimeSpan A_0)
	{
		this.g += Math.Min((int)(A_0.TotalMilliseconds / (double)this.d), this.f);
		this.h = 2500.0 * (0.75 + cuo.a.NextDouble() / 4.0);
	}

	// Token: 0x0600516B RID: 20843 RVA: 0x0024A2A0 File Offset: 0x002484A0
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x0600516C RID: 20844 RVA: 0x0024A2A4 File Offset: 0x002484A4
	private void d()
	{
		if (this.b() < this.f)
		{
			this.a();
		}
	}

	// Token: 0x0600516D RID: 20845 RVA: 0x0024A2C0 File Offset: 0x002484C0
	private int b()
	{
		d60 d = base.a8().a();
		int result;
		if (d != null)
		{
			result = d.ab4(new string[]
			{
				"caveHopper"
			}).Count;
		}
		else
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x0600516E RID: 20846 RVA: 0x0024A304 File Offset: 0x00248504
	private void a()
	{
		base.a8().Zone.ActionManager.g9(new bjt.a(base.a8()), atp.a);
	}

	// Token: 0x04002156 RID: 8534
	private const string a = "caveHopper";

	// Token: 0x04002157 RID: 8535
	private const string b = "locale\\creatures\\CaveHopper";

	// Token: 0x04002158 RID: 8536
	private const int c = 2500;

	// Token: 0x04002159 RID: 8537
	private int d = 30000;

	// Token: 0x0400215A RID: 8538
	private double e;

	// Token: 0x0400215B RID: 8539
	private int f;

	// Token: 0x0400215C RID: 8540
	private int g;

	// Token: 0x0400215D RID: 8541
	private double h;

	// Token: 0x02000F91 RID: 3985
	[eiz("SLGA")]
	[Serializable]
	private sealed class a : b1z
	{
		// Token: 0x0600516F RID: 20847 RVA: 0x0024A334 File Offset: 0x00248534
		public a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
			this.a = (A_0.GetValue("SLGA:SR", typeof(ar7)) as ar7);
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x0024A360 File Offset: 0x00248560
		public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			base.GetObjectData(info, ctx);
			info.AddValue("SLGA:SR", this.a);
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x0024A37C File Offset: 0x0024857C
		public a(c5x A_0)
		{
			this.a = new ar7(A_0);
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x0024A394 File Offset: 0x00248594
		protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
		{
			if (this.a == null || this.a.ao() == null || this.a.ao().Area == null)
			{
				return dc4.e;
			}
			c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("locale\\creatures\\CaveHopper");
			if (c5k != null)
			{
				c5x c5x = c5k.a(null, false) as c5x;
				if (c5x != null)
				{
					c5x.Location = this.a.ao().Location;
					c5x.Layer = aju.x;
					c5x.SetAspect<e3l>(new e3l(c5x)
					{
						a = 
						{
							"caveHopper"
						}
					});
					this.a.ao().Area.a(c5x);
					return dc4.c;
				}
			}
			return dc4.e;
		}

		// Token: 0x0400215E RID: 8542
		private new ar7 a;
	}
}
