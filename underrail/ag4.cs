using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;

// Token: 0x020012FB RID: 4859
[eiz("FREA")]
[a(typeof(bim))]
[Serializable]
public sealed class ag4 : bim, c98
{
	// Token: 0x06006C13 RID: 27667 RVA: 0x002D5888 File Offset: 0x002D3A88
	private ag4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.j = (A_0.GetValue("FREA:H", typeof(EntityAspectReference<b8b, b8b>)) as EntityAspectReference<b8b, b8b>);
		this.i = A_0.GetDouble("FREA:T");
		this.k = (A_0.GetValue("FREA:FA", typeof(List<Point>)) as List<Point>);
	}

	// Token: 0x06006C14 RID: 27668 RVA: 0x002D58F0 File Offset: 0x002D3AF0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FREA:H", this.j);
		info.AddValue("FREA:T", this.i);
		info.AddValue("FREA:FA", this.k);
	}

	// Token: 0x06006C15 RID: 27669 RVA: 0x002D5938 File Offset: 0x002D3B38
	public ag4(c5x A_0) : base(A_0)
	{
		this.h();
	}

	// Token: 0x06006C16 RID: 27670 RVA: 0x002D5948 File Offset: 0x002D3B48
	public void r7(eds A_0)
	{
		if (dz6.e())
		{
			if (this.j != null)
			{
				this.f();
			}
			this.h();
			this.g();
			return;
		}
		if (this.k == null)
		{
			if (!this.l)
			{
				this.b();
				return;
			}
		}
		else if (this.j != null)
		{
			if ((this.i -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.f();
				this.h();
				return;
			}
		}
		else if ((this.i -= A_0.b.TotalMilliseconds) <= 0.0)
		{
			if (this.e())
			{
				this.g();
				return;
			}
			this.h();
		}
	}

	// Token: 0x06006C17 RID: 27671 RVA: 0x002D5A1C File Offset: 0x002D3C1C
	public override void mx()
	{
		base.mx();
		base.a8().d = true;
	}

	// Token: 0x06006C18 RID: 27672 RVA: 0x002D5A30 File Offset: 0x002D3C30
	public override avd[] jz()
	{
		return new avd[]
		{
			new avd("reelin", "Abilities.94", "Катушка", "Попробуйте выловить, то что клюнет."),
			new avd("dismantle", "Abilities.93", "Расснастить", "Собрать и взять удочку.")
		};
	}

	// Token: 0x06006C19 RID: 27673 RVA: 0x002D5A70 File Offset: 0x002D3C70
	protected override void mz(c5x A_0, string A_1 = null)
	{
		base.mz(A_0, A_1);
		if (A_0 != null && A_0.h.b != null)
		{
			if (A_1 == null || A_1 == "reelin")
			{
				if (A_0.h.b.aa().b(d8o.t))
				{
					bmj.a(base.a8(), new d53("Вы не можете взять удочку этими отростками.", adi.m, null, false));
					return;
				}
				if (this.j != null && this.j.ao() != null)
				{
					coh coh = null;
					if (this.j.ao().a8() != null && this.j.ao().a8().j == cgy.b)
					{
						coh = this.j.ao().b(A_0.h.b.aa());
					}
					if (coh != null)
					{
						if (A_0.IsPlayer)
						{
							bmj.a(base.a8(), new d53("Попалась!", Color.White, null, false));
						}
						base.a8().c().a(Guid.NewGuid().ToString(), "FishingSuccess", 1f, c9z.a, false, false);
						mk mk = new mk();
						mk.GiveTo = bvl.c;
						mk.StaticItems.z3(coh, true);
						mk.PublishEventsForPlayer = true;
						mk.ym(null, A_0, null);
					}
					else
					{
						bmj.a(base.a8(), new d53("Сорвалась!", Color.Red, null, false));
						base.a8().c().a(Guid.NewGuid().ToString(), "FishingFailure", 1f, c9z.a, false, false);
					}
					this.f();
					return;
				}
				bmj.a(base.a8(), new d53("Ничего не клюёт.", Color.OrangeRed, null, false));
				this.h();
				return;
			}
			else if (A_1 == "dismantle" && A_0.IsPlayer)
			{
				coh coh2 = new d48(ez2.CreateDefinitonProvider<ebz>("Devices\\FishingRod"));
				if (coh2 != null)
				{
					if (base.a8().i.b != null)
					{
						base.a8().i.b.a(true, false);
					}
					c7 a_ = new c7(base.a8(), false, false, true, false);
					base.a8().Zone.ActionManager.g9(a_, atp.a);
					mk mk2 = new mk();
					mk2.GiveTo = bvl.c;
					mk2.StaticItems.z3(coh2, true);
					mk2.PublishEventsForPlayer = true;
					mk2.ym(null, A_0, null);
				}
			}
		}
	}

	// Token: 0x06006C1A RID: 27674 RVA: 0x002D5D0C File Offset: 0x002D3F0C
	private void h()
	{
		this.i = (0.75 + zp.a.NextDouble() * 0.5) * 5000.0;
	}

	// Token: 0x06006C1B RID: 27675 RVA: 0x002D5D3C File Offset: 0x002D3F3C
	private void g()
	{
		this.i = (0.8 + zp.a.NextDouble() * 0.4) * 4000.0;
	}

	// Token: 0x06006C1C RID: 27676 RVA: 0x002D5D70 File Offset: 0x002D3F70
	private void f()
	{
		if (base.a8().i.b != null)
		{
			base.a8().i.b.a(m7.b, true, false);
		}
		if (base.a8().o.b != null && base.a8().i.b != null && base.a8().o.b.b.X > 0)
		{
			dqm dqm = new dqm(base.a8().o.b);
			dqm.b(base.a8().o.b.b.X);
			dqm.a(-1);
			dqm.a(175.0);
			dqm.c(base.a8().o.b.b.X);
			dqm.a(true);
			base.a8().i.b.b(dqm, atp.a);
		}
		this.j = null;
		this.h();
	}

	// Token: 0x06006C1D RID: 27677 RVA: 0x002D5E8C File Offset: 0x002D408C
	private bool e()
	{
		List<b8b> list = this.d();
		if (list.Count > 0)
		{
			int index = zp.a.Next(list.Count);
			this.j = new EntityAspectReference<b8b, b8b>(list[index]);
			this.m = false;
			if (base.a8().i.b != null && base.a8().o.b != null)
			{
				dtb dtb = new dtb();
				dtb.a(m7.b);
				dqm dqm = new dqm(base.a8().o.b);
				dqm.b(1);
				dqm.a(1);
				dqm.a(175.0);
				dqm.c(2);
				dqm.a(false);
				dqm dqm2 = new dqm(base.a8().o.b);
				dqm2.b(2);
				dqm2.a(-1);
				dqm2.a(175.0);
				dqm2.c(1);
				dqm2.a(false);
				dtb.ad().Add(dqm);
				dtb.ad().Add(dqm2);
				base.a8().i.b.b(dtb, atp.c);
			}
			return true;
		}
		return false;
	}

	// Token: 0x06006C1E RID: 27678 RVA: 0x002D5FC8 File Offset: 0x002D41C8
	private List<b8b> d()
	{
		List<b8b> list = new List<b8b>();
		if (this.k != null && this.k.Count > 0)
		{
			foreach (Point a_ in this.k)
			{
				ak1 ak = base.a8().Area.a(a_);
				if (ak != null && ak.Formation.b(64L))
				{
					foreach (b0b b0b in ak.Entities)
					{
						c5x c5x = (c5x)b0b;
						if (c5x.w.b != null && !c5x.w.b.b() && zp.a.NextDouble() < (double)c5x.w.b.f())
						{
							list.Add(c5x.w.b);
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06006C1F RID: 27679 RVA: 0x002D6110 File Offset: 0x002D4310
	private void b()
	{
		this.l = true;
		anp anp = new anp(this.a(), base.a8().Area, 5f, 64L, true, 0L);
		anp.c(false);
		anp.a(new EventHandler<EventArgs>(this.a));
		anp.k();
	}

	// Token: 0x06006C20 RID: 27680 RVA: 0x002D6164 File Offset: 0x002D4364
	private Point a()
	{
		Point point = base.a8().Location.a();
		Point point2 = base.a8().Size.a();
		switch (base.a8().VisualDirection)
		{
		case HorizontalDirection.North:
		case HorizontalDirection.West:
			return point;
		case HorizontalDirection.East:
			return new Point(point.X + (point2.X - 1), point.Y);
		case HorizontalDirection.South:
			return new Point(point.X, point.Y + (point2.Y - 1));
		}
		return point;
	}

	// Token: 0x06006C21 RID: 27681 RVA: 0x002D6200 File Offset: 0x002D4400
	[dcc("FREA:mIF")]
	private void a(object A_0, EventArgs A_1)
	{
		anp anp = A_0 as anp;
		this.k = new List<Point>();
		this.l = false;
		if (anp != null && anp.f() != null)
		{
			this.k.AddRange(anp.f());
		}
	}

	// Token: 0x04002C57 RID: 11351
	private new const int a = 5000;

	// Token: 0x04002C58 RID: 11352
	private const double b = 0.5;

	// Token: 0x04002C59 RID: 11353
	private const int c = 4000;

	// Token: 0x04002C5A RID: 11354
	private const double d = 0.4;

	// Token: 0x04002C5B RID: 11355
	private const int e = 1;

	// Token: 0x04002C5C RID: 11356
	private const int f = 4;

	// Token: 0x04002C5D RID: 11357
	private const int g = 5;

	// Token: 0x04002C5E RID: 11358
	private const int h = 175;

	// Token: 0x04002C5F RID: 11359
	private double i;

	// Token: 0x04002C60 RID: 11360
	private new EntityAspectReference<b8b, b8b> j;

	// Token: 0x04002C61 RID: 11361
	private new List<Point> k;

	// Token: 0x04002C62 RID: 11362
	[NonSerialized]
	private new bool l;

	// Token: 0x04002C63 RID: 11363
	[NonSerialized]
	private bool m;
}
