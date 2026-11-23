using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x0200066B RID: 1643
[eiz("S1")]
[Serializable]
public sealed class p9 : ISerializable
{
	// Token: 0x060029C8 RID: 10696 RVA: 0x000ED178 File Offset: 0x000EB378
	private p9(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<d6w>("S1:S", ref this.b, A_0);
			this.c = (egv)A_0.GetValue("S1:MRF", typeof(egv));
			if (ell.a() >= 5)
			{
				this.e = (efi)A_0.GetValue("S1:FM", typeof(efi));
				di7.ReadList<bp2>("S1:FS", ref this.d, A_0);
			}
			else
			{
				this.d = new List<bp2>();
			}
			if (ell.a() >= 109)
			{
				di7.ReadList<string>("S1:C", ref this.f, A_0);
			}
			else
			{
				this.f = new List<string>();
			}
			if (ell.a() >= 143)
			{
				this.g = (A_0.GetValue("S1:RP", typeof(int?)) as int?);
			}
			else
			{
				this.g = new int?(90);
			}
			if (ell.a() >= 190)
			{
				di7.ReadList<d9n>("S1:TD", ref this.h, A_0);
				this.i = A_0.GetInt32("S1:D");
				return;
			}
			this.h = new List<d9n>();
			return;
		}
		else
		{
			if (base.GetType() == typeof(p9))
			{
				this.b = (List<d6w>)A_0.GetValue("_Shipments", typeof(List<d6w>));
				this.c = (egv)A_0.GetValue("_MerchantReactionFunction", typeof(egv));
				return;
			}
			this.b = (List<d6w>)A_0.GetValue("Store+_Shipments", typeof(List<d6w>));
			this.c = (egv)A_0.GetValue("Store+_MerchantReactionFunction", typeof(egv));
			return;
		}
	}

	// Token: 0x060029C9 RID: 10697 RVA: 0x000ED38C File Offset: 0x000EB58C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<d6w>("S1:S", this.b, info);
		di7.WriteList<bp2>("S1:FS", this.d, info);
		info.AddValue("S1:MRF", this.c);
		info.AddValue("S1:FM", this.e);
		di7.WriteList<string>("S1:C", this.f, info);
		info.AddValue("S1:RP", this.g);
		di7.WriteList<d9n>("S1:TD", this.h, info);
		info.AddValue("S1:D", this.i);
	}

	// Token: 0x060029CA RID: 10698 RVA: 0x000ED42C File Offset: 0x000EB62C
	public int? c()
	{
		return this.g;
	}

	// Token: 0x060029CB RID: 10699 RVA: 0x000ED434 File Offset: 0x000EB634
	public void a(int? A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060029CC RID: 10700 RVA: 0x000ED440 File Offset: 0x000EB640
	public List<d6w> b()
	{
		return this.b;
	}

	// Token: 0x060029CD RID: 10701 RVA: 0x000ED448 File Offset: 0x000EB648
	public egv g()
	{
		return this.c;
	}

	// Token: 0x060029CE RID: 10702 RVA: 0x000ED450 File Offset: 0x000EB650
	public void a(egv A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060029CF RID: 10703 RVA: 0x000ED45C File Offset: 0x000EB65C
	public efi a()
	{
		return this.e;
	}

	// Token: 0x060029D0 RID: 10704 RVA: 0x000ED464 File Offset: 0x000EB664
	public void a(efi A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060029D1 RID: 10705 RVA: 0x000ED470 File Offset: 0x000EB670
	public List<bp2> f()
	{
		return this.d;
	}

	// Token: 0x060029D2 RID: 10706 RVA: 0x000ED478 File Offset: 0x000EB678
	public void a(List<bp2> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060029D3 RID: 10707 RVA: 0x000ED484 File Offset: 0x000EB684
	public List<string> e()
	{
		return this.f;
	}

	// Token: 0x060029D4 RID: 10708 RVA: 0x000ED48C File Offset: 0x000EB68C
	public void a(List<string> A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060029D5 RID: 10709 RVA: 0x000ED498 File Offset: 0x000EB698
	public List<d9n> h()
	{
		return this.h;
	}

	// Token: 0x060029D6 RID: 10710 RVA: 0x000ED4A0 File Offset: 0x000EB6A0
	public void a(List<d9n> A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060029D7 RID: 10711 RVA: 0x000ED4AC File Offset: 0x000EB6AC
	public int d()
	{
		return this.i;
	}

	// Token: 0x060029D8 RID: 10712 RVA: 0x000ED4B4 File Offset: 0x000EB6B4
	public void a(int A_0)
	{
		this.i = A_0;
	}

	// Token: 0x060029D9 RID: 10713 RVA: 0x000ED4C0 File Offset: 0x000EB6C0
	public p9()
	{
	}

	// Token: 0x060029DA RID: 10714 RVA: 0x000ED4F8 File Offset: 0x000EB6F8
	public iv a(eg A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		iv iv = new iv();
		if (this.b != null)
		{
			foreach (d6w d6w in this.b)
			{
				if (d6w != null && !A_0.ap8().Contains(d6w.d()) && (d6w.h() == null || d6w.h().jh(this)) && (string.IsNullOrEmpty(d6w.f()) || dk2.b(d6w.f())) && d6w.b())
				{
					iv.a = true;
					break;
				}
			}
			foreach (d6w d6w2 in this.b)
			{
				if (d6w2 != null && (iv.a || !A_0.ap8().Contains(d6w2.d())) && (d6w2.h() == null || d6w2.h().jh(this)) && (string.IsNullOrEmpty(d6w2.f()) || dk2.b(d6w2.f())))
				{
					List<coh> list = d6w2.c();
					if (list != null)
					{
						foreach (coh coh in list)
						{
							if (coh.Definition != null && (coh.Definition.a5() == null || !coh.Definition.a5().EndsWith("Scraps")))
							{
								if (d6w2.e())
								{
									coh.CustomProperties[vo.h] = true;
								}
								if (d6w2.a())
								{
									coh.CustomProperties[vo.i] = true;
								}
								iv.c.Add(coh);
							}
						}
					}
					iv.b |= d6w2.b();
					iv.d.Add(d6w2.d());
				}
			}
		}
		return iv;
	}

	// Token: 0x060029DB RID: 10715 RVA: 0x000ED79C File Offset: 0x000EB99C
	public float a(eg A_0, efk A_1)
	{
		float? a_ = null;
		if (this.c != null)
		{
			try
			{
				a_ = new float?(this.c.a0(A_0, A_1));
			}
			catch (Exception a_2)
			{
				dux.a(LogSeverity.Error, a_2, "Error occurred while executing merchant reaction function '{0}'.", new object[]
				{
					this.c.ToString()
				});
			}
		}
		return bhm.a(a_, A_1);
	}

	// Token: 0x040016BE RID: 5822
	public const string a = "store";

	// Token: 0x040016BF RID: 5823
	private List<d6w> b = new List<d6w>();

	// Token: 0x040016C0 RID: 5824
	private egv c;

	// Token: 0x040016C1 RID: 5825
	private List<bp2> d = new List<bp2>();

	// Token: 0x040016C2 RID: 5826
	private efi e;

	// Token: 0x040016C3 RID: 5827
	private List<string> f = new List<string>();

	// Token: 0x040016C4 RID: 5828
	private int? g;

	// Token: 0x040016C5 RID: 5829
	private List<d9n> h = new List<d9n>();

	// Token: 0x040016C6 RID: 5830
	private int i;
}
