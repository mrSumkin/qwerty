using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020014BB RID: 5307
[eiz("P0")]
[Serializable]
public abstract class c11 : a6k, ISerializable
{
	// Token: 0x06007721 RID: 30497 RVA: 0x00324394 File Offset: 0x00322594
	protected c11(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007722 RID: 30498 RVA: 0x003243A0 File Offset: 0x003225A0
	protected c11()
	{
	}

	// Token: 0x06007723 RID: 30499 RVA: 0x003243A8 File Offset: 0x003225A8
	public virtual bool db()
	{
		return true;
	}

	// Token: 0x06007724 RID: 30500 RVA: 0x003243AC File Offset: 0x003225AC
	public virtual double? dc()
	{
		return new double?(0.55);
	}

	// Token: 0x06007725 RID: 30501 RVA: 0x003243BC File Offset: 0x003225BC
	public virtual bool dd()
	{
		return true;
	}

	// Token: 0x06007726 RID: 30502 RVA: 0x003243C0 File Offset: 0x003225C0
	public bool a(ak1 A_0, coh A_1, bool A_2 = false, int A_3 = 1, string A_4 = null)
	{
		c5x c5x;
		return this.a(A_0, A_1, out c5x, A_2, A_3, A_4);
	}

	// Token: 0x06007727 RID: 30503 RVA: 0x003243DC File Offset: 0x003225DC
	public bool a(ak1 A_0, coh A_1, out c5x A_2, bool A_3 = false, int A_4 = 1, string A_5 = null)
	{
		A_2 = null;
		if (A_0 != null && A_0.Area != null && A_1 != null)
		{
			if ((A_0.Formation.c(2L) && !A_0.Formation.c(128L)) || A_0.f(null) != 0L)
			{
				if (!A_3 && base.vg().q().IsPlayer)
				{
					bmj.a(base.vg().q(), new d53("Можно установить только на незанятое место.", adi.l, null, false));
				}
				return false;
			}
			IEnumerable<cos> enumerable = Enumerable.OfType<cos>(A_0.a(typeof(cos)) ?? new List<ya>());
			if (!A_3)
			{
				bool flag = false;
				foreach (cos cos in enumerable)
				{
					cos.a(base.vg().q());
					flag = true;
				}
				if (flag)
				{
					return true;
				}
			}
			d02 service = bpo.GetService<d02>();
			cnk service2 = bpo.GetService<cnk>();
			List<Guid> list = new List<Guid>();
			if (!A_3 && service2 != null && service != null && service2.aqu() != null)
			{
				r0 r = new r0(A_0.Area.c(), new Vector2((float)A_0.Location.X, (float)A_0.Location.Y));
				foreach (d4n d4n in service.ahl())
				{
					if (d4n.b.aa().a(service2.aqu().ac(), base.vg().e().b8().FactionId) == h.e)
					{
						list.Add(d4n.b.a8().qe());
					}
					else if (service.ahg() && d4n.b != null && d4n.b.a8() != null && d4n.b.a8().t.b != null && d4n.b.a8().t.b.b(service).Contains(r))
					{
						double num = aw1.a(d4n.b.a8(), A_0);
						if (d4n.b.aa().b(d8o.b | d8o.d | d8o.h) && num <= (double)Math.Min(4f, d4n.b.aa().SightRange) && service2.aqu().ac().abt(d4n.b.aa().FactionId).h())
						{
							awq.a(d4n.b.a8(), base.vg().q(), false, false, false, true, false, false);
						}
					}
				}
			}
			c4j c4j = A_1.Definition as c4j;
			if (c4j != null)
			{
				string text = this.di();
				string a = this.de();
				Point point = this.dh(A_1);
				A_2 = new c5x();
				if (A_3)
				{
					A_2.q(text);
				}
				else
				{
					A_2.q(text + (base.vg().q().IsPlayer ? " (игрок)" : ""));
				}
				A_2.Location = new Vector3((float)A_0.Location.X, (float)A_0.Location.Y, 0f);
				A_2.Size = new Vector3(1f, 1f, 0.2f);
				A_2.IsGround = true;
				A_2.VisualPriority = int.MaxValue;
				A_2.Layer = aju.x;
				A_2.TileFormationModifiers.s3(10);
				A_2.d = true;
				alv alv = new alv(A_2);
				alv.a.Add(new cd0(A_2)
				{
					a = a,
					b = point
				});
				if (this.db())
				{
					List<cd0> a2 = alv.a;
					etz etz = new etz(A_2);
					etz.a = a;
					etz.b = new Point(point.X + 1, point.Y);
					etz.c = new Color?(this.tf());
					etz.a(point.X + 1);
					etz.c(2);
					etz.d(350);
					a2.Add(etz);
				}
				A_2.SetAspect<alv>(alv);
				ed2 ed;
				if (A_3)
				{
					ed = new ed2(A_2, null);
				}
				else
				{
					ed = new ed2(A_2, base.vg().q().h.b);
				}
				ed.a(int.MaxValue);
				foreach (Guid guid in list)
				{
					ed.a.Add(guid);
				}
				if (A_3)
				{
					ed.c = (int)(c4j.a() * (double)A_4);
					ed.d = A_4;
					ed.f = A_5;
				}
				else
				{
					double num2 = c4j.a() * (double)base.vg().e().b8().Skills.Get<c0b>().g();
					if (base.vg().e().b8().Feats.Contains<c62>())
					{
						num2 *= 1.0 + c62.b + (double)base.vg().e().b8().GetSpecializationValue<coi>(true) * coi.a;
					}
					ed.c = (int)num2;
					ed.d = base.vg().e().b8().Skills.Get<c0b>().g();
					ed.a.Add(base.vg().q().qe());
				}
				ed.g = this.dg();
				ed.i = this.db();
				ed.h = this.tg();
				if (!A_3 && base.vg().q().IsPlayer)
				{
					ed.a(true);
				}
				A_2.SetAspect<b4h>(ed);
				if (this.dd())
				{
					anc anc = new anc(A_2);
					anc.a().Add(new cqb());
					A_2.SetAspect<anc>(anc);
				}
				bim bim = new bim(A_2);
				bim.k = true;
				A_2.SetAspect<bim>(bim);
				A_0.Area.a(A_2);
				coh coh = A_1.fy();
				coh.Stacks = 1;
				cos cos2 = this.dj(A_2, coh);
				if (cos2 != null)
				{
					cos2.Location = A_0.Location;
					cos2.Size = new esj(1, 1);
					cos2.Layer = aju.x;
					cos2.TriggeringRadius = this.dc();
					A_0.Area.b(cos2);
					if (!A_3)
					{
						string text2 = this.df();
						if (!string.IsNullOrEmpty(text2))
						{
							A_2.c().a("arming", text2, 1f, c9z.a, false, false);
						}
					}
					if (!A_3 && base.vg().q().h.b != null)
					{
						a4l a4l = Enumerable.FirstOrDefault<a4l>(base.vg().q().h.b.aa().StatusEffects.Get<a4l>());
						if (a4l != null)
						{
							base.vg().q().h.b.aa().StatusEffects.d(a4l);
						}
					}
					return true;
				}
			}
		}
		return true;
	}

	// Token: 0x06007728 RID: 30504 RVA: 0x00324C08 File Offset: 0x00322E08
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 a_ = base.vg().h() as ak1;
		coh a_2 = base.vg().e().b9() as coh;
		if (this.a(a_, a_2, false, 1, null))
		{
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06007729 RID: 30505 RVA: 0x00324C50 File Offset: 0x00322E50
	protected virtual Color tg()
	{
		return Color.Red;
	}

	// Token: 0x0600772A RID: 30506 RVA: 0x00324C58 File Offset: 0x00322E58
	protected virtual Color tf()
	{
		return Color.DarkOrange;
	}

	// Token: 0x0600772B RID: 30507
	protected abstract string de();

	// Token: 0x0600772C RID: 30508
	protected abstract string di();

	// Token: 0x0600772D RID: 30509
	protected abstract Point dh(coh A_0);

	// Token: 0x0600772E RID: 30510
	protected abstract string df();

	// Token: 0x0600772F RID: 30511
	protected abstract string dg();

	// Token: 0x06007730 RID: 30512
	protected abstract cos dj(c5x A_0, coh A_1);
}
