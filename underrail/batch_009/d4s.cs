using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;

// Token: 0x0200206F RID: 8303
public sealed class d4s : euz
{
	// Token: 0x0600C61E RID: 50718 RVA: 0x00454678 File Offset: 0x00452878
	public string e()
	{
		return this.d;
	}

	// Token: 0x0600C61F RID: 50719 RVA: 0x00454684 File Offset: 0x00452884
	public void a(string A_0)
	{
		string a_ = this.d;
		this.d = A_0;
		if (a_ != A_0)
		{
			if (this.a != null)
			{
				this.a.a(A_0);
			}
			if (this.g != null)
			{
				this.g(this, new c1(a_, A_0));
			}
		}
	}

	// Token: 0x0600C620 RID: 50720 RVA: 0x004546E0 File Offset: 0x004528E0
	public bool f()
	{
		return this.e;
	}

	// Token: 0x0600C621 RID: 50721 RVA: 0x004546E8 File Offset: 0x004528E8
	public void a(bool A_0)
	{
		if (this.e != A_0)
		{
			this.e = A_0;
			this.b();
		}
	}

	// Token: 0x0600C622 RID: 50722 RVA: 0x00454704 File Offset: 0x00452904
	[CompilerGenerated]
	public void b(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.g;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C623 RID: 50723 RVA: 0x0045473C File Offset: 0x0045293C
	[CompilerGenerated]
	public void a(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.g;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C624 RID: 50724 RVA: 0x00454774 File Offset: 0x00452974
	public d4s()
	{
		this.d();
	}

	// Token: 0x0600C625 RID: 50725 RVA: 0x00454784 File Offset: 0x00452984
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.b();
	}

	// Token: 0x0600C626 RID: 50726 RVA: 0x00454794 File Offset: 0x00452994
	private void d()
	{
		this.c();
		this.a();
		this.a(Enumerable.FirstOrDefault<string>(this.f));
		this.b();
	}

	// Token: 0x0600C627 RID: 50727 RVA: 0x004547BC File Offset: 0x004529BC
	private void c()
	{
		this.a = new apw(bd8.b);
		this.a.IsPrivateComponent = true;
		this.b = new aqw();
		this.b.IsPrivateComponent = true;
		this.b.a = bo1.a6;
		this.b.Size = new esj(24, 23);
		this.b.b = new Point(0, 46);
		this.b.p(new EventHandler<b25>(this.a));
		this.c = new aqw();
		this.c.IsPrivateComponent = true;
		this.c.a = bo1.a6;
		this.c.Size = new esj(24, 23);
		this.c.b = new Point(0, 69);
		this.c.p(new EventHandler<b25>(this.b));
		this.aox(this.a);
		this.aox(this.b);
		this.aox(this.c);
	}

	// Token: 0x0600C628 RID: 50728 RVA: 0x004548D4 File Offset: 0x00452AD4
	private void b()
	{
		if (this.a != null)
		{
			this.a.Location = new Point(base.Size.c / 2 - this.a.Size.c / 2, base.Size.d / 2 - this.a.Size.d / 2);
		}
		if (this.b != null)
		{
			this.b.Visible = !this.e;
			this.b.Location = new Point(0, base.Size.d / 2 - this.b.Size.d / 2);
		}
		if (this.c != null)
		{
			this.c.Visible = !this.e;
			this.c.Location = new Point(base.Size.c - this.c.Size.c, base.Size.d / 2 - this.c.Size.d / 2);
		}
	}

	// Token: 0x0600C629 RID: 50729 RVA: 0x004549F8 File Offset: 0x00452BF8
	private void a()
	{
		this.f = new List<string>();
		d67 d = dr3.d();
		if (d != null && d.lh() != null)
		{
			try
			{
				foreach (string path in Directory.GetFiles(Path.Combine(d.lh().RootDirectory, "Portraits"), "*_l.xnb", 0))
				{
					try
					{
						string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
						if (fileNameWithoutExtension.Length > 2)
						{
							string item = fileNameWithoutExtension.Substring(0, fileNameWithoutExtension.Length - 2);
							this.f.Add(item);
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x0600C62A RID: 50730 RVA: 0x00454AC8 File Offset: 0x00452CC8
	private void b(object A_0, b25 A_1)
	{
		int num = this.f.IndexOf(this.a.g());
		if (num != -1 && num < this.f.Count - 1)
		{
			this.a(this.f[num + 1]);
			return;
		}
		this.a(Enumerable.FirstOrDefault<string>(this.f));
	}

	// Token: 0x0600C62B RID: 50731 RVA: 0x00454B2C File Offset: 0x00452D2C
	private void a(object A_0, b25 A_1)
	{
		int num = this.f.IndexOf(this.a.g());
		if (num != -1 && num > 0)
		{
			this.a(this.f[num - 1]);
			return;
		}
		this.a(Enumerable.LastOrDefault<string>(this.f));
	}

	// Token: 0x040048C4 RID: 18628
	private new apw a;

	// Token: 0x040048C5 RID: 18629
	private new aqw b;

	// Token: 0x040048C6 RID: 18630
	private new aqw c;

	// Token: 0x040048C7 RID: 18631
	private new string d;

	// Token: 0x040048C8 RID: 18632
	private new bool e;

	// Token: 0x040048C9 RID: 18633
	private new List<string> f;

	// Token: 0x040048CA RID: 18634
	[CompilerGenerated]
	private new EventHandler<c1> g;
}
