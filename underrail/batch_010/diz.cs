using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001949 RID: 6473
[elw(typeof(a06))]
[eiz("EI")]
[Serializable]
public abstract class diz : bk3, ISerializable, c6m
{
	// Token: 0x060089BF RID: 35263 RVA: 0x0038AEE4 File Offset: 0x003890E4
	protected diz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<d3e>("EI:SE", ref this.a, A_0);
			if (ell.a() >= 113)
			{
				this.c = A_0.GetBoolean("EI:E");
			}
			if (ell.a() >= 132)
			{
				di7.ReadList<wq>("EI:DE", ref this.b, A_0);
			}
			else
			{
				this.b = new List<wq>();
			}
			if (ell.a() >= 365)
			{
				di7.ReadList<aia>("EI:QC", ref this.d, A_0);
			}
			else
			{
				this.d = new List<aia>();
			}
			if (ell.a() >= 444)
			{
				this.e = (A_0.GetValue("EI:LC", typeof(Color?)) as Color?);
				this.f = A_0.GetSingle("EI:LI");
				this.g = A_0.GetSingle("EI:LFR");
				this.h = A_0.GetSingle("EI:LR");
				this.i = A_0.GetBoolean("EI:LN");
			}
			if (ell.a() >= 452)
			{
				di7.ReadList<brl>("EI:RQ", ref this.j, A_0);
				return;
			}
			this.j = new List<brl>();
			return;
		}
		else
		{
			if (base.GetType() == typeof(diz))
			{
				this.a = (List<d3e>)A_0.GetValue("_StaticEffects", typeof(List<d3e>));
				return;
			}
			this.a = (List<d3e>)A_0.GetValue("EquippableItem+_StaticEffects", typeof(List<d3e>));
			return;
		}
	}

	// Token: 0x060089C0 RID: 35264 RVA: 0x0038B0C8 File Offset: 0x003892C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<d3e>("EI:SE", this.a, info);
		di7.WriteList<wq>("EI:DE", this.b, info);
		info.AddValue("EI:E", this.c);
		di7.WriteList<aia>("EI:QC", this.d, info);
		info.AddValue("EI:LC", this.e);
		info.AddValue("EI:LI", this.f);
		info.AddValue("EI:LFR", this.g);
		info.AddValue("EI:LR", this.h);
		info.AddValue("EI:LN", this.i);
		di7.WriteList<brl>("EI:RQ", this.j, info);
	}

	// Token: 0x060089C1 RID: 35265 RVA: 0x0038B18C File Offset: 0x0038938C
	public List<d3e> ar()
	{
		return this.a;
	}

	// Token: 0x060089C2 RID: 35266 RVA: 0x0038B194 File Offset: 0x00389394
	public List<wq> ao()
	{
		return this.b;
	}

	// Token: 0x060089C3 RID: 35267 RVA: 0x0038B19C File Offset: 0x0038939C
	public bool at()
	{
		return this.c;
	}

	// Token: 0x060089C4 RID: 35268 RVA: 0x0038B1A4 File Offset: 0x003893A4
	public void e(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060089C5 RID: 35269 RVA: 0x0038B1B0 File Offset: 0x003893B0
	public List<aia> @as()
	{
		return this.d;
	}

	// Token: 0x060089C6 RID: 35270 RVA: 0x0038B1B8 File Offset: 0x003893B8
	public new void a(List<aia> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060089C7 RID: 35271 RVA: 0x0038B1C4 File Offset: 0x003893C4
	public List<brl> av()
	{
		return this.j;
	}

	// Token: 0x060089C8 RID: 35272 RVA: 0x0038B1CC File Offset: 0x003893CC
	public new void a(List<brl> A_0)
	{
		this.j = A_0;
	}

	// Token: 0x060089C9 RID: 35273 RVA: 0x0038B1D8 File Offset: 0x003893D8
	public Color? ap()
	{
		return this.e;
	}

	// Token: 0x060089CA RID: 35274 RVA: 0x0038B1E0 File Offset: 0x003893E0
	public new void a(Color? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060089CB RID: 35275 RVA: 0x0038B1EC File Offset: 0x003893EC
	public float au()
	{
		return this.f;
	}

	// Token: 0x060089CC RID: 35276 RVA: 0x0038B1F4 File Offset: 0x003893F4
	public void g(float A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060089CD RID: 35277 RVA: 0x0038B200 File Offset: 0x00389400
	public float aw()
	{
		return this.g;
	}

	// Token: 0x060089CE RID: 35278 RVA: 0x0038B208 File Offset: 0x00389408
	public void f(float A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060089CF RID: 35279 RVA: 0x0038B214 File Offset: 0x00389414
	public float ax()
	{
		return this.h;
	}

	// Token: 0x060089D0 RID: 35280 RVA: 0x0038B21C File Offset: 0x0038941C
	public void e(float A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060089D1 RID: 35281 RVA: 0x0038B228 File Offset: 0x00389428
	public bool aq()
	{
		return this.i;
	}

	// Token: 0x060089D2 RID: 35282 RVA: 0x0038B230 File Offset: 0x00389430
	public void d(bool A_0)
	{
		this.i = A_0;
	}

	// Token: 0x060089D3 RID: 35283 RVA: 0x0038B23C File Offset: 0x0038943C
	public bool e(string A_0)
	{
		for (int i = 0; i < this.d.Count; i++)
		{
			if (this.d[i].CapabilityFullTypeName == A_0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060089D4 RID: 35284 RVA: 0x0038B284 File Offset: 0x00389484
	public List<brl> j0()
	{
		return this.j;
	}

	// Token: 0x060089D5 RID: 35285 RVA: 0x0038B290 File Offset: 0x00389490
	public new bool a(efk A_0)
	{
		if (this.j != null && this.j.Count > 0)
		{
			using (List<brl>.Enumerator enumerator = this.j.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.oh(A_0))
					{
						return false;
					}
				}
			}
			return true;
		}
		return true;
	}

	// Token: 0x060089D6 RID: 35286 RVA: 0x0038B314 File Offset: 0x00389514
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		diz diz = (diz)A_0;
		diz.c = this.c;
		diz.a = new List<d3e>();
		if (this.a != null)
		{
			foreach (d3e d3e in this.a)
			{
				diz.a.Add(d3e.b3());
			}
		}
		diz.b = new List<wq>();
		if (this.b != null)
		{
			foreach (wq wq in this.b)
			{
				diz.b.Add(wq.dn());
			}
		}
		foreach (aia aia in this.d)
		{
			diz.d.Add(aia.b());
		}
		diz.e = this.e;
		diz.g = this.g;
		diz.f = this.f;
		diz.h = this.h;
		diz.i = this.i;
		if (this.j != null)
		{
			foreach (brl brl in this.j)
			{
				ICloneable cloneable = brl as ICloneable;
				if (cloneable != null)
				{
					brl item = cloneable.Clone() as brl;
					if (A_0 != null)
					{
						diz.j.Add(item);
					}
				}
			}
		}
	}

	// Token: 0x060089D7 RID: 35287 RVA: 0x0038B520 File Offset: 0x00389720
	protected diz()
	{
	}

	// Token: 0x040036D8 RID: 14040
	private new List<d3e> a = new List<d3e>();

	// Token: 0x040036D9 RID: 14041
	private List<wq> b = new List<wq>();

	// Token: 0x040036DA RID: 14042
	private bool c;

	// Token: 0x040036DB RID: 14043
	private List<aia> d = new List<aia>();

	// Token: 0x040036DC RID: 14044
	private Color? e;

	// Token: 0x040036DD RID: 14045
	private float f;

	// Token: 0x040036DE RID: 14046
	private float g = 0.05f;

	// Token: 0x040036DF RID: 14047
	private new float h;

	// Token: 0x040036E0 RID: 14048
	private bool i;

	// Token: 0x040036E1 RID: 14049
	private new List<brl> j = new List<brl>();
}
