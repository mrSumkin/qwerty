using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Ouroboros.Core.Logging;

// Token: 0x0200019C RID: 412
public sealed class bso : bcm, d1a
{
	// Token: 0x06000BE3 RID: 3043
	[DllImport("user32.dll")]
	public static extern long SetCursorPos(int A_0, int A_1);

	// Token: 0x06000BE4 RID: 3044
	[DllImport("user32.dll")]
	public static extern bool ClientToScreen(IntPtr A_0, ref bso.a A_1);

	// Token: 0x06000BE5 RID: 3045 RVA: 0x000300E0 File Offset: 0x0002E2E0
	[CompilerGenerated]
	public aj3 aam()
	{
		return this.p;
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x000300E8 File Offset: 0x0002E2E8
	[CompilerGenerated]
	public void aan(aj3 A_0)
	{
		this.p = A_0;
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x000300F4 File Offset: 0x0002E2F4
	public bool aao()
	{
		return this.o;
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x000300FC File Offset: 0x0002E2FC
	public void aap(bool A_0)
	{
		this.o = A_0;
	}

	// Token: 0x06000BE9 RID: 3049 RVA: 0x00030108 File Offset: 0x0002E308
	public bool aaq()
	{
		return this.b;
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x00030110 File Offset: 0x0002E310
	public void aar(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000BEB RID: 3051 RVA: 0x0003011C File Offset: 0x0002E31C
	public string aas()
	{
		return this.e;
	}

	// Token: 0x06000BEC RID: 3052 RVA: 0x00030124 File Offset: 0x0002E324
	public void aat(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x00030130 File Offset: 0x0002E330
	public euz aau()
	{
		return this.f;
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x00030138 File Offset: 0x0002E338
	public void aav(euz A_0)
	{
		if (this.f != A_0)
		{
			if (this.f != null)
			{
				this.f.bn();
			}
			this.aa4(null);
			this.g = null;
			this.f = A_0;
			if (this.f != null)
			{
				this.f.am();
			}
		}
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x00030194 File Offset: 0x0002E394
	public euz aaw()
	{
		return this.g;
	}

	// Token: 0x06000BF0 RID: 3056 RVA: 0x0003019C File Offset: 0x0002E39C
	public void aax(euz A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x000301A8 File Offset: 0x0002E3A8
	public bool aay()
	{
		return this.i;
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x000301B0 File Offset: 0x0002E3B0
	public void aaz(bool A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x000301BC File Offset: 0x0002E3BC
	public euz aa0()
	{
		return this.j;
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x000301C4 File Offset: 0x0002E3C4
	public void aa1(euz A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x000301D0 File Offset: 0x0002E3D0
	public bool aa2()
	{
		return this.n;
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x000301D8 File Offset: 0x0002E3D8
	public void aa3(bool A_0)
	{
		this.n = A_0;
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x000301E4 File Offset: 0x0002E3E4
	internal j a()
	{
		return this.c;
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x000301EC File Offset: 0x0002E3EC
	internal ajd c()
	{
		return this.d;
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x000301F4 File Offset: 0x0002E3F4
	internal IntPtr b()
	{
		return this.a;
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x000301FC File Offset: 0x0002E3FC
	public bso(IntPtr A_0, j A_1, ajd A_2)
	{
		this.a = A_0;
		this.c = A_1;
		this.d = A_2;
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x00030228 File Offset: 0x0002E428
	internal void a(MouseState A_0)
	{
		this.k = this.aa9(A_0);
	}

	// Token: 0x06000BFC RID: 3068 RVA: 0x00030238 File Offset: 0x0002E438
	internal void b(MouseState A_0)
	{
		this.m = A_0.ScrollWheelValue - this.l;
		this.l = A_0.ScrollWheelValue;
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x0003025C File Offset: 0x0002E45C
	public void aa4(euz A_0)
	{
		euz euz = this.h;
		this.h = A_0;
		if (euz != null)
		{
			aj3 aj = this.h as aj3;
			if (aj == null || aj.ajs() != euz)
			{
				euz.bb();
			}
		}
		if (A_0 != null)
		{
			euz euz2 = A_0.Parent;
			euz euz3 = A_0;
			while (euz2 != null && euz3 != null)
			{
				euz2.d(euz3);
				euz2 = euz3.Parent;
				euz3 = euz2;
			}
			this.h.a5();
		}
	}

	// Token: 0x06000BFE RID: 3070 RVA: 0x000302DC File Offset: 0x0002E4DC
	public void aa5()
	{
		if (this.h != null && this.h.IsFragileFocus)
		{
			this.aa6();
		}
	}

	// Token: 0x06000BFF RID: 3071 RVA: 0x00030300 File Offset: 0x0002E500
	public void aa6()
	{
		this.aa4(this.g);
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x00030310 File Offset: 0x0002E510
	public euz aa7()
	{
		return this.h;
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x00030318 File Offset: 0x0002E518
	public euz aa8()
	{
		return this.k;
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x00030320 File Offset: 0x0002E520
	public euz aa9(MouseState A_0)
	{
		if (this.f != null)
		{
			return this.f.a(A_0);
		}
		return null;
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x0003033C File Offset: 0x0002E53C
	public int aba()
	{
		return this.m;
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x00030348 File Offset: 0x0002E548
	public void abb(Point A_0)
	{
		try
		{
			if (this.a != IntPtr.Zero)
			{
				bso.a a = default(bso.a);
				a.a = A_0.X;
				a.b = A_0.Y;
				bso.ClientToScreen(this.a, ref a);
				bso.SetCursorPos(a.a, a.b);
			}
		}
		catch (Exception ex)
		{
			cvq service = bpo.GetService<cvq>();
			if (service != null && service.n8() && service.n9(LogSeverity.Error, 110))
			{
				string a_ = string.Format("[GUI] Failed to move mouse to relative position '{0}'. Exception: {1}", A_0, ex.ToString());
				service.n7(LogSeverity.Error, 110, a_);
			}
		}
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x00030410 File Offset: 0x0002E610
	public void abc()
	{
		euz euz = this.aam() as euz;
		if (euz != null)
		{
			euz euz2 = this.aam().ajs() as euz;
			bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
			if (serviceOrThrow.aau() != null)
			{
				serviceOrThrow.aau().g(euz);
			}
			d1a service = bpo.GetService<d1a>();
			if (service != null)
			{
				service.aan(null);
			}
			if (euz2 != null && euz2.Activated && euz2.Focusable)
			{
				euz2.bb();
			}
		}
	}

	// Token: 0x04000718 RID: 1816
	private IntPtr a;

	// Token: 0x04000719 RID: 1817
	private bool b = true;

	// Token: 0x0400071A RID: 1818
	private j c;

	// Token: 0x0400071B RID: 1819
	private ajd d;

	// Token: 0x0400071C RID: 1820
	private string e;

	// Token: 0x0400071D RID: 1821
	private euz f;

	// Token: 0x0400071E RID: 1822
	private euz g;

	// Token: 0x0400071F RID: 1823
	private euz h;

	// Token: 0x04000720 RID: 1824
	private bool i;

	// Token: 0x04000721 RID: 1825
	private euz j;

	// Token: 0x04000722 RID: 1826
	private euz k;

	// Token: 0x04000723 RID: 1827
	private int l;

	// Token: 0x04000724 RID: 1828
	private int m;

	// Token: 0x04000725 RID: 1829
	private bool n;

	// Token: 0x04000726 RID: 1830
	private bool o = true;

	// Token: 0x04000727 RID: 1831
	[CompilerGenerated]
	private aj3 p;

	// Token: 0x0200019E RID: 414
	public struct a
	{
		// Token: 0x04000728 RID: 1832
		public int a;

		// Token: 0x04000729 RID: 1833
		public int b;
	}
}
