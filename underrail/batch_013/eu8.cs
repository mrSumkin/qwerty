using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001429 RID: 5161
[eiz("PCC")]
[Serializable]
public sealed class eu8 : b1z
{
	// Token: 0x060073B8 RID: 29624 RVA: 0x0030DFF4 File Offset: 0x0030C1F4
	private eu8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (d8o)A_0.GetValue("PCC:Q", typeof(d8o));
		this.b = A_0.GetInt32("PCC:R");
		di7.ReadList<ar7>("PCC:PC", ref this.c, A_0);
		this.d = (A_0.GetValue("PCC:L", typeof(edx)) as edx);
		this.e = (A_0.GetValue("PCC:I", typeof(anp)) as anp);
		this.f = A_0.GetBoolean("PCC:CP");
		this.g = A_0.GetBoolean("PCC:LP");
		this.h = (A_0.GetValue("PCC:IR", typeof(ar7)) as ar7);
		this.i = A_0.GetInt32("PCC:D");
		this.j = A_0.GetBoolean("PCC:PI");
	}

	// Token: 0x060073B9 RID: 29625 RVA: 0x0030E0F0 File Offset: 0x0030C2F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PCC:Q", this.a);
		info.AddValue("PCC:R", this.b);
		di7.WriteList<ar7>("PCC:PC", this.c, info);
		info.AddValue("PCC:L", this.d);
		info.AddValue("PCC:I", this.e);
		info.AddValue("PCC:CP", this.f);
		info.AddValue("PCC:LP", this.g);
		info.AddValue("PCC:IR", this.h);
		info.AddValue("PCC:D", this.i);
		info.AddValue("PCC:PI", this.j);
	}

	// Token: 0x060073BA RID: 29626 RVA: 0x0030E1B4 File Offset: 0x0030C3B4
	public eu8(c5x A_0, d8o A_1, ak1 A_2, int A_3, int A_4, List<ar7> A_5 = null)
	{
		this.i = A_4;
		this.a = A_1;
		this.c = A_5;
		if (A_2 != null)
		{
			this.d = new edx(A_2);
		}
		this.b = A_3;
		if (A_0 != null)
		{
			this.h = new ar7(A_0);
		}
	}

	// Token: 0x060073BB RID: 29627 RVA: 0x0030E20C File Offset: 0x0030C40C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (!this.f && this.c != null && this.c.Count > 0)
		{
			foreach (ar7 ar in this.c)
			{
				if (ar != null)
				{
					c5x c5x = ar.ao() as c5x;
					if (c5x != null && c5x.h.b != null)
					{
						this.a(c5x.h.b);
					}
				}
			}
			this.f = true;
		}
		if (!this.g && this.d != null && this.d.ao() != null)
		{
			if (this.e == null)
			{
				this.a();
			}
			return dc4.b;
		}
		return dc4.c;
	}

	// Token: 0x060073BC RID: 29628 RVA: 0x0030E300 File Offset: 0x0030C500
	private void a(amc A_0)
	{
		if ((this.h == null || this.h.ao() == null || A_0.a8() != this.h.ao()) && A_0.aa().c(this.a))
		{
			if (A_0.aa().c(d8o.e) || A_0.aa().a(CharacterImmunities.Fear))
			{
				if (this.j)
				{
					etm a_ = new etm(new ap9(A_0.aa()), "эффекту страха");
					bey.a(a_, A_0.aa(), A_0.aa(), A_0);
					a7v.a(a_);
					bmj.a(A_0.a8(), new ba0());
					return;
				}
			}
			else
			{
				axo a_2 = new axo(this.i, (this.h != null && this.h.ao() != null) ? new ar7(this.h.ao()) : null);
				A_0.aa().StatusEffects.a(a_2, false, false, false);
			}
		}
	}

	// Token: 0x060073BD RID: 29629 RVA: 0x0030E418 File Offset: 0x0030C618
	private void a()
	{
		this.e = aw1.b(this.d.ao().Location, this.d.ao().Area, (float)this.b, 0L, 0L);
		this.e.a(new EventHandler<EventArgs>(this.a));
		this.e.k();
	}

	// Token: 0x060073BE RID: 29630 RVA: 0x0030E480 File Offset: 0x0030C680
	[dcc("PCC:mIF")]
	private void a(object A_0, EventArgs A_1)
	{
		anp anp = A_0 as anp;
		if (anp != null && this.d.ao() != null)
		{
			List<Guid> list = new List<Guid>();
			foreach (Point a_ in anp.f())
			{
				ak1 ak = this.d.ao().Area.a(a_);
				if (ak != null)
				{
					foreach (b0b b0b in ak.Entities)
					{
						c5x c5x = (c5x)b0b;
						if (c5x.h.b != null && !list.Contains(c5x.qe()))
						{
							this.a(c5x.h.b);
							list.Add(c5x.qe());
						}
					}
				}
			}
		}
		this.g = true;
	}

	// Token: 0x04002F46 RID: 12102
	private new d8o a;

	// Token: 0x04002F47 RID: 12103
	private int b;

	// Token: 0x04002F48 RID: 12104
	private List<ar7> c;

	// Token: 0x04002F49 RID: 12105
	private edx d;

	// Token: 0x04002F4A RID: 12106
	private anp e;

	// Token: 0x04002F4B RID: 12107
	private bool f;

	// Token: 0x04002F4C RID: 12108
	private bool g;

	// Token: 0x04002F4D RID: 12109
	private ar7 h;

	// Token: 0x04002F4E RID: 12110
	private int i;

	// Token: 0x04002F4F RID: 12111
	public new bool j;
}
