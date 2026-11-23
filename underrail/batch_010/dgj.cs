using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02001C15 RID: 7189
public sealed class dgj
{
	// Token: 0x06009DD2 RID: 40402 RVA: 0x003E08BC File Offset: 0x003DEABC
	public void a(efk A_0, bool A_1, float A_2, float A_3)
	{
		c32 c = Enumerable.FirstOrDefault<c32>(A_0.StatusEffects.Get<c32>());
		this.n = null;
		this.a = A_1;
		this.b = d05.b(0f, A_2, 1f);
		this.c = d05.b(0f, A_3, 1f);
		this.d = 1f;
		this.e = 1f;
		this.f = 0f;
		HashSet<string> hashSet = new HashSet<string>();
		HashSet<string> hashSet2 = new HashSet<string>();
		foreach (coh coh in A_0.Bag.z2())
		{
			if (coh.Definition != null && coh.Definition.a5() != null && coh.Definition.a5().StartsWith("charm."))
			{
				string text = coh.Definition.a5().Substring(6);
				hashSet.Add(text);
			}
		}
		foreach (coh coh2 in A_0.Gear.i())
		{
			if (coh2.Definition != null && coh2.Definition.a5() != null && coh2.Definition.a5().StartsWith("charm."))
			{
				string text2 = coh2.Definition.a5().Substring(6);
				if (c != null && c.b == text2)
				{
					this.n = c.b;
				}
				hashSet.Add(text2);
				hashSet2.Add(text2);
			}
		}
		this.g = this.a(hashSet, hashSet2, "hopperFoot");
		this.h = this.a(hashSet, hashSet2, "psiBeetleClaw");
		this.i = this.a(hashSet, hashSet2, "warthogFoot");
		this.j = this.a(hashSet, hashSet2, "burrowerTarsus");
		this.k = this.a(hashSet, hashSet2, "siphonerFoot");
		this.l = this.a(hashSet, hashSet2, "deathStalkerClaw");
		this.m = this.a(hashSet, hashSet2, "coilSpiderTarsus");
		if (this.f > 0f)
		{
			this.d = Convert.ToSingle(Math.Pow(1.25, (double)(this.f - 1f)));
			this.e = Convert.ToSingle(Math.Pow(0.8, (double)(this.f - 1f)));
			return;
		}
		this.d = 1f;
		this.e = 1f;
	}

	// Token: 0x06009DD3 RID: 40403 RVA: 0x003E0BA8 File Offset: 0x003DEDA8
	public bool a()
	{
		TimeSpan timeSpan = new TimeSpan(DateTime.Now.Ticks);
		long num = (long)timeSpan.TotalHours % 7L;
		if (num == 0L || num == 2L || num == 3L || num == 5L)
		{
			int num2 = timeSpan.Minutes % 11;
			int num3 = new bm4(Convert.ToInt32(timeSpan.TotalHours % 10000.0)).a(5);
			if (this.n != null)
			{
				if (num2 >= num3 && num2 <= num3 + 9)
				{
					return true;
				}
			}
			else if (num2 >= num3 && num2 <= num3 + 6)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06009DD4 RID: 40404 RVA: 0x003E0C58 File Offset: 0x003DEE58
	private float a(HashSet<string> A_0, HashSet<string> A_1, string A_2)
	{
		if (A_0.Contains(A_2))
		{
			if (A_1.Contains(A_2))
			{
				if (this.n == null)
				{
					this.f += 1f;
					return 1f;
				}
				if (this.n == A_2)
				{
					this.f += 1f;
					return 1.33f;
				}
				return 0f;
			}
			else if (this.n == null || this.n == A_2)
			{
				this.f += 0.8f;
				return 0.66f;
			}
		}
		return 0f;
	}

	// Token: 0x04003D31 RID: 15665
	public bool a;

	// Token: 0x04003D32 RID: 15666
	public float b;

	// Token: 0x04003D33 RID: 15667
	public float c;

	// Token: 0x04003D34 RID: 15668
	public float d;

	// Token: 0x04003D35 RID: 15669
	public float e;

	// Token: 0x04003D36 RID: 15670
	public float f;

	// Token: 0x04003D37 RID: 15671
	public float g;

	// Token: 0x04003D38 RID: 15672
	public float h;

	// Token: 0x04003D39 RID: 15673
	public float i;

	// Token: 0x04003D3A RID: 15674
	public float j;

	// Token: 0x04003D3B RID: 15675
	public float k;

	// Token: 0x04003D3C RID: 15676
	public float l;

	// Token: 0x04003D3D RID: 15677
	public float m;

	// Token: 0x04003D3E RID: 15678
	public string n;
}
