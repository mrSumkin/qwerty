using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Ouroboros.Core.Logging;

// Token: 0x02000182 RID: 386
public abstract class euz : btr, azr
{
	// Token: 0x06000AA8 RID: 2728
	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern short GetKeyState(int A_0);

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0002BF2C File Offset: 0x0002A12C
	// (set) Token: 0x06000AAA RID: 2730 RVA: 0x0002BF34 File Offset: 0x0002A134
	public TimeSpan DoubleClickSpeed
	{
		get
		{
			return this.k;
		}
		set
		{
			this.k = value;
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0002BF40 File Offset: 0x0002A140
	// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0002BF4C File Offset: 0x0002A14C
	[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
	[Category("Appearance")]
	public string Text
	{
		get
		{
			return this.i;
		}
		set
		{
			string a_ = this.i;
			this.i = value;
			if (a_ != value)
			{
				if (this.ap != null)
				{
					this.ap(this, new c1(a_, value));
				}
				this.bi();
			}
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0002BF98 File Offset: 0x0002A198
	// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0002BFA0 File Offset: 0x0002A1A0
	[Category("Layout")]
	public Point Location
	{
		get
		{
			return this.d;
		}
		set
		{
			if (this.d != value)
			{
				this.d = value;
				if (this.ah != null)
				{
					this.ah(this, null);
				}
				this.bi();
			}
		}
	}

	// Token: 0x06000AAF RID: 2735 RVA: 0x0002BFDC File Offset: 0x0002A1DC
	public Point at()
	{
		Point a_ = Point.Zero;
		if (this.Parent != null)
		{
			a_ = this.Parent.at();
		}
		Point point = d05.a(a_, this.Location, false);
		if (!this.IsPrivateComponent)
		{
			abp abp = this.Parent as abp;
			if (abp != null)
			{
				point = d05.a(point, abp.aae(), true);
			}
		}
		return point;
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x0002C040 File Offset: 0x0002A240
	public Point c(int A_0, int A_1)
	{
		return d05.a(new Point(A_0, A_1), this.at(), true);
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0002C058 File Offset: 0x0002A258
	// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0002C064 File Offset: 0x0002A264
	[Category("Layout")]
	public esj Size
	{
		get
		{
			return this.e;
		}
		set
		{
			esj esj = this.e;
			if (esj.c(esj, value))
			{
				this.e = value;
				c1 c = new c1(esj, value);
				if (this.ai != null)
				{
					this.ai(this, c);
				}
				this.bi();
			}
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0002C0BC File Offset: 0x0002A2BC
	// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0002C0C8 File Offset: 0x0002A2C8
	[Category("Behavior")]
	public virtual bool Enabled
	{
		get
		{
			return this.g;
		}
		set
		{
			bool flag = this.g;
			if (flag != value)
			{
				this.g = value;
				if (this.ao != null)
				{
					this.ao(this, new c1(flag, value));
				}
				this.bi();
			}
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0002C118 File Offset: 0x0002A318
	// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0002C120 File Offset: 0x0002A320
	[Category("Behavior")]
	public bool Visible
	{
		get
		{
			return this.h;
		}
		set
		{
			bool flag = this.h;
			if (flag != value)
			{
				this.h = value;
				if (this.an != null)
				{
					this.an(this, new c1(flag, value));
				}
			}
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0002C16C File Offset: 0x0002A36C
	// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0002C178 File Offset: 0x0002A378
	[Category("Design")]
	public string Name
	{
		get
		{
			return this.f;
		}
		set
		{
			string a_ = this.f;
			if (a_ != value)
			{
				this.f = value;
				if (this.am != null)
				{
					this.am(this, new c1(a_, value));
				}
			}
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0002C1C0 File Offset: 0x0002A3C0
	// (set) Token: 0x06000ABA RID: 2746 RVA: 0x0002C1C8 File Offset: 0x0002A3C8
	[Browsable(false)]
	public object Tag
	{
		get
		{
			return this.j;
		}
		set
		{
			this.j = value;
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0002C1D4 File Offset: 0x0002A3D4
	// (set) Token: 0x06000ABC RID: 2748 RVA: 0x0002C1E0 File Offset: 0x0002A3E0
	[Category("Appearance")]
	public Color Color
	{
		get
		{
			return this.m;
		}
		set
		{
			Color color = this.m;
			if (color != value)
			{
				this.m = value;
				if (this.aq != null)
				{
					this.aq(this, new c1(color, value));
				}
			}
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0002C230 File Offset: 0x0002A430
	// (set) Token: 0x06000ABE RID: 2750 RVA: 0x0002C238 File Offset: 0x0002A438
	[Category("Behavior")]
	public bool PropagateColorChange
	{
		get
		{
			return this.n;
		}
		set
		{
			this.n = value;
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0002C244 File Offset: 0x0002A444
	// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x0002C24C File Offset: 0x0002A44C
	public bool Ghost
	{
		get
		{
			return this.o;
		}
		set
		{
			this.o = value;
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0002C258 File Offset: 0x0002A458
	// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x0002C260 File Offset: 0x0002A460
	[Browsable(false)]
	[XmlIgnore]
	public euz Parent
	{
		get
		{
			return this.r;
		}
		private set
		{
			if (this.r != value)
			{
				this.r = value;
				this.bi();
			}
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0002C27C File Offset: 0x0002A47C
	[XmlIgnore]
	[Browsable(false)]
	public euz Context
	{
		get
		{
			if (!this.IsPrivateComponent)
			{
				return this;
			}
			if (this.Parent != null)
			{
				return this.Parent.Context;
			}
			return null;
		}
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x0002C2A4 File Offset: 0x0002A4A4
	public virtual bool aox(euz A_0)
	{
		czh.a(A_0, "control");
		this.q.AcquireWriterLock(-1);
		try
		{
			if (this.p.Contains(A_0))
			{
				return false;
			}
			A_0.b(Keyboard.GetState());
			A_0.Parent = this;
			this.b(A_0);
			A_0.am();
			if (this.ay != null)
			{
				this.ay(this, new d71(A_0));
			}
			this.bi();
		}
		finally
		{
			this.q.ReleaseWriterLock();
		}
		return true;
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x0002C348 File Offset: 0x0002A548
	public virtual bool g(euz A_0)
	{
		czh.a(A_0, "control");
		this.q.AcquireWriterLock(-1);
		try
		{
			if (!this.p.Contains(A_0))
			{
				return false;
			}
			this.f(null);
			A_0.bn();
			this.p.Remove(A_0);
			if (this.az != null)
			{
				this.az(this, new d71(A_0));
			}
			this.bi();
		}
		finally
		{
			this.q.ReleaseWriterLock();
		}
		return true;
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x0002C3E8 File Offset: 0x0002A5E8
	private void e()
	{
		this.a6 = false;
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x0002C3F4 File Offset: 0x0002A5F4
	internal void ao()
	{
		this.q.AcquireWriterLock(-1);
		try
		{
			while (this.Controls.Count > 0)
			{
				this.g(this.Controls[0]);
			}
		}
		finally
		{
			this.q.ReleaseWriterLock();
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0002C454 File Offset: 0x0002A654
	[XmlIgnore]
	[Browsable(false)]
	public ReadOnlyCollection<euz> Controls
	{
		get
		{
			return this.p.AsReadOnly();
		}
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x0002C464 File Offset: 0x0002A664
	public virtual bool d(euz A_0)
	{
		czh.a(A_0, "control");
		if (!this.p.Contains(A_0))
		{
			return false;
		}
		if (A_0.Gravity != axy.b)
		{
			this.q.AcquireWriterLock(-1);
			try
			{
				this.p.Remove(A_0);
				this.b(A_0);
			}
			finally
			{
				this.q.ReleaseWriterLock();
			}
		}
		return true;
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06000ACA RID: 2762 RVA: 0x0002C4E0 File Offset: 0x0002A6E0
	// (set) Token: 0x06000ACB RID: 2763 RVA: 0x0002C4E8 File Offset: 0x0002A6E8
	[Category("Behavior")]
	public virtual axy Gravity
	{
		get
		{
			return this.s;
		}
		set
		{
			if (this.s != value)
			{
				this.s = value;
				this.bi();
			}
		}
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x0002C504 File Offset: 0x0002A704
	private void b(euz A_0)
	{
		if (A_0.Gravity == axy.c)
		{
			this.p.Add(A_0);
			return;
		}
		int index = 0;
		for (int i = this.p.Count - 1; i >= 0; i--)
		{
			if (this.p[i].Gravity != axy.c)
			{
				index = i + 1;
				break;
			}
		}
		this.p.Insert(index, A_0);
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0002C574 File Offset: 0x0002A774
	public virtual bool UseScissorRect
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0002C578 File Offset: 0x0002A778
	[XmlIgnore]
	[Browsable(false)]
	public bool IsLocalShadow
	{
		get
		{
			if (this.r == null)
			{
				return false;
			}
			euz euz = this.r.bm();
			return euz != null && euz != this;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0002C5B0 File Offset: 0x0002A7B0
	[Browsable(false)]
	[XmlIgnore]
	public virtual bool IsShadow
	{
		get
		{
			if (this.r == null)
			{
				return false;
			}
			euz euz = this.r.a7();
			return euz != null && euz != this && !this.a(euz);
		}
	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x0002C5F4 File Offset: 0x0002A7F4
	private bool a(euz A_0)
	{
		foreach (euz euz in A_0.Controls)
		{
			if (euz == this || this.a(euz))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0002C660 File Offset: 0x0002A860
	[Browsable(false)]
	[XmlIgnore]
	public bool IsLocalDialog
	{
		get
		{
			return this.r != null && this.r.bm() == this;
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0002C684 File Offset: 0x0002A884
	[XmlIgnore]
	[Browsable(false)]
	public bool IsDialog
	{
		get
		{
			return this.r != null && this.r.a7() == this;
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0002C6AC File Offset: 0x0002A8AC
	[Browsable(false)]
	[XmlIgnore]
	public bool IsFocus
	{
		get
		{
			d1a d1a = bjn.c();
			return d1a != null && d1a.aa7() == this;
		}
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x0002C6D0 File Offset: 0x0002A8D0
	public void bj()
	{
		this.Gravity = axy.c;
		if (this.r == null)
		{
			bjn.b().aau().aox(this);
		}
		this.r.f(this);
		this.a9();
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x0002C708 File Offset: 0x0002A908
	public void e(euz A_0)
	{
		this.Gravity = axy.c;
		czh.a(A_0, "parent");
		A_0.aox(this);
		this.r.f(this);
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x0002C734 File Offset: 0x0002A934
	public void a9()
	{
		d1a service = bpo.GetService<d1a>();
		if (service != null && service.aam() != null && service.aam().ajs() == this)
		{
			return;
		}
		if (this.Focusable)
		{
			service.aa4(this);
			return;
		}
		service.aa5();
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x0002C784 File Offset: 0x0002A984
	public void bp()
	{
		d1a service = bpo.GetService<d1a>();
		if (service.aa7() == this || this.ajp())
		{
			service.aa6();
		}
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x0002C7B4 File Offset: 0x0002A9B4
	protected virtual bool ajp()
	{
		return false;
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x0002C7B8 File Offset: 0x0002A9B8
	public virtual euz bm()
	{
		return this.t;
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x0002C7C4 File Offset: 0x0002A9C4
	public euz a7()
	{
		if (this.Parent != null)
		{
			euz euz = this.Parent.a7();
			if (euz != null)
			{
				return euz;
			}
		}
		return this.t;
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x0002C7F8 File Offset: 0x0002A9F8
	public virtual void f(euz A_0)
	{
		this.t = A_0;
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0002C804 File Offset: 0x0002AA04
	// (set) Token: 0x06000ADD RID: 2781 RVA: 0x0002C80C File Offset: 0x0002AA0C
	[Category("Behavior")]
	public virtual bool Focusable
	{
		get
		{
			return this.u;
		}
		set
		{
			this.u = value;
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0002C818 File Offset: 0x0002AA18
	[Browsable(false)]
	public virtual bool IsFragileFocus
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x0002C81C File Offset: 0x0002AA1C
	public void bb()
	{
		if (this.@as != null)
		{
			this.@as(this, null);
		}
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x0002C838 File Offset: 0x0002AA38
	internal void a5()
	{
		if (this.ar != null)
		{
			this.ar(this, null);
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0002C854 File Offset: 0x0002AA54
	[Category("Appearance")]
	public virtual string CursorName
	{
		get
		{
			return null;
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0002C858 File Offset: 0x0002AA58
	[Browsable(false)]
	public bool Activated
	{
		get
		{
			return this.v;
		}
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x0002C860 File Offset: 0x0002AA60
	static euz()
	{
		euz.c.ScissorTestEnable = true;
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x0002C87C File Offset: 0x0002AA7C
	protected euz()
	{
		this.d();
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x0002C924 File Offset: 0x0002AB24
	private void d()
	{
		this.h(new EventHandler(this.f));
		this.j(new EventHandler<b25>(this.ik));
		this.g(new EventHandler<b25>(this.ns));
		this.l(new EventHandler<b25>(this.nr));
		this.m(new EventHandler<b25>(this.vt));
		this.s(new EventHandler<b25>(this.vu));
		this.t(new EventHandler<b25>(this.it));
		this.d(new EventHandler<ane>(this.vx));
		this.g(new EventHandler<ane>(this.g6));
		this.e(new EventHandler<ane>(this.h8));
		this.c(new EventHandler<ane>(this.y7));
		this.p(new EventHandler<c1>(this.j));
		this.q(new EventHandler<c1>(this.jq));
		this.q(new EventHandler<c1>(this.a));
		this.p(new EventHandler<b25>(this.lq));
		this.i(new EventHandler<b25>(this.af));
		this.u(new EventHandler<c1>(this.k));
		this.w(new EventHandler<c1>(this.m));
		this.y(new EventHandler<c1>(this.n6));
		this.o(new EventHandler<c1>(this.j5));
		this.z(new EventHandler<c1>(this.l));
		this.e(new EventHandler(this.ls));
		this.i(new EventHandler(this.afy));
		this.i(new EventHandler<etu>(this.ag6));
		this.h(new EventHandler<etu>(this.d));
		this.g(new EventHandler<etu>(this.ag7));
		this.c(new EventHandler<etu>(this.b));
		this.d(new EventHandler<etu>(this.c));
		this.d(new EventHandler<d71>(this.aaf));
		this.c(new EventHandler<d71>(this.aag));
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x0002CB6C File Offset: 0x0002AD6C
	public virtual void aoy()
	{
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x0002CB70 File Offset: 0x0002AD70
	public void am()
	{
		if (!this.v)
		{
			this.e();
			this.i0();
			this.v = true;
		}
		foreach (euz euz in this.Controls)
		{
			euz.am();
		}
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x0002CBE4 File Offset: 0x0002ADE4
	public void bn()
	{
		if (this.v)
		{
			this.i1();
			this.v = false;
		}
		foreach (euz euz in this.Controls)
		{
			euz.bn();
		}
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x0002CC50 File Offset: 0x0002AE50
	protected virtual void i0()
	{
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x0002CC54 File Offset: 0x0002AE54
	protected virtual void i1()
	{
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x0002CC58 File Offset: 0x0002AE58
	[CompilerGenerated]
	public void j(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.w;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.w, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x0002CC90 File Offset: 0x0002AE90
	[CompilerGenerated]
	public void u(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.w;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.w, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x0002CCC8 File Offset: 0x0002AEC8
	[CompilerGenerated]
	public void l(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.x;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.x, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x0002CD00 File Offset: 0x0002AF00
	[CompilerGenerated]
	public void n(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.x;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.x, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x0002CD38 File Offset: 0x0002AF38
	[CompilerGenerated]
	public void g(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.y;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.y, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x0002CD70 File Offset: 0x0002AF70
	[CompilerGenerated]
	public void o(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.y;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.y, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x0002CDA8 File Offset: 0x0002AFA8
	[CompilerGenerated]
	public void m(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.z;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.z, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x0002CDE0 File Offset: 0x0002AFE0
	[CompilerGenerated]
	public void k(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.z;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.z, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x0002CE18 File Offset: 0x0002B018
	[CompilerGenerated]
	public void s(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.aa;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.aa, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x0002CE50 File Offset: 0x0002B050
	[CompilerGenerated]
	public void r(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.aa;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.aa, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x0002CE88 File Offset: 0x0002B088
	[CompilerGenerated]
	public void t(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.ab;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.ab, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x0002CEC0 File Offset: 0x0002B0C0
	[CompilerGenerated]
	public void v(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.ab;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.ab, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0002CEF8 File Offset: 0x0002B0F8
	// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x0002CF00 File Offset: 0x0002B100
	public bool PropagateMouseScrollEvent
	{
		get
		{
			return this.ac;
		}
		set
		{
			this.ac = value;
		}
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x0002CF0C File Offset: 0x0002B10C
	[CompilerGenerated]
	public void d(EventHandler<ane> A_0)
	{
		EventHandler<ane> eventHandler = this.ad;
		EventHandler<ane> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ane> value = (EventHandler<ane>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ane>>(ref this.ad, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x0002CF44 File Offset: 0x0002B144
	[CompilerGenerated]
	public void a(EventHandler<ane> A_0)
	{
		EventHandler<ane> eventHandler = this.ad;
		EventHandler<ane> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ane> value = (EventHandler<ane>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ane>>(ref this.ad, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x0002CF7C File Offset: 0x0002B17C
	[CompilerGenerated]
	public void g(EventHandler<ane> A_0)
	{
		EventHandler<ane> eventHandler = this.ae;
		EventHandler<ane> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ane> value = (EventHandler<ane>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ane>>(ref this.ae, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x0002CFB4 File Offset: 0x0002B1B4
	[CompilerGenerated]
	public void h(EventHandler<ane> A_0)
	{
		EventHandler<ane> eventHandler = this.ae;
		EventHandler<ane> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ane> value = (EventHandler<ane>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ane>>(ref this.ae, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x0002CFEC File Offset: 0x0002B1EC
	[CompilerGenerated]
	public void e(EventHandler<ane> A_0)
	{
		EventHandler<ane> eventHandler = this.af;
		EventHandler<ane> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ane> value = (EventHandler<ane>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ane>>(ref this.af, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x0002D024 File Offset: 0x0002B224
	[CompilerGenerated]
	public void f(EventHandler<ane> A_0)
	{
		EventHandler<ane> eventHandler = this.af;
		EventHandler<ane> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ane> value = (EventHandler<ane>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ane>>(ref this.af, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x0002D05C File Offset: 0x0002B25C
	[CompilerGenerated]
	public void c(EventHandler<ane> A_0)
	{
		EventHandler<ane> eventHandler = this.ag;
		EventHandler<ane> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ane> value = (EventHandler<ane>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ane>>(ref this.ag, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x0002D094 File Offset: 0x0002B294
	[CompilerGenerated]
	public void b(EventHandler<ane> A_0)
	{
		EventHandler<ane> eventHandler = this.ag;
		EventHandler<ane> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ane> value = (EventHandler<ane>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ane>>(ref this.ag, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x0002D0CC File Offset: 0x0002B2CC
	[CompilerGenerated]
	public void p(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ah;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ah, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B02 RID: 2818 RVA: 0x0002D104 File Offset: 0x0002B304
	[CompilerGenerated]
	public void m(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ah;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ah, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x0002D13C File Offset: 0x0002B33C
	[CompilerGenerated]
	public void q(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ai;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ai, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x0002D174 File Offset: 0x0002B374
	[CompilerGenerated]
	public void s(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ai;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ai, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x0002D1AC File Offset: 0x0002B3AC
	[CompilerGenerated]
	public void p(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.aj;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.aj, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x0002D1E4 File Offset: 0x0002B3E4
	[CompilerGenerated]
	public void h(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.aj;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.aj, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x0002D21C File Offset: 0x0002B41C
	[CompilerGenerated]
	public void i(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.ak;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.ak, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x0002D254 File Offset: 0x0002B454
	[CompilerGenerated]
	public void q(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.ak;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.ak, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x0002D28C File Offset: 0x0002B48C
	[CompilerGenerated]
	public void h(EventHandler A_0)
	{
		EventHandler eventHandler = this.al;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.al, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x0002D2C4 File Offset: 0x0002B4C4
	[CompilerGenerated]
	public void g(EventHandler A_0)
	{
		EventHandler eventHandler = this.al;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.al, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x0002D2FC File Offset: 0x0002B4FC
	[CompilerGenerated]
	public void u(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.am;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.am, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x0002D334 File Offset: 0x0002B534
	[CompilerGenerated]
	public void x(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.am;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.am, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x0002D36C File Offset: 0x0002B56C
	[CompilerGenerated]
	public void w(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.an;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.an, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x0002D3A4 File Offset: 0x0002B5A4
	[CompilerGenerated]
	public void n(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.an;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.an, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x0002D3DC File Offset: 0x0002B5DC
	[CompilerGenerated]
	public void y(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ao;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ao, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x0002D414 File Offset: 0x0002B614
	[CompilerGenerated]
	public void t(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ao;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ao, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x0002D44C File Offset: 0x0002B64C
	[CompilerGenerated]
	public void o(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ap;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ap, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x0002D484 File Offset: 0x0002B684
	[CompilerGenerated]
	public void r(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.ap;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.ap, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x0002D4BC File Offset: 0x0002B6BC
	[CompilerGenerated]
	public void z(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.aq;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.aq, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x0002D4F4 File Offset: 0x0002B6F4
	[CompilerGenerated]
	public void v(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.aq;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.aq, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x0002D52C File Offset: 0x0002B72C
	[CompilerGenerated]
	public void e(EventHandler A_0)
	{
		EventHandler eventHandler = this.ar;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.ar, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B16 RID: 2838 RVA: 0x0002D564 File Offset: 0x0002B764
	[CompilerGenerated]
	public void f(EventHandler A_0)
	{
		EventHandler eventHandler = this.ar;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.ar, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x0002D59C File Offset: 0x0002B79C
	[CompilerGenerated]
	public void i(EventHandler A_0)
	{
		EventHandler eventHandler = this.@as;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.@as, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x0002D5D4 File Offset: 0x0002B7D4
	[CompilerGenerated]
	public void j(EventHandler A_0)
	{
		EventHandler eventHandler = this.@as;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.@as, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x0002D60C File Offset: 0x0002B80C
	[CompilerGenerated]
	public void h(EventHandler<etu> A_0)
	{
		EventHandler<etu> eventHandler = this.at;
		EventHandler<etu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<etu> value = (EventHandler<etu>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<etu>>(ref this.at, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x0002D644 File Offset: 0x0002B844
	[CompilerGenerated]
	public void b(EventHandler<etu> A_0)
	{
		EventHandler<etu> eventHandler = this.at;
		EventHandler<etu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<etu> value = (EventHandler<etu>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<etu>>(ref this.at, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x0002D67C File Offset: 0x0002B87C
	[CompilerGenerated]
	public void d(EventHandler<etu> A_0)
	{
		EventHandler<etu> eventHandler = this.au;
		EventHandler<etu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<etu> value = (EventHandler<etu>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<etu>>(ref this.au, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x0002D6B4 File Offset: 0x0002B8B4
	[CompilerGenerated]
	public void a(EventHandler<etu> A_0)
	{
		EventHandler<etu> eventHandler = this.au;
		EventHandler<etu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<etu> value = (EventHandler<etu>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<etu>>(ref this.au, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x0002D6EC File Offset: 0x0002B8EC
	[CompilerGenerated]
	public void c(EventHandler<etu> A_0)
	{
		EventHandler<etu> eventHandler = this.av;
		EventHandler<etu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<etu> value = (EventHandler<etu>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<etu>>(ref this.av, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x0002D724 File Offset: 0x0002B924
	[CompilerGenerated]
	public void f(EventHandler<etu> A_0)
	{
		EventHandler<etu> eventHandler = this.av;
		EventHandler<etu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<etu> value = (EventHandler<etu>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<etu>>(ref this.av, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x0002D75C File Offset: 0x0002B95C
	[CompilerGenerated]
	public void i(EventHandler<etu> A_0)
	{
		EventHandler<etu> eventHandler = this.aw;
		EventHandler<etu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<etu> value = (EventHandler<etu>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<etu>>(ref this.aw, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x0002D794 File Offset: 0x0002B994
	[CompilerGenerated]
	public void j(EventHandler<etu> A_0)
	{
		EventHandler<etu> eventHandler = this.aw;
		EventHandler<etu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<etu> value = (EventHandler<etu>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<etu>>(ref this.aw, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x0002D7CC File Offset: 0x0002B9CC
	[CompilerGenerated]
	public void g(EventHandler<etu> A_0)
	{
		EventHandler<etu> eventHandler = this.ax;
		EventHandler<etu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<etu> value = (EventHandler<etu>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<etu>>(ref this.ax, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x0002D804 File Offset: 0x0002BA04
	[CompilerGenerated]
	public void e(EventHandler<etu> A_0)
	{
		EventHandler<etu> eventHandler = this.ax;
		EventHandler<etu> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<etu> value = (EventHandler<etu>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<etu>>(ref this.ax, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x0002D83C File Offset: 0x0002BA3C
	[CompilerGenerated]
	public void d(EventHandler<d71> A_0)
	{
		EventHandler<d71> eventHandler = this.ay;
		EventHandler<d71> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<d71> value = (EventHandler<d71>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<d71>>(ref this.ay, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x0002D874 File Offset: 0x0002BA74
	[CompilerGenerated]
	public void a(EventHandler<d71> A_0)
	{
		EventHandler<d71> eventHandler = this.ay;
		EventHandler<d71> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<d71> value = (EventHandler<d71>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<d71>>(ref this.ay, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x0002D8AC File Offset: 0x0002BAAC
	[CompilerGenerated]
	public void c(EventHandler<d71> A_0)
	{
		EventHandler<d71> eventHandler = this.az;
		EventHandler<d71> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<d71> value = (EventHandler<d71>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<d71>>(ref this.az, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x0002D8E4 File Offset: 0x0002BAE4
	[CompilerGenerated]
	public void b(EventHandler<d71> A_0)
	{
		EventHandler<d71> eventHandler = this.az;
		EventHandler<d71> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<d71> value = (EventHandler<d71>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<d71>>(ref this.az, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x0002D91C File Offset: 0x0002BB1C
	protected void bi()
	{
		if (this.al != null)
		{
			this.al(this, new EventArgs());
		}
	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x0002D93C File Offset: 0x0002BB3C
	protected virtual void f(object A_0, EventArgs A_1)
	{
		this.e("Changed");
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x0002D94C File Offset: 0x0002BB4C
	protected virtual void aaf(object A_0, d71 A_1)
	{
		this.e("ChildControlAdded");
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x0002D95C File Offset: 0x0002BB5C
	protected virtual void aag(object A_0, d71 A_1)
	{
		this.e("ChildControlRemoved");
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x0002D96C File Offset: 0x0002BB6C
	protected virtual void lq(object A_0, b25 A_1)
	{
		this.e("Click");
		if ((A_1.b() == eoo.b || A_1.b() == eoo.d) && !this.IsFocus)
		{
			this.a9();
		}
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x0002D9B0 File Offset: 0x0002BBB0
	protected virtual void af(object A_0, b25 A_1)
	{
		this.e("DoubleClick");
		if ((A_1.b() == eoo.b || A_1.b() == eoo.d) && !this.IsFocus)
		{
			this.a9();
		}
	}

	// Token: 0x06000B2D RID: 2861 RVA: 0x0002D9F4 File Offset: 0x0002BBF4
	protected virtual void ik(object A_0, b25 A_1)
	{
		this.e("MouseEnter");
		chr chr = bjn.d();
		if (chr != null && chr.aw() && this.at != null)
		{
			etu etu = new etu(chr.ax(), A_1.a());
			this.at(A_0, etu);
		}
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x0002DA50 File Offset: 0x0002BC50
	protected virtual void nr(object A_0, b25 A_1)
	{
		this.e("MouseLeave");
		chr chr = bjn.d();
		if (chr != null && chr.aw() && this.av != null)
		{
			etu etu = new etu(chr.ax(), A_1.a());
			this.av(A_0, etu);
		}
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x0002DAAC File Offset: 0x0002BCAC
	protected virtual void ns(object A_0, b25 A_1)
	{
		this.e("MouseMove");
		chr chr = bjn.d();
		if (chr != null && chr.aw() && this.au != null)
		{
			etu etu = new etu(chr.ax(), A_1.a());
			this.au(A_0, etu);
		}
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x0002DB08 File Offset: 0x0002BD08
	protected virtual void c(object A_0, etu A_1)
	{
		this.e("DragOver");
	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x0002DB18 File Offset: 0x0002BD18
	protected virtual void b(object A_0, etu A_1)
	{
		this.e("DragLeave");
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x0002DB28 File Offset: 0x0002BD28
	protected virtual void ag7(object A_0, etu A_1)
	{
		this.e("DragError");
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x0002DB38 File Offset: 0x0002BD38
	protected virtual void d(object A_0, etu A_1)
	{
		this.e("DragEnter");
	}

	// Token: 0x06000B34 RID: 2868 RVA: 0x0002DB48 File Offset: 0x0002BD48
	protected virtual void ag6(object A_0, etu A_1)
	{
		this.e("DragDrop");
	}

	// Token: 0x06000B35 RID: 2869 RVA: 0x0002DB58 File Offset: 0x0002BD58
	protected virtual void afy(object A_0, EventArgs A_1)
	{
		this.e("FocusLeave");
	}

	// Token: 0x06000B36 RID: 2870 RVA: 0x0002DB68 File Offset: 0x0002BD68
	protected virtual void ls(object A_0, EventArgs A_1)
	{
		this.e("FocusEnter");
	}

	// Token: 0x06000B37 RID: 2871 RVA: 0x0002DB78 File Offset: 0x0002BD78
	protected virtual void j5(object A_0, c1 A_1)
	{
		this.e("TextChanged");
	}

	// Token: 0x06000B38 RID: 2872 RVA: 0x0002DB88 File Offset: 0x0002BD88
	protected virtual void l(object A_0, c1 A_1)
	{
		this.e("ColorChanged");
		if (this.n)
		{
			foreach (euz euz in this.Controls)
			{
				euz.Color = this.Color;
			}
		}
	}

	// Token: 0x06000B39 RID: 2873 RVA: 0x0002DBF8 File Offset: 0x0002BDF8
	protected virtual void n6(object A_0, c1 A_1)
	{
		this.e("EnabledChanged");
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x0002DC08 File Offset: 0x0002BE08
	protected virtual void m(object A_0, c1 A_1)
	{
		this.e("VisibilityChanged");
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x0002DC18 File Offset: 0x0002BE18
	protected virtual void k(object A_0, c1 A_1)
	{
		this.e("NameChanged");
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x0002DC28 File Offset: 0x0002BE28
	protected virtual void jq(object A_0, c1 A_1)
	{
		this.e("Resized");
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x0002DC38 File Offset: 0x0002BE38
	protected virtual void j(object A_0, c1 A_1)
	{
		this.e("Moved");
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x0002DC48 File Offset: 0x0002BE48
	protected virtual void h8(object A_0, ane A_1)
	{
		this.e("KeyPressed");
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x0002DC58 File Offset: 0x0002BE58
	protected virtual void y7(object A_0, ane A_1)
	{
		this.e("KeyDistinctlyPressed");
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x0002DC68 File Offset: 0x0002BE68
	protected virtual void g6(object A_0, ane A_1)
	{
		this.e("KeyDown");
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x0002DC78 File Offset: 0x0002BE78
	protected virtual void vx(object A_0, ane A_1)
	{
		this.e("KeyUp");
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x0002DC88 File Offset: 0x0002BE88
	protected virtual void vu(object A_0, b25 A_1)
	{
		this.e("MouseUp");
		if (A_1.b() == eoo.b)
		{
			this.a6();
			this.a8();
		}
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x0002DCB0 File Offset: 0x0002BEB0
	protected virtual void vt(object A_0, b25 A_1)
	{
		this.e("MouseDown");
		if (A_1.b() == eoo.b)
		{
			if (this.a(A_1))
			{
				this.f(A_1);
				return;
			}
			if (this.d(A_1))
			{
				this.b(A_1);
			}
		}
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x0002DCFC File Offset: 0x0002BEFC
	protected virtual void it(object A_0, b25 A_1)
	{
		this.e("MouseScroll");
		if (this.PropagateMouseScrollEvent && this.Parent != null)
		{
			this.Parent.ab(this.Parent, A_1);
		}
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x0002DD44 File Offset: 0x0002BF44
	protected virtual bool afn(euz A_0, b25 A_1)
	{
		return false;
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x0002DD48 File Offset: 0x0002BF48
	protected virtual bool afo(euz A_0, b25 A_1)
	{
		return false;
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x0002DD4C File Offset: 0x0002BF4C
	protected virtual bool afp(euz A_0, b25 A_1)
	{
		return false;
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x0002DD50 File Offset: 0x0002BF50
	protected virtual bool afq(euz A_0, ane A_1)
	{
		return false;
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x0002DD54 File Offset: 0x0002BF54
	protected virtual bool afs(euz A_0, ane A_1)
	{
		return false;
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x0002DD58 File Offset: 0x0002BF58
	protected virtual bool afr(euz A_0, ane A_1)
	{
		return false;
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x0002DD5C File Offset: 0x0002BF5C
	public virtual string afm(euz A_0)
	{
		return null;
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0002DD60 File Offset: 0x0002BF60
	[Browsable(false)]
	[XmlIgnore]
	public bool IsMoving
	{
		get
		{
			return this.a0;
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06000B4D RID: 2893 RVA: 0x0002DD68 File Offset: 0x0002BF68
	[XmlIgnore]
	[Browsable(false)]
	public bool IsResizing
	{
		get
		{
			return this.a1;
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0002DD70 File Offset: 0x0002BF70
	// (set) Token: 0x06000B4F RID: 2895 RVA: 0x0002DD78 File Offset: 0x0002BF78
	[Category("Behavior")]
	public bool Movable
	{
		get
		{
			return this.a2;
		}
		set
		{
			if (this.a2 != value)
			{
				this.a2 = value;
				this.bi();
			}
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0002DD94 File Offset: 0x0002BF94
	// (set) Token: 0x06000B51 RID: 2897 RVA: 0x0002DD9C File Offset: 0x0002BF9C
	[Category("Behavior")]
	public bool Resizable
	{
		get
		{
			return this.a3;
		}
		set
		{
			if (this.a3 != value)
			{
				this.a3 = value;
				this.bi();
			}
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0002DDB8 File Offset: 0x0002BFB8
	// (set) Token: 0x06000B53 RID: 2899 RVA: 0x0002DDC0 File Offset: 0x0002BFC0
	[Category("Layout")]
	public mu Anchoring
	{
		get
		{
			return this.a4;
		}
		set
		{
			this.a4 = value;
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0002DDCC File Offset: 0x0002BFCC
	// (set) Token: 0x06000B55 RID: 2901 RVA: 0x0002DDD4 File Offset: 0x0002BFD4
	[Category("Behavior")]
	public bool IsPrivateComponent
	{
		get
		{
			return this.a5;
		}
		set
		{
			if (this.a5 != value)
			{
				this.a5 = value;
				this.bi();
			}
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0002DDF0 File Offset: 0x0002BFF0
	public virtual bool ForceProvidesCursor
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x0002DDF4 File Offset: 0x0002BFF4
	protected virtual void b(b25 A_0)
	{
		if (this.IsPrivateComponent)
		{
			if (this.Parent != null)
			{
				this.Parent.b(A_0);
				return;
			}
		}
		else if (this.Movable || (euz.DesignMode && !((btr)this).a()))
		{
			this.a0 = true;
		}
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x0002DE4C File Offset: 0x0002C04C
	protected void a6()
	{
		if (this.IsPrivateComponent)
		{
			if (this.Parent != null)
			{
				this.Parent.a6();
				return;
			}
		}
		else
		{
			this.a0 = false;
		}
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x0002DE7C File Offset: 0x0002C07C
	protected bool d(b25 A_0)
	{
		if (!this.IsPrivateComponent)
		{
			return true;
		}
		if (this.Parent != null)
		{
			b25 a_ = new b25(this.e(A_0.a()), A_0.c(), A_0.b());
			return this.Parent.d(a_);
		}
		return false;
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x0002DED0 File Offset: 0x0002C0D0
	protected void f(b25 A_0)
	{
		if (this.IsPrivateComponent)
		{
			if (this.Parent != null)
			{
				this.Parent.f(A_0);
				return;
			}
		}
		else if (this.Resizable || (euz.DesignMode && !((btr)this).a()))
		{
			this.a1 = true;
		}
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x0002DF28 File Offset: 0x0002C128
	protected void a8()
	{
		if (this.IsPrivateComponent)
		{
			if (this.Parent != null)
			{
				this.Parent.a8();
				return;
			}
		}
		else
		{
			this.a1 = false;
		}
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x0002DF58 File Offset: 0x0002C158
	protected virtual bool a(b25 A_0)
	{
		if (this.IsPrivateComponent)
		{
			if (this.Parent != null)
			{
				b25 a_ = new b25(this.e(A_0.a()), A_0.c(), A_0.b());
				return this.Parent.a(a_);
			}
			return false;
		}
		else
		{
			if (A_0 == null)
			{
				return true;
			}
			Point point = A_0.a();
			int num = 10;
			return point.X >= this.Size.c - num && point.Y >= this.Size.d - num;
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0002DFF0 File Offset: 0x0002C1F0
	protected static bool DesignMode
	{
		get
		{
			bcm bcm = bjn.b();
			return bcm != null && bcm.aay();
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0002E014 File Offset: 0x0002C214
	protected bool IsDesignSelected
	{
		get
		{
			bcm bcm = bjn.b();
			return bcm != null && bcm.aa0() == this;
		}
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x0002E038 File Offset: 0x0002C238
	private void a(object A_0, c1 A_1)
	{
		if (!(A_1.b() is esj) || !(A_1.a() is esj))
		{
			return;
		}
		esj esj = (esj)A_1.b();
		esj a_ = (esj)A_1.a();
		if (esj.c == 0 || esj.d == 0)
		{
			return;
		}
		foreach (euz euz in this.Controls)
		{
			if (!euz.IsPrivateComponent && euz.IsAnchored)
			{
				euz.a(esj, a_);
			}
		}
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x0002E0F8 File Offset: 0x0002C2F8
	private void a(esj A_0, esj A_1)
	{
		esj esj = esj.b(A_1, A_0);
		esj esj2 = this.Size;
		Point a_ = this.Location;
		if (this.Anchoring.a() && this.Anchoring.b())
		{
			esj2.c += esj.c;
		}
		else if (this.Anchoring.b())
		{
			a_.X += esj.c;
		}
		if (this.Anchoring.c() && this.Anchoring.d())
		{
			esj2.d += esj.d;
		}
		else if (this.Anchoring.d())
		{
			a_.Y += esj.d;
		}
		if (esj2.c < 3)
		{
			esj2.c = 3;
		}
		if (esj2.d < 3)
		{
			esj2.d = 3;
		}
		this.Size = esj2;
		this.Location = a_;
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x0002E200 File Offset: 0x0002C400
	public void ap()
	{
		if (this.r != null)
		{
			this.Location = new Point((this.r.e.c - this.e.c) / 2, (this.r.e.d - this.e.d) / 2);
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0002E260 File Offset: 0x0002C460
	[Browsable(false)]
	[XmlIgnore]
	public bool IsAnchored
	{
		get
		{
			return this.Anchoring != null && (this.Anchoring.a() || this.Anchoring.b() || this.Anchoring.c() || this.Anchoring.d());
		}
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x0002E2BC File Offset: 0x0002C4BC
	public virtual void iv(e6d A_0, cp9 A_1)
	{
		if (this.UseScissorRect)
		{
			bool scissorTestEnable = A_1.c.RasterizerState.ScissorTestEnable;
			Rectangle scissorRectangle = A_1.c.ScissorRectangle;
			Rectangle rectangle = Rectangle.Intersect(scissorRectangle, this.rv());
			Rectangle rectangle2 = scissorRectangle;
			foreach (euz euz in this.p)
			{
				if (euz.IsEffectivelyVisible)
				{
					Rectangle rectangle3;
					if (euz.IsPrivateComponent)
					{
						rectangle3 = scissorRectangle;
					}
					else
					{
						rectangle3 = rectangle;
					}
					if (rectangle3 != rectangle2)
					{
						A_1.a();
						A_1.c.ScissorRectangle = rectangle3;
						A_1.a(euz.c);
					}
					euz.iv(A_0, A_1);
					rectangle2 = rectangle3;
				}
			}
			A_1.a();
			A_1.c.ScissorRectangle = scissorRectangle;
			RasterizerState cullCounterClockwise;
			if (scissorTestEnable)
			{
				cullCounterClockwise = euz.c;
			}
			else
			{
				cullCounterClockwise = RasterizerState.CullCounterClockwise;
			}
			A_1.a(cullCounterClockwise);
			return;
		}
		foreach (euz euz2 in this.p)
		{
			if (euz2.IsEffectivelyVisible)
			{
				euz2.iv(A_0, A_1);
			}
		}
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x0002E430 File Offset: 0x0002C630
	protected virtual Rectangle rv()
	{
		Point point = this.at();
		return new Rectangle(point.X, point.Y, this.Size.c, this.Size.d);
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0002E46C File Offset: 0x0002C66C
	protected bool MousedOverCache
	{
		get
		{
			return this.a6;
		}
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x0002E478 File Offset: 0x0002C678
	public virtual void ag5(e6d A_0)
	{
		d1a a_ = bjn.c();
		bcm a_2 = bjn.b();
		if (this.IsShadow || !this.Enabled || !this.IsEffectivelyVisible)
		{
			return;
		}
		List<euz> list = new List<euz>(this.p);
		bool a_3 = this.b(A_0, a_, a_2);
		this.a(A_0, a_, a_2);
		this.b(A_0);
		this.a(A_0);
		this.a(A_0, a_3);
		this.c(A_0);
		foreach (euz euz in list)
		{
			if (euz.Enabled)
			{
				euz.ag5(A_0);
			}
		}
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x0002E544 File Offset: 0x0002C744
	private void b(KeyboardState A_0)
	{
		this.bi = A_0;
		if (!this.IsFocus)
		{
			this.bj.Clear();
		}
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x0002E564 File Offset: 0x0002C764
	private void c(e6d A_0)
	{
		this.b(A_0.c());
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x0002E578 File Offset: 0x0002C778
	private void a(e6d A_0, bool A_1)
	{
		MouseState mouseState = A_0.b();
		Point point = new Point(mouseState.X, mouseState.Y);
		this.a6 = A_1;
		this.a7 = point;
		this.a8 = new ButtonState?(mouseState.LeftButton);
		this.a9 = new ButtonState?(mouseState.RightButton);
		this.ba = new ButtonState?(mouseState.MiddleButton);
		this.bb = new ButtonState?(mouseState.XButton1);
		this.bc = new ButtonState?(mouseState.XButton2);
		if (this.a8.GetValueOrDefault() != ButtonState.Pressed)
		{
			this.bd = false;
		}
		if (this.a9.GetValueOrDefault() != ButtonState.Pressed)
		{
			this.be = false;
		}
		if (this.ba.GetValueOrDefault() != ButtonState.Pressed)
		{
			this.bf = false;
		}
		if (this.bb.GetValueOrDefault() != ButtonState.Pressed)
		{
			this.bg = false;
		}
		if (this.bc.GetValueOrDefault() != ButtonState.Pressed)
		{
			this.bh = false;
		}
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x0002E684 File Offset: 0x0002C884
	private void b(e6d A_0)
	{
		if (this.a0)
		{
			int num = A_0.b().X - this.a7.X;
			int num2 = A_0.b().Y - this.a7.Y;
			this.Location = new Point(this.Location.X + num, this.Location.Y + num2);
		}
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x0002E6F8 File Offset: 0x0002C8F8
	private void a(e6d A_0)
	{
		if (this.a1)
		{
			Point point = this.at();
			int num = A_0.b().X - point.X;
			int num2 = A_0.b().Y - point.Y;
			if (num < 3)
			{
				num = 3;
			}
			if (num2 < 3)
			{
				num2 = 3;
			}
			this.Size = new esj(num, num2);
		}
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x0002E764 File Offset: 0x0002C964
	private bool b(e6d A_0, d1a A_1, bcm A_2)
	{
		MouseState mouseState = A_0.b();
		Point point = new Point(mouseState.X, mouseState.Y);
		Point point2 = this.at();
		Point point3 = new Point(mouseState.X - point2.X, mouseState.Y - point2.Y);
		bool flag = A_0.d && this.IsMousedOver;
		if (flag)
		{
			if (!this.a6 && this.w != null)
			{
				this.w(this, new b25(point3));
			}
			if (this.a7 != point && this.y != null)
			{
				this.y(this, new b25(point3));
			}
			if (mouseState.LeftButton == ButtonState.Pressed)
			{
				ButtonState? buttonState = this.a8;
				ButtonState buttonState2 = ButtonState.Released;
				if (buttonState.GetValueOrDefault() == buttonState2 & buttonState != null)
				{
					b25 a_ = new b25(point3, eoo.b);
					if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afn(this, a_))
					{
						if (this.z != null)
						{
							this.z(this, a_);
						}
						this.bd = true;
						this.a9();
					}
				}
			}
			if (mouseState.RightButton == ButtonState.Pressed)
			{
				ButtonState? buttonState = this.a9;
				ButtonState buttonState2 = ButtonState.Released;
				if (buttonState.GetValueOrDefault() == buttonState2 & buttonState != null)
				{
					b25 a_2 = new b25(point3, eoo.d);
					if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afn(this, a_2))
					{
						if (this.z != null)
						{
							this.z(this, a_2);
						}
						this.b(eoo.d, d7i.ak);
						this.be = true;
						this.a9();
					}
				}
			}
			if (mouseState.MiddleButton == ButtonState.Pressed)
			{
				ButtonState? buttonState = this.ba;
				ButtonState buttonState2 = ButtonState.Released;
				if (buttonState.GetValueOrDefault() == buttonState2 & buttonState != null)
				{
					b25 a_3 = new b25(point3, eoo.c);
					if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afn(this, a_3))
					{
						if (this.z != null)
						{
							this.z(this, a_3);
						}
						this.b(eoo.c, d7i.ak);
						this.bf = true;
						this.a9();
					}
				}
			}
			if (mouseState.XButton1 == ButtonState.Pressed)
			{
				ButtonState? buttonState = this.bb;
				ButtonState buttonState2 = ButtonState.Released;
				if (buttonState.GetValueOrDefault() == buttonState2 & buttonState != null)
				{
					b25 a_4 = new b25(point3, eoo.e);
					if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afn(this, a_4))
					{
						if (this.z != null)
						{
							this.z(this, a_4);
						}
						this.b(eoo.e, d7i.ak);
						this.bg = true;
						this.a9();
					}
				}
			}
			if (mouseState.XButton2 == ButtonState.Pressed)
			{
				ButtonState? buttonState = this.bc;
				ButtonState buttonState2 = ButtonState.Released;
				if (buttonState.GetValueOrDefault() == buttonState2 & buttonState != null)
				{
					b25 a_5 = new b25(point3, eoo.f);
					if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afn(this, a_5))
					{
						if (this.z != null)
						{
							this.z(this, a_5);
						}
						this.b(eoo.f, d7i.ak);
						this.bh = true;
						this.a9();
					}
				}
			}
			bool flag2 = false;
			chr chr = bjn.d();
			if (chr != null && chr.aw() && mouseState.LeftButton == ButtonState.Released && this.aw != null && this.iq(chr.ax()))
			{
				e08 a_6 = chr.ay();
				this.aw(this, new etu(a_6, point3));
				flag2 = true;
			}
			if (!flag2 && mouseState.LeftButton == ButtonState.Released && this.bd)
			{
				b25 a_7 = new b25(point3, eoo.b);
				if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afp(this, a_7))
				{
					if (this.aj != null)
					{
						this.aj(this, a_7);
					}
					this.a(A_0, a_7);
				}
			}
			if (mouseState.RightButton == ButtonState.Released && this.be)
			{
				b25 a_8 = new b25(point3, eoo.d);
				if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afp(this, a_8))
				{
					if (this.aj != null)
					{
						this.aj(this, a_8);
					}
					this.a(A_0, a_8);
				}
			}
			if (mouseState.MiddleButton == ButtonState.Released && this.bf)
			{
				b25 a_9 = new b25(point3, eoo.c);
				if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afp(this, a_9))
				{
					if (this.aj != null)
					{
						this.aj(this, a_9);
					}
					this.a(A_0, a_9);
				}
			}
			if (mouseState.XButton1 == ButtonState.Released && this.bg)
			{
				b25 a_10 = new b25(point3, eoo.e);
				if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afp(this, a_10))
				{
					if (this.aj != null)
					{
						this.aj(this, a_10);
					}
					this.a(A_0, a_10);
				}
			}
			if (mouseState.XButton2 == ButtonState.Released && this.bh)
			{
				b25 a_11 = new b25(point3, eoo.f);
				if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afp(this, a_11))
				{
					if (this.aj != null)
					{
						this.aj(this, a_11);
					}
					this.a(A_0, a_11);
				}
			}
			if (A_1.aba() != 0 && this.ab != null)
			{
				this.ab(this, new b25(point3, A_1.aba()));
			}
		}
		else if (this.a6 && this.x != null)
		{
			this.x(this, new b25(point3));
		}
		if (mouseState.LeftButton == ButtonState.Released && this.a8.GetValueOrDefault() == ButtonState.Pressed && this.aa != null)
		{
			b25 a_12 = new b25(point3, eoo.b);
			if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afo(this, a_12))
			{
				this.aa(this, a_12);
			}
		}
		if (mouseState.RightButton == ButtonState.Released && this.a9.GetValueOrDefault() == ButtonState.Pressed && this.aa != null)
		{
			b25 a_13 = new b25(point3, eoo.d);
			if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afo(this, a_13))
			{
				this.aa(this, a_13);
			}
		}
		if (mouseState.MiddleButton == ButtonState.Released && this.ba.GetValueOrDefault() == ButtonState.Pressed && this.aa != null)
		{
			b25 a_14 = new b25(point3, eoo.c);
			if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afo(this, a_14))
			{
				this.aa(this, a_14);
			}
		}
		if (mouseState.XButton1 == ButtonState.Released && this.bb.GetValueOrDefault() == ButtonState.Pressed && this.aa != null)
		{
			b25 a_15 = new b25(point3, eoo.e);
			if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afo(this, a_15))
			{
				this.aa(this, a_15);
			}
		}
		if (mouseState.XButton2 == ButtonState.Released && this.bc.GetValueOrDefault() == ButtonState.Pressed && this.aa != null)
		{
			b25 a_16 = new b25(point3, eoo.f);
			if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afo(this, a_16))
			{
				this.aa(this, a_16);
			}
		}
		return flag;
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x0002F068 File Offset: 0x0002D268
	private void a(e6d A_0, b25 A_1)
	{
		TimeSpan t;
		if (this.l.TryGetValue(A_1.b(), out t) && A_0.a().TotalGameTime - t <= this.k)
		{
			KeyboardState state = Keyboard.GetState();
			if (!this.a(state))
			{
				this.ak(this, A_1);
			}
			this.l.Remove(A_1.b());
			return;
		}
		this.l[A_1.b()] = A_0.a().TotalGameTime;
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x0002F0FC File Offset: 0x0002D2FC
	private bool a(KeyboardState A_0)
	{
		foreach (Keys key in new Keys[]
		{
			Keys.LeftAlt,
			Keys.RightAlt,
			Keys.LeftShift,
			Keys.RightShift,
			Keys.LeftControl,
			Keys.RightControl
		})
		{
			if (A_0.IsKeyDown(key))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x0002F168 File Offset: 0x0002D368
	private void a(e6d A_0, d1a A_1, bcm A_2)
	{
		KeyboardState keyboardState = A_0.c();
		if (this.IsFocus)
		{
			IEnumerable<Keys> pressedKeys = keyboardState.GetPressedKeys();
			foreach (object obj in Enum.GetValues(typeof(Keys)))
			{
				Keys keys = (Keys)obj;
				KeyState keyState = this.bi[keys];
				KeyState keyState2 = keyboardState[keys];
				ane a_ = new ane(keys, pressedKeys, false);
				if (keyState == KeyState.Up && keyState2 == KeyState.Down && (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afq(this, a_)))
				{
					if (this.ae != null)
					{
						this.ae(this, a_);
					}
					bool flag;
					if (this.bj.TryGetValue(keys, out flag) && !flag)
					{
						this.bj[keys] = true;
					}
					if (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afr(this, a_))
					{
						if (this.af != null)
						{
							this.af(this, a_);
						}
						this.b(keys, d7i.ak);
					}
				}
				if (keyState == KeyState.Down && keyState2 == KeyState.Up && (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afs(this, a_)))
				{
					if (this.ad != null)
					{
						this.ad(this, a_);
					}
					bool flag2;
					if (this.bj.TryGetValue(keys, out flag2) && flag2 && this.ag != null)
					{
						this.ag(this, a_);
					}
					this.bj[keys] = false;
				}
				if (keyState == KeyState.Up && keyState2 == KeyState.Up)
				{
					this.bj[keys] = false;
				}
				if (keyState == KeyState.Down && keyState2 == KeyState.Down && this.a(keys, A_0.a().ElapsedGameTime))
				{
					if (this.af != null && (A_2 == null || A_2.aau() == null || A_2.aau() == this || !A_2.aau().afr(this, a_)))
					{
						this.af(this, a_);
					}
					this.b(keys, d7i.al);
				}
			}
		}
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x0002F428 File Offset: 0x0002D628
	public void au4(Keys A_0, Keys[] A_1, bool A_2)
	{
		if (this.Enabled)
		{
			ane ane = new ane(A_0, A_1, A_2);
			EventHandler<ane> eventHandler = this.af;
			if (eventHandler != null)
			{
				eventHandler(this, ane);
			}
			EventHandler<ane> eventHandler2 = this.ag;
			if (eventHandler2 == null)
			{
				return;
			}
			eventHandler2(this, ane);
		}
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x0002F478 File Offset: 0x0002D678
	protected bool a(object A_0, TimeSpan A_1)
	{
		this.bl.AcquireReaderLock(-1);
		bool result;
		try
		{
			if (this.bk.ContainsKey(A_0))
			{
				this.bk[A_0] = this.bk[A_0] - A_1;
				if (this.bk[A_0] < TimeSpan.Zero)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			else
			{
				result = false;
			}
		}
		finally
		{
			this.bl.ReleaseReaderLock();
		}
		return result;
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x0002F510 File Offset: 0x0002D710
	protected void b(object A_0, TimeSpan A_1)
	{
		if (!this.bk.ContainsKey(A_0))
		{
			this.bl.AcquireWriterLock(-1);
			try
			{
				this.bk.Add(A_0, A_1);
				return;
			}
			finally
			{
				this.bl.ReleaseWriterLock();
			}
		}
		this.bl.AcquireReaderLock(-1);
		try
		{
			this.bk[A_0] = A_1;
		}
		finally
		{
			this.bl.ReleaseReaderLock();
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0002F5A0 File Offset: 0x0002D7A0
	[Browsable(false)]
	public virtual bool IsMousedOver
	{
		get
		{
			return !this.IsShadow && bpo.GetService<d1a>().aa8() == this;
		}
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x0002F5BC File Offset: 0x0002D7BC
	internal euz a(MouseState A_0)
	{
		if (this.iz(A_0) && this.IsEffectivelyVisible)
		{
			this.q.AcquireReaderLock(-1);
			try
			{
				for (int i = this.p.Count - 1; i >= 0; i--)
				{
					euz euz = this.p[i].a(A_0);
					if (euz != null)
					{
						return euz;
					}
				}
				return this;
			}
			finally
			{
				this.q.ReleaseReaderLock();
			}
		}
		return null;
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x0002F650 File Offset: 0x0002D850
	public virtual bool iz(MouseState A_0)
	{
		if (!this.o)
		{
			Point point = this.at();
			if (A_0.X >= point.X && A_0.Y >= point.Y && A_0.X <= point.X + this.Size.c && A_0.Y <= point.Y + this.Size.d)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x0002F6D4 File Offset: 0x0002D8D4
	internal void a(object A_0, etu A_1)
	{
		if (this.ax != null)
		{
			this.ax(A_0, A_1);
		}
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x0002F6F0 File Offset: 0x0002D8F0
	public virtual bool iq(e08 A_0)
	{
		return false;
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0002F6F4 File Offset: 0x0002D8F4
	// (set) Token: 0x06000B79 RID: 2937 RVA: 0x0002F6FC File Offset: 0x0002D8FC
	bool btr.Locked
	{
		get
		{
			return this.bm;
		}
		set
		{
			this.bm = value;
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0002F708 File Offset: 0x0002D908
	// (set) Token: 0x06000B7B RID: 2939 RVA: 0x0002F710 File Offset: 0x0002D910
	bool btr.Shown
	{
		get
		{
			return this.bn;
		}
		set
		{
			this.bn = value;
		}
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x0002F71C File Offset: 0x0002D91C
	protected Point e(Point A_0)
	{
		Point point = this.at();
		Point point2 = this.Parent.at();
		return new Point(point.X + A_0.X - point2.X, point.Y + A_0.Y - point2.Y);
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x0002F76C File Offset: 0x0002D96C
	protected Point f(Point A_0)
	{
		Point point = this.at();
		return new Point(A_0.X - point.X, A_0.Y - point.Y);
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x0002F7A0 File Offset: 0x0002D9A0
	protected void e(string A_0)
	{
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Verbose, 110))
		{
			string a_ = "[GUI] - Event triggered. Control: " + this.ToString() + ". Event: " + A_0;
			cvq.n7(LogSeverity.Verbose, 110, a_);
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0002F7F4 File Offset: 0x0002D9F4
	protected bool IsEffectivelyVisible
	{
		get
		{
			if (euz.DesignMode)
			{
				return ((btr)this).b() && (this.Visible || !this.IsPrivateComponent) && this.IsInParentClientRect;
			}
			return this.Visible && (this.IsInParentClientRect || this.IsPrivateComponent);
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0002F858 File Offset: 0x0002DA58
	private bool IsInParentClientRect
	{
		get
		{
			if (this.Parent != null)
			{
				Rectangle rectangle = this.Parent.rv();
				Point point = this.at();
				Rectangle value = new Rectangle(point.X, point.Y, this.Size.c, this.Size.d);
				return rectangle.Intersects(value);
			}
			return true;
		}
	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x0002F8B8 File Offset: 0x0002DAB8
	protected void e(b25 A_0)
	{
		if (this.z != null)
		{
			this.z(this, A_0);
		}
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x0002F8D4 File Offset: 0x0002DAD4
	protected void c(b25 A_0)
	{
		if (this.aj != null)
		{
			this.aj(this, A_0);
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0002F8F0 File Offset: 0x0002DAF0
	public static bool CapsLock
	{
		get
		{
			bool result = false;
			try
			{
				result = ((euz.GetKeyState(20) & 1) == 1);
			}
			catch
			{
			}
			return result;
		}
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x0002F928 File Offset: 0x0002DB28
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (euz euz = this; euz != null; euz = euz.Parent)
		{
			try
			{
				stringBuilder.Insert(0, euz.Name + ".");
			}
			catch
			{
			}
		}
		stringBuilder.Remove(stringBuilder.Length - 1, 1);
		return stringBuilder.ToString();
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x0002F998 File Offset: 0x0002DB98
	[OnDeserialized]
	private void a(StreamingContext A_0)
	{
		this.q = new ReaderWriterLock();
		this.bl = new ReaderWriterLock();
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x0002F9B0 File Offset: 0x0002DBB0
	public void a(eoo A_0)
	{
		b25 b = new b25(Point.Zero, A_0);
		if (this.z != null)
		{
			this.z(this, b);
		}
		if (this.aa != null)
		{
			this.aa(this, b);
		}
		if (this.aj != null)
		{
			this.aj(this, b);
		}
	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x0002FA14 File Offset: 0x0002DC14
	public void d(int A_0, int A_1)
	{
		this.Location = new Point(this.d.X + A_0, this.d.Y + A_1);
	}

	// Token: 0x04000690 RID: 1680
	private const int a = 3;

	// Token: 0x04000691 RID: 1681
	private const int b = 3;

	// Token: 0x04000692 RID: 1682
	private static readonly RasterizerState c = new RasterizerState();

	// Token: 0x04000693 RID: 1683
	private Point d;

	// Token: 0x04000694 RID: 1684
	private esj e;

	// Token: 0x04000695 RID: 1685
	private string f = "<Unnamed>";

	// Token: 0x04000696 RID: 1686
	private bool g = true;

	// Token: 0x04000697 RID: 1687
	private bool h = true;

	// Token: 0x04000698 RID: 1688
	private string i;

	// Token: 0x04000699 RID: 1689
	private object j;

	// Token: 0x0400069A RID: 1690
	private TimeSpan k = TimeSpan.FromMilliseconds(350.0);

	// Token: 0x0400069B RID: 1691
	private Dictionary<eoo, TimeSpan> l = new Dictionary<eoo, TimeSpan>();

	// Token: 0x0400069C RID: 1692
	private Color m = Color.White;

	// Token: 0x0400069D RID: 1693
	private bool n;

	// Token: 0x0400069E RID: 1694
	private bool o;

	// Token: 0x0400069F RID: 1695
	private List<euz> p = new List<euz>();

	// Token: 0x040006A0 RID: 1696
	[NonSerialized]
	private ReaderWriterLock q = new ReaderWriterLock();

	// Token: 0x040006A1 RID: 1697
	private euz r;

	// Token: 0x040006A2 RID: 1698
	private axy s;

	// Token: 0x040006A3 RID: 1699
	private euz t;

	// Token: 0x040006A4 RID: 1700
	private bool u;

	// Token: 0x040006A5 RID: 1701
	private bool v;

	// Token: 0x040006A6 RID: 1702
	[CompilerGenerated]
	private EventHandler<b25> w;

	// Token: 0x040006A7 RID: 1703
	[CompilerGenerated]
	private EventHandler<b25> x;

	// Token: 0x040006A8 RID: 1704
	[CompilerGenerated]
	private EventHandler<b25> y;

	// Token: 0x040006A9 RID: 1705
	[CompilerGenerated]
	private EventHandler<b25> z;

	// Token: 0x040006AA RID: 1706
	[CompilerGenerated]
	private EventHandler<b25> aa;

	// Token: 0x040006AB RID: 1707
	[CompilerGenerated]
	private EventHandler<b25> ab;

	// Token: 0x040006AC RID: 1708
	private bool ac;

	// Token: 0x040006AD RID: 1709
	[CompilerGenerated]
	private EventHandler<ane> ad;

	// Token: 0x040006AE RID: 1710
	[CompilerGenerated]
	private EventHandler<ane> ae;

	// Token: 0x040006AF RID: 1711
	[CompilerGenerated]
	private EventHandler<ane> af;

	// Token: 0x040006B0 RID: 1712
	[CompilerGenerated]
	private EventHandler<ane> ag;

	// Token: 0x040006B1 RID: 1713
	[CompilerGenerated]
	private EventHandler<c1> ah;

	// Token: 0x040006B2 RID: 1714
	[CompilerGenerated]
	private EventHandler<c1> ai;

	// Token: 0x040006B3 RID: 1715
	[CompilerGenerated]
	private EventHandler<b25> aj;

	// Token: 0x040006B4 RID: 1716
	[CompilerGenerated]
	private EventHandler<b25> ak;

	// Token: 0x040006B5 RID: 1717
	[CompilerGenerated]
	private EventHandler al;

	// Token: 0x040006B6 RID: 1718
	[CompilerGenerated]
	private EventHandler<c1> am;

	// Token: 0x040006B7 RID: 1719
	[CompilerGenerated]
	private EventHandler<c1> an;

	// Token: 0x040006B8 RID: 1720
	[CompilerGenerated]
	private EventHandler<c1> ao;

	// Token: 0x040006B9 RID: 1721
	[CompilerGenerated]
	private EventHandler<c1> ap;

	// Token: 0x040006BA RID: 1722
	[CompilerGenerated]
	private EventHandler<c1> aq;

	// Token: 0x040006BB RID: 1723
	[CompilerGenerated]
	private EventHandler ar;

	// Token: 0x040006BC RID: 1724
	[CompilerGenerated]
	private EventHandler @as;

	// Token: 0x040006BD RID: 1725
	[CompilerGenerated]
	private EventHandler<etu> at;

	// Token: 0x040006BE RID: 1726
	[CompilerGenerated]
	private EventHandler<etu> au;

	// Token: 0x040006BF RID: 1727
	[CompilerGenerated]
	private EventHandler<etu> av;

	// Token: 0x040006C0 RID: 1728
	[CompilerGenerated]
	private EventHandler<etu> aw;

	// Token: 0x040006C1 RID: 1729
	[CompilerGenerated]
	private EventHandler<etu> ax;

	// Token: 0x040006C2 RID: 1730
	[CompilerGenerated]
	private EventHandler<d71> ay;

	// Token: 0x040006C3 RID: 1731
	[CompilerGenerated]
	private EventHandler<d71> az;

	// Token: 0x040006C4 RID: 1732
	private bool a0;

	// Token: 0x040006C5 RID: 1733
	private bool a1;

	// Token: 0x040006C6 RID: 1734
	private bool a2;

	// Token: 0x040006C7 RID: 1735
	private bool a3;

	// Token: 0x040006C8 RID: 1736
	private mu a4 = new mu();

	// Token: 0x040006C9 RID: 1737
	private bool a5;

	// Token: 0x040006CA RID: 1738
	private bool a6;

	// Token: 0x040006CB RID: 1739
	private Point a7;

	// Token: 0x040006CC RID: 1740
	private ButtonState? a8;

	// Token: 0x040006CD RID: 1741
	private ButtonState? a9;

	// Token: 0x040006CE RID: 1742
	private ButtonState? ba;

	// Token: 0x040006CF RID: 1743
	private ButtonState? bb;

	// Token: 0x040006D0 RID: 1744
	private ButtonState? bc;

	// Token: 0x040006D1 RID: 1745
	private bool bd;

	// Token: 0x040006D2 RID: 1746
	private bool be;

	// Token: 0x040006D3 RID: 1747
	private bool bf;

	// Token: 0x040006D4 RID: 1748
	private bool bg;

	// Token: 0x040006D5 RID: 1749
	private bool bh;

	// Token: 0x040006D6 RID: 1750
	[NonSerialized]
	private KeyboardState bi;

	// Token: 0x040006D7 RID: 1751
	[NonSerialized]
	private Dictionary<Keys, bool> bj = new Dictionary<Keys, bool>();

	// Token: 0x040006D8 RID: 1752
	private Dictionary<object, TimeSpan> bk = new Dictionary<object, TimeSpan>();

	// Token: 0x040006D9 RID: 1753
	[NonSerialized]
	private ReaderWriterLock bl = new ReaderWriterLock();

	// Token: 0x040006DA RID: 1754
	private bool bm;

	// Token: 0x040006DB RID: 1755
	private bool bn = true;
}
