using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

// Token: 0x0200017D RID: 381
public abstract class t3 : euz
{
	// Token: 0x06000A20 RID: 2592 RVA: 0x00029954 File Offset: 0x00027B54
	public Func<bool> o()
	{
		return this.g;
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x0002995C File Offset: 0x00027B5C
	public void a(Func<bool> A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x00029968 File Offset: 0x00027B68
	public int r()
	{
		return this.f;
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x00029970 File Offset: 0x00027B70
	public void b(int A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x0002997C File Offset: 0x00027B7C
	protected int s()
	{
		return this.d;
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x00029984 File Offset: 0x00027B84
	protected void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x00029990 File Offset: 0x00027B90
	public virtual List<char> q()
	{
		return this.a;
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00029998 File Offset: 0x00027B98
	public virtual List<char> m()
	{
		return this.b;
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x000299A0 File Offset: 0x00027BA0
	public virtual Vector2 n()
	{
		return this.c;
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x000299A8 File Offset: 0x00027BA8
	public virtual void a(Vector2 A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x000299B4 File Offset: 0x00027BB4
	public override bool lr()
	{
		return true;
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x000299BC File Offset: 0x00027BBC
	[CompilerGenerated]
	public void b(EventHandler A_0)
	{
		EventHandler eventHandler = this.j;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x000299F4 File Offset: 0x00027BF4
	[CompilerGenerated]
	public void a(EventHandler A_0)
	{
		EventHandler eventHandler = this.j;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x00029A2C File Offset: 0x00027C2C
	protected override void h8(object A_0, ane A_1)
	{
		base.h8(A_0, A_1);
		if (this.h != null && this.h(this, A_1.a, A_1.b, A_1.c))
		{
			return;
		}
		int a_ = this.d;
		if (A_1.a == Keys.Back)
		{
			this.k();
			return;
		}
		if (A_1.a == Keys.Delete)
		{
			this.l();
			return;
		}
		if ((A_1.b.Contains(Keys.LeftControl) || A_1.b.Contains(Keys.RightControl)) && A_1.a == Keys.C)
		{
			this.d();
			return;
		}
		if ((A_1.b.Contains(Keys.LeftControl) || A_1.b.Contains(Keys.RightControl)) && A_1.a == Keys.X)
		{
			this.c();
			return;
		}
		if ((A_1.b.Contains(Keys.LeftControl) || A_1.b.Contains(Keys.RightControl)) && A_1.a == Keys.V)
		{
			this.b();
			return;
		}
		if (A_1.a == Keys.Left && this.d > 0)
		{
			if (A_1.b.Contains(Keys.LeftControl) || A_1.b.Contains(Keys.RightControl))
			{
				this.g();
				this.a(a_, A_1.b);
				return;
			}
			this.e();
			this.a(a_, A_1.b);
			return;
		}
		else if (A_1.a == Keys.Right && base.Text != null && this.d < base.Text.Length)
		{
			if (A_1.b.Contains(Keys.LeftControl) || A_1.b.Contains(Keys.RightControl))
			{
				this.h();
				this.a(a_, A_1.b);
				return;
			}
			this.f();
			this.a(a_, A_1.b);
			return;
		}
		else
		{
			if (A_1.a == Keys.Home)
			{
				this.d = 0;
				this.a(a_, A_1.b);
				return;
			}
			if (A_1.a == Keys.End)
			{
				this.d = ((base.Text != null) ? base.Text.Length : 0);
				this.a(a_, A_1.b);
				return;
			}
			if (A_1.a == Keys.Escape)
			{
				base.bp();
				return;
			}
			if (A_1.a == Keys.Enter)
			{
				if (this.g == null || this.g())
				{
					base.bp();
					this.i();
					return;
				}
			}
			else if (this.a(A_1.a, A_1.b, true, A_1.c))
			{
				this.j();
				this.a(A_1.a, A_1.b, false, A_1.c);
			}
			return;
		}
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x00029D2C File Offset: 0x00027F2C
	protected override void ls(object A_0, EventArgs A_1)
	{
		base.ls(A_0, A_1);
		this.p();
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x00029D3C File Offset: 0x00027F3C
	protected virtual void a(object A_0, EventArgs A_1)
	{
		base.e("Confirmed");
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00029D4C File Offset: 0x00027F4C
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		if (base.Text == null || this.d > base.Text.Length)
		{
			this.p();
		}
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x00029D88 File Offset: 0x00027F88
	protected t3()
	{
		this.Focusable = true;
		this.b(new EventHandler(this.a));
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00029DF4 File Offset: 0x00027FF4
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (this.e != null && (this.e.Value < 0 || this.e.Value > base.Text.Length))
		{
			this.e = null;
		}
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00029E50 File Offset: 0x00028050
	public void p()
	{
		if (base.Text != null)
		{
			this.d = base.Text.Length;
			return;
		}
		this.d = 0;
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x00029E78 File Offset: 0x00028078
	public bool a(Keys A_0, List<Keys> A_1, bool A_2 = false, bool A_3 = false)
	{
		if (base.Text == null)
		{
			base.Text = string.Empty;
		}
		char a_ = b5u.a(A_0, A_1 != null && (A_1.Contains(Keys.LeftShift) || A_1.Contains(Keys.RightShift)), this.i);
		if (this.ahc() || !this.a(a_))
		{
			return false;
		}
		string text = new string(a_, 1);
		if ((A_1.Contains(Keys.LeftShift) || A_1.Contains(Keys.RightShift)) ^ (euz.CapsLock && !A_3))
		{
			text = text.ToUpperInvariant();
		}
		else
		{
			text = text.ToLowerInvariant();
		}
		if (!A_2)
		{
			this.a(text);
		}
		return true;
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00029F54 File Offset: 0x00028154
	protected virtual bool ahc()
	{
		return base.Text.Length >= this.r();
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x00029F70 File Offset: 0x00028170
	private void l()
	{
		if (!this.j() && this.d < base.Text.Length)
		{
			base.Text = base.Text.Remove(this.d, 1);
		}
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x00029FB8 File Offset: 0x000281B8
	private void k()
	{
		if (!this.j() && this.d > 0)
		{
			string text = base.Text;
			int startIndex = this.d - 1;
			this.d = startIndex;
			base.Text = text.Remove(startIndex, 1);
		}
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x0002A000 File Offset: 0x00028200
	private bool j()
	{
		if (this.e != null && this.e.Value != this.d)
		{
			int startIndex = Math.Min(this.d, this.e.Value);
			int count = Math.Abs(this.d - this.e.Value);
			base.Text = base.Text.Remove(startIndex, count);
			this.d = startIndex;
			this.e = null;
			return true;
		}
		return false;
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x0002A08C File Offset: 0x0002828C
	private void a(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			if (base.Text == null)
			{
				base.Text = "";
			}
			int val = this.d + A_0.Length;
			if (this.d == base.Text.Length)
			{
				base.Text += A_0;
			}
			else
			{
				base.Text = base.Text.Insert(this.s(), A_0);
			}
			this.d = Math.Min(base.Text.Length, val);
		}
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x0002A124 File Offset: 0x00028324
	private void i()
	{
		if (this.j != null)
		{
			this.j(this, null);
		}
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x0002A140 File Offset: 0x00028340
	private void h()
	{
		bool flag = false;
		for (int i = this.d + 1; i < base.Text.Length; i++)
		{
			if (i == base.Text.Length - 1)
			{
				this.d = base.Text.Length;
				return;
			}
			if (flag)
			{
				if (!this.b(base.Text[i]))
				{
					this.d = i;
					return;
				}
			}
			else if (this.b(base.Text[i]))
			{
				flag = true;
			}
		}
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x0002A1D4 File Offset: 0x000283D4
	private void g()
	{
		bool flag = false;
		bool flag2 = false;
		for (int i = this.d - 1; i >= 0; i--)
		{
			if (i == 0)
			{
				this.d = 0;
				return;
			}
			if (flag2 && !this.b(base.Text[i]))
			{
				flag2 = false;
			}
			if (flag && !flag2)
			{
				if (this.b(base.Text[i - 1]))
				{
					this.d = i;
					return;
				}
			}
			else if (this.b(base.Text[i - 1]))
			{
				flag2 = true;
			}
			flag = true;
		}
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x0002A274 File Offset: 0x00028474
	private void f()
	{
		this.d++;
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x0002A284 File Offset: 0x00028484
	private void e()
	{
		this.d--;
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x0002A294 File Offset: 0x00028494
	private bool b(char A_0)
	{
		return A_0 == ' ' || A_0 == '-' || A_0 == ',' || A_0 == '.';
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x0002A2B8 File Offset: 0x000284B8
	private void a(int A_0, List<Keys> A_1)
	{
		if (A_1.Contains(Keys.LeftShift) || A_1.Contains(Keys.RightShift))
		{
			if (this.e == null && A_0 != this.d)
			{
				this.e = new int?(A_0);
				return;
			}
		}
		else
		{
			this.e = null;
		}
	}

	// Token: 0x06000A41 RID: 2625 RVA: 0x0002A31C File Offset: 0x0002851C
	private bool a(char A_0)
	{
		return A_0 != '\0' && (this.q() == null || !this.q().Contains(A_0)) && (((float)A_0 >= this.n().X && (float)A_0 <= this.n().Y) || (this.m() != null && this.m().Contains(A_0)));
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x0002A3A0 File Offset: 0x000285A0
	private void d()
	{
		string text;
		if (this.e != null)
		{
			text = this.a();
		}
		else
		{
			text = base.Text;
		}
		if (!string.IsNullOrEmpty(text))
		{
			bpo.GetServiceOrThrow<bbp>().kw(text);
		}
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x0002A3E8 File Offset: 0x000285E8
	private void c()
	{
		this.d();
		if (!this.j())
		{
			base.Text = "";
			this.d = 0;
			this.e = null;
		}
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x0002A41C File Offset: 0x0002861C
	private void b()
	{
		string text = bpo.GetServiceOrThrow<bbp>().kx();
		if (text != null)
		{
			this.j();
			int num = 0;
			while (num < text.Length && !this.ahc())
			{
				if (this.a(text[num]))
				{
					this.a(text.Substring(num, 1));
				}
				num++;
			}
		}
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x0002A480 File Offset: 0x00028680
	private string a()
	{
		if (this.e != null && base.Text.Length >= Math.Max(this.e.Value, this.d))
		{
			return base.Text.Substring(Math.Min(this.e.Value, this.d), Math.Abs(this.e.Value - this.d));
		}
		return null;
	}

	// Token: 0x04000663 RID: 1635
	private new List<char> a = new List<char>();

	// Token: 0x04000664 RID: 1636
	private new List<char> b = new List<char>();

	// Token: 0x04000665 RID: 1637
	private new Vector2 c = new Vector2(float.MinValue, float.MaxValue);

	// Token: 0x04000666 RID: 1638
	protected new int d;

	// Token: 0x04000667 RID: 1639
	protected new int? e;

	// Token: 0x04000668 RID: 1640
	private new int f = int.MaxValue;

	// Token: 0x04000669 RID: 1641
	private new Func<bool> g;

	// Token: 0x0400066A RID: 1642
	public Func<object, Keys, List<Keys>, bool, bool> h;

	// Token: 0x0400066B RID: 1643
	public bool i = true;

	// Token: 0x0400066C RID: 1644
	[CompilerGenerated]
	private new EventHandler j;
}
