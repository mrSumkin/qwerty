using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.UI;

// Token: 0x02002055 RID: 8277
public sealed class arv : ec9, ctv, e8p
{
	// Token: 0x0600C480 RID: 50304 RVA: 0x00444398 File Offset: 0x00442598
	public arv(SavedGameManipulationMode A_0, abx A_1)
	{
		this.b = A_0;
		this.c = A_1;
		this.h();
	}

	// Token: 0x0600C481 RID: 50305 RVA: 0x004443D4 File Offset: 0x004425D4
	private void h()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			base.Size = new esj(900, 600);
			this.c = bo1.m;
		}
		else
		{
			esj fu = wj.fu;
			wj.a().a(ref fu.d);
			base.Size = fu;
			this.c = wj.f;
			this.e = wj.b6;
			this.d = new esj?(wj.b7);
		}
		this.Focusable = true;
		base.g(new EventHandler<ane>(this.a));
		this.g();
		if (wj.c())
		{
			this.d = new cj5(this.r, this);
		}
		else
		{
			this.d = new cj5(this.r, this, typeof(dg8));
		}
		this.d.Location = new Point(this.a, this.a);
		if (wj.c())
		{
			this.d.Size = new esj(450, 490);
		}
		else
		{
			this.d.a(wj.bm.c);
			this.d.Size = new esj((base.Size.c - 3 * this.a) / 2, wj.h5);
			this.d.c(wj.h4);
			this.d.c = wj.f;
			this.d.e = wj.b8;
			this.d.d = new esj?(wj.b9);
			this.d.e(wj.h6);
		}
		this.d.IsPrivateComponent = true;
		this.aox(this.d);
		this.e = new ec9();
		if (wj.c())
		{
			this.e.Location = new Point(this.d.Location.X + this.d.Size.c + 15, this.d.Location.Y);
			this.e.Size = new esj(393, 300);
			this.e.c = bo1.w;
		}
		else
		{
			this.e.Location = new Point(this.d.Location.X + this.d.Size.c + this.a, this.d.Location.Y);
			this.e.Size = new esj(this.d.Size.c, (int)((float)this.d.Size.d * 0.6f));
			this.e.c = wj.f;
			this.e.e = wj.fm;
			this.e.d = new esj?(wj.fn);
		}
		this.e.IsPrivateComponent = true;
		this.aox(this.e);
		this.f = new avo();
		this.f.Location = new Point(this.e.Location.X, this.e.Location.Y + this.e.Size.d + this.a);
		if (wj.c())
		{
			this.f.a(egg.b);
			this.f.Size = new esj(this.e.Size.c, 30);
		}
		else
		{
			this.f.a(wj.h0);
			this.f.Size = new esj(this.e.Size.c, wj.h1);
		}
		this.f.IsPrivateComponent = true;
		this.f.Color = adi.a;
		this.aox(this.f);
		this.g = new avo();
		this.g.Location = new Point(this.f.Location.X, this.f.Location.Y + this.f.Size.d + 5);
		if (wj.c())
		{
			if (egg.v)
			{
				this.g.a(egg.a);
			}
			else
			{
				this.g.a(egg.@as);
			}
			this.g.Size = new esj(this.e.Size.c, 25);
		}
		else
		{
			this.g.a(wj.h2);
			this.g.Size = new esj(this.e.Size.c, wj.h3);
		}
		this.g.IsPrivateComponent = true;
		this.g.Color = adi.a;
		this.aox(this.g);
		this.h = new avo();
		this.h.Location = new Point(this.g.Location.X, this.g.Location.Y + this.g.Size.d + 5);
		this.h.Size = new esj(this.e.Size.c, this.g.Size.d);
		this.h.IsPrivateComponent = true;
		this.h.Color = adi.a;
		this.h.a(this.g.g());
		this.aox(this.h);
		this.j = new avo();
		this.j.Location = new Point(this.h.Location.X, this.h.Location.Y + this.h.Size.d + 5);
		this.j.Size = new esj(this.e.Size.c, this.g.Size.d);
		this.j.IsPrivateComponent = true;
		this.j.a(this.g.g());
		this.j.Color = adi.a;
		this.aox(this.j);
		this.k = new avo();
		this.k.Location = new Point(this.j.Location.X, this.j.Location.Y + this.j.Size.d + 5);
		this.k.Size = new esj(this.e.Size.c, this.g.Size.d);
		this.k.IsPrivateComponent = true;
		this.k.a(this.g.g());
		this.k.Color = adi.a;
		this.aox(this.k);
		this.i = new avo();
		this.i.Location = new Point(this.k.Location.X, this.k.Location.Y + this.k.Size.d + 5);
		this.i.Size = new esj(this.e.Size.c, this.g.Size.d);
		this.i.IsPrivateComponent = true;
		this.i.a(this.g.g());
		this.i.Color = adi.a;
		this.aox(this.i);
		this.m = new dak();
		arv.a(this.m);
		if (wj.c())
		{
			this.m.Location = new Point(760, 550);
		}
		else
		{
			this.m.Location = new Point(base.Size.c - this.a - this.m.Size.c, base.Size.d - this.a - this.m.Size.d);
		}
		this.m.Text = dh9.c("Cancel");
		this.m.c(new EventHandler<b25>(this.a));
		this.m.IsPrivateComponent = true;
		this.aox(this.m);
		this.l = new dak();
		arv.a(this.l);
		if (wj.c())
		{
			this.l.Location = new Point(620, 550);
		}
		else
		{
			this.l.Location = new Point(this.m.Location.X - this.a - this.l.Size.c, this.m.Location.Y);
		}
		this.l.Text = dh9.c("SaveLoad_Button_" + this.b.ToString());
		this.l.c(new EventHandler<b25>(this.c));
		this.l.IsPrivateComponent = true;
		this.aox(this.l);
		this.n = new dak();
		arv.a(this.n);
		if (wj.c())
		{
			this.n.Location = new Point(20, 550);
		}
		else
		{
			this.n.Location = new Point(this.a, this.l.Location.Y);
		}
		this.n.Text = dh9.c("Delete_Button");
		this.n.c(new EventHandler<b25>(this.b));
		this.n.IsPrivateComponent = true;
		this.aox(this.n);
		this.o = new bg1();
		this.o.a = true;
		this.o.c = new Func<Texture2D>(this.b);
		this.aox(this.o);
		this.f();
	}

	// Token: 0x0600C482 RID: 50306 RVA: 0x00444EB0 File Offset: 0x004430B0
	private static void a(dak A_0)
	{
		wj wj = wj.a();
		if (wj.c())
		{
			A_0.Size = new esj(120, 35);
			A_0.Font = egg.b;
			A_0.d = bo1.y;
			A_0.TextLabelOffset = new Point(0, 6);
		}
		else
		{
			A_0.Size = wj.f3;
			A_0.Font = wj.f5;
			A_0.TextLabelOffset = new Point(0, wj.f4);
			A_0.d = wj.f;
			A_0.f = wj.e3;
			A_0.e = new esj?(wj.e4);
		}
		A_0.g = adi.a;
		A_0.j = adi.b;
		e4z.j(A_0);
	}

	// Token: 0x0600C483 RID: 50307 RVA: 0x00444F74 File Offset: 0x00443174
	private void g()
	{
		this.r.Clear();
		this.s.Clear();
		if (this.b == SavedGameManipulationMode.Save)
		{
			a3r a3r = new a3r();
			a3r.Name = dh9.c("SaveLoad_<New>");
			a3r.New = true;
			this.r.Add(a3r);
			this.s.Add(a3r, this.b(a3r));
		}
		foreach (a3r a3r2 in bpo.GetServiceOrThrow<cnk>().arm())
		{
			this.r.Add(a3r2);
			this.s.Add(a3r2, this.b(a3r2));
		}
	}

	// Token: 0x0600C484 RID: 50308 RVA: 0x00445048 File Offset: 0x00443248
	private afg b(a3r A_0)
	{
		afg afg = new afg();
		afg.Text = A_0.Name;
		afg.VerticalTextAlignment = ad4.b;
		afg.HorizontalTextAlignment = cab.b;
		afg.CheckOnClick = false;
		afg.c(new EventHandler<b25>(this.e));
		afg.i(new EventHandler<b25>(this.d));
		e4z.f(afg);
		return afg;
	}

	// Token: 0x0600C485 RID: 50309 RVA: 0x004450A8 File Offset: 0x004432A8
	private void f()
	{
		if (this.s != null && this.s.Count > 0)
		{
			this.a(Enumerable.First<afg>(this.s.Values));
			return;
		}
		this.a(null);
	}

	// Token: 0x0600C486 RID: 50310 RVA: 0x004450E8 File Offset: 0x004432E8
	private void a(a3r A_0)
	{
		this.e();
		this.q = A_0;
		if (A_0 != null && !A_0.New)
		{
			this.f.Text = string.Format("{0} - " + dh9.c("Level") + " {1}", A_0.CharacterName, A_0.CharacterLevel);
			this.g.Text = A_0.Location;
			this.h.Text = A_0.SaveTime.ToString();
			if (A_0.PlayTime != null)
			{
				this.j.Text = dh9.c("SaveLoad_PlayTime") + ": ";
				if (A_0.PlayTime.Value >= TimeSpan.FromDays(1.0))
				{
					avo avo = this.j;
					avo.Text += A_0.PlayTime.Value.ToString("d\\:hh\\:mm");
				}
				else
				{
					avo avo2 = this.j;
					avo2.Text += A_0.PlayTime.Value.ToString("hh\\:mm");
				}
			}
			else
			{
				this.j.Text = null;
			}
			if (A_0.Difficulty != null)
			{
				this.k.Text = dh9.c("Difficulty") + ": " + dh9.c("NewGame_GameDifficulty_" + A_0.Difficulty.Value.ToString());
			}
			else
			{
				this.k.Text = dh9.c("Difficulty") + ": ?";
			}
			this.i.Text = dh9.c("Version") + ": " + A_0.GameVersion.ToString();
			if (A_0.DLCs != null && A_0.DLCs.Count > 0)
			{
				avo avo3 = this.i;
				avo3.Text += " (";
				for (int i = 0; i < A_0.DLCs.Count; i++)
				{
					if (i != 0)
					{
						avo avo4 = this.i;
						avo4.Text += ", ";
					}
					avo avo5 = this.i;
					avo5.Text += dk2.d(A_0.DLCs[i]);
				}
				avo avo6 = this.i;
				avo6.Text += ")";
			}
			if (ast.a(A_0.GameVersion, A_0.DLCs))
			{
				this.i.Color = Color.Red;
			}
			else if (ast.a(A_0.GameVersion))
			{
				this.i.Color = Color.OrangeRed;
			}
			else
			{
				this.i.Color = adi.a;
			}
			string text = Path.Combine(d5x.d(A_0.FolderName), "screenshot.png");
			try
			{
				bef serviceOrThrow = bpo.GetServiceOrThrow<bef>();
				this.p = e3v.a(serviceOrThrow.k9(), text);
				goto IL_3E0;
			}
			catch (Exception a_)
			{
				dux.a(LogSeverity.Warning, a_, "Не удалось загрузить снимок экрана из '{0}'.", new object[]
				{
					text
				});
				goto IL_3E0;
			}
		}
		this.f.Text = null;
		this.h.Text = null;
		this.j.Text = null;
		if (A_0 != null && A_0.New)
		{
			this.g.Text = dh9.c("SaveLoad_SaveInNewSlot");
		}
		else
		{
			this.g.Text = null;
		}
		this.k.Text = null;
		this.i.Text = null;
		IL_3E0:
		this.l.Enabled = (A_0 != null);
		this.n.Enabled = (A_0 != null && !A_0.New);
	}

	// Token: 0x0600C487 RID: 50311 RVA: 0x00445514 File Offset: 0x00443714
	private new void e()
	{
		if (this.p != null)
		{
			this.p.Dispose();
			this.p = null;
		}
	}

	// Token: 0x0600C488 RID: 50312 RVA: 0x00445534 File Offset: 0x00443734
	private void a(afg A_0)
	{
		foreach (KeyValuePair<a3r, afg> keyValuePair in this.s)
		{
			if (keyValuePair.Value == A_0)
			{
				keyValuePair.Value.Checked = true;
				this.a(keyValuePair.Key);
			}
			else
			{
				keyValuePair.Value.Checked = false;
			}
		}
	}

	// Token: 0x0600C489 RID: 50313 RVA: 0x004455C0 File Offset: 0x004437C0
	private new void d()
	{
		base.z();
		if (this.c == abx.a)
		{
			bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.ReturnToMainMenu, new object[0]));
		}
	}

	// Token: 0x0600C48A RID: 50314 RVA: 0x004455EC File Offset: 0x004437EC
	private new bool c()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (!this.q.New && serviceOrThrow.aq1().d().d())
		{
			base.a9();
			this.a(this.q.Name);
			return true;
		}
		e4u e4u = new e4u(this.q.Name);
		if (wj.a().d == UiSize.Classic)
		{
			e4u.Location = new Point((base.Size.c - e4u.Size.c) / 2, (base.Size.d - e4u.Size.d) / 2 + 100);
		}
		else
		{
			e4u.Location = new Point((base.Size.c - e4u.Size.c) / 2, (base.Size.d - e4u.Size.d) / 2);
		}
		e4u.Gravity = axy.c;
		this.aox(e4u);
		e4u.bj();
		e4u.d();
		e4u.a(new EventHandler<el5>(this.a));
		e4u.a(new EventHandler(this.a));
		return false;
	}

	// Token: 0x0600C48B RID: 50315 RVA: 0x00445720 File Offset: 0x00443920
	private void a(string A_0)
	{
		string text;
		if (!this.q.New && A_0 == this.q.Name)
		{
			text = this.q.FolderName;
		}
		else
		{
			text = bdo.a(A_0);
		}
		base.z();
		d4m serviceOrThrow = bpo.GetServiceOrThrow<d4m>();
		if (!this.q.New)
		{
			serviceOrThrow.avp(dla.a(TimelapseWorkflows.SaveGame, new object[]
			{
				text,
				this.q.FolderName
			}));
			return;
		}
		serviceOrThrow.avp(dla.a(TimelapseWorkflows.SaveGame, new object[]
		{
			text
		}));
	}

	// Token: 0x0600C48C RID: 50316 RVA: 0x004457C4 File Offset: 0x004439C4
	private Texture2D b()
	{
		return this.p;
	}

	// Token: 0x0600C48D RID: 50317 RVA: 0x004457CC File Offset: 0x004439CC
	protected override void i0()
	{
		base.i0();
		this.d.a9();
	}

	// Token: 0x0600C48E RID: 50318 RVA: 0x004457E0 File Offset: 0x004439E0
	protected override void i1()
	{
		base.i1();
		this.e();
	}

	// Token: 0x0600C48F RID: 50319 RVA: 0x004457F0 File Offset: 0x004439F0
	protected override void r4(object A_0, el5 A_1)
	{
		e4z.j();
		base.r4(A_0, A_1);
	}

	// Token: 0x0600C490 RID: 50320 RVA: 0x00445800 File Offset: 0x00443A00
	private new void e(object A_0, b25 A_1)
	{
		this.a(A_0 as afg);
	}

	// Token: 0x0600C491 RID: 50321 RVA: 0x00445810 File Offset: 0x00443A10
	private new void d(object A_0, b25 A_1)
	{
		this.a(A_0 as afg);
		if (this.l.Enabled)
		{
			this.l.a(eoo.b);
		}
	}

	// Token: 0x0600C492 RID: 50322 RVA: 0x0044583C File Offset: 0x00443A3C
	private new void c(object A_0, b25 A_1)
	{
		if (this.b != SavedGameManipulationMode.Load)
		{
			if (this.b == SavedGameManipulationMode.Save)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (!this.q.New && !serviceOrThrow.aq1().d().d())
				{
					bnr.a(new esj(400, 230), new arv.c(this), dh9.c("SaveLoad_OverwriteCaption"), dh9.c("SaveLoad_Overwrite"), "O", "C", null, null, 0, new cpk[]
					{
						new cpk("O", dh9.c("SaveLoad_Command_Overwrite"), true),
						new cpk("A", dh9.c("SaveLoad_Command_AutoOverwrite"), true),
						new cpk("C", dh9.c("Cancel"), true)
					}, this, this);
					return;
				}
				this.c();
			}
			return;
		}
		cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
		if (ast.a(this.q.GameVersion, this.q.DLCs))
		{
			bnr.a(new esj(550, 200), null, dh9.c("SaveLoad_LoadCaption"), dh9.c("SaveLoad_IncompatibleSave"), "O", "O", null, null, 0, new cpk[]
			{
				new cpk("O", dh9.c("OK"), true)
			}, this, this);
			return;
		}
		if (ast.a(this.q.GameVersion) && serviceOrThrow2.aq1().d().e())
		{
			bnr.a(new esj(550, 250), new arv.a(this), dh9.c("SaveLoad_LoadCaption"), dh9.c("SaveLoad_PartiallyCompatibleSave"), "Y", "N", null, null, 0, new cpk[]
			{
				new cpk("Y", dh9.c("Yes"), true),
				new cpk("A", dh9.c("YesAndStopAsking"), true),
				new cpk("N", dh9.c("No"), true)
			}, this, this);
			return;
		}
		this.a();
	}

	// Token: 0x0600C493 RID: 50323 RVA: 0x00445AA4 File Offset: 0x00443CA4
	private void a()
	{
		if (this.q != null && !ast.a(this.q.GameVersion, this.q.DLCs))
		{
			d4m serviceOrThrow = bpo.GetServiceOrThrow<d4m>();
			if (this.c == abx.a)
			{
				serviceOrThrow.avp(dla.a(TimelapseWorkflows.LoadGameFromMainMenu, new object[]
				{
					this.q
				}));
				return;
			}
			serviceOrThrow.avp(dla.a(TimelapseWorkflows.LoadGameFromLocale, new object[]
			{
				this.q
			}));
		}
	}

	// Token: 0x0600C494 RID: 50324 RVA: 0x00445B28 File Offset: 0x00443D28
	private void b(object A_0, b25 A_1)
	{
		if (this.q == null || string.IsNullOrEmpty(this.q.FolderName))
		{
			return;
		}
		bnr.a(new esj(500, 200), new arv.b(this, this.q), dh9.c("SaveLoad_DeleteCaption"), dh9.c("SaveLoad_Delete"), "Y", "N", null, null, 0, new cpk[]
		{
			new cpk("Y", dh9.c("Yes"), true),
			new cpk("N", dh9.c("No"), true)
		}, this, this);
	}

	// Token: 0x0600C495 RID: 50325 RVA: 0x00445BE8 File Offset: 0x00443DE8
	private void a(object A_0, b25 A_1)
	{
		this.d();
	}

	// Token: 0x0600C496 RID: 50326 RVA: 0x00445BF0 File Offset: 0x00443DF0
	private void a(object A_0, ane A_1)
	{
		if (A_1.a == Keys.Escape)
		{
			this.d();
		}
		if (A_1.a == Keys.Enter && this.l.Enabled)
		{
			this.l.a(eoo.b);
		}
	}

	// Token: 0x0600C497 RID: 50327 RVA: 0x00445C30 File Offset: 0x00443E30
	private void a(object A_0, el5 A_1)
	{
		base.a9();
	}

	// Token: 0x0600C498 RID: 50328 RVA: 0x00445C3C File Offset: 0x00443E3C
	private void a(object A_0, EventArgs A_1)
	{
		e4u e4u = A_0 as e4u;
		if (e4u != null)
		{
			this.a(e4u.e());
		}
	}

	// Token: 0x0600C499 RID: 50329 RVA: 0x00445C64 File Offset: 0x00443E64
	public euz r5(object A_0)
	{
		a3r a3r = A_0 as a3r;
		if (a3r != null)
		{
			afg result;
			this.s.TryGetValue(a3r, out result);
			return result;
		}
		return null;
	}

	// Token: 0x0600C49A RID: 50330 RVA: 0x00445C90 File Offset: 0x00443E90
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (this.p != null)
		{
			base.at();
			float num = (float)(this.e.Size.c - 20) / (float)this.p.Width;
			float num2 = (float)(this.e.Size.d - 20) / (float)this.p.Height;
			int num3 = 0;
			int num4 = 0;
			if (num < num2)
			{
				num4 = (int)Math.Max(0f, ((float)(this.e.Size.d - 20) - num * (float)this.p.Height) / 2f);
				this.o.Size = new esj(this.e.Size.c - 20, (int)((float)(this.e.Size.d - 20) * (num / num2)));
			}
			else if (num2 < num)
			{
				num3 = (int)Math.Max(0f, ((float)(this.e.Size.c - 20) - num2 * (float)this.p.Width) / 2f);
				this.o.Size = new esj((int)((float)(this.e.Size.c - 20) * (num2 / num)), this.e.Size.d - 20);
			}
			this.o.Visible = true;
			this.o.Location = new Point(this.e.Location.X + 10 + num3, this.e.Location.Y + 10 + num4);
		}
		else
		{
			this.o.Visible = false;
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x040047A0 RID: 18336
	private new int a = 20;

	// Token: 0x040047A1 RID: 18337
	private new SavedGameManipulationMode b;

	// Token: 0x040047A2 RID: 18338
	private new abx c;

	// Token: 0x040047A3 RID: 18339
	private new cj5 d;

	// Token: 0x040047A4 RID: 18340
	private new ec9 e;

	// Token: 0x040047A5 RID: 18341
	private new avo f;

	// Token: 0x040047A6 RID: 18342
	private new avo g;

	// Token: 0x040047A7 RID: 18343
	private avo h;

	// Token: 0x040047A8 RID: 18344
	private avo i;

	// Token: 0x040047A9 RID: 18345
	private new avo j;

	// Token: 0x040047AA RID: 18346
	private new avo k;

	// Token: 0x040047AB RID: 18347
	private new dak l;

	// Token: 0x040047AC RID: 18348
	private new dak m;

	// Token: 0x040047AD RID: 18349
	private dak n;

	// Token: 0x040047AE RID: 18350
	private bg1 o;

	// Token: 0x040047AF RID: 18351
	private Texture2D p;

	// Token: 0x040047B0 RID: 18352
	private a3r q;

	// Token: 0x040047B1 RID: 18353
	private List<a3r> r = new List<a3r>();

	// Token: 0x040047B2 RID: 18354
	private Dictionary<a3r, afg> s = new Dictionary<a3r, afg>();

	// Token: 0x02002056 RID: 8278
	private new class c : eyp
	{
		// Token: 0x0600C49B RID: 50331 RVA: 0x00445E4C File Offset: 0x0044404C
		public c(arv A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600C49C RID: 50332 RVA: 0x00445E60 File Offset: 0x00444060
		public void g0(string A_0)
		{
			if (A_0 == "O")
			{
				if (this.a.c())
				{
					this.a.a9();
					return;
				}
			}
			else if (A_0 == "A")
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				serviceOrThrow.aq1().d().b(true);
				serviceOrThrow.arb(serviceOrThrow.aq1());
				this.a.c();
			}
		}

		// Token: 0x040047B3 RID: 18355
		private arv a;
	}

	// Token: 0x02002057 RID: 8279
	private new class a : eyp
	{
		// Token: 0x0600C49D RID: 50333 RVA: 0x00445ED8 File Offset: 0x004440D8
		public a(arv A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600C49E RID: 50334 RVA: 0x00445EEC File Offset: 0x004440EC
		public void g0(string A_0)
		{
			if (A_0 == "Y")
			{
				this.a.a();
			}
			else if (A_0 == "A")
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				serviceOrThrow.aq1().d().a(false);
				serviceOrThrow.arb(serviceOrThrow.aq1());
				this.a.a();
			}
			this.a.a9();
		}

		// Token: 0x040047B4 RID: 18356
		private arv a;
	}

	// Token: 0x02002058 RID: 8280
	private new sealed class b : eyp
	{
		// Token: 0x0600C49F RID: 50335 RVA: 0x00445F60 File Offset: 0x00444160
		public b(arv A_0, a3r A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x0600C4A0 RID: 50336 RVA: 0x00445F78 File Offset: 0x00444178
		public void g0(string A_0)
		{
			if (A_0 == "Y")
			{
				try
				{
					bpo.GetServiceOrThrow<cnk>().arn(this.b.FolderName);
					this.a.g();
					this.a.d.g();
					this.a.f();
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "Failed to delete saved game: '{0}'.", new object[]
					{
						this.b.FolderName
					});
					bnr.a(new esj(450, 140), null, dh9.c("Error"), dh9.c("SaveLoad_FailedToSave"), "C", "C", new Color?(Color.Red), null, 0, new cpk[]
					{
						new cpk("C", dh9.c("Close"), true)
					}, this.a, this.a);
				}
			}
			this.a.a9();
		}

		// Token: 0x040047B5 RID: 18357
		private arv a;

		// Token: 0x040047B6 RID: 18358
		private a3r b;
	}
}
