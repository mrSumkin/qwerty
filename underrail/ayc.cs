using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020010D8 RID: 4312
[eiz("YR")]
[Serializable]
public sealed class ayc : cze
{
	// Token: 0x06005AD7 RID: 23255 RVA: 0x00272240 File Offset: 0x00270440
	private ayc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("YR:S");
		this.b = (a1q)A_0.GetValue("YR:D", typeof(a1q));
		this.c = A_0.GetBoolean("YR:H");
		this.d = A_0.GetBoolean("YR:R");
		di7.ReadList<string>("YR:W", ref this.e, A_0);
		di7.ReadList<double>("YR:A", ref this.f, A_0);
		di7.ReadList<double>("YR:M", ref this.g, A_0);
	}

	// Token: 0x06005AD8 RID: 23256 RVA: 0x002722FC File Offset: 0x002704FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("YR:S", this.a);
		info.AddValue("YR:D", this.b);
		info.AddValue("YR:H", this.c);
		info.AddValue("YR:R", this.d);
		di7.WriteList<string>("YR:W", this.e, info);
		di7.WriteList<double>("YR:A", this.f, info);
		di7.WriteList<double>("YR:M", this.g, info);
	}

	// Token: 0x06005AD9 RID: 23257 RVA: 0x00272390 File Offset: 0x00270590
	public a1q f()
	{
		return this.b;
	}

	// Token: 0x06005ADA RID: 23258 RVA: 0x00272398 File Offset: 0x00270598
	public void a(a1q A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005ADB RID: 23259 RVA: 0x002723A4 File Offset: 0x002705A4
	public string c()
	{
		return this.a;
	}

	// Token: 0x06005ADC RID: 23260 RVA: 0x002723AC File Offset: 0x002705AC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005ADD RID: 23261 RVA: 0x002723B8 File Offset: 0x002705B8
	public bool d()
	{
		return this.c;
	}

	// Token: 0x06005ADE RID: 23262 RVA: 0x002723C0 File Offset: 0x002705C0
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005ADF RID: 23263 RVA: 0x002723CC File Offset: 0x002705CC
	public bool e()
	{
		return this.d;
	}

	// Token: 0x06005AE0 RID: 23264 RVA: 0x002723D4 File Offset: 0x002705D4
	public void b(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005AE1 RID: 23265 RVA: 0x002723E0 File Offset: 0x002705E0
	public List<string> b()
	{
		return this.e;
	}

	// Token: 0x06005AE2 RID: 23266 RVA: 0x002723E8 File Offset: 0x002705E8
	public void a(List<string> A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005AE3 RID: 23267 RVA: 0x002723F4 File Offset: 0x002705F4
	public List<double> g()
	{
		return this.f;
	}

	// Token: 0x06005AE4 RID: 23268 RVA: 0x002723FC File Offset: 0x002705FC
	public void b(List<double> A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005AE5 RID: 23269 RVA: 0x00272408 File Offset: 0x00270608
	public List<double> a()
	{
		return this.g;
	}

	// Token: 0x06005AE6 RID: 23270 RVA: 0x00272410 File Offset: 0x00270610
	public void a(List<double> A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005AE7 RID: 23271 RVA: 0x0027241C File Offset: 0x0027061C
	public ayc()
	{
	}

	// Token: 0x06005AE8 RID: 23272 RVA: 0x00272448 File Offset: 0x00270648
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Zone != null && !string.IsNullOrEmpty(this.a) && this.e.Count > 0 && this.e.Count == this.f.Count && this.e.Count == this.g.Count)
		{
			c1a c1a = A_1.Zone;
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				List<ayc.a> list = new List<ayc.a>();
				for (int i = 0; i < this.e.Count; i++)
				{
					string a_ = this.e[i];
					csd csd = c1a.g(a_);
					if (csd != null)
					{
						double a_2 = this.g[i];
						list.Add(new ayc.a
						{
							b = csd.Area,
							a = csd.Location,
							d = this.f[i],
							c = euf.a(this.b, a_2)
						});
					}
				}
				if (list.Count > 0)
				{
					foreach (d4n d4n in service.ahl())
					{
						if (!d4n.b.aa().Passive && !d4n.b.aa().Dead)
						{
							ayc.a a = null;
							foreach (ayc.a a2 in list)
							{
								if (a2.b == d4n.b.a8().Area && (double)Math.Abs((d4n.b.a8().Location.b() - a2.a.b()).Length()) <= a2.d && (a == null || a2.c.Amount > a.c.Amount))
								{
									a = a2;
								}
							}
							if (a != null)
							{
								cwt cwt = new cwt();
								cwt.b = true;
								cwt.l = this.c;
								cwt.p = this.d;
								cwt.f.Add(a.c);
								cwt.v = this.a;
								d4n.b.aa().Defense.a(cwt);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04002450 RID: 9296
	private new string a;

	// Token: 0x04002451 RID: 9297
	private a1q b;

	// Token: 0x04002452 RID: 9298
	private bool c;

	// Token: 0x04002453 RID: 9299
	private bool d;

	// Token: 0x04002454 RID: 9300
	private List<string> e = new List<string>();

	// Token: 0x04002455 RID: 9301
	private List<double> f = new List<double>();

	// Token: 0x04002456 RID: 9302
	private List<double> g = new List<double>();

	// Token: 0x020010D9 RID: 4313
	private new class a
	{
		// Token: 0x04002457 RID: 9303
		public Vector3 a;

		// Token: 0x04002458 RID: 9304
		public aud b;

		// Token: 0x04002459 RID: 9305
		public csk c;

		// Token: 0x0400245A RID: 9306
		public double d;
	}
}
