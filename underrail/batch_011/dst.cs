using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

// Token: 0x0200007B RID: 123
public sealed class dst : ax1
{
	// Token: 0x06000294 RID: 660 RVA: 0x0000CA04 File Offset: 0x0000AC04
	public c1a d()
	{
		return this.a;
	}

	// Token: 0x06000295 RID: 661 RVA: 0x0000CA0C File Offset: 0x0000AC0C
	public bool ape()
	{
		return this.e;
	}

	// Token: 0x06000296 RID: 662 RVA: 0x0000CA14 File Offset: 0x0000AC14
	public long apf()
	{
		return this.f;
	}

	// Token: 0x06000297 RID: 663 RVA: 0x0000CA1C File Offset: 0x0000AC1C
	public void apg(long A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06000298 RID: 664 RVA: 0x0000CA28 File Offset: 0x0000AC28
	public Dictionary<c9z, float> aph()
	{
		return this.g;
	}

	// Token: 0x06000299 RID: 665 RVA: 0x0000CA30 File Offset: 0x0000AC30
	public int api()
	{
		return this.h;
	}

	// Token: 0x0600029A RID: 666 RVA: 0x0000CA38 File Offset: 0x0000AC38
	public void apj(int A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600029B RID: 667 RVA: 0x0000CA44 File Offset: 0x0000AC44
	public int apk()
	{
		return this.i;
	}

	// Token: 0x0600029C RID: 668 RVA: 0x0000CA4C File Offset: 0x0000AC4C
	public void apl(int A_0)
	{
		this.i = A_0;
	}

	// Token: 0x0600029D RID: 669 RVA: 0x0000CA58 File Offset: 0x0000AC58
	public float apm()
	{
		return this.j;
	}

	// Token: 0x0600029E RID: 670 RVA: 0x0000CA60 File Offset: 0x0000AC60
	public void apn(float A_0)
	{
		this.j = A_0;
	}

	// Token: 0x0600029F RID: 671 RVA: 0x0000CA6C File Offset: 0x0000AC6C
	public HashSet<c9z> c()
	{
		return this.k;
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x0000CA74 File Offset: 0x0000AC74
	public dst(c1a A_0, long A_1)
	{
		HashSet<c9z> hashSet = new HashSet<c9z>();
		hashSet.Add(c9z.a);
		hashSet.Add(c9z.d);
		this.k = hashSet;
		base..ctor();
		czh.a(A_0, "zone");
		this.g = new Dictionary<c9z, float>();
		this.g[c9z.a] = 0.75f;
		this.g[c9z.b] = 0.4f;
		this.g[c9z.c] = 0.4f;
		this.g[c9z.d] = 0.75f;
		this.g[c9z.e] = 0f;
		this.a = A_0;
		this.f = A_1;
		this.b();
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x0000CB54 File Offset: 0x0000AD54
	public void apo(Guid A_0, Vector3 A_1)
	{
		List<k2> a_ = this.a();
		foreach (KeyValuePair<Guid, efu> keyValuePair in this.b)
		{
			keyValuePair.Value.a(A_0, A_1, a_);
		}
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x0000CBBC File Offset: 0x0000ADBC
	public void app(k2 A_0)
	{
		if (!this.c.Contains(A_0))
		{
			this.c.Add(A_0);
			List<k2> list;
			this.d.TryGetValue(A_0.Observer.c, out list);
			if (list == null)
			{
				list = new List<k2>();
				this.d[A_0.Observer.c] = list;
			}
			if (!list.Contains(A_0))
			{
				list.Add(A_0);
			}
		}
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x0000CC38 File Offset: 0x0000AE38
	public void apq(k2 A_0)
	{
		List<k2> list;
		this.d.TryGetValue(A_0.Observer.c, out list);
		if (list != null)
		{
			list.Remove(A_0);
		}
		this.c.Remove(A_0);
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x0000CC7C File Offset: 0x0000AE7C
	public void apr(Guid A_0)
	{
		dst.a a = new dst.a();
		a.a = A_0;
		k2 k = Enumerable.FirstOrDefault<k2>(Enumerable.Where<k2>(this.c, new Func<k2, bool>(a.a)));
		if (k != null)
		{
			this.apq(k);
		}
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
	public void aps()
	{
		this.c.Clear();
		this.d.Clear();
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x0000CCD8 File Offset: 0x0000AED8
	public ef4? apt(string A_0, b0b A_1, string A_2, float A_3, bool A_4, c9z A_5)
	{
		if (A_1 != null && A_1.Area != null)
		{
			efu efu;
			this.b.TryGetValue(A_1.Area.qe(), out efu);
			if (efu != null)
			{
				string text = efu.a(A_0, A_1, A_2, A_3, A_4, A_5);
				if (!string.IsNullOrEmpty(text))
				{
					return new ef4?(new ef4(A_1.Area.qe(), text));
				}
			}
		}
		return null;
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x0000CD50 File Offset: 0x0000AF50
	public ef4? apu(b0b A_0, string A_1, float A_2, bool A_3, c9z A_4)
	{
		return this.apt(null, A_0, A_1, A_2, A_3, A_4);
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x0000CD60 File Offset: 0x0000AF60
	public bool apv(ef4 A_0, bool A_1)
	{
		efu efu;
		this.b.TryGetValue(A_0.b(), out efu);
		return efu != null && efu.a(A_0.c(), A_1);
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x0000CD98 File Offset: 0x0000AF98
	public bool apw(ef4 A_0)
	{
		efu efu;
		this.b.TryGetValue(A_0.b(), out efu);
		return efu != null && efu.b(A_0.c());
	}

	// Token: 0x060002AA RID: 682 RVA: 0x0000CDD0 File Offset: 0x0000AFD0
	public bool apx(ef4 A_0)
	{
		efu efu;
		this.b.TryGetValue(A_0.b(), out efu);
		return efu != null && efu.a(A_0.c());
	}

	// Token: 0x060002AB RID: 683 RVA: 0x0000CE08 File Offset: 0x0000B008
	public bool apy(ef4 A_0, float A_1)
	{
		efu efu;
		this.b.TryGetValue(A_0.b(), out efu);
		return efu != null && efu.a(A_0.c(), A_1);
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0000CE40 File Offset: 0x0000B040
	public SoundState? apz(ef4 A_0)
	{
		efu efu;
		this.b.TryGetValue(A_0.b(), out efu);
		if (efu != null)
		{
			return efu.c(A_0.c());
		}
		return null;
	}

	// Token: 0x060002AD RID: 685 RVA: 0x0000CE80 File Offset: 0x0000B080
	public bool ap0()
	{
		if (!this.e)
		{
			this.e = true;
			foreach (efu efu in this.b.Values)
			{
				efu.a(this.k);
			}
			return true;
		}
		return false;
	}

	// Token: 0x060002AE RID: 686 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
	public bool ap1()
	{
		if (this.e)
		{
			this.e = false;
			foreach (efu efu in this.b.Values)
			{
				efu.a();
			}
			return true;
		}
		return false;
	}

	// Token: 0x060002AF RID: 687 RVA: 0x0000CF68 File Offset: 0x0000B168
	private void b()
	{
		if (this.a.Areas != null)
		{
			foreach (aud a_ in this.a.Areas)
			{
				this.a(a_);
			}
		}
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
	private void a(aud A_0)
	{
		efu value = new efu(this, A_0);
		this.b[A_0.qe()] = value;
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x0000D000 File Offset: 0x0000B200
	private List<k2> a()
	{
		List<k2> list = new List<k2>();
		foreach (KeyValuePair<byte, List<k2>> keyValuePair in this.d)
		{
			if (bcj.a(this.f, keyValuePair.Key))
			{
				foreach (k2 k in keyValuePair.Value)
				{
					if (k.Initialized && k.Carrier != null && k.Carrier.Zone == this.a)
					{
						list.Add(k);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x040003BB RID: 955
	private c1a a;

	// Token: 0x040003BC RID: 956
	private Dictionary<Guid, efu> b = new Dictionary<Guid, efu>();

	// Token: 0x040003BD RID: 957
	private List<k2> c = new List<k2>();

	// Token: 0x040003BE RID: 958
	private Dictionary<byte, List<k2>> d = new Dictionary<byte, List<k2>>();

	// Token: 0x040003BF RID: 959
	private bool e;

	// Token: 0x040003C0 RID: 960
	private long f;

	// Token: 0x040003C1 RID: 961
	private Dictionary<c9z, float> g;

	// Token: 0x040003C2 RID: 962
	private int h = 15;

	// Token: 0x040003C3 RID: 963
	private int i = 25;

	// Token: 0x040003C4 RID: 964
	private float j;

	// Token: 0x040003C5 RID: 965
	private HashSet<c9z> k;

	// Token: 0x0200007D RID: 125
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x060002CB RID: 715 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		internal bool a(k2 A_0)
		{
			return A_0.Id == this.a;
		}

		// Token: 0x040003C6 RID: 966
		public Guid a;
	}
}
