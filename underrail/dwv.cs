using System;
using System.Runtime.CompilerServices;

// Token: 0x020002AA RID: 682
[apc("camera")]
public class dwv : e1k
{
	// Token: 0x060013E3 RID: 5091 RVA: 0x000535AC File Offset: 0x000517AC
	public dwv()
	{
		this.b = new vw(new string[]
		{
			"Nb"
		});
		this.a = new aij();
		this.c = new fh(new arr[0]);
		this.d = new ej0();
		this.f = new bud();
		this.e = new ej0();
		this.g = new ej0();
		this.g.a = new Action<ej0>(dwv.a.a.c);
		this.g.a = this.c;
		fh fh = this.c;
		arr[] array = new arr[3];
		array[0] = new arr(this.a, new Func<e1k, bool>(dwv.a.a.a));
		array[1] = new arr(this.d, new Func<e1k, bool>(dwv.a.a.b));
		array[2] = new arr(this.f, null);
		fh.a(array);
		this.d.a = new Action<ej0>(dwv.a.a.a);
		this.d.a = this.a;
		this.f.b = new Func<bud, int>(dwv.a.a.a);
		this.f.a.Add(this.e);
		this.f.a.Add(this.a);
		this.e.a = new Action<ej0>(dwv.a.a.b);
		this.e.a = this.f;
		this.a.a = this.b;
		this.b.a = this.g;
		base.b(this.b);
	}

	// Token: 0x04000AB6 RID: 2742
	protected aij a;

	// Token: 0x04000AB7 RID: 2743
	protected vw b;

	// Token: 0x04000AB8 RID: 2744
	protected fh c;

	// Token: 0x04000AB9 RID: 2745
	protected ej0 d;

	// Token: 0x04000ABA RID: 2746
	protected new ej0 e;

	// Token: 0x04000ABB RID: 2747
	protected bud f;

	// Token: 0x04000ABC RID: 2748
	protected ej0 g;

	// Token: 0x020002AC RID: 684
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060013FE RID: 5118 RVA: 0x00053A40 File Offset: 0x00051C40
		internal void c(ej0 A_0)
		{
			A_0.b().d()[e2z.b] = 0;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00053A60 File Offset: 0x00051C60
		internal bool a(e1k A_0)
		{
			return !A_0.g().a8().a();
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00053A78 File Offset: 0x00051C78
		internal bool b(e1k A_0)
		{
			return e5v.h(A_0.c());
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00053A88 File Offset: 0x00051C88
		internal void a(ej0 A_0)
		{
			e5v.d(A_0.b().c());
			if (e5v.g(A_0.b().c()))
			{
				A_0.b().c().y6()[ddq.i] = emu.c;
			}
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00053ADC File Offset: 0x00051CDC
		internal int a(bud A_0)
		{
			if (e5v.b(A_0.b().c()))
			{
				A_0.b().c().y6()[ddq.i] = emu.b;
				return 1;
			}
			if (A_0.b().d().GetPrimitivePropertyValue<int>(e2z.b, new int?(0)).Value >= 2)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00053B4C File Offset: 0x00051D4C
		internal void b(ej0 A_0)
		{
			e5v.c(A_0.b().c());
			e5v.a(A_0.b().c());
			int value = A_0.b().d().GetPrimitivePropertyValue<int>(e2z.b, new int?(0)).Value;
			A_0.b().d()[e2z.b] = value + 1;
			A_0.b().c().y6()[ddq.i] = emu.a;
		}

		// Token: 0x04000AC4 RID: 2756
		public static readonly dwv.a a = new dwv.a();

		// Token: 0x04000AC5 RID: 2757
		public static Action<ej0> b;

		// Token: 0x04000AC6 RID: 2758
		public static Func<e1k, bool> c;

		// Token: 0x04000AC7 RID: 2759
		public static Func<e1k, bool> d;

		// Token: 0x04000AC8 RID: 2760
		public static Action<ej0> e;

		// Token: 0x04000AC9 RID: 2761
		public static Func<bud, int> f;

		// Token: 0x04000ACA RID: 2762
		public static Action<ej0> g;
	}
}
