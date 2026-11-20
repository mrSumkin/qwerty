using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

// Token: 0x0200007E RID: 126
public sealed class efu
{
	// Token: 0x060002CC RID: 716 RVA: 0x0000D10C File Offset: 0x0000B30C
	public efu(dst A_0, aud A_1)
	{
		czh.a(A_1, "area");
		czh.a(A_0, "zoneAudioManager");
		this.c = A_0;
		this.b = A_1;
	}

	// Token: 0x060002CD RID: 717 RVA: 0x0000D15C File Offset: 0x0000B35C
	public void a(Guid A_0, Vector3 A_1, List<k2> A_2)
	{
		dd7 serviceOrThrow = bpo.GetServiceOrThrow<dd7>();
		if (this.e != null && this.e.Count > 0)
		{
			int i = 0;
			while (i < Math.Min(10, this.e.Count))
			{
				if (this.f >= this.e.Count)
				{
					this.f = 0;
				}
				if (this.e.Count != 0)
				{
					e8a e8a = this.e[this.f];
					if (e8a == null)
					{
						goto IL_B3;
					}
					SoundState? soundState = serviceOrThrow.aec(e8a.f().Value);
					if (soundState != null && soundState.GetValueOrDefault() != SoundState.Stopped)
					{
						this.a(A_0, A_1, A_2, e8a);
						goto IL_B3;
					}
					this.a(e8a);
					IL_C1:
					i++;
					continue;
					IL_B3:
					this.f++;
					goto IL_C1;
				}
				break;
			}
		}
	}

	// Token: 0x060002CE RID: 718 RVA: 0x0000D248 File Offset: 0x0000B448
	public string a(string A_0, b0b A_1, string A_2, float A_3, bool A_4, c9z A_5)
	{
		string text;
		if (!string.IsNullOrEmpty(A_0) && !this.d.ContainsKey(A_0))
		{
			text = A_0;
		}
		else
		{
			do
			{
				text = Guid.NewGuid().ToString();
			}
			while (this.d.ContainsKey(text));
		}
		e8a e8a = new e8a(text, A_1, A_2, A_3, A_4, A_5);
		if (e8a.a(this.a(e8a.d())))
		{
			this.b(e8a);
			return e8a.e();
		}
		return null;
	}

	// Token: 0x060002CF RID: 719 RVA: 0x0000D2D0 File Offset: 0x0000B4D0
	public bool a(string A_0, bool A_1)
	{
		e8a e8a;
		this.d.TryGetValue(A_0, out e8a);
		if (e8a != null)
		{
			this.a(e8a);
			return e8a.b(A_1);
		}
		return false;
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0000D304 File Offset: 0x0000B504
	public bool b(string A_0)
	{
		e8a e8a;
		this.d.TryGetValue(A_0, out e8a);
		return e8a != null && e8a.d(this.a(e8a.d()));
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x0000D33C File Offset: 0x0000B53C
	public bool a(string A_0)
	{
		e8a e8a;
		this.d.TryGetValue(A_0, out e8a);
		return e8a != null && e8a.c(!this.a(e8a.d()));
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0000D378 File Offset: 0x0000B578
	public bool a(string A_0, float A_1)
	{
		e8a e8a;
		this.d.TryGetValue(A_0, out e8a);
		if (e8a != null)
		{
			e8a.b(A_1);
			return true;
		}
		return false;
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0000D3A4 File Offset: 0x0000B5A4
	public SoundState? c(string A_0)
	{
		e8a e8a;
		this.d.TryGetValue(A_0, out e8a);
		if (e8a != null)
		{
			return e8a.h();
		}
		return null;
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0000D3D8 File Offset: 0x0000B5D8
	public void a(IEnumerable<c9z> A_0)
	{
		this.g = new HashSet<c9z>(A_0);
		foreach (e8a e8a in this.e)
		{
			if (this.g.Contains(e8a.d()))
			{
				e8a.d(false);
			}
		}
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x0000D454 File Offset: 0x0000B654
	public void a()
	{
		if (this.g != null && this.g.Count > 0)
		{
			foreach (e8a e8a in this.e)
			{
				if (this.g.Contains(e8a.d()) && !e8a.c())
				{
					e8a.c(true);
				}
			}
		}
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x0000D4EC File Offset: 0x0000B6EC
	private void b(e8a A_0)
	{
		this.d[A_0.e()] = A_0;
		this.e.Add(A_0);
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x0000D50C File Offset: 0x0000B70C
	private void a(e8a A_0)
	{
		this.e.Remove(A_0);
		this.d.Remove(A_0.e());
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x0000D530 File Offset: 0x0000B730
	private void a(Guid A_0, Vector3 A_1, List<k2> A_2, e8a A_3)
	{
		if (A_3.i().Zone != this.c.d())
		{
			this.a(A_3.e(), false);
			return;
		}
		float a_;
		if (A_0 != this.b.qe())
		{
			a_ = 0f;
		}
		else
		{
			float num = float.MaxValue;
			bool flag = false;
			foreach (k2 k in A_2)
			{
				if (k.HearingRange > 0)
				{
					float num2 = (A_3.i().Location - k.Location).Length();
					if (num2 <= (float)k.HearingRange)
					{
						flag = true;
						float num3 = num2 / (float)k.HearingRange;
						if (num3 < num)
						{
							num = num3;
						}
					}
				}
			}
			if (!flag)
			{
				a_ = 0f;
			}
			else
			{
				float num4 = (num == 2.1474836E+09f) ? 0f : this.a(num, A_3.d());
				float num5 = this.a(A_1, A_3.i().Location);
				a_ = num4 * num5;
			}
		}
		A_3.a(a_);
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x0000D684 File Offset: 0x0000B884
	private float a(float A_0, c9z A_1)
	{
		float num = this.c.aph()[A_1];
		if (A_0 <= num || num >= 1f)
		{
			return 1f;
		}
		return 1f - (A_0 - num) / (1f - num);
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0000D6CC File Offset: 0x0000B8CC
	private float a(Vector3 A_0, Vector3 A_1)
	{
		float num = (A_0 - A_1).Length();
		float result;
		if (num > (float)this.c.apk())
		{
			result = 0f;
		}
		else if (num > (float)this.c.api())
		{
			float num2 = num - (float)this.c.api();
			float num3 = (float)(this.c.apk() - this.c.api());
			result = 1f - num2 / num3 * (1f - this.c.apm());
		}
		else
		{
			result = 1f;
		}
		return result;
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0000D76C File Offset: 0x0000B96C
	private bool a(c9z A_0)
	{
		return this.c.ape() && this.g != null && this.g.Contains(A_0);
	}

	// Token: 0x040003C7 RID: 967
	private const int a = 10;

	// Token: 0x040003C8 RID: 968
	private aud b;

	// Token: 0x040003C9 RID: 969
	private dst c;

	// Token: 0x040003CA RID: 970
	private Dictionary<string, e8a> d = new Dictionary<string, e8a>();

	// Token: 0x040003CB RID: 971
	private List<e8a> e = new List<e8a>();

	// Token: 0x040003CC RID: 972
	private int f;

	// Token: 0x040003CD RID: 973
	private HashSet<c9z> g;
}
