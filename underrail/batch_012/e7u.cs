using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Ouroboros.Core.Logging;

// Token: 0x0200203B RID: 8251
public sealed class e7u : ec9, ctv
{
	// Token: 0x0600C387 RID: 50055 RVA: 0x0043AD74 File Offset: 0x00438F74
	public e7u()
	{
		this.c();
	}

	// Token: 0x0600C388 RID: 50056 RVA: 0x0043ADC4 File Offset: 0x00438FC4
	private new void c()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			base.Size = new esj(965, 704);
			this.c = bo1.m;
		}
		else
		{
			esj a_ = esj.a(wj.fu, new esj(0, wj.fw.d));
			wj.a(ref a_.d);
			base.Size = a_;
			this.c = wj.f;
			this.e = wj.b6;
			this.d = new esj?(wj.b7);
		}
		this.Focusable = true;
		base.g(new EventHandler<ane>(this.a));
		this.b();
		if (wj.c())
		{
			this.b = new cj5(this.p, this);
		}
		else
		{
			this.b = new cj5(this.p, this, typeof(dg8));
		}
		this.b.Location = new Point(this.a, this.a);
		if (wj.c())
		{
			this.b.Size = new esj(450, 610);
		}
		else
		{
			this.b.a(wj.bm.c);
			esj a_2 = new esj((base.Size.c - 3 * this.a) / 2, wj.h5);
			wj.a(ref a_2.d);
			this.b.Size = a_2;
			this.b.c(wj.h4);
			this.b.e(wj.h6);
			this.b.c = wj.f;
			this.b.e = wj.b8;
			this.b.d = new esj?(wj.b9);
		}
		this.b.IsPrivateComponent = true;
		this.aox(this.b);
		if (wj.c())
		{
			this.h = new apw(bd8.b);
		}
		else
		{
			this.h = new apw((bd8)wj.f2);
		}
		this.h.Location = new Point(this.b.Location.X + this.b.Size.c + this.a, this.b.Location.Y);
		this.aox(this.h);
		this.i = new avo();
		this.i.Text = " ";
		if (wj.c())
		{
			this.i.a(egg.f);
			this.i.Location = new Point(this.h.Location.X + this.h.Size.c + 15, this.h.Location.Y + this.a);
		}
		else
		{
			this.i.a(wj.h9);
		}
		this.i.Color = Color.White;
		this.i.a(true);
		this.aox(this.i);
		this.j = new avo();
		if (wj.c())
		{
			this.j.Location = new Point(this.i.Location.X, this.i.Location.Y + 40);
		}
		this.j.Text = " ";
		if (wj.c())
		{
			this.j.a(egg.e);
		}
		else
		{
			this.j.a(wj.ia);
		}
		this.j.Color = adi.a;
		this.j.a(true);
		this.aox(this.j);
		if (!wj.c())
		{
			int num = this.i.Size.d + this.i.Size.d + this.a / 2;
			this.i.Location = new Point(this.h.Location.X + this.h.Size.c + this.a, this.h.Location.Y + (this.h.Size.d - num) / 2);
			this.j.Location = new Point(this.i.Location.X, this.i.Location.Y + this.i.Size.d);
		}
		int num2 = 0;
		foreach (to to in new bn2())
		{
			avo avo = new avo();
			avo.a(true);
			avo.Text = dh9.a("BaseAbilityEnum." + to.Name);
			if (string.IsNullOrEmpty(avo.Text))
			{
				avo.Text = to.Name;
			}
			if (wj.c())
			{
				avo.Location = new Point(this.h.Location.X, this.h.Location.Y + this.h.Size.d + 35 + num2 * 40);
				avo.a(egg.e);
			}
			else
			{
				avo.a(wj.ia);
				avo.Location = new Point(this.h.Location.X, this.h.Location.Y + this.h.Size.d + this.a * 2 + num2 * (avo.Size.d + this.a / 2));
			}
			avo.Color = adi.a;
			this.aox(avo);
			this.k.Add(avo);
			avo avo2 = new avo();
			avo2.Text = " ";
			if (wj.c())
			{
				avo2.Location = new Point(this.h.Location.X + 300, this.h.Location.Y + this.h.Size.d + 35 + num2 * 40);
			}
			else
			{
				int num3 = (base.Size.c - (this.b.Location.X + this.b.Size.c)) / 2;
				avo2.Location = new Point(avo.Location.X + num3, avo.Location.Y);
			}
			avo2.a(avo.g());
			avo2.Color = Color.White;
			avo2.a(true);
			this.aox(avo2);
			this.l.Add(avo2);
			num2++;
		}
		this.m = new avo();
		this.m.Text = " ";
		this.m.a(true);
		if (wj.c())
		{
			this.m.Location = new Point(this.h.Location.X, 520);
			this.m.a(egg.b);
		}
		else
		{
			this.m.a(wj.ib);
			this.m.Location = new Point(this.k[0].Location.X, this.b.Location.Y + this.b.Size.d - this.m.Size.d * 2);
		}
		this.m.Color = adi.a;
		this.aox(this.m);
		this.n = new avo();
		this.n.Text = " ";
		this.n.a(true);
		if (wj.c())
		{
			this.n.Location = new Point(this.m.Location.X, this.m.Location.Y + 30);
			this.n.a(egg.b);
		}
		else
		{
			this.n.Location = new Point(this.m.Location.X, this.m.Location.Y + this.m.Size.d);
			this.n.a(this.m.g());
		}
		this.n.Color = adi.a;
		this.aox(this.n);
		this.o = new avo();
		this.o.Text = " ";
		this.o.a(true);
		if (wj.c())
		{
			this.o.Location = new Point(this.n.Location.X, this.n.Location.Y + 30);
			this.o.a(egg.b);
		}
		else
		{
			this.o.Location = new Point(this.n.Location.X, this.n.Location.Y + this.n.Size.d);
			this.o.a(this.m.g());
		}
		this.o.Color = adi.a;
		this.aox(this.o);
		this.d = new dak();
		e7u.a(this.d);
		this.d.Text = dh9.c("Cancel");
		this.d.c(new EventHandler<b25>(this.a));
		this.d.IsPrivateComponent = true;
		if (wj.c())
		{
			this.d.Location = new Point(base.Size.c - (this.d.Size.c + 35), base.Size.d - (this.d.Size.d + 25));
		}
		else
		{
			this.d.Location = new Point(base.Size.c - this.a - this.d.Size.c, base.Size.d - this.a - this.d.Size.d);
		}
		this.aox(this.d);
		this.c = new dak();
		e7u.a(this.c);
		this.c.Text = dh9.c("Import");
		this.c.c(new EventHandler<b25>(this.c));
		this.c.IsPrivateComponent = true;
		if (wj.c())
		{
			this.c.Location = new Point(this.d.Location.X - this.c.Size.c - 15, this.d.Location.Y);
		}
		else
		{
			this.c.Location = new Point(this.d.Location.X - this.a - this.c.Size.c, this.d.Location.Y);
		}
		this.aox(this.c);
		this.e = new dak();
		e7u.a(this.e);
		this.e.Text = dh9.c("Delete_Button");
		this.e.c(new EventHandler<b25>(this.b));
		this.e.IsPrivateComponent = true;
		if (wj.c())
		{
			this.e.Location = new Point(25, this.d.Location.Y);
		}
		else
		{
			this.e.Location = new Point(this.a, this.c.Location.Y);
		}
		this.aox(this.e);
		this.a();
	}

	// Token: 0x0600C389 RID: 50057 RVA: 0x0043BABC File Offset: 0x00439CBC
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

	// Token: 0x0600C38A RID: 50058 RVA: 0x0043BB80 File Offset: 0x00439D80
	public euz r5(object A_0)
	{
		string text = A_0 as string;
		if (text != null)
		{
			afg result;
			this.q.TryGetValue(text, out result);
			return result;
		}
		return null;
	}

	// Token: 0x0600C38B RID: 50059 RVA: 0x0043BBAC File Offset: 0x00439DAC
	private void b()
	{
		this.p.Clear();
		this.q.Clear();
		string text = d5x.h();
		if (Directory.Exists(text))
		{
			foreach (string text2 in Enumerable.OrderBy<string, string>(Directory.GetFiles(text, "*.char", 0), new Func<string, string>(e7u.a.a.a)))
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text2);
				this.p.Add(fileNameWithoutExtension);
				this.q.Add(fileNameWithoutExtension, this.a(fileNameWithoutExtension, text2));
			}
		}
	}

	// Token: 0x0600C38C RID: 50060 RVA: 0x0043BC78 File Offset: 0x00439E78
	private afg a(string A_0, string A_1)
	{
		afg afg = new afg();
		afg.Text = A_0;
		afg.Tag = A_1;
		afg.VerticalTextAlignment = ad4.b;
		afg.HorizontalTextAlignment = cab.b;
		afg.CheckOnClick = false;
		afg.c(new EventHandler<b25>(this.d));
		e4z.f(afg);
		return afg;
	}

	// Token: 0x0600C38D RID: 50061 RVA: 0x0043BCC8 File Offset: 0x00439EC8
	private void a()
	{
		if (this.q != null && this.q.Count > 0)
		{
			this.a(Enumerable.First<afg>(this.q.Values));
			return;
		}
		this.b(null);
	}

	// Token: 0x0600C38E RID: 50062 RVA: 0x0043BD08 File Offset: 0x00439F08
	private void b(string A_0)
	{
		this.f = A_0;
		this.g = null;
		if (A_0 != null)
		{
			try
			{
				this.g = ajk.a(A_0);
			}
			catch (Exception a_)
			{
				dux.a(LogSeverity.Error, a_, "Ошибка при загрузке персонажа: {0}", new object[]
				{
					A_0
				});
			}
		}
		if (this.g != null)
		{
			this.h.a(this.g.a.Portrait);
			this.i.Text = this.g.a.Name;
			this.j.Text = dh9.c("Level") + " " + this.g.a.Level.ToString();
			int num = 0;
			foreach (to to in this.g.a.BaseAbilities)
			{
				this.l[num].Text = string.Format("{0}", to.f());
				num++;
			}
			this.m.Text = dh9.c("SaveLoad_ExportedOn") + ": " + this.g.c.ToString();
			this.n.Text = dh9.c("SaveLoad_GameVersion") + ": " + this.g.b.ToString();
			this.o.Text = "";
			if (this.g.e != null && this.g.e.Count > 0)
			{
				avo avo = this.o;
				avo.Text += " (";
				for (int i = 0; i < this.g.e.Count; i++)
				{
					if (i != 0)
					{
						avo avo2 = this.o;
						avo2.Text += ", ";
					}
					avo avo3 = this.o;
					avo3.Text += dk2.d(this.g.e[i]);
				}
				avo avo4 = this.o;
				avo4.Text += ")";
			}
			if (ast.a(this.g.b, this.g.e))
			{
				this.n.Color = Color.Red;
				this.o.Color = Color.Red;
			}
			else
			{
				this.n.Color = adi.a;
				this.o.Color = adi.a;
			}
		}
		bool a_2 = this.g != null;
		this.c.Enabled = a_2;
		this.e.Enabled = a_2;
		this.h.Visible = a_2;
		this.i.Visible = a_2;
		this.j.Visible = a_2;
		this.m.Visible = a_2;
		this.n.Visible = a_2;
		foreach (avo avo5 in this.k)
		{
			avo5.Visible = a_2;
		}
		foreach (avo avo6 in this.l)
		{
			avo6.Visible = a_2;
		}
	}

	// Token: 0x0600C38F RID: 50063 RVA: 0x0043C0EC File Offset: 0x0043A2EC
	private void a(afg A_0)
	{
		foreach (KeyValuePair<string, afg> keyValuePair in this.q)
		{
			if (keyValuePair.Value == A_0)
			{
				keyValuePair.Value.Checked = true;
				this.b((string)A_0.Tag);
			}
			else
			{
				keyValuePair.Value.Checked = false;
			}
		}
	}

	// Token: 0x0600C390 RID: 50064 RVA: 0x0043C17C File Offset: 0x0043A37C
	private static string a(string A_0)
	{
		string text = A_0;
		int num = 1;
		while (Directory.Exists(d5x.d(text)) && num < 2147483647)
		{
			num++;
			text = A_0 + "-" + num.ToString();
		}
		if (num == 2147483647)
		{
			text = A_0 + "-" + Guid.NewGuid().ToString("N") + Guid.NewGuid().ToString("N");
		}
		return text;
	}

	// Token: 0x0600C391 RID: 50065 RVA: 0x0043C200 File Offset: 0x0043A400
	protected override void i0()
	{
		base.i0();
		this.b.a9();
	}

	// Token: 0x0600C392 RID: 50066 RVA: 0x0043C214 File Offset: 0x0043A414
	protected override void r4(object A_0, el5 A_1)
	{
		e4z.j();
		base.r4(A_0, A_1);
	}

	// Token: 0x0600C393 RID: 50067 RVA: 0x0043C224 File Offset: 0x0043A424
	private new void d(object A_0, b25 A_1)
	{
		this.a(A_0 as afg);
	}

	// Token: 0x0600C394 RID: 50068 RVA: 0x0043C238 File Offset: 0x0043A438
	private new void c(object A_0, b25 A_1)
	{
		if (ast.a(this.g.b, this.g.e))
		{
			bnr.a(new esj(550, 200), null, dh9.c("SaveLoad_ImportCaption"), dh9.c("SaveLoad_CharNotCompatible"), "O", "O", null, null, 0, new cpk[]
			{
				new cpk("O", dh9.c("OK"), true)
			}, null, null);
			return;
		}
		base.z();
	}

	// Token: 0x0600C395 RID: 50069 RVA: 0x0043C2D8 File Offset: 0x0043A4D8
	private void b(object A_0, b25 A_1)
	{
		if (this.g == null || string.IsNullOrEmpty(this.f))
		{
			return;
		}
		bnr.a(new esj(500, 200), new e7u.b(this, this.f), dh9.c("SaveLoad_DeleteCaption"), dh9.c("SaveLoad_DeleteCharacter"), "Y", "N", null, null, 0, new cpk[]
		{
			new cpk("Y", dh9.c("Yes"), true),
			new cpk("N", dh9.c("No"), true)
		}, null, null);
	}

	// Token: 0x0600C396 RID: 50070 RVA: 0x0043C394 File Offset: 0x0043A594
	private void a(object A_0, b25 A_1)
	{
		this.g = null;
		base.z();
	}

	// Token: 0x0600C397 RID: 50071 RVA: 0x0043C3A4 File Offset: 0x0043A5A4
	private void a(object A_0, ane A_1)
	{
		if (A_1.a == Keys.Escape)
		{
			this.g = null;
			base.z();
		}
	}

	// Token: 0x04004701 RID: 18177
	private new int a = 20;

	// Token: 0x04004702 RID: 18178
	private new cj5 b;

	// Token: 0x04004703 RID: 18179
	private new dak c;

	// Token: 0x04004704 RID: 18180
	private new dak d;

	// Token: 0x04004705 RID: 18181
	private new dak e;

	// Token: 0x04004706 RID: 18182
	private new string f;

	// Token: 0x04004707 RID: 18183
	public new ajk g;

	// Token: 0x04004708 RID: 18184
	private apw h;

	// Token: 0x04004709 RID: 18185
	private avo i;

	// Token: 0x0400470A RID: 18186
	private new avo j;

	// Token: 0x0400470B RID: 18187
	private new List<avo> k = new List<avo>();

	// Token: 0x0400470C RID: 18188
	private new List<avo> l = new List<avo>();

	// Token: 0x0400470D RID: 18189
	private new avo m;

	// Token: 0x0400470E RID: 18190
	private avo n;

	// Token: 0x0400470F RID: 18191
	private avo o;

	// Token: 0x04004710 RID: 18192
	private List<string> p = new List<string>();

	// Token: 0x04004711 RID: 18193
	private Dictionary<string, afg> q = new Dictionary<string, afg>();

	// Token: 0x0200203C RID: 8252
	private new sealed class b : eyp
	{
		// Token: 0x0600C398 RID: 50072 RVA: 0x0043C3C0 File Offset: 0x0043A5C0
		public b(e7u A_0, string A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x0600C399 RID: 50073 RVA: 0x0043C3D8 File Offset: 0x0043A5D8
		public void g0(string A_0)
		{
			if (A_0 == "Y")
			{
				try
				{
					File.Delete(this.b);
					this.a.b();
					this.a.b.g();
					this.a.a();
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "Не удалось удалить персонажа: '{0}'.", new object[]
					{
						this.b
					});
					bnr.a(new esj(450, 140), null, dh9.c("Error"), dh9.c("SaveLoad_FailedToDeleteCharacter"), "C", "C", new Color?(Color.Red), null, 0, new cpk[]
					{
						new cpk("C", dh9.c("Close"), true)
					}, null, null);
				}
			}
		}

		// Token: 0x04004712 RID: 18194
		private e7u a;

		// Token: 0x04004713 RID: 18195
		private string b;
	}

	// Token: 0x0200203D RID: 8253
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C39C RID: 50076 RVA: 0x0043C4DC File Offset: 0x0043A6DC
		internal string a(string A_0)
		{
			return A_0;
		}

		// Token: 0x04004714 RID: 18196
		public static readonly e7u.a a = new e7u.a();

		// Token: 0x04004715 RID: 18197
		public static Func<string, string> b;
	}
}
