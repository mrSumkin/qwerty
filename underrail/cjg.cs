using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001012 RID: 4114
[eiz("Q98")]
[Serializable]
public sealed class cjg : cze, ISerializable
{
	// Token: 0x060054E0 RID: 21728 RVA: 0x00258DDC File Offset: 0x00256FDC
	private cjg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (cze)A_0.GetValue("Q98:J", typeof(cze));
		this.b = A_0.GetString("Q98:K");
	}

	// Token: 0x060054E1 RID: 21729 RVA: 0x00258E18 File Offset: 0x00257018
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("Q98:J", this.a);
		info.AddValue("Q98:K", this.b);
	}

	// Token: 0x060054E2 RID: 21730 RVA: 0x00258E44 File Offset: 0x00257044
	public cze b()
	{
		return this.a;
	}

	// Token: 0x060054E3 RID: 21731 RVA: 0x00258E4C File Offset: 0x0025704C
	public void a(cze A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060054E4 RID: 21732 RVA: 0x00258E58 File Offset: 0x00257058
	public string a()
	{
		return this.b;
	}

	// Token: 0x060054E5 RID: 21733 RVA: 0x00258E60 File Offset: 0x00257060
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060054E6 RID: 21734 RVA: 0x00258E6C File Offset: 0x0025706C
	public cjg()
	{
	}

	// Token: 0x060054E7 RID: 21735 RVA: 0x00258E78 File Offset: 0x00257078
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			aud aud = A_0.Area;
			if (aud != null && aud.Zone != null)
			{
				d2b d2b = null;
				if (A_1 != null)
				{
					d2b = A_1.GetAspect<d2b>();
				}
				if (string.IsNullOrEmpty(this.b) || Enumerable.Any<coh>(c5x.h.b.aa().Bag.b(this.b)) || (d2b != null && d2b.f()))
				{
					c5x.c().a(c5x.qe().ToString(), "UnlockDigi", 1f, c9z.a, false, false);
					if (this.a != null)
					{
						this.a.ym(A_0, A_1, A_2);
					}
					if (d2b != null && !d2b.f())
					{
						d2b.e(true);
						return;
					}
				}
				else
				{
					bool flag = true;
					object obj;
					bool flag2;
					bool flag3;
					if (A_2 != null && A_2.TryGetValue("keycardRequiredSctShown", out obj))
					{
						if (obj is bool)
						{
							flag2 = (bool)obj;
							flag3 = true;
						}
						else
						{
							flag3 = false;
						}
					}
					else
					{
						flag3 = false;
					}
					if (flag3 && flag2)
					{
						flag = false;
					}
					if (flag && A_1 != null)
					{
						bmj.a(A_1, new d53("Требуется ключ-карта", adi.l, null, true));
						if (A_2 != null)
						{
							A_2["keycardRequiredSctShown"] = true;
						}
					}
					c5x.c().a(c5x.qe().ToString(), "HackingFailure", 1f, c9z.a, false, false);
				}
			}
		}
	}

	// Token: 0x04002288 RID: 8840
	private new cze a;

	// Token: 0x04002289 RID: 8841
	private string b;
}
