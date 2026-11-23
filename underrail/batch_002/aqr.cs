using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000F93 RID: 3987
[eiz("CEXVSA")]
[Serializable]
public sealed class aqr : b1z, ISerializable
{
	// Token: 0x0600518B RID: 20875 RVA: 0x0024AFF4 File Offset: 0x002491F4
	private aqr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("CEXVSA:I", typeof(List<aqr.b>)) as List<aqr.b>);
		this.b = A_0.GetInt32("CEXVSA:C");
	}

	// Token: 0x0600518C RID: 20876 RVA: 0x0024B048 File Offset: 0x00249248
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CEXVSA:I", this.a);
		info.AddValue("CEXVSA:C", this.b);
	}

	// Token: 0x0600518D RID: 20877 RVA: 0x0024B074 File Offset: 0x00249274
	public aqr()
	{
	}

	// Token: 0x0600518E RID: 20878 RVA: 0x0024B088 File Offset: 0x00249288
	protected override dc4 dt()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() == null)
		{
			return dc4.e;
		}
		aud aud = Enumerable.FirstOrDefault<aud>(serviceOrThrow.aqw().Areas);
		if (aud == null)
		{
			return dc4.e;
		}
		Vector2 value = new Vector2(45f, 50f);
		foreach (b0b b0b in aud.Entities)
		{
			c5x c5x = (c5x)b0b;
			if (c5x.o.b != null)
			{
				string text = c5x.o.b.a;
				if (!string.IsNullOrEmpty(text))
				{
					bool flag = string.Equals(text, "Objects\\Compositions\\xphw_void_bunkerslab", StringComparison.OrdinalIgnoreCase);
					bool flag2 = string.Equals(text, "Objects\\Compositions\\xphw_void_bunkerslab_1", StringComparison.OrdinalIgnoreCase);
					bool flag3 = text.StartsWith("Objects\\Compositions\\xphw_voidtile_", StringComparison.OrdinalIgnoreCase);
					bool flag4 = text.StartsWith("Walls\\xphw_bunker_large_rubble", StringComparison.OrdinalIgnoreCase);
					bool flag5 = c5x.GetAspect<h4>() != null;
					bool flag6 = c5x.GetAspect<ws>() != null;
					bool flag7 = c5x.a("voidLantern");
					if (flag || flag2 || flag3 || flag4 || flag5 || flag6 || flag7)
					{
						Vector2 value2 = c5x.aj().b();
						float num = Vector2.Distance(value, value2);
						TimeSpan t = TimeSpan.FromSeconds((double)(15f - num) * 0.3 + cuo.a.NextDouble() * 0.3);
						aqr.b b = new aqr.b();
						b.b = num;
						b.a = new ar7(c5x);
						b.c = serviceOrThrow.aqw().ElapsedZoneTime + t;
						b.d = flag;
						b.e = flag2;
						b.f = flag3;
						b.g = flag4;
						b.h = flag5;
						b.i = flag6;
						b.j = flag7;
						if (flag2)
						{
							b.e = true;
							etz etz = c5x.o.b as etz;
							if (etz != null)
							{
								c5x.SetAspect<cd0>(new cd0(c5x)
								{
									a = etz.a,
									b = new Point(0, etz.b.Y - 1)
								});
							}
						}
						this.a.Add(b);
					}
				}
			}
		}
		return dc4.b;
	}

	// Token: 0x0600518F RID: 20879 RVA: 0x0024B320 File Offset: 0x00249520
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() == null)
		{
			return dc4.e;
		}
		for (int i = this.a.Count - 1; i >= 0; i--)
		{
			aqr.b b = this.a[i];
			if (b.c <= A_0)
			{
				if (b.a.ao() != null && b.a.ao().j == cgy.b)
				{
					c5x c5x = b.a.ao() as c5x;
					dtb dtb = new dtb();
					if (b.j)
					{
						bsf bsf = Enumerable.FirstOrDefault<ejt>(c5x.RaysEmitters) as bsf;
						if (bsf != null)
						{
							bsf.Definition.Enabled = true;
							dtb.ad().Add(new b6j(new ar7(c5x), bsf.Definition.Name, new float?(0f), 1f, 0.0005f, false));
						}
					}
					if (b.g)
					{
						List<auv> list = dtb.ad();
						ad6 ad = new ad6(c5x);
						ad.b(0.0);
						ad.c(1.0);
						ad.a(0.002);
						list.Add(ad);
					}
					else if (b.f)
					{
						List<auv> list2 = dtb.ad();
						ad6 ad2 = new ad6(c5x);
						ad2.b(0.0);
						ad2.c(1.0);
						list2.Add(ad2);
					}
					else if (b.e)
					{
						if (c5x.o.b != null)
						{
							List<auv> list3 = dtb.ad();
							dqm dqm = new dqm(c5x.o.b);
							dqm.c(6);
							list3.Add(dqm);
							dtb.ad().Add(new aqr.a(c5x));
						}
					}
					else if (b.d)
					{
						if (c5x.o.b != null)
						{
							int num = this.b;
							this.b = num + 1;
							if (num % 20 == 0)
							{
								dtb.ad().Add(new a4s(new bfq("RockDebris" + cuo.a.Next(3).ToString()), null, new ar7(c5x), null));
							}
							List<auv> list4 = dtb.ad();
							dqm dqm2 = new dqm(c5x.o.b);
							dqm2.c(12);
							list4.Add(dqm2);
						}
						dtb.ad().Add(new c7(b.a.ao(), false, false, true, false));
					}
					if (b.h)
					{
						h4 aspect = c5x.GetAspect<h4>();
						if (aspect != null)
						{
							aspect.b(true);
						}
					}
					if (b.i)
					{
						ws aspect2 = c5x.GetAspect<ws>();
						if (aspect2 != null)
						{
							aspect2.a(true);
						}
					}
					serviceOrThrow.aqw().ActionManager.g9(dtb, atp.a);
				}
				this.a.RemoveAt(i);
			}
		}
		if (this.a.Count == 0)
		{
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x0400216A RID: 8554
	private new List<aqr.b> a = new List<aqr.b>();

	// Token: 0x0400216B RID: 8555
	private int b;

	// Token: 0x02000F94 RID: 3988
	[eiz("SLINF")]
	[Serializable]
	private sealed class b : ISerializable
	{
		// Token: 0x06005190 RID: 20880 RVA: 0x0024B634 File Offset: 0x00249834
		private b(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("SLINF:E", typeof(ar7)) as ar7);
			this.b = A_0.GetSingle("SLINF:D");
			this.c = (TimeSpan)A_0.GetValue("SLINF:C", typeof(TimeSpan));
			this.d = A_0.GetBoolean("SLINF:S");
			this.e = A_0.GetBoolean("SLINF:DY");
			this.f = A_0.GetBoolean("SLINF:SM");
			this.g = A_0.GetBoolean("SLINF:RB");
			this.h = A_0.GetBoolean("SLINF:WF");
			this.i = A_0.GetBoolean("SLINF:BL");
			this.j = A_0.GetBoolean("SLINF:VL");
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x0024B710 File Offset: 0x00249910
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("SLINF:E", this.a);
			info.AddValue("SLINF:D", this.b);
			info.AddValue("SLINF:C", this.c);
			info.AddValue("SLINF:S", this.d);
			info.AddValue("SLINF:DY", this.e);
			info.AddValue("SLINF:SM", this.f);
			info.AddValue("SLINF:RB", this.g);
			info.AddValue("SLINF:WF", this.h);
			info.AddValue("SLINF:BL", this.i);
			info.AddValue("SLINF:VL", this.j);
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x0024B7CC File Offset: 0x002499CC
		public b()
		{
		}

		// Token: 0x0400216C RID: 8556
		public ar7 a;

		// Token: 0x0400216D RID: 8557
		public float b;

		// Token: 0x0400216E RID: 8558
		public TimeSpan c;

		// Token: 0x0400216F RID: 8559
		public bool d;

		// Token: 0x04002170 RID: 8560
		public bool e;

		// Token: 0x04002171 RID: 8561
		public bool f;

		// Token: 0x04002172 RID: 8562
		public bool g;

		// Token: 0x04002173 RID: 8563
		public bool h;

		// Token: 0x04002174 RID: 8564
		public bool i;

		// Token: 0x04002175 RID: 8565
		public bool j;
	}

	// Token: 0x02000F95 RID: 3989
	[eiz("ASLA")]
	[Serializable]
	private new sealed class a : dvv
	{
		// Token: 0x06005193 RID: 20883 RVA: 0x0024B7D4 File Offset: 0x002499D4
		private a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
			this.a = (A_0.GetValue("ASLA:E", typeof(ar7)) as ar7);
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x0024B800 File Offset: 0x00249A00
		public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			base.GetObjectData(info, ctx);
			info.AddValue("ASLA:E", this.a);
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x0024B81C File Offset: 0x00249A1C
		public a(c5x A_0)
		{
			this.a = new ar7(A_0);
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x0024B834 File Offset: 0x00249A34
		protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
		{
			if (this.a == null || this.a.ao() == null)
			{
				return dc4.e;
			}
			c5x c5x = (c5x)this.a.ao();
			cd0 b = c5x.o.b;
			if (b != null)
			{
				etz etz = new etz(c5x);
				etz.a = b.a;
				etz.d(180);
				etz.b = new Point(0, b.b.Y + 1);
				etz.c(6);
				etz.a(true);
				c5x.SetAspect<cd0>(etz);
			}
			return dc4.c;
		}

		// Token: 0x04002176 RID: 8566
		private new ar7 a;
	}
}
