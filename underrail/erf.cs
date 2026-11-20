using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Ouroboros.Common.Data;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200204E RID: 8270
public class erf : euz, dyo, bcn
{
	// Token: 0x0600C421 RID: 50209 RVA: 0x00441224 File Offset: 0x0043F424
	public string e()
	{
		return this.k;
	}

	// Token: 0x0600C422 RID: 50210 RVA: 0x0044122C File Offset: 0x0043F42C
	public void b(string A_0)
	{
		if (this.k != A_0)
		{
			this.k = A_0;
			this.d.Text = this.k;
		}
	}

	// Token: 0x0600C423 RID: 50211 RVA: 0x00441258 File Offset: 0x0043F458
	protected ali j()
	{
		return this.d;
	}

	// Token: 0x0600C424 RID: 50212 RVA: 0x00441260 File Offset: 0x0043F460
	protected ec9 h()
	{
		return this.e;
	}

	// Token: 0x0600C425 RID: 50213 RVA: 0x00441268 File Offset: 0x0043F468
	public bool auj()
	{
		return this.f;
	}

	// Token: 0x0600C426 RID: 50214 RVA: 0x00441270 File Offset: 0x0043F470
	public void auk(bool A_0)
	{
		if (this.f != A_0)
		{
			this.f = A_0;
			this.b();
		}
	}

	// Token: 0x0600C427 RID: 50215 RVA: 0x0044128C File Offset: 0x0043F48C
	public esj g()
	{
		return this.g;
	}

	// Token: 0x0600C428 RID: 50216 RVA: 0x00441294 File Offset: 0x0043F494
	public void a(esj A_0)
	{
		if (esj.c(this.g, A_0))
		{
			this.g = A_0;
			this.d();
			this.b();
		}
	}

	// Token: 0x0600C429 RID: 50217 RVA: 0x004412BC File Offset: 0x0043F4BC
	public string k()
	{
		return this.e.c;
	}

	// Token: 0x0600C42A RID: 50218 RVA: 0x004412CC File Offset: 0x0043F4CC
	public void c(string A_0)
	{
		this.e.c = A_0;
	}

	// Token: 0x0600C42B RID: 50219 RVA: 0x004412DC File Offset: 0x0043F4DC
	public Color f()
	{
		return this.d.h();
	}

	// Token: 0x0600C42C RID: 50220 RVA: 0x004412EC File Offset: 0x0043F4EC
	public void a(Color A_0)
	{
		this.d.a(A_0);
	}

	// Token: 0x0600C42D RID: 50221 RVA: 0x004412FC File Offset: 0x0043F4FC
	public string i()
	{
		return this.l;
	}

	// Token: 0x0600C42E RID: 50222 RVA: 0x00441304 File Offset: 0x0043F504
	public void a(string A_0)
	{
		this.l = A_0;
	}

	// Token: 0x0600C42F RID: 50223 RVA: 0x00441310 File Offset: 0x0043F510
	[CompilerGenerated]
	public void aul(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.p;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.p, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C430 RID: 50224 RVA: 0x00441348 File Offset: 0x0043F548
	[CompilerGenerated]
	public void aum(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.p;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.p, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C431 RID: 50225 RVA: 0x00441380 File Offset: 0x0043F580
	public erf(IEnumerable<eza> A_0, int A_1, esj A_2, int A_3 = 300, int A_4 = 50, bool A_5 = true)
	{
		if (A_0 != null)
		{
			eza eza = Enumerable.FirstOrDefault<eza>(A_0);
			if (eza != null && eza.Value != null)
			{
				this.l = eza.Value.Group;
			}
		}
		this.i = new List<eza>(A_0);
		this.g = A_2;
		this.h = A_1;
		this.j.c = A_3;
		this.j.d = A_4;
		this.f = A_5;
		this.c();
	}

	// Token: 0x0600C432 RID: 50226 RVA: 0x0044143C File Offset: 0x0043F63C
	public override void iv(e6d A_0, cp9 A_1)
	{
		wj wj = wj.a();
		base.iv(A_0, A_1);
		if (!this.f && this.i != null && this.i.Count > 0)
		{
			Point point = base.at();
			int num = point.Y + this.d.Size.d + this.h + this.g.d;
			int num2 = point.X + this.b;
			for (int i = 0; i < this.i.Count; i++)
			{
				eza eza = this.i[i];
				dn3 dn;
				this.n.TryGetValue(this.i[i], out dn);
				if (dn != null)
				{
					dn.a(new Point(num2, num), A_1, null, 1f);
				}
				Texture2D resource = A_1.a.GetResource<Texture2D>(this.m, null);
				if (resource != null)
				{
					if (wj.c())
					{
						A_1.b().w5(resource, new Vector2((float)(num2 - 20), (float)(num - 5)), new Rectangle?(this.c[eza.State]), this.a(eza));
					}
					else
					{
						Vector2 vector = Vector2.Zero;
						string assetName = this.a(true);
						SpriteFont resource2 = A_1.a.GetResource<SpriteFont>(assetName, null);
						if (resource2 != null)
						{
							vector = resource2.MeasureString("0");
						}
						A_1.b().w5(resource, new Vector2((float)(num2 - wj.el.c), (float)num - ((float)wj.el.d - vector.Y) / 2f), new Rectangle?(this.c[eza.State]), this.a(eza));
					}
				}
				num += dn.b.d + this.a;
			}
		}
	}

	// Token: 0x0600C433 RID: 50227 RVA: 0x0044163C File Offset: 0x0043F83C
	public void ata(int A_0)
	{
		this.e.Size = new esj(base.Size.c, A_0 - this.d.Size.d - this.h);
	}

	// Token: 0x0600C434 RID: 50228 RVA: 0x00441680 File Offset: 0x0043F880
	public override void aoy()
	{
		base.aoy();
		if (base.Size.c != this.o)
		{
			this.d();
			this.o = base.Size.c;
		}
		this.b();
	}

	// Token: 0x0600C435 RID: 50229 RVA: 0x004416C8 File Offset: 0x0043F8C8
	public void b(bool A_0)
	{
		this.d.a(A_0 ? adi.c : adi.a);
		this.d.a(A_0 ? 3 : 0);
	}

	// Token: 0x0600C436 RID: 50230 RVA: 0x00441704 File Offset: 0x0043F904
	private void a(object A_0, b25 A_1)
	{
		this.f = !this.f;
		this.b();
		if (this.p != null)
		{
			this.p(this, new EventArgs());
		}
	}

	// Token: 0x0600C437 RID: 50231 RVA: 0x00441738 File Offset: 0x0043F938
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.d.Size = new esj(base.Size.c, this.d.Size.d);
		this.e.Size = new esj(base.Size.c, this.e.Size.d);
		if (base.Size.c != this.o)
		{
			this.d();
			this.o = base.Size.c;
		}
	}

	// Token: 0x0600C438 RID: 50232 RVA: 0x004417D0 File Offset: 0x0043F9D0
	private void d()
	{
		if (this.d != null)
		{
			this.d.a(adi.a);
			this.d.b(adi.c);
			this.d.c(adi.c);
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.n = new Dictionary<eza, dn3>();
		foreach (eza eza in this.i)
		{
			if (!eza.Read && this.d != null)
			{
				this.d.a(adi.d);
				this.d.b(adi.d);
				this.d.c(adi.d);
			}
			ecs ecs = new ecs();
			string a_ = this.a(eza.Read);
			string text;
			if (eza.Value != null && !string.IsNullOrEmpty(eza.Value.DisplayText))
			{
				bq8 a_2;
				if (serviceOrThrow.aqu() != null)
				{
					a_2 = serviceOrThrow.aqu().e();
				}
				else
				{
					a_2 = new PropertyCollection();
				}
				text = qv.b("quests/" + eza.Name);
				text = eb2.a(a_2, new PropertyCollection(), text);
			}
			else
			{
				text = "????";
			}
			ecs.a.Add(new dl6(new bph[]
			{
				new bph(new d22(a_, this.a(eza)), text, null)
			}));
			List<ecs> list = ecs.a(base.Size.c - 2 * this.g.c - this.b, 0);
			if (list != null && list.Count > 0)
			{
				this.n[eza] = list[0].b();
			}
			else
			{
				this.n[eza] = null;
			}
		}
	}

	// Token: 0x0600C439 RID: 50233 RVA: 0x004419E8 File Offset: 0x0043FBE8
	private string a(bool A_0)
	{
		wj wj = wj.a();
		if (wj.c())
		{
			string result;
			string result2;
			if (egg.v)
			{
				result = egg.t;
				result2 = egg.n;
			}
			else if (A_0)
			{
				result = egg.@as;
				result2 = egg.ad;
			}
			else
			{
				result = egg.au;
				result2 = egg.ac;
			}
			if (pp.b.aq1().b().h() == InterfaceElementSize2.Small)
			{
				return result2;
			}
			return result;
		}
		else
		{
			if (A_0)
			{
				return wj.en;
			}
			return wj.em;
		}
	}

	// Token: 0x0600C43A RID: 50234 RVA: 0x00441A78 File Offset: 0x0043FC78
	private Color a(eza A_0)
	{
		Dictionary<e3c, Color> dictionary;
		if (A_0.Read)
		{
			dictionary = new Dictionary<e3c, Color>
			{
				{
					e3c.a,
					adi.c
				},
				{
					e3c.b,
					Color.Green
				},
				{
					e3c.c,
					Color.Red
				}
			};
		}
		else
		{
			dictionary = new Dictionary<e3c, Color>
			{
				{
					e3c.a,
					adi.d
				},
				{
					e3c.b,
					Color.LightGreen
				},
				{
					e3c.c,
					Color.Crimson
				}
			};
		}
		return dictionary[A_0.State];
	}

	// Token: 0x0600C43B RID: 50235 RVA: 0x00441AF8 File Offset: 0x0043FCF8
	private void c()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.c = new Dictionary<e3c, Rectangle>
			{
				{
					e3c.a,
					new Rectangle(0, 193, 16, 24)
				},
				{
					e3c.b,
					new Rectangle(16, 193, 16, 24)
				},
				{
					e3c.c,
					new Rectangle(32, 193, 16, 24)
				}
			};
		}
		else
		{
			this.m = wj.f;
			this.c = new Dictionary<e3c, Rectangle>
			{
				{
					e3c.a,
					new Rectangle(wj.ek.X, wj.ek.Y, wj.el.c, wj.el.d)
				},
				{
					e3c.b,
					new Rectangle(wj.ek.X + wj.el.c, wj.ek.Y, wj.el.c, wj.el.d)
				},
				{
					e3c.c,
					new Rectangle(wj.ek.X + 2 * wj.el.c, wj.ek.Y, wj.el.c, wj.el.d)
				}
			};
			this.b = wj.ep;
			this.a = wj.eq;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (wj.c())
		{
			this.d = new ali(bo1.au, new esj(43, 33));
			if (egg.v)
			{
				this.d.a((serviceOrThrow.aq1().b().h() != InterfaceElementSize2.Small) ? egg.t : egg.q);
			}
			else
			{
				this.d.a((serviceOrThrow.aq1().b().h() != InterfaceElementSize2.Small) ? egg.at : egg.al);
			}
		}
		else
		{
			this.d = new ali(wj.f, wj.er, wj.es);
			this.d.a(wj.eo);
		}
		this.d.a(new Vector2(0f, (float)egg.b(this.d.f())));
		this.d.a(adi.a);
		this.d.b(adi.c);
		this.d.c(adi.c);
		this.d.PropagateMouseScrollEvent = true;
		this.d.c(new EventHandler<b25>(this.a));
		this.d.IsPrivateComponent = true;
		this.d.Size = new esj(this.j.c, this.j.d);
		e4z.a(this.d);
		this.aox(this.d);
		this.e = new ec9();
		this.e.c = null;
		this.e.Location = new Point(0, this.d.Size.d + this.h);
		this.e.PropagateMouseScrollEvent = true;
		base.Size = this.j;
		this.b();
	}

	// Token: 0x0600C43C RID: 50236 RVA: 0x00441E48 File Offset: 0x00440048
	private void b()
	{
		this.d.Checked = !this.f;
		if (base.Controls.Contains(this.e))
		{
			this.g(this.e);
		}
		if (!this.f)
		{
			this.e.Size = this.a();
			this.aox(this.e);
			base.Size = new esj(base.Size.c, this.d.Size.d + this.e.Size.d + this.h);
			return;
		}
		base.Size = new esj(base.Size.c, this.j.d);
	}

	// Token: 0x0600C43D RID: 50237 RVA: 0x00441F18 File Offset: 0x00440118
	private esj a()
	{
		esj result = default(esj);
		if (this.i != null && this.i.Count > 0)
		{
			result.c = base.Size.c;
			int num = Enumerable.Sum<dn3>(Enumerable.Where<dn3>(this.n.Values, new Func<dn3, bool>(erf.a.a.a)), new Func<dn3, int>(erf.a.a.b)) + this.n.Count * this.a;
			result.d = (int)Math.Ceiling((double)num / (double)this.d.Size.d) * this.d.Size.d;
		}
		else
		{
			result.d = this.j.d;
			result.c = this.j.c;
		}
		return result;
	}

	// Token: 0x04004774 RID: 18292
	private new int a = 10;

	// Token: 0x04004775 RID: 18293
	private new int b = 30;

	// Token: 0x04004776 RID: 18294
	private new Dictionary<e3c, Rectangle> c;

	// Token: 0x04004777 RID: 18295
	private new ali d;

	// Token: 0x04004778 RID: 18296
	private new ec9 e;

	// Token: 0x04004779 RID: 18297
	private new bool f;

	// Token: 0x0400477A RID: 18298
	private new esj g = new esj(10, 15);

	// Token: 0x0400477B RID: 18299
	private int h;

	// Token: 0x0400477C RID: 18300
	private List<eza> i;

	// Token: 0x0400477D RID: 18301
	private new esj j;

	// Token: 0x0400477E RID: 18302
	private new string k;

	// Token: 0x0400477F RID: 18303
	private new string l;

	// Token: 0x04004780 RID: 18304
	private new string m = bo1.ad;

	// Token: 0x04004781 RID: 18305
	private Dictionary<eza, dn3> n = new Dictionary<eza, dn3>();

	// Token: 0x04004782 RID: 18306
	private int o;

	// Token: 0x04004783 RID: 18307
	[CompilerGenerated]
	private EventHandler<EventArgs> p;

	// Token: 0x0200204F RID: 8271
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C440 RID: 50240 RVA: 0x00442038 File Offset: 0x00440238
		internal bool a(dn3 A_0)
		{
			return A_0 != null;
		}

		// Token: 0x0600C441 RID: 50241 RVA: 0x00442040 File Offset: 0x00440240
		internal int b(dn3 A_0)
		{
			return A_0.b.d;
		}

		// Token: 0x04004784 RID: 18308
		public static readonly erf.a a = new erf.a();

		// Token: 0x04004785 RID: 18309
		public static Func<dn3, bool> b;

		// Token: 0x04004786 RID: 18310
		public static Func<dn3, int> c;
	}
}
