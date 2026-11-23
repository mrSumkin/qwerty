using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Common.Settings;

// Token: 0x020004B3 RID: 1203
[eiz("I39")]
[Serializable]
public sealed class a6t : elf
{
	// Token: 0x06001E8F RID: 7823 RVA: 0x000AA038 File Offset: 0x000A8238
	private a6t(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 328)
		{
			this.d = (InterfaceElementSize2)A_0.GetValue("I39:D", typeof(InterfaceElementSize2));
		}
		else
		{
			InterfaceElementSize interfaceElementSize = (InterfaceElementSize)A_0.GetValue("I39:D", typeof(InterfaceElementSize));
			this.d = (InterfaceElementSize2)interfaceElementSize;
		}
		if (ell.a() >= 643)
		{
			this.c = (InterfaceElementSize2)A_0.GetValue("I39:P", typeof(InterfaceElementSize2));
		}
		else
		{
			this.c = (InterfaceElementSize2)A_0.GetValue("I39:P", typeof(InterfaceElementSize));
		}
		this.i = (dow)A_0.GetValue("I39:SCT", typeof(dow));
		if (ell.a() >= 153)
		{
			this.h = (AutoSelectOption)A_0.GetValue("I39:AS", typeof(AutoSelectOption));
		}
		else
		{
			this.h = AutoSelectOption.Always;
		}
		if (ell.a() >= 237)
		{
			if (ell.a() >= 329)
			{
				this.e = (InterfaceElementSize2)A_0.GetValue("I39:TF", typeof(InterfaceElementSize2));
			}
			else
			{
				InterfaceElementSize interfaceElementSize2 = (InterfaceElementSize)A_0.GetValue("I39:TF", typeof(InterfaceElementSize));
				this.e = (InterfaceElementSize2)interfaceElementSize2;
			}
			if (ell.a() >= 644)
			{
				this.f = (InterfaceElementSize2)A_0.GetValue("I39:LF", typeof(InterfaceElementSize2));
			}
			else
			{
				this.f = (InterfaceElementSize2)A_0.GetValue("I39:LF", typeof(InterfaceElementSize));
			}
			if (ell.a() >= 642)
			{
				this.g = (InterfaceElementSize2)A_0.GetValue("I39:GF", typeof(InterfaceElementSize2));
			}
			else
			{
				this.g = (InterfaceElementSize2)A_0.GetValue("I39:GF", typeof(InterfaceElementSize));
			}
		}
		if (ell.a() >= 238)
		{
			this.j = A_0.GetDouble("I39:LW");
		}
		else
		{
			this.j = 1.0;
		}
		if (ell.a() >= 244)
		{
			this.k = A_0.GetBoolean("I39:L");
		}
		else
		{
			this.k = true;
		}
		if (ell.a() >= 277)
		{
			this.l = (OutlinesOption)A_0.GetValue("I39:O", typeof(OutlinesOption));
		}
		else
		{
			this.l = OutlinesOption.HighlightsOnly;
		}
		if (ell.a() >= 305)
		{
			this.m = A_0.GetSingle("I39:U");
		}
		else
		{
			this.m = 0.4f;
		}
		if (ell.a() >= 317)
		{
			this.o = A_0.GetSingle("I39:DW");
		}
		else
		{
			this.o = 0.6f;
		}
		if (ell.a() >= 417)
		{
			this.p = (MainMenuTheme)A_0.GetValue("I39:MM", typeof(MainMenuTheme));
		}
		if (ell.a() >= 442)
		{
			this.n = A_0.GetSingle("I39:T");
		}
		else
		{
			this.n = 0.3f;
		}
		if (ell.a() >= 641)
		{
			this.a = (UiSize)A_0.GetValue("I39:IS", typeof(UiSize));
		}
		if (ell.a() >= 647)
		{
			this.b = (UiSize)A_0.GetValue("I39:CS", typeof(UiSize));
		}
		if (ell.a() >= 660)
		{
			this.q = A_0.GetBoolean("I39:OSC");
		}
	}

	// Token: 0x06001E90 RID: 7824 RVA: 0x000AA488 File Offset: 0x000A8688
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("I39:D", this.d);
		info.AddValue("I39:P", this.c);
		info.AddValue("I39:AS", this.h);
		info.AddValue("I39:SCT", this.i);
		info.AddValue("I39:TF", this.e);
		info.AddValue("I39:LF", this.f);
		info.AddValue("I39:GF", this.g);
		info.AddValue("I39:LW", this.j);
		info.AddValue("I39:L", this.k);
		info.AddValue("I39:O", this.l);
		info.AddValue("I39:U", this.m);
		info.AddValue("I39:T", this.n);
		info.AddValue("I39:DW", this.o);
		info.AddValue("I39:MM", this.p);
		info.AddValue("I39:IS", this.a);
		info.AddValue("I39:CS", this.b);
		info.AddValue("I39:OSC", this.q);
	}

	// Token: 0x06001E91 RID: 7825 RVA: 0x000AA5F0 File Offset: 0x000A87F0
	public UiSize m()
	{
		return this.a;
	}

	// Token: 0x06001E92 RID: 7826 RVA: 0x000AA5F8 File Offset: 0x000A87F8
	public void b(UiSize A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001E93 RID: 7827 RVA: 0x000AA604 File Offset: 0x000A8804
	public UiSize d()
	{
		return this.b;
	}

	// Token: 0x06001E94 RID: 7828 RVA: 0x000AA60C File Offset: 0x000A880C
	public void c(UiSize A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001E95 RID: 7829 RVA: 0x000AA618 File Offset: 0x000A8818
	public UiSize e()
	{
		return this.a(this.a);
	}

	// Token: 0x06001E96 RID: 7830 RVA: 0x000AA628 File Offset: 0x000A8828
	public UiSize t()
	{
		if (this.b == UiSize.Auto)
		{
			return this.e();
		}
		return this.b;
	}

	// Token: 0x06001E97 RID: 7831 RVA: 0x000AA644 File Offset: 0x000A8844
	public double j()
	{
		return this.j;
	}

	// Token: 0x06001E98 RID: 7832 RVA: 0x000AA64C File Offset: 0x000A884C
	public void a(double A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06001E99 RID: 7833 RVA: 0x000AA658 File Offset: 0x000A8858
	public InterfaceElementSize2 c()
	{
		return this.d;
	}

	// Token: 0x06001E9A RID: 7834 RVA: 0x000AA660 File Offset: 0x000A8860
	public void f(InterfaceElementSize2 A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001E9B RID: 7835 RVA: 0x000AA66C File Offset: 0x000A886C
	public InterfaceElementSize2 v()
	{
		return this.e;
	}

	// Token: 0x06001E9C RID: 7836 RVA: 0x000AA674 File Offset: 0x000A8874
	public void b(InterfaceElementSize2 A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06001E9D RID: 7837 RVA: 0x000AA680 File Offset: 0x000A8880
	public InterfaceElementSize2 g()
	{
		return this.a(this.e);
	}

	// Token: 0x06001E9E RID: 7838 RVA: 0x000AA690 File Offset: 0x000A8890
	public InterfaceElementSize2 r()
	{
		return this.f;
	}

	// Token: 0x06001E9F RID: 7839 RVA: 0x000AA698 File Offset: 0x000A8898
	public void c(InterfaceElementSize2 A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06001EA0 RID: 7840 RVA: 0x000AA6A4 File Offset: 0x000A88A4
	public InterfaceElementSize2 l()
	{
		return this.a(this.f);
	}

	// Token: 0x06001EA1 RID: 7841 RVA: 0x000AA6B4 File Offset: 0x000A88B4
	public InterfaceElementSize2 p()
	{
		return this.a(this.g);
	}

	// Token: 0x06001EA2 RID: 7842 RVA: 0x000AA6C4 File Offset: 0x000A88C4
	public InterfaceElementSize2 u()
	{
		return this.g;
	}

	// Token: 0x06001EA3 RID: 7843 RVA: 0x000AA6CC File Offset: 0x000A88CC
	public void e(InterfaceElementSize2 A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06001EA4 RID: 7844 RVA: 0x000AA6D8 File Offset: 0x000A88D8
	public InterfaceElementSize2 h()
	{
		return this.a(this.d);
	}

	// Token: 0x06001EA5 RID: 7845 RVA: 0x000AA6E8 File Offset: 0x000A88E8
	public InterfaceElementSize2 o()
	{
		return this.c;
	}

	// Token: 0x06001EA6 RID: 7846 RVA: 0x000AA6F0 File Offset: 0x000A88F0
	public void d(InterfaceElementSize2 A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001EA7 RID: 7847 RVA: 0x000AA6FC File Offset: 0x000A88FC
	public InterfaceElementSize2 n()
	{
		return this.a(this.c);
	}

	// Token: 0x06001EA8 RID: 7848 RVA: 0x000AA70C File Offset: 0x000A890C
	public AutoSelectOption b()
	{
		return this.h;
	}

	// Token: 0x06001EA9 RID: 7849 RVA: 0x000AA714 File Offset: 0x000A8914
	public void a(AutoSelectOption A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06001EAA RID: 7850 RVA: 0x000AA720 File Offset: 0x000A8920
	public dow w()
	{
		return this.i;
	}

	// Token: 0x06001EAB RID: 7851 RVA: 0x000AA728 File Offset: 0x000A8928
	public void a(dow A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06001EAC RID: 7852 RVA: 0x000AA734 File Offset: 0x000A8934
	public bool a()
	{
		return this.k;
	}

	// Token: 0x06001EAD RID: 7853 RVA: 0x000AA73C File Offset: 0x000A893C
	public void a(bool A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06001EAE RID: 7854 RVA: 0x000AA748 File Offset: 0x000A8948
	public OutlinesOption k()
	{
		return this.l;
	}

	// Token: 0x06001EAF RID: 7855 RVA: 0x000AA750 File Offset: 0x000A8950
	public void a(OutlinesOption A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06001EB0 RID: 7856 RVA: 0x000AA75C File Offset: 0x000A895C
	public float i()
	{
		return this.m;
	}

	// Token: 0x06001EB1 RID: 7857 RVA: 0x000AA764 File Offset: 0x000A8964
	public void c(float A_0)
	{
		this.m = A_0;
	}

	// Token: 0x06001EB2 RID: 7858 RVA: 0x000AA770 File Offset: 0x000A8970
	public float f()
	{
		return this.n;
	}

	// Token: 0x06001EB3 RID: 7859 RVA: 0x000AA778 File Offset: 0x000A8978
	public void b(float A_0)
	{
		this.n = A_0;
	}

	// Token: 0x06001EB4 RID: 7860 RVA: 0x000AA784 File Offset: 0x000A8984
	public float x()
	{
		return this.o;
	}

	// Token: 0x06001EB5 RID: 7861 RVA: 0x000AA78C File Offset: 0x000A898C
	public void a(float A_0)
	{
		this.o = A_0;
	}

	// Token: 0x06001EB6 RID: 7862 RVA: 0x000AA798 File Offset: 0x000A8998
	public MainMenuTheme q()
	{
		return this.p;
	}

	// Token: 0x06001EB7 RID: 7863 RVA: 0x000AA7A0 File Offset: 0x000A89A0
	public void a(MainMenuTheme A_0)
	{
		this.p = A_0;
	}

	// Token: 0x06001EB8 RID: 7864 RVA: 0x000AA7AC File Offset: 0x000A89AC
	public MainMenuTheme s()
	{
		if ((this.p == MainMenuTheme.Default || this.p == MainMenuTheme.HeavyDuty) && dk2.e())
		{
			return MainMenuTheme.HeavyDuty;
		}
		if ((this.p == MainMenuTheme.Default || this.p == MainMenuTheme.Expedition) && dk2.f())
		{
			return MainMenuTheme.Expedition;
		}
		return MainMenuTheme.Original;
	}

	// Token: 0x06001EB9 RID: 7865 RVA: 0x000AA800 File Offset: 0x000A8A00
	public a6t(ls A_0) : base(A_0)
	{
	}

	// Token: 0x06001EBA RID: 7866 RVA: 0x000AA864 File Offset: 0x000A8A64
	public a6t a(ls A_0)
	{
		return new a6t(A_0)
		{
			d = this.d,
			c = this.c,
			h = this.h,
			i = this.i.c(),
			e = this.e,
			f = this.f,
			g = this.g,
			j = this.j,
			k = this.k,
			l = this.l,
			m = this.m,
			o = this.o,
			p = this.p,
			n = this.n,
			a = this.a,
			b = this.b,
			q = this.q
		};
	}

	// Token: 0x06001EBB RID: 7867 RVA: 0x000AA948 File Offset: 0x000A8B48
	private InterfaceElementSize2 a(InterfaceElementSize2 A_0)
	{
		if (A_0 == InterfaceElementSize2.Auto)
		{
			return efw.a(base.y().g().a).c;
		}
		return A_0;
	}

	// Token: 0x06001EBC RID: 7868 RVA: 0x000AA96C File Offset: 0x000A8B6C
	private UiSize a(UiSize A_0)
	{
		if (A_0 == UiSize.Auto)
		{
			return efw.a(base.y().g().a).f;
		}
		return A_0;
	}

	// Token: 0x04001379 RID: 4985
	private UiSize a;

	// Token: 0x0400137A RID: 4986
	private UiSize b;

	// Token: 0x0400137B RID: 4987
	private InterfaceElementSize2 c;

	// Token: 0x0400137C RID: 4988
	private InterfaceElementSize2 d;

	// Token: 0x0400137D RID: 4989
	private InterfaceElementSize2 e;

	// Token: 0x0400137E RID: 4990
	private InterfaceElementSize2 f;

	// Token: 0x0400137F RID: 4991
	private InterfaceElementSize2 g;

	// Token: 0x04001380 RID: 4992
	private AutoSelectOption h = AutoSelectOption.Always;

	// Token: 0x04001381 RID: 4993
	private dow i = new dow();

	// Token: 0x04001382 RID: 4994
	private double j = 1.0;

	// Token: 0x04001383 RID: 4995
	private bool k = true;

	// Token: 0x04001384 RID: 4996
	private OutlinesOption l = OutlinesOption.HighlightsOnly;

	// Token: 0x04001385 RID: 4997
	private float m = 0.3f;

	// Token: 0x04001386 RID: 4998
	private float n = 0.3f;

	// Token: 0x04001387 RID: 4999
	private float o = 0.6f;

	// Token: 0x04001388 RID: 5000
	private MainMenuTheme p;

	// Token: 0x04001389 RID: 5001
	public bool q;
}
