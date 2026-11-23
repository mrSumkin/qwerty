using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Common;

// Token: 0x020007C6 RID: 1990
[eiz("UEA")]
[Serializable]
public class bim : Aspect<c5x>, bp1, ISerializable
{
	// Token: 0x060031D5 RID: 12757 RVA: 0x00131080 File Offset: 0x0012F280
	protected bim(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<HorizontalDirection>("UEA:AD", ref this.a, A_0);
		this.b = A_0.GetBoolean("UEA:OBAD");
		di7.ReadList<cze>("UEA:OUJ", ref this.c, A_0);
		if (ell.a() >= 35)
		{
			this.d = A_0.GetBoolean("UEA:FO");
			if (ell.a() >= 46)
			{
				this.f = A_0.GetSingle("UEA:R");
				this.g = A_0.GetBoolean("UEA:PA");
			}
			else
			{
				this.g = true;
			}
		}
		if (ell.a() >= 57)
		{
			this.ps((d98)A_0.GetValue("UEA:I", typeof(d98)));
		}
		if (ell.a() >= 70)
		{
			this.e = A_0.GetBoolean("UEA:C");
		}
		if (ell.a() >= 72)
		{
			this.i = A_0.GetBoolean("UEA:U");
		}
		else
		{
			this.i = true;
		}
		if (ell.a() >= 74)
		{
			this.j = A_0.GetBoolean("UEA:E");
		}
		else
		{
			this.j = true;
		}
		if (ell.a() >= 121)
		{
			this.k = A_0.GetBoolean("UEA:H");
		}
		if (ell.a() >= 126)
		{
			this.l = (A_0.GetValue("UEA:CH", typeof(TimelapseCursor?)) as TimelapseCursor?);
		}
		if (ell.a() >= 137)
		{
			this.m = A_0.GetBoolean("UEA:UP");
		}
		else
		{
			this.m = true;
		}
		if (ell.a() >= 153)
		{
			this.n = A_0.GetBoolean("UEA:A");
		}
		if (ell.a() >= 272)
		{
			this.o = A_0.GetBoolean("UEA:D");
		}
		if (ell.a() >= 618)
		{
			this.p = A_0.GetInt32("UEA:UD");
		}
		if (ell.a() >= 619)
		{
			this.q = A_0.GetString("UEA:X");
		}
	}

	// Token: 0x060031D6 RID: 12758 RVA: 0x001312D0 File Offset: 0x0012F4D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<HorizontalDirection>("UEA:AD", this.a, info);
		info.AddValue("UEA:OBAD", this.b);
		di7.WriteList<cze>("UEA:OUJ", this.c, info);
		info.AddValue("UEA:FO", this.d);
		info.AddValue("UEA:R", this.f);
		info.AddValue("UEA:PA", this.g);
		info.AddValue("UEA:I", this.pr());
		info.AddValue("UEA:C", this.e);
		info.AddValue("UEA:U", this.i);
		info.AddValue("UEA:E", this.j);
		info.AddValue("UEA:H", this.k);
		info.AddValue("UEA:CH", this.l);
		info.AddValue("UEA:UP", this.m);
		info.AddValue("UEA:A", this.n);
		info.AddValue("UEA:D", this.o);
		info.AddValue("UEA:UD", this.p);
		info.AddValue("UEA:X", this.q);
	}

	// Token: 0x060031D7 RID: 12759 RVA: 0x00131410 File Offset: 0x0012F610
	public bool w()
	{
		return this.n;
	}

	// Token: 0x060031D8 RID: 12760 RVA: 0x00131418 File Offset: 0x0012F618
	public void e(bool A_0)
	{
		this.n = A_0;
	}

	// Token: 0x060031D9 RID: 12761 RVA: 0x00131424 File Offset: 0x0012F624
	public bool z()
	{
		return this.m;
	}

	// Token: 0x060031DA RID: 12762 RVA: 0x0013142C File Offset: 0x0012F62C
	public void h(bool A_0)
	{
		this.m = A_0;
	}

	// Token: 0x060031DB RID: 12763 RVA: 0x00131438 File Offset: 0x0012F638
	public virtual d98 pr()
	{
		return this.h;
	}

	// Token: 0x060031DC RID: 12764 RVA: 0x00131440 File Offset: 0x0012F640
	public virtual void ps(d98 A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060031DD RID: 12765 RVA: 0x0013144C File Offset: 0x0012F64C
	public List<cze> s()
	{
		return this.c;
	}

	// Token: 0x060031DE RID: 12766 RVA: 0x00131454 File Offset: 0x0012F654
	public void d(List<cze> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060031DF RID: 12767 RVA: 0x00131460 File Offset: 0x0012F660
	public float ac()
	{
		return this.f;
	}

	// Token: 0x060031E0 RID: 12768 RVA: 0x00131468 File Offset: 0x0012F668
	public void c(float A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060031E1 RID: 12769 RVA: 0x00131474 File Offset: 0x0012F674
	public bool x()
	{
		return this.g;
	}

	// Token: 0x060031E2 RID: 12770 RVA: 0x0013147C File Offset: 0x0012F67C
	public void l(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060031E3 RID: 12771 RVA: 0x00131488 File Offset: 0x0012F688
	public List<HorizontalDirection> t()
	{
		return this.a;
	}

	// Token: 0x060031E4 RID: 12772 RVA: 0x00131490 File Offset: 0x0012F690
	public void a(List<HorizontalDirection> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060031E5 RID: 12773 RVA: 0x0013149C File Offset: 0x0012F69C
	public bool v()
	{
		return this.b;
	}

	// Token: 0x060031E6 RID: 12774 RVA: 0x001314A4 File Offset: 0x0012F6A4
	public void f(bool A_0)
	{
		if (this.b != A_0)
		{
			this.b = A_0;
			if (this.b)
			{
				this.a();
			}
		}
	}

	// Token: 0x060031E7 RID: 12775 RVA: 0x001314CC File Offset: 0x0012F6CC
	public bool y()
	{
		return this.d;
	}

	// Token: 0x060031E8 RID: 12776 RVA: 0x001314D4 File Offset: 0x0012F6D4
	public void j(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060031E9 RID: 12777 RVA: 0x001314E0 File Offset: 0x0012F6E0
	public bool u()
	{
		return this.e;
	}

	// Token: 0x060031EA RID: 12778 RVA: 0x001314E8 File Offset: 0x0012F6E8
	public void i(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060031EB RID: 12779 RVA: 0x001314F4 File Offset: 0x0012F6F4
	public virtual bool af1()
	{
		return this.i;
	}

	// Token: 0x060031EC RID: 12780 RVA: 0x001314FC File Offset: 0x0012F6FC
	public virtual void af2(bool A_0)
	{
		this.i = A_0;
	}

	// Token: 0x060031ED RID: 12781 RVA: 0x00131508 File Offset: 0x0012F708
	public bool ab()
	{
		return this.j;
	}

	// Token: 0x060031EE RID: 12782 RVA: 0x00131510 File Offset: 0x0012F710
	public void g(bool A_0)
	{
		this.j = A_0;
	}

	// Token: 0x060031EF RID: 12783 RVA: 0x0013151C File Offset: 0x0012F71C
	public bool aa()
	{
		return this.o;
	}

	// Token: 0x060031F0 RID: 12784 RVA: 0x00131524 File Offset: 0x0012F724
	public void k(bool A_0)
	{
		this.o = A_0;
	}

	// Token: 0x060031F1 RID: 12785 RVA: 0x00131530 File Offset: 0x0012F730
	public bim(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060031F2 RID: 12786 RVA: 0x00131554 File Offset: 0x0012F754
	public bool a(c5x A_0, string A_1 = null, bool A_2 = false, bool A_3 = false)
	{
		string text = null;
		if (A_0 != null && !A_2 && !this.ww(A_0, out text))
		{
			if (A_0.IsPlayer && !string.IsNullOrEmpty(text))
			{
				bmj.a(base.a8(), new d53(text, adi.l, null, true));
			}
			return false;
		}
		if (base.a8() != null && A_0 != null && A_0.h.b != null)
		{
			c3g aspect = base.a8().GetAspect<c3g>();
			if (aspect != null)
			{
				this.m0(A_0, aspect, A_1);
			}
		}
		if (!A_3 && A_0 != null && this.p > 0)
		{
			c3n c3n = dgk.Get<cjb>();
			if (c3n != null)
			{
				eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(A_0.GetAspect<amc>())), A_1) as eu7;
				if (eu != null)
				{
					cp.b(eu, A_0, base.a8());
				}
			}
		}
		else
		{
			if ((!this.n || this.i || A_0 == null || A_0.h.b == null || !A_0.h.b.aa().IsInCombat) && this.c != null)
			{
				Dictionary<string, object> a_ = this.a(a3f.a(base.a8()), A_0);
				foreach (cze cze in Enumerable.ToList<cze>(this.c))
				{
					if (cze != null)
					{
						cze.ym(A_0, base.a8(), a_);
					}
				}
			}
			this.mz(A_0, A_1);
		}
		return true;
	}

	// Token: 0x060031F3 RID: 12787 RVA: 0x00131718 File Offset: 0x0012F918
	public bool a(c5x A_0, string A_1 = null, bool A_2 = false)
	{
		return this.a(A_0, A_1, A_2, true);
	}

	// Token: 0x060031F4 RID: 12788 RVA: 0x00131724 File Offset: 0x0012F924
	public virtual void mx()
	{
		base.a8().a(new EventHandler<c1>(this.a));
		base.a8().e = true;
		if (this.b)
		{
			this.a();
		}
		if (this.s() != null && this.s().Count > 0)
		{
			foreach (cze cze in this.s())
			{
				e68 e = cze as e68;
				if (e != null && e.Destination != null && e.Destination.b() != null && !e.Destination.b().Equals(base.a8().Zone.y8(), StringComparison.OrdinalIgnoreCase))
				{
					this.h = d98.e;
					break;
				}
			}
		}
	}

	// Token: 0x060031F5 RID: 12789 RVA: 0x00131820 File Offset: 0x0012FA20
	public virtual void my()
	{
		base.a8().b(new EventHandler<c1>(this.a));
	}

	// Token: 0x060031F6 RID: 12790 RVA: 0x0013183C File Offset: 0x0012FA3C
	public virtual avd[] jz()
	{
		return null;
	}

	// Token: 0x060031F7 RID: 12791 RVA: 0x00131840 File Offset: 0x0012FA40
	public virtual TimelapseCursor? ar3()
	{
		if (this.l != null)
		{
			return new TimelapseCursor?(this.l.Value);
		}
		if (this.pr() == d98.b)
		{
			return new TimelapseCursor?(TimelapseCursor.Observe);
		}
		if (this.pr() == d98.e)
		{
			return new TimelapseCursor?(TimelapseCursor.AreaTransition);
		}
		return null;
	}

	// Token: 0x060031F8 RID: 12792 RVA: 0x001318A0 File Offset: 0x0012FAA0
	protected virtual bool ww(c5x A_0, out string A_1)
	{
		A_1 = null;
		if (!base.a8().a())
		{
			bool flag = false;
			if (!this.m)
			{
				flag = true;
			}
			else if (this.s().Count == 1)
			{
				a72 a = this.s()[0] as a72;
				if (a != null)
				{
					flag = !a.b();
				}
			}
			if (flag)
			{
				A_1 = "Нет питания";
				return false;
			}
		}
		return true;
	}

	// Token: 0x060031F9 RID: 12793 RVA: 0x00131918 File Offset: 0x0012FB18
	protected virtual void mz(c5x A_0, string A_1 = null)
	{
	}

	// Token: 0x060031FA RID: 12794 RVA: 0x0013191C File Offset: 0x0012FB1C
	protected virtual void m0(c5x A_0, c3g A_1, string A_2)
	{
		if (A_1.a(A_0.h.b) && A_1.e())
		{
			a7v.a(new ehr("Ваши действия спровоцировали враждебность."));
		}
	}

	// Token: 0x060031FB RID: 12795 RVA: 0x00131950 File Offset: 0x0012FB50
	private void a()
	{
		this.a(new List<HorizontalDirection>
		{
			base.a8().VisualDirection
		});
	}

	// Token: 0x060031FC RID: 12796 RVA: 0x0013197C File Offset: 0x0012FB7C
	private Dictionary<string, object> a(Dictionary<string, object> A_0, c5x A_1)
	{
		Dictionary<string, object> dictionary = A_0;
		if (A_1 != null)
		{
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, object>();
			}
			HorizontalDirection horizontalDirection = bnx.a(base.a8().Location, A_1.Location);
			dictionary["usageDirection"] = horizontalDirection;
		}
		return dictionary;
	}

	// Token: 0x060031FD RID: 12797 RVA: 0x001319C8 File Offset: 0x0012FBC8
	[dcc("UEA:mAVDC")]
	private void a(object A_0, c1 A_1)
	{
		if (this.b)
		{
			this.a();
		}
	}

	// Token: 0x04001AC4 RID: 6852
	private List<HorizontalDirection> a;

	// Token: 0x04001AC5 RID: 6853
	private bool b;

	// Token: 0x04001AC6 RID: 6854
	private List<cze> c = new List<cze>();

	// Token: 0x04001AC7 RID: 6855
	private bool d;

	// Token: 0x04001AC8 RID: 6856
	private bool e;

	// Token: 0x04001AC9 RID: 6857
	private float f;

	// Token: 0x04001ACA RID: 6858
	private bool g = true;

	// Token: 0x04001ACB RID: 6859
	private d98 h;

	// Token: 0x04001ACC RID: 6860
	private bool i;

	// Token: 0x04001ACD RID: 6861
	public bool j = true;

	// Token: 0x04001ACE RID: 6862
	public bool k;

	// Token: 0x04001ACF RID: 6863
	public TimelapseCursor? l;

	// Token: 0x04001AD0 RID: 6864
	private bool m;

	// Token: 0x04001AD1 RID: 6865
	private bool n;

	// Token: 0x04001AD2 RID: 6866
	private bool o;

	// Token: 0x04001AD3 RID: 6867
	public int p;

	// Token: 0x04001AD4 RID: 6868
	public string q;
}
