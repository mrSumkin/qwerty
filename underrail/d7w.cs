using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Ouroboros.Core.Logging;

// Token: 0x020001B1 RID: 433
[dmo(DisplayName = "Label", Description = "A normal text label.", InitialWidth = 100, InitialHeight = 30)]
public class d7w : euz
{
	// Token: 0x06000C43 RID: 3139 RVA: 0x00032398 File Offset: 0x00030598
	public string g()
	{
		return this.a;
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x000323A4 File Offset: 0x000305A4
	public void a(string A_0)
	{
		this.a = A_0;
		object a_ = this.a;
		if (this.g != null)
		{
			this.g(this, new c1(a_, A_0));
		}
	}

	// Token: 0x06000C45 RID: 3141 RVA: 0x000323E0 File Offset: 0x000305E0
	public bool d()
	{
		return this.b;
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x000323EC File Offset: 0x000305EC
	public void a(bool A_0)
	{
		if (this.b != A_0)
		{
			bool flag = this.b;
			this.b = A_0;
			if (this.h != null)
			{
				this.h(this, new c1(flag, this.b));
			}
			this.c();
		}
	}

	// Token: 0x06000C47 RID: 3143 RVA: 0x00032448 File Offset: 0x00030648
	public cab f()
	{
		return this.c;
	}

	// Token: 0x06000C48 RID: 3144 RVA: 0x00032450 File Offset: 0x00030650
	public void a(cab A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000C49 RID: 3145 RVA: 0x0003245C File Offset: 0x0003065C
	public ad4 e()
	{
		return this.d;
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x00032464 File Offset: 0x00030664
	public void a(ad4 A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x00032470 File Offset: 0x00030670
	public d7w()
	{
		this.c(new EventHandler<c1>(this.a));
		this.a(new EventHandler<c1>(this.b));
	}

	// Token: 0x06000C4C RID: 3148 RVA: 0x000324A0 File Offset: 0x000306A0
	[CompilerGenerated]
	public void c(EventHandler<c1> A_0)
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

	// Token: 0x06000C4D RID: 3149 RVA: 0x000324D8 File Offset: 0x000306D8
	[CompilerGenerated]
	public void d(EventHandler<c1> A_0)
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

	// Token: 0x06000C4E RID: 3150 RVA: 0x00032510 File Offset: 0x00030710
	[CompilerGenerated]
	public void a(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.h;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C4F RID: 3151 RVA: 0x00032548 File Offset: 0x00030748
	[CompilerGenerated]
	public void b(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.h;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x00032580 File Offset: 0x00030780
	protected virtual void b(object A_0, c1 A_1)
	{
		base.e("AutoSizeChanged");
		this.c();
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x00032594 File Offset: 0x00030794
	protected virtual void a(object A_0, c1 A_1)
	{
		base.e("FontAssetNameChanged");
		this.c();
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x000325A8 File Offset: 0x000307A8
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		this.c();
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x000325B8 File Offset: 0x000307B8
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		if (!this.d())
		{
			this.c();
		}
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x000325D8 File Offset: 0x000307D8
	public override void iv(e6d A_0, cp9 A_1)
	{
		cvq cvq = dr3.e();
		if (!string.IsNullOrEmpty(this.g()) && !string.IsNullOrEmpty(this.f) && esj.c(this.e, esj.a()))
		{
			Point point = base.at();
			SpriteFont spriteFont = this.b();
			if (spriteFont != null)
			{
				Vector2 zero = Vector2.Zero;
				if (this.d())
				{
					zero.X = (float)point.X;
					zero.Y = (float)point.Y;
				}
				else
				{
					cab cab = this.f();
					if (cab != cab.b)
					{
						if (cab != cab.c)
						{
							zero.X = (float)point.X;
						}
						else
						{
							zero.X = (float)(point.X + base.Size.c - this.e.c);
						}
					}
					else
					{
						zero.X = (float)(point.X + (base.Size.c - this.e.c) / 2);
					}
					ad4 ad = this.e();
					if (ad != ad4.b)
					{
						if (ad != ad4.c)
						{
							zero.Y = (float)point.Y;
						}
						else
						{
							zero.Y = (float)(point.Y + base.Size.d - this.e.d);
						}
					}
					else
					{
						zero.Y = (float)(point.Y + (base.Size.d - this.e.d) / 2);
					}
				}
				A_1.b().xb(spriteFont, this.f, zero, base.Color);
			}
			else if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 110))
			{
				string a_ = "[GUI] - Failed rendering label: " + this.ToString() + ". Could not load font: " + this.g();
				cvq.n7(LogSeverity.Error, 110, a_);
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x000327D8 File Offset: 0x000309D8
	private void c()
	{
		esj esj = esj.a();
		string text = null;
		if (!string.IsNullOrEmpty(base.Text))
		{
			SpriteFont spriteFont = this.b();
			if (spriteFont != null)
			{
				esj esj2 = esj.a(spriteFont.MeasureString(base.Text));
				if (this.d() || esj.d(base.Size, esj.a()))
				{
					text = base.Text;
					esj = esj2;
				}
				else
				{
					text = this.a(spriteFont);
					esj = esj.a(spriteFont.MeasureString(text));
				}
			}
		}
		this.f = text;
		this.e = esj;
		if (this.b)
		{
			base.Size = this.e;
		}
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x00032888 File Offset: 0x00030A88
	private string a(SpriteFont A_0)
	{
		string text = "";
		int num = 0;
		string[] array = base.Text.Split(new string[]
		{
			"\r\n"
		}, StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			foreach (string str in ev7.a(array[i], A_0, base.Size.c, base.Size.c))
			{
				num += A_0.LineSpacing;
				if (num > base.Size.d)
				{
					return text;
				}
				if (!string.IsNullOrEmpty(text))
				{
					text += "\r\n";
				}
				text += str;
			}
		}
		return text;
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x00032978 File Offset: 0x00030B78
	private SpriteFont b()
	{
		cvq cvq = dr3.e();
		cne cne = d7w.a();
		SpriteFont result = null;
		if (!string.IsNullOrEmpty(this.g()))
		{
			if (cne != null)
			{
				result = cne.GetResource<SpriteFont>(this.g(), null);
			}
			else if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 110))
			{
				string a_ = "[GUI] - Failed to retrieve dynamic resource manager.";
				cvq.n7(LogSeverity.Error, 110, a_);
			}
		}
		return result;
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x000329F8 File Offset: 0x00030BF8
	private new static cne a()
	{
		return bpo.GetService<cne>();
	}

	// Token: 0x0400074C RID: 1868
	private new string a;

	// Token: 0x0400074D RID: 1869
	private new bool b;

	// Token: 0x0400074E RID: 1870
	private new cab c;

	// Token: 0x0400074F RID: 1871
	private new ad4 d;

	// Token: 0x04000750 RID: 1872
	private new esj e;

	// Token: 0x04000751 RID: 1873
	private new string f;

	// Token: 0x04000752 RID: 1874
	[CompilerGenerated]
	private new EventHandler<c1> g;

	// Token: 0x04000753 RID: 1875
	[CompilerGenerated]
	private EventHandler<c1> h;
}
