using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using Ouroboros.Core.Logging;

// Token: 0x0200006E RID: 110
public sealed class b6d : dd7, z6
{
	// Token: 0x060001F3 RID: 499 RVA: 0x0000A820 File Offset: 0x00008A20
	public Guid qe()
	{
		return new Guid("{95B3C2C8-B31C-4cad-8B6B-25E5E909016D}");
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x0000A82C File Offset: 0x00008A2C
	public string y8()
	{
		return "AudioManager";
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x0000A834 File Offset: 0x00008A34
	public int adk()
	{
		return this.a;
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x0000A83C File Offset: 0x00008A3C
	public void adl(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x0000A848 File Offset: 0x00008A48
	public int adm()
	{
		return this.b;
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x0000A850 File Offset: 0x00008A50
	public void adn(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x0000A85C File Offset: 0x00008A5C
	public TimeSpan ado()
	{
		return this.d;
	}

	// Token: 0x060001FA RID: 506 RVA: 0x0000A864 File Offset: 0x00008A64
	public void adp(TimeSpan A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060001FB RID: 507 RVA: 0x0000A870 File Offset: 0x00008A70
	public int adq()
	{
		return this.l;
	}

	// Token: 0x060001FC RID: 508 RVA: 0x0000A878 File Offset: 0x00008A78
	public void adr(int A_0)
	{
		this.l = A_0;
	}

	// Token: 0x060001FD RID: 509 RVA: 0x0000A884 File Offset: 0x00008A84
	public Dictionary<c9z, float> ads()
	{
		return this.r;
	}

	// Token: 0x060001FE RID: 510 RVA: 0x0000A88C File Offset: 0x00008A8C
	internal bxt e()
	{
		return this.h;
	}

	// Token: 0x060001FF RID: 511 RVA: 0x0000A894 File Offset: 0x00008A94
	internal void b(bxt A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06000200 RID: 512 RVA: 0x0000A8A0 File Offset: 0x00008AA0
	internal bxt f()
	{
		return this.i;
	}

	// Token: 0x06000201 RID: 513 RVA: 0x0000A8A8 File Offset: 0x00008AA8
	internal void a(bxt A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06000202 RID: 514 RVA: 0x0000A8B4 File Offset: 0x00008AB4
	public float adt()
	{
		return this.p;
	}

	// Token: 0x06000203 RID: 515 RVA: 0x0000A8BC File Offset: 0x00008ABC
	public void adu(float A_0)
	{
		this.p = A_0;
	}

	// Token: 0x06000204 RID: 516 RVA: 0x0000A8C8 File Offset: 0x00008AC8
	public Dictionary<c9z, float> adv()
	{
		return this.q;
	}

	// Token: 0x06000205 RID: 517 RVA: 0x0000A8D0 File Offset: 0x00008AD0
	public void adw(Dictionary<c9z, float> A_0)
	{
		this.q = A_0;
	}

	// Token: 0x06000206 RID: 518 RVA: 0x0000A8DC File Offset: 0x00008ADC
	public float? adx()
	{
		return this.s;
	}

	// Token: 0x06000207 RID: 519 RVA: 0x0000A8E4 File Offset: 0x00008AE4
	public void ady(float? A_0)
	{
		this.s = A_0;
	}

	// Token: 0x06000208 RID: 520 RVA: 0x0000A8F0 File Offset: 0x00008AF0
	public b6d()
	{
		this.p = 1f;
		foreach (object obj in Enum.GetValues(typeof(c9z)))
		{
			c9z key = (c9z)obj;
			this.q[key] = 1f;
		}
		this.ad0();
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0000AA08 File Offset: 0x00008C08
	public void adz()
	{
		this.d();
	}

	// Token: 0x0600020A RID: 522 RVA: 0x0000AA10 File Offset: 0x00008C10
	public void ad0()
	{
		foreach (object obj in Enum.GetValues(typeof(c9z)))
		{
			c9z key = (c9z)obj;
			this.r[key] = this.q[key] * this.p;
		}
	}

	// Token: 0x0600020B RID: 523 RVA: 0x0000AA94 File Offset: 0x00008C94
	public void ad1()
	{
		MediaPlayer.Pause();
	}

	// Token: 0x0600020C RID: 524 RVA: 0x0000AA9C File Offset: 0x00008C9C
	public void ad2()
	{
		MediaPlayer.Resume();
	}

	// Token: 0x0600020D RID: 525 RVA: 0x0000AAA8 File Offset: 0x00008CA8
	public bool ad3(string A_0, float A_1, b1g? A_2, bbs? A_3)
	{
		abr a_;
		if (!string.IsNullOrEmpty(A_0))
		{
			a_ = this.a(A_0);
		}
		else
		{
			a_ = null;
		}
		if (this.m is exd)
		{
			this.m.n();
		}
		exd exd = new exd(this, a_, A_1, A_2, A_3);
		this.n.Enqueue(exd);
		return true;
	}

	// Token: 0x0600020E RID: 526 RVA: 0x0000AB04 File Offset: 0x00008D04
	public void d1(e6d A_0)
	{
		this.b();
		this.a();
		if (this.m == null)
		{
			if (this.n.Count > 0)
			{
				this.m = this.n.Dequeue();
				this.m.d(A_0);
			}
		}
		else if (this.m.f(A_0) != cdv.a)
		{
			this.m = null;
		}
		if (this.h != null)
		{
			this.h.a(this);
		}
	}

	// Token: 0x0600020F RID: 527 RVA: 0x0000AB8C File Offset: 0x00008D8C
	public void ad4(string A_0)
	{
		this.d();
		cvq service = bpo.GetService<cvq>();
		eg9 eg = null;
		try
		{
			eg = eoq.DeserializeFromBinaryFileCompressed<eg9>(Path.ChangeExtension(A_0, "uab"), dds.a(), true);
		}
		catch (Exception ex)
		{
			if (service != null && service.n8() && service.n9(LogSeverity.Error, 118))
			{
				string a_ = string.Format("[Audio Manager] - Failed to load audio bank '{0}'. Exception: {1}.", A_0, ex.ToString());
				service.n7(LogSeverity.Error, 118, a_);
			}
			return;
		}
		if (eg == null)
		{
			if (service != null && service.n8() && service.n9(LogSeverity.Error, 118))
			{
				string a_2 = string.Format("[Audio Manager] - Failed to load audio bank '{0}' because it was not found.", A_0);
				service.n7(LogSeverity.Error, 118, a_2);
			}
			return;
		}
		this.c = eg;
		this.c();
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0000AC60 File Offset: 0x00008E60
	public bool ad5(string A_0)
	{
		czh.a(A_0, "songId");
		if (this.e != null)
		{
			abr abr;
			if (A_0 != null)
			{
				this.e.TryGetValue(A_0.ToLowerInvariant(), out abr);
			}
			else
			{
				abr = null;
			}
			if (abr != null)
			{
				abr.b();
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0000ACB4 File Offset: 0x00008EB4
	public bool ad6(string A_0)
	{
		czh.a(A_0, "songId");
		if (this.e != null)
		{
			abr abr;
			if (A_0 != null)
			{
				this.e.TryGetValue(A_0.ToLowerInvariant(), out abr);
			}
			else
			{
				abr = null;
			}
			if (abr != null)
			{
				abr.a();
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000212 RID: 530 RVA: 0x0000AD08 File Offset: 0x00008F08
	public bool ad7(Guid A_0, bool A_1)
	{
		cvi cvi;
		this.j.TryGetValue(A_0, out cvi);
		if (cvi != null)
		{
			cvi.f().Stop();
			this.j.Remove(A_0);
			this.k.Remove(new KeyValuePair<Guid, cvi>(A_0, cvi));
			return true;
		}
		return false;
	}

	// Token: 0x06000213 RID: 531 RVA: 0x0000AD58 File Offset: 0x00008F58
	public bool ad8(Guid A_0)
	{
		cvi cvi;
		this.j.TryGetValue(A_0, out cvi);
		if (cvi != null)
		{
			cvi.f().Pause();
			return true;
		}
		return false;
	}

	// Token: 0x06000214 RID: 532 RVA: 0x0000AD88 File Offset: 0x00008F88
	public bool ad9(Guid A_0)
	{
		cvi cvi;
		this.j.TryGetValue(A_0, out cvi);
		if (cvi != null && cvi.f().State == SoundState.Paused)
		{
			cvi.f().Resume();
			return true;
		}
		return false;
	}

	// Token: 0x06000215 RID: 533 RVA: 0x0000ADCC File Offset: 0x00008FCC
	public bool aea(Guid A_0, float A_1)
	{
		cvi cvi;
		this.j.TryGetValue(A_0, out cvi);
		if (cvi != null && cvi.f().State != SoundState.Stopped)
		{
			cvi.a(A_1);
			cvi.a(this);
			return true;
		}
		return false;
	}

	// Token: 0x06000216 RID: 534 RVA: 0x0000AE10 File Offset: 0x00009010
	public Guid? aeb(string A_0, float A_1, bool A_2, c9z A_3, bool A_4 = false)
	{
		cvq service = bpo.GetService<cvq>();
		if (string.IsNullOrEmpty(A_0))
		{
			if (service != null && service.n8() && service.n9(LogSeverity.Error, 118))
			{
				string a_ = "[AudioManager] - PlaySoundEffect invoked with null or empty id.";
				service.n7(LogSeverity.Error, 118, a_);
			}
			return null;
		}
		d6c d6c;
		this.g.TryGetValue(A_0, out d6c);
		if (d6c == null)
		{
			if (service != null && service.n8() && service.n9(LogSeverity.Error, 118))
			{
				string a_2 = string.Format("[AudioManager] - Unable to find sound effect with id: '{0}'.", A_0);
				service.n7(LogSeverity.Error, 118, a_2);
			}
			return null;
		}
		Guid guid;
		do
		{
			guid = Guid.NewGuid();
		}
		while (this.j.ContainsKey(guid));
		cvi cvi = new cvi(d6c, A_1, A_3, A_2);
		cvi.f().Play();
		if (A_4)
		{
			cvi.f().Pause();
		}
		this.j[guid] = cvi;
		this.k.Add(new KeyValuePair<Guid, cvi>(guid, cvi));
		return new Guid?(guid);
	}

	// Token: 0x06000217 RID: 535 RVA: 0x0000AF28 File Offset: 0x00009128
	public SoundState? aec(Guid A_0)
	{
		cvi cvi;
		this.j.TryGetValue(A_0, out cvi);
		if (cvi != null && cvi.f() != null && !cvi.f().IsDisposed)
		{
			return new SoundState?(cvi.f().State);
		}
		return null;
	}

	// Token: 0x06000218 RID: 536 RVA: 0x0000AF80 File Offset: 0x00009180
	public float aed(Guid A_0)
	{
		cvi cvi;
		this.j.TryGetValue(A_0, out cvi);
		if (cvi != null && cvi.f() != null)
		{
			return cvi.f().Volume;
		}
		return 0f;
	}

	// Token: 0x06000219 RID: 537 RVA: 0x0000AFC0 File Offset: 0x000091C0
	internal abr a(string A_0)
	{
		abr result;
		if (A_0 != null)
		{
			this.e.TryGetValue(A_0.ToLowerInvariant(), out result);
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0600021A RID: 538 RVA: 0x0000AFF0 File Offset: 0x000091F0
	private void d()
	{
		foreach (abr abr in this.f)
		{
			abr.a();
		}
		foreach (d6c d6c in this.g.Values)
		{
			d6c.b();
		}
		this.m = null;
		this.n.Clear();
		this.e = new Dictionary<string, abr>();
		this.f = new List<abr>();
		this.g = new Dictionary<string, d6c>();
		this.c = null;
		this.o = 0;
	}

	// Token: 0x0600021B RID: 539 RVA: 0x0000B0D4 File Offset: 0x000092D4
	private void c()
	{
		this.e = new Dictionary<string, abr>();
		this.f = new List<abr>();
		this.g = new Dictionary<string, d6c>();
		if (this.c != null)
		{
			if (this.c.a() != null)
			{
				foreach (za za in this.c.a())
				{
					abr abr = new abr(za);
					this.e.Add(za.d().ToLowerInvariant(), abr);
					this.f.Add(abr);
				}
			}
			if (this.c.b() != null)
			{
				foreach (dv5 dv in this.c.b())
				{
					if (string.IsNullOrEmpty(dv.a()) || dk2.b(dv.a()))
					{
						d6c d6c = new d6c(dv);
						if (d6c.d())
						{
							this.g.Add(dv.c(), d6c);
						}
					}
				}
			}
		}
		this.o = 0;
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0000B23C File Offset: 0x0000943C
	private void b()
	{
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0000B240 File Offset: 0x00009440
	private void a()
	{
		if (this.k != null && this.k.Count > 0)
		{
			int i = 0;
			while (i < Math.Min(this.l, this.k.Count))
			{
				if (this.o >= this.k.Count)
				{
					this.o = 0;
				}
				if (this.k.Count != 0)
				{
					KeyValuePair<Guid, cvi> item = this.k[this.o];
					if (item.Value.f() == null)
					{
						goto IL_D2;
					}
					if (!item.Value.f().IsDisposed && item.Value.f().State != SoundState.Stopped)
					{
						item.Value.b(this);
						goto IL_D2;
					}
					this.k.Remove(item);
					this.j.Remove(item.Key);
					IL_E0:
					i++;
					continue;
					IL_D2:
					this.o++;
					goto IL_E0;
				}
				break;
			}
		}
	}

	// Token: 0x04000378 RID: 888
	private int a = 5000;

	// Token: 0x04000379 RID: 889
	private int b = 2500;

	// Token: 0x0400037A RID: 890
	private eg9 c;

	// Token: 0x0400037B RID: 891
	private TimeSpan d = TimeSpan.FromMinutes(1.0);

	// Token: 0x0400037C RID: 892
	private Dictionary<string, abr> e = new Dictionary<string, abr>();

	// Token: 0x0400037D RID: 893
	private List<abr> f = new List<abr>();

	// Token: 0x0400037E RID: 894
	private Dictionary<string, d6c> g = new Dictionary<string, d6c>();

	// Token: 0x0400037F RID: 895
	private bxt h;

	// Token: 0x04000380 RID: 896
	private bxt i;

	// Token: 0x04000381 RID: 897
	private Dictionary<Guid, cvi> j = new Dictionary<Guid, cvi>();

	// Token: 0x04000382 RID: 898
	private List<KeyValuePair<Guid, cvi>> k = new List<KeyValuePair<Guid, cvi>>();

	// Token: 0x04000383 RID: 899
	private int l = 10;

	// Token: 0x04000384 RID: 900
	private btm m;

	// Token: 0x04000385 RID: 901
	private Queue<btm> n = new Queue<btm>();

	// Token: 0x04000386 RID: 902
	private int o;

	// Token: 0x04000387 RID: 903
	private float p;

	// Token: 0x04000388 RID: 904
	private Dictionary<c9z, float> q = new Dictionary<c9z, float>();

	// Token: 0x04000389 RID: 905
	private Dictionary<c9z, float> r = new Dictionary<c9z, float>();

	// Token: 0x0400038A RID: 906
	private float? s;
}
