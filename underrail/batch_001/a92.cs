using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020010AF RID: 4271
[eiz("DSXT")]
[Serializable]
public sealed class a92 : cze
{
	// Token: 0x060059BE RID: 22974 RVA: 0x0026BFF0 File Offset: 0x0026A1F0
	private a92(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("DSXT:I", typeof(Guid?));
		this.b = A_0.GetString("DSXT:A");
		this.c = A_0.GetString("DSXT:F");
	}

	// Token: 0x060059BF RID: 22975 RVA: 0x0026C048 File Offset: 0x0026A248
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DSXT:I", this.a);
		info.AddValue("DSXT:A", this.b);
		info.AddValue("DSXT:F", this.c);
	}

	// Token: 0x060059C0 RID: 22976 RVA: 0x0026C098 File Offset: 0x0026A298
	public string a()
	{
		return this.b;
	}

	// Token: 0x060059C1 RID: 22977 RVA: 0x0026C0A0 File Offset: 0x0026A2A0
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060059C2 RID: 22978 RVA: 0x0026C0AC File Offset: 0x0026A2AC
	public Guid? c()
	{
		return this.a;
	}

	// Token: 0x060059C3 RID: 22979 RVA: 0x0026C0B4 File Offset: 0x0026A2B4
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060059C4 RID: 22980 RVA: 0x0026C0C0 File Offset: 0x0026A2C0
	public string b()
	{
		return this.c;
	}

	// Token: 0x060059C5 RID: 22981 RVA: 0x0026C0C8 File Offset: 0x0026A2C8
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060059C6 RID: 22982 RVA: 0x0026C0D4 File Offset: 0x0026A2D4
	public a92()
	{
	}

	// Token: 0x060059C7 RID: 22983 RVA: 0x0026C0DC File Offset: 0x0026A2DC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = null;
			if (this.b != null)
			{
				b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow.yn().Zones[0].n(this.b);
				}
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.a.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			c5x c5x2 = vq.a("Creature\\Machines\\ShockTurret", c5x.Zone, new bt4(c5x.Area.y8(), c5x.Location), false);
			if (c5x2 != null)
			{
				c5x2.VisualDirection = c5x.VisualDirection;
				if (c5x2.t.b != null)
				{
					c5x2.t.b.y6()[ddq.at] = this.c;
				}
				dt5 aspect = c5x.GetAspect<dt5>();
				axh aspect2 = c5x.GetAspect<axh>();
				bool aspect3 = c5x2.GetAspect<dt5>() != null;
				axh aspect4 = c5x2.GetAspect<axh>();
				if (c5x2.h.b != null)
				{
					c5x2.h.b.aa().Passive = true;
					c5x2.h.b.aq = new int?(0);
					c5x2.h.b.ap = new CharacterState?(CharacterState.Custom5);
				}
				if (aspect4 != null && aspect2 != null)
				{
					aspect4.a(aspect2.h());
				}
				c5x.w();
				c5x.an();
				awx awx = new awx();
				awx.a(m7.b | m7.k);
				List<auv> list = awx.ad();
				a4s a4s = new a4s(new bfq("eltRise"), null, null, null);
				a4s.b(new ar7(c5x2));
				list.Add(a4s);
				clw clw = new clw();
				clw.a(new e6z(c5x2.Area));
				clw.a(true);
				clw.a(Axis.X);
				clw.a().Add(c5x2.Location.a());
				clw.e().Add(c5x2.qe());
				awx.ad().Add(clw);
				awx.ad().Add(new e4t(c5x2.h.b, CharacterState.Custom5, dz6.b(150), 0, null, 1));
				List<auv> list2 = awx.ad();
				a4s a4s2 = new a4s(new epw(new CharacterState?(CharacterState.Custom1)), null, null, null);
				a4s2.b(new ar7(c5x2));
				list2.Add(a4s2);
				if (aspect3 && aspect != null)
				{
					eon eon = new eon();
					eon.a(new List<string>(aspect.g()));
					List<auv> list3 = awx.ad();
					a4s a4s3 = new a4s(eon, null, null, null);
					a4s3.b(new ar7(c5x2));
					list3.Add(a4s3);
				}
				c5x2.i.b.b(awx, atp.a);
			}
		}
	}

	// Token: 0x04002409 RID: 9225
	private new Guid? a;

	// Token: 0x0400240A RID: 9226
	private string b;

	// Token: 0x0400240B RID: 9227
	private string c;
}
