using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

// Token: 0x02002059 RID: 8281
public sealed class e4u : ec9
{
	// Token: 0x0600C4A1 RID: 50337 RVA: 0x0044608C File Offset: 0x0044428C
	[CompilerGenerated]
	public void a(EventHandler A_0)
	{
		EventHandler eventHandler = this.e;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C4A2 RID: 50338 RVA: 0x004460C4 File Offset: 0x004442C4
	[CompilerGenerated]
	public void b(EventHandler A_0)
	{
		EventHandler eventHandler = this.e;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C4A3 RID: 50339 RVA: 0x004460FC File Offset: 0x004442FC
	public new string e()
	{
		if (this.b.Text != null)
		{
			return this.b.Text.Trim();
		}
		return string.Empty;
	}

	// Token: 0x0600C4A4 RID: 50340 RVA: 0x00446124 File Offset: 0x00444324
	public e4u(string A_0)
	{
		if (A_0 == "<Новое>")
		{
			this.a("");
		}
		else
		{
			this.a(A_0);
		}
		this.c();
	}

	// Token: 0x0600C4A5 RID: 50341 RVA: 0x0044615C File Offset: 0x0044435C
	private void a(string A_0)
	{
		wj wj = wj.a();
		this.Focusable = true;
		if (wj.c())
		{
			base.Size = new esj(500, 100);
			this.c = bo1.r;
		}
		else
		{
			base.Size = wj.h7;
			this.c = wj.f;
			this.e = wj.b8;
			this.d = new esj?(wj.b9);
		}
		this.d = new dak();
		this.d.Text = "Отмена";
		e4u.a(this.d);
		if (wj.c())
		{
			this.d.Location = new Point(360, 55);
		}
		else
		{
			this.d.Location = new Point(base.Size.c - this.d.Size.c - e4u.a, base.Size.d - this.d.Size.d - e4u.a);
		}
		this.d.IsPrivateComponent = true;
		this.d.c(new EventHandler<b25>(this.b));
		this.aox(this.d);
		this.c = new dak();
		this.c.Text = "Сохранить";
		e4u.a(this.c);
		if (wj.c())
		{
			this.c.Location = new Point(220, 55);
		}
		else
		{
			this.c.Location = new Point(this.d.Location.X - e4u.a - this.c.Size.c, this.d.Location.Y);
		}
		this.c.IsPrivateComponent = true;
		this.c.c(new EventHandler<b25>(this.a));
		this.aox(this.c);
		this.b = new c68();
		if (wj.c())
		{
			this.b.Location = new Point(10, 10);
			this.b.Size = new esj(480, 35);
			this.b.a(new Point(10, 6));
		}
		else
		{
			this.b.Location = new Point(e4u.a, e4u.a);
			this.b.Size = new esj(base.Size.c - 2 * e4u.a, wj.h8.d);
			this.b.a(new Point(10, wj.gn));
			this.b.a(wj.gm);
			this.b.a(true);
		}
		this.b.b(30);
		this.b.a(new Vector2(-1f, -1f));
		this.b.Text = A_0;
		this.b.o(new EventHandler<c1>(this.a));
		this.b.i(new EventHandler(this.b));
		this.b.b(new EventHandler(this.a));
		this.b.c(new EventHandler<ane>(this.a));
		this.b.a(new Func<bool>(this.a));
		this.b.e(new EventHandler(this.c));
		e4u.a(this.b);
		this.b.IsPrivateComponent = true;
		bl9.a(this.b);
		this.aox(this.b);
	}

	// Token: 0x0600C4A6 RID: 50342 RVA: 0x00446530 File Offset: 0x00444730
	private new void c(object A_0, EventArgs A_1)
	{
		bl9.a(this.b, aqo.a, null);
	}

	// Token: 0x0600C4A7 RID: 50343 RVA: 0x00446554 File Offset: 0x00444754
	protected override void aei(object A_0, ddj A_1)
	{
		this.b.j(new EventHandler(this.b));
		base.aei(A_0, A_1);
		bl9.a();
	}

	// Token: 0x0600C4A8 RID: 50344 RVA: 0x0044657C File Offset: 0x0044477C
	private static void a(c68 A_0)
	{
		for (int i = 48; i <= 57; i++)
		{
			A_0.m().Add((char)i);
		}
		for (int j = 65; j <= 90; j++)
		{
			A_0.m().Add((char)j);
		}
		for (int k = 97; k <= 122; k++)
		{
			A_0.m().Add((char)k);
		}
		A_0.m().Add(' ');
	}

	// Token: 0x0600C4A9 RID: 50345 RVA: 0x004465F0 File Offset: 0x004447F0
	private static void a(dak A_0)
	{
		wj wj = wj.a();
		if (wj.c())
		{
			A_0.Size = new esj(120, 35);
			A_0.Font = egg.b;
			A_0.TextLabelOffset = new Point(0, 6);
			A_0.d = bo1.y;
		}
		else
		{
			A_0.Size = wj.h8;
			A_0.Font = wj.gm;
			A_0.TextLabelOffset = new Point(0, wj.gn);
			A_0.d = wj.f;
			A_0.f = wj.e7;
			A_0.e = new esj?(wj.e8);
		}
		A_0.g = adi.a;
		A_0.j = adi.b;
		e4z.j(A_0);
	}

	// Token: 0x0600C4AA RID: 50346 RVA: 0x004466B4 File Offset: 0x004448B4
	private new void c()
	{
		this.c.Enabled = (this.b.Text != null && this.b.Text.Trim().Length > 0);
	}

	// Token: 0x0600C4AB RID: 50347 RVA: 0x004466FC File Offset: 0x004448FC
	private void b()
	{
		base.z();
		if (this.e != null)
		{
			this.e(this, new EventArgs());
		}
	}

	// Token: 0x0600C4AC RID: 50348 RVA: 0x00446720 File Offset: 0x00444920
	public new void d()
	{
		if (this.b != null && this.b.Activated && !this.b.IsFocus)
		{
			this.b.a9();
		}
	}

	// Token: 0x0600C4AD RID: 50349 RVA: 0x00446758 File Offset: 0x00444958
	public override void iv(e6d A_0, cp9 A_1)
	{
		d0p.a(A_1, new Color(0, 0, 0, 150), true, false);
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C4AE RID: 50350 RVA: 0x00446778 File Offset: 0x00444978
	private void a(object A_0, c1 A_1)
	{
		this.c();
	}

	// Token: 0x0600C4AF RID: 50351 RVA: 0x00446780 File Offset: 0x00444980
	private void b(object A_0, b25 A_1)
	{
		base.z();
	}

	// Token: 0x0600C4B0 RID: 50352 RVA: 0x00446788 File Offset: 0x00444988
	private void b(object A_0, EventArgs A_1)
	{
		if (bpo.GetServiceOrThrow<d1a>().aa7() != this.b)
		{
			this.b.a9();
		}
	}

	// Token: 0x0600C4B1 RID: 50353 RVA: 0x004467AC File Offset: 0x004449AC
	protected override void ls(object A_0, EventArgs A_1)
	{
		base.ls(A_0, A_1);
	}

	// Token: 0x0600C4B2 RID: 50354 RVA: 0x004467B8 File Offset: 0x004449B8
	private void a(object A_0, b25 A_1)
	{
		this.b();
	}

	// Token: 0x0600C4B3 RID: 50355 RVA: 0x004467C0 File Offset: 0x004449C0
	private void a(object A_0, EventArgs A_1)
	{
		this.c();
		if (this.c.Enabled)
		{
			this.b();
		}
	}

	// Token: 0x0600C4B4 RID: 50356 RVA: 0x004467E0 File Offset: 0x004449E0
	private void a(object A_0, ane A_1)
	{
		if (A_1.a == Keys.Escape)
		{
			base.z();
		}
	}

	// Token: 0x0600C4B6 RID: 50358 RVA: 0x00446804 File Offset: 0x00444A04
	[CompilerGenerated]
	private bool a()
	{
		return this.c.Enabled;
	}

	// Token: 0x040047B7 RID: 18359
	private new static readonly int a = 10;

	// Token: 0x040047B8 RID: 18360
	private new c68 b;

	// Token: 0x040047B9 RID: 18361
	private new dak c;

	// Token: 0x040047BA RID: 18362
	private new dak d;

	// Token: 0x040047BB RID: 18363
	[CompilerGenerated]
	private new EventHandler e;
}
